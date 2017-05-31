Imports System.ComponentModel
Imports System.Threading
Imports BUS.BUS
Imports DTO.DTO
Imports GUI.XuLy


Public Class frmLapPhieuThuePhong

    Private Sub frmLapPhieuThuePhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' hiển thị danh sách mã phòng
        cboMaPhong.DataSource = PhongBUS.selectPhongAll()
        cboMaPhong.DisplayMember = "MaPhong"
        ' cboMaPhong.ValueMember = "MaPhong"

        ' hiển thị tên phòng
        txtTenPhong.Text = cboMaPhong.SelectedItem.TenPhong

        ' hiển thị đơn giá
        txtDonGiaThue.Text = LoaiPhongBUS.selectDonGiaByMaLoaiPhong(cboMaPhong.SelectedItem.MaLoaiPhong)

        ' khởi tạo danh sách khách thuê
        Dim danhSachKhachThue As New DataTable
        danhSachKhachThue.Columns.Add("TenKhachHang", GetType(String))
        danhSachKhachThue.Columns.Add("CMND", GetType(String))
        danhSachKhachThue.Columns.Add("DiaChi", GetType(String))

        dgvDanhSachKhachThue.DataSource = danhSachKhachThue

        ' hiển thị loại khách lên combobox : DatagridviewComboBoxColumn 
        cboDgvLoaiKhach.DataSource = LoaiKhachHangBUS.selectLoaiKhachHangAll()
        cboDgvLoaiKhach.DisplayMember = "TenLoaiKhachHang"
        cboDgvLoaiKhach.ValueMember = "MaLoaiKhachHang"
        cboDgvLoaiKhach.DefaultCellStyle.NullValue = "Chọn loại khách"
        cboDgvLoaiKhach.Name = "MaLoaiKhachHang"

        ' giới hạn NgayTraPhong
        dtpNgayTraPhong.MinDate = dtpNgayBatDauThue.Value

    End Sub

    Private Sub cboMaPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaPhong.SelectedIndexChanged
        ' hiển thị tên phòng
        txtTenPhong.Text = cboMaPhong.SelectedItem.TenPhong

        ' hiển thị đơn giá
        txtDonGiaThue.Text = LoaiPhongBUS.selectDonGiaByMaLoaiPhong(cboMaPhong.SelectedItem.MaLoaiPhong)

        ' hiển thị mã phiếu thuê
        txtMaPhieuThue.Text = tangMaPhieuThue(PhieuThueBUS.selectMaPhieuThueMoiNhat())
    End Sub

    Private Function tangMaPhieuThue(maPhieuThue As String) As String

        If (maPhieuThue = Nothing) Then
            Return "PT000"
        End If

        Dim maPhieuThueTang As String

        maPhieuThueTang = "PT" + ((Integer.Parse(maPhieuThue.Substring(2)) + 1).ToString).PadLeft(3, "0")

        Return maPhieuThueTang
    End Function

    Private Sub txtTenPhong_Validated(sender As Object, e As EventArgs) Handles txtTenPhong.Validated
        hienThiMaPhongTheoTenPhong()
    End Sub

    Private Sub txtTenPhong_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTenPhong.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            cboMaPhong.Focus()
        End If
    End Sub

    Private Sub hienThiMaPhongTheoTenPhong()
        Dim tenPhongTam As String = txtTenPhong.Text

        ' tìm tenPhongTam có trong danh sách phòng hay không
        Dim timThay As Boolean = False

        For i As Integer = 0 To (cboMaPhong.DataSource.count - 1)
            If (tenPhongTam = cboMaPhong.DataSource(i).TenPhong) Then
                cboMaPhong.SelectedIndex = i
                timThay = True
            End If
        Next

        If (timThay = False) Then
            ' hiển thị tên phòng
            txtTenPhong.Text = cboMaPhong.SelectedItem.TenPhong

            Using New CenteredMessageBox(Me)
                MessageBox.Show("Tên phòng không có trong hệ thống.")
            End Using

        End If

    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)

        ' chặn sự kiện Validate của tất cả control trên form khi nhấn nút thoát (X) hoặc Alt+F4
        If (m.Msg = 16) Then
            AutoValidate = AutoValidate.Disable
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click

        '' >> lưu phiếu thuê xuống CSDL
        Dim phieuThue As New PhieuThueDTO

        'phieuThue.MaPhieuThue được tăng tự động khi lưu mới phiếu thuê
        'phieuThue.MaPhieuThue = txtMaPhieuThue.Text
        phieuThue.MaPhong = cboMaPhong.SelectedItem.MaPhong
        phieuThue.NgayBatDauThue = dtpNgayBatDauThue.Value.ToShortDateString()
        phieuThue.NgayTraPhong = dtpNgayTraPhong.Value.ToShortDateString()
        phieuThue.DonGiaThueThucTe = txtDonGiaThue.Text

        ' tính thành tiền phòng
        Dim soNgayThue As Integer = (phieuThue.NgayTraPhong - phieuThue.NgayBatDauThue).Days + 1
        phieuThue.ThanhTienPhong = soNgayThue * phieuThue.DonGiaThueThucTe
        ' MaHoaDon mặc định là null khi lập hóa đơn mới được cập nhật
        '  phieuThue.MaHoaDon = ""
        phieuThue.PhuThuThucTe = ThamSoBUS.selectThamSoAll().TiLePhuThu

        '' >> Lưu chi tiết phiếu thuê xuống CSDL
        Dim dtDanhSachKhachThue As DataTable = dgvDanhSachKhachThue.DataSource
        Dim listChiTietPhieuThue As New List(Of ChiTietPhieuThueDTO)

        For idong As Integer = 0 To (dtDanhSachKhachThue.Rows.Count - 1)
            Dim chiTietPhieuThue As New ChiTietPhieuThueDTO

            chiTietPhieuThue.MaPhieuThue = txtMaPhieuThue.Text.ToString
            chiTietPhieuThue.TenKhachHang = dgvDanhSachKhachThue.Rows(idong).Cells("TenKhachHang").Value
            chiTietPhieuThue.MaLoaiKhachHang = dgvDanhSachKhachThue.Rows(idong).Cells("MaLoaiKhachHang").Value
            chiTietPhieuThue.CMnd = dgvDanhSachKhachThue.Rows(idong).Cells("CMND").Value
            chiTietPhieuThue.DiaChi = dgvDanhSachKhachThue.Rows(idong).Cells("DiaChi").Value
            chiTietPhieuThue.HeSoThucTe = LoaiKhachHangBUS.selectHeSoKhachByMaLoaiKhach(chiTietPhieuThue.MaLoaiKhachHang)

            listChiTietPhieuThue.Add(chiTietPhieuThue)
        Next

        ' Lưu phiếu thuê và danh sách chi tiết phiếu thuê xuống CSDL
        Using New CenteredMessageBox(Me)
            If ((PhieuThueBUS.themPhieuThue(phieuThue) = True) And
                (ChiTietPhieuThueBUS.themDanhSachChiTietPhieuThue(listChiTietPhieuThue) > 0)) Then
                MessageBox.Show("Lập phiếu thuê thành công.")
            Else
                MessageBox.Show("Lập phiếu thuê không thành công.")
            End If
        End Using

        ' Thoát khỏi from Lập phiếu thuê phòng
        Me.Close()

    End Sub

    Private Sub dgvDanhSachKhachThue_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgvDanhSachKhachThue.UserAddedRow

        ' giới hạn số dòng (khách hàng) được thêm bởi người dùng
        Dim SoKhachToiDa As Integer = 3
        If (ThamSoBUS.selectThamSoAll() IsNot Nothing) Then
            SoKhachToiDa = ThamSoBUS.selectThamSoAll().SoKhachToiDa
        End If

        If (dgvDanhSachKhachThue.Rows.Count > SoKhachToiDa) Then
            dgvDanhSachKhachThue.AllowUserToAddRows = False
        End If

    End Sub

    Private Sub dgvDanhSachKhachThue_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvDanhSachKhachThue.CellValidating
        Dim chuoi = sender.CurrentRow.Cells(sender.CurrentCell.ColumnIndex).EditedFormattedValue.ToString()

        If (String.IsNullOrEmpty(chuoi)) Then
            Return
        ElseIf (String.IsNullOrWhiteSpace(chuoi)) Then
            e.Cancel = True

            Using New CenteredMessageBox(Me)
                MessageBox.Show(Me, "Vui lòng nhập giá trị hợp lệ!")
            End Using
        End If

    End Sub

    Private Sub dgvDanhSachKhachThue_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvDanhSachKhachThue.UserDeletingRow
        If (dgvDanhSachKhachThue.Rows.Count = 1) Then
            dgvDanhSachKhachThue.CurrentRow.SetValues(Nothing, Nothing, Nothing, Nothing)
            e.Cancel = True
        End If
        dgvDanhSachKhachThue.AllowUserToAddRows = True
    End Sub

    Private Sub dtpNgayBatDauThue_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayBatDauThue.ValueChanged
        ' giới hạn NgayTraPhong
        dtpNgayTraPhong.MinDate = dtpNgayBatDauThue.Value
    End Sub
End Class