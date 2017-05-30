Imports BUS.BUS
Imports DTO.DTO


Public Class frmLapPhieuThuePhong
    Private danhSachKhachThue As New DataTable

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
        danhSachKhachThue.Columns.Add("TenKhachHang", GetType(String))
        danhSachKhachThue.Columns.Add("LoaiKhach", GetType(String))
        danhSachKhachThue.Columns.Add("CMND", GetType(String))
        danhSachKhachThue.Columns.Add("DiaChi", GetType(String))

        danhSachKhachThue.Rows.Add("", "", "", "")
        danhSachKhachThue.Rows.Add("", "", "", "")
        danhSachKhachThue.Rows.Add("", "", "", "")

        dgvDanhSachKhachThue.DataSource = danhSachKhachThue

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

            MessageBox.Show("Tên phòng không có trong hệ thống.")
        End If

    End Sub


    Private Sub dgvDanhSachKhachThue_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachKhachThue.CellEndEdit

        ' lưu dgvDanhSachKhachThue vào danhSachKhachThue

        danhSachKhachThue.Rows(dgvDanhSachKhachThue.CurrentRow.Index)(dgvDanhSachKhachThue.CurrentCell.ColumnIndex) = (dgvDanhSachKhachThue.CurrentRow.Cells(dgvDanhSachKhachThue.CurrentCell.ColumnIndex)).ToString

        MessageBox.Show("asdfsdaf")
    End Sub
End Class