Imports System.ComponentModel
Imports System.Threading
Imports BUS.BUS
Imports DTO.DTO
Imports GUI.XuLy


Public Class frmLapPhieuThuePhong

    Private fatherForm As frmQuanLyPhieuThue

    Private Sub frmLapPhieuThuePhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' hiển thị danh sách mã phòng
        Try

            cboTenKhuyenMai.DisplayMember = "TenKhuyenMai" ' cột cần hiển thị ra ngoài comboboxs
            cboTenKhuyenMai.ValueMember = "MaKhuyenMai" ' giá trị tương ứng với displayMember được chọn
            cboTenKhuyenMai.DataSource = KhuyenMaiBUS.selectKhuyenMaiAll()

            lblNoiDungKM.Text = ""

            cboMaPhong.DataSource = PhongBUS.selectPhongAll()
            cboMaPhong.DisplayMember = "MaPhong"
            ' cboMaPhong.ValueMember = "MaPhong"

            ' hiển thị tên phòng
            txtTenPhong.Text = cboMaPhong.SelectedItem.TenPhong
            ' hiển thị đơn giá
            txtDonGiaThue.Text = LoaiPhongBUS.selectDonGiaByMaLoaiPhong(cboMaPhong.SelectedItem.MaLoaiPhong)
        Catch ex As Exception
            MessageBox.Show("Không có phòng nào trong hệ thống.")
            Return
        End Try

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
        ' giới hạn NgayBatDauThue
        dtpNgayBatDauThue.MinDate = Date.Now

        ' hiển thị danh sách tình trạng của các phòng trong khoảng thời gian
        '  từ NgayBatDauThue đến NgayTraPhong
        hienThiDanhSachTinhTrangByThoiGian()

    End Sub

    Private Sub cboMaPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaPhong.SelectedIndexChanged
        ' hiển thị tên phòng
        txtTenPhong.Text = cboMaPhong.SelectedItem.TenPhong

        ' hiển thị đơn giá
        txtDonGiaThue.Text = LoaiPhongBUS.selectDonGiaByMaLoaiPhong(cboMaPhong.SelectedItem.MaLoaiPhong)

        ' hiển thị mã phiếu thuê
        txtMaPhieuThue.Text = XuLyGUI.tangMa(PhieuThueBUS.selectMaPhieuThueMoiNhat(), "PT")
    End Sub

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

        ' kiểm tra phòng còn trống trong khoảng thời gian NgayBatDau và NgayTraPhong
        If (TinhTrangBUS.phongDuocThue(cboMaPhong.SelectedItem.MaPhong,
                                               dtpNgayBatDauThue.Value.ToShortDateString(),
                                               dtpNgayTraPhong.Value.ToShortDateString()) = True) Then
            Using New CenteredMessageBox(Me)
                MessageBox.Show("Phòng đã được thuê.")
                Return
            End Using

        End If
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

        '' >> lưu chi tiết phiếu thuê xuống CSDL
        Dim dtDanhSachKhachThue As DataTable = dgvDanhSachKhachThue.DataSource
        Dim listChiTietPhieuThue As New List(Of ChiTietPhieuThueDTO)

        If (dtDanhSachKhachThue.Rows.Count = 0) Then
            Using New CenteredMessageBox(Me)
                MessageBox.Show("Vui lòng nhập thông tin khách hàng!")
            End Using
            Return
        End If

        For idong As Integer = 0 To (dtDanhSachKhachThue.Rows.Count - 1)

            If (String.IsNullOrEmpty(dgvDanhSachKhachThue.Rows(idong).Cells("TenKhachHang").Value.ToString) _
                Or String.IsNullOrEmpty(dgvDanhSachKhachThue.Rows(idong).Cells("MaLoaiKhachHang").Value) _
                Or String.IsNullOrEmpty(dgvDanhSachKhachThue.Rows(idong).Cells("CMND").Value.ToString) _
                Or String.IsNullOrEmpty(dgvDanhSachKhachThue.Rows(idong).Cells("DiaChi").Value.ToString)) Then

                Using New CenteredMessageBox(Me)
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!")
                End Using
                Return

            End If

            Dim chiTietPhieuThue As New ChiTietPhieuThueDTO

            chiTietPhieuThue.MaPhieuThue = txtMaPhieuThue.Text.ToString
            chiTietPhieuThue.TenKhachHang = dgvDanhSachKhachThue.Rows(idong).Cells("TenKhachHang").Value.ToString
            chiTietPhieuThue.MaLoaiKhachHang = dgvDanhSachKhachThue.Rows(idong).Cells("MaLoaiKhachHang").Value
            chiTietPhieuThue.CMND = dgvDanhSachKhachThue.Rows(idong).Cells("CMND").Value.ToString
            chiTietPhieuThue.DiaChi = dgvDanhSachKhachThue.Rows(idong).Cells("DiaChi").Value.ToString
            chiTietPhieuThue.HeSoThucTe = LoaiKhachHangBUS.selectHeSoKhachByMaLoaiKhach(chiTietPhieuThue.MaLoaiKhachHang)

            listChiTietPhieuThue.Add(chiTietPhieuThue)
        Next

        ' lưu phiếu thuê và danh sách chi tiết phiếu thuê xuống CSDL
        ' cập nhật lại tình trạng của phòng
        Using New CenteredMessageBox(Me)
            If ((PhieuThueBUS.themPhieuThue(phieuThue) = True) And
                (ChiTietPhieuThueBUS.themDanhSachChiTietPhieuThue(listChiTietPhieuThue) > 0) And
                (TinhTrangBUS.capNhatTinhTrangPhongByMaPhong(phieuThue.MaPhong, phieuThue.NgayBatDauThue, phieuThue.NgayTraPhong) = True)) Then
                MessageBox.Show("Lập phiếu thuê thành công.")
            Else
                MessageBox.Show("Lập phiếu thuê không thành công.")
            End If
        End Using

        ' thoát khỏi from Lập phiếu thuê phòng
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

        hienThiDanhSachTinhTrangByThoiGian()
    End Sub

    Private Sub hienThiDanhSachTinhTrangByThoiGian()
        dgvTrangThaiPhong.DataSource = TinhTrangBUS.selectTinhTrangPhongByThoiGian(dtpNgayBatDauThue.Value.ToShortDateString(),
                                                   dtpNgayTraPhong.Value.ToShortDateString())
    End Sub

    Private Sub dtpNgayTraPhong_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayTraPhong.ValueChanged
        hienThiDanhSachTinhTrangByThoiGian()
    End Sub

    Sub New(formFather As frmQuanLyPhieuThue)
        InitializeComponent()
        fatherForm = formFather
    End Sub

    Private Sub frmLapPhieuThuePhong_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        fatherForm.CapNhat()
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub

    Private Function kiemTraKhachHangTrong(khachHang As DataGridViewRow) As Boolean
        For Each cell As DataGridViewCell In khachHang.Cells
            If (Not (cell.Value Is Nothing)) Then
                If (Not (String.IsNullOrEmpty(cell.EditedFormattedValue.ToString))) Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Sub dgvDanhSachKhachThue_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachKhachThue.CellValueChanged
        If (dgvDanhSachKhachThue.RowCount > 1) Then
            If (kiemTraKhachHangTrong(sender.CurrentRow)) Then
                dgvDanhSachKhachThue.AllowUserToAddRows = False
                sender.Rows.Remove(sender.CurrentRow)
                dgvDanhSachKhachThue.AllowUserToAddRows = True
                dgvDanhSachKhachThue.Refresh()
            End If
        End If
    End Sub

    Private Sub cboTenKhuyenMai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTenKhuyenMai.SelectedIndexChanged

        If (cboTenKhuyenMai.SelectedItem.TenKhuyenMai.ToString = "Không") Then
            lblNoiDungKM.Text = ""
        Else
            lblNoiDungKM.Text = "HS " + cboTenKhuyenMai.SelectedItem.HeSoKhuyenMai.ToString + " + " + cboTenKhuyenMai.SelectedItem.GhiChu.ToString
        End If


    End Sub
End Class