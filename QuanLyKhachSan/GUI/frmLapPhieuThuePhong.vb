Imports System.ComponentModel
Imports System.Threading
Imports BUS.BUS
Imports DTO.DTO
Imports GUI.XuLy


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

        'danhSachKhachThue.Rows.Add("", "", "", "")
        'danhSachKhachThue.Rows.Add("", "", "", "")
        'danhSachKhachThue.Rows.Add("", "", "", "")

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

            Using New CenteredMessageBox(Me)
                MessageBox.Show("Tên phòng không có trong hệ thống.")
            End Using

        End If

    End Sub

    Private Sub dgvDanhSachKhachThue_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvDanhSachKhachThue.RowValidating
        Dim chuoi = sender.CurrentRow.Cells(sender.CurrentCell.ColumnIndex).Value.ToString

        If (String.IsNullOrEmpty(chuoi)) Then
            Return
        ElseIf (String.IsNullOrWhiteSpace(chuoi)) Then
            e.Cancel = True

            Using New CenteredMessageBox(Me)
                MessageBox.Show(Me, "Vui lòng nhập giá trị hợp lệ!")
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
        Dim dtDanSachKhachThue As DataTable = dgvDanhSachKhachThue.DataSource

        ' hiển thị giá trị trong dt để kiểm tra
        Dim str As String = ""
        For Each row As DataRow In dtDanSachKhachThue.Rows
            For Each col As DataColumn In dtDanSachKhachThue.Columns
                str += row(col) + " "
            Next
            str += vbCrLf
        Next

        MessageBox.Show(dtDanSachKhachThue.Rows.Count.ToString)
        MessageBox.Show(str)

    End Sub

    ' tạo sự kiện giới hạn số dòng (khách hàng) được thêm bởi người dùng
    Private Sub dgvDanhSachKhachThue_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgvDanhSachKhachThue.UserAddedRow
        Dim SoKhachToiDa As Integer = 3

        If (dgvDanhSachKhachThue.Rows.Count > SoKhachToiDa) Then
            dgvDanhSachKhachThue.AllowUserToAddRows = False
        End If
    End Sub
End Class