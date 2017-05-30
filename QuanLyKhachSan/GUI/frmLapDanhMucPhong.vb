Imports BUS.BUS
Imports DTO.DTO

Public Class frmLapDanhMucPhong

    Private danhSachPhongTam As New DataTable


    Private Sub frmLapDanhMucPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load danh sách tên loại phòng lên combobox
        ''''' Tạo ở lớp LoaiPhongBUS.SelectLoaiPhongAll();
        '''''''''''Tạo lớp LoaiPhongDA0.SelectLoaiPhongAll();
        '''''''''''''''''Tạo lớp sqlDataAccessHelper, dùng kỹ thuật parameter để truy cập dữ liệu

        ' Nhận dữ liệu từ combobox để truyền cho dataGridView hiển thị danh sách Phòng theo Tên loại phòng.

        ' 

        ' Thử select danh sách loại phòng
        ' dgvDanhMucPhong.DataSource = LoaiPhongBUS.SelectAllLoaiPhong()


        ' hiển thị danh sách loại phòng
        cboTenLoaiPhong.DisplayMember = "TenLoaiPhong" ' cột cần hiển thị ra ngoài comboboxs
        cboTenLoaiPhong.ValueMember = "MaLoaiPhong" ' giá trị tương ứng với displayMember được chọn
        cboTenLoaiPhong.DataSource = LoaiPhongBUS.selectLoaiPhongAll()

        ' hiển thị mã loại phòng đã tăng
        txtMaPhong.Text = tangMaphong(PhongBUS.selectMaPhongMoiNhat())

        ' hiển thị danh sách các loại phòng tạm
        dgvDanhMucPhong.AutoGenerateColumns = False
        dgvDanhMucPhong.DataSource = danhSachPhongTam

        ' khởi tạo bảng phòng tạm
        danhSachPhongTam.Columns.Add("MaPhong", GetType(String))
        danhSachPhongTam.Columns.Add("TenPhong", GetType(String))
        danhSachPhongTam.Columns.Add("MaLoaiPhong", GetType(String))
        danhSachPhongTam.Columns.Add("TenLoaiPhong", GetType(String))
        danhSachPhongTam.Columns.Add("DonGia", GetType(Double))
        danhSachPhongTam.Columns.Add("GhiChu", GetType(String))

       

    End Sub


    Private Sub cboTenLoaiPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTenLoaiPhong.SelectedIndexChanged
        ' hiển thị đơn giá từ database tương ứng với cboTenLoaiPhong
        ' tip: int.Parse(cbEmployeeStyle.SelectedValue.ToString());

        txtDonGia.Text = LoaiPhongBUS.selectDonGiaByMaLoaiPhong(cboTenLoaiPhong.SelectedValue.ToString)

    End Sub

    Private Sub btnThemPhong_Click(sender As Object, e As EventArgs) Handles btnThemPhong.Click

        If (String.IsNullOrEmpty(txtTenPhong.Text)) Then
            MessageBox.Show("Vui lòng nhập tên phòng.")
            Return
        End If

        Dim maPhong As String = txtMaPhong.Text

        If (danhSachPhongTam.Rows.Count - 1 >= 0) Then
            maPhong = danhSachPhongTam.Rows(danhSachPhongTam.Rows.Count - 1).Item(0).ToString
            maPhong = tangMaphong(maPhong)
        End If

        danhSachPhongTam.Rows.Add(maPhong, txtTenPhong.Text, cboTenLoaiPhong.SelectedItem.MaLoaiPhong,
                                  cboTenLoaiPhong.SelectedItem.TenLoaiPhong, txtDonGia.Text, txtGhiChu.Text)

        dgvDanhMucPhong.DataSource = Nothing
        dgvDanhMucPhong.DataSource = danhSachPhongTam

        ' tăng mã phòng
        txtMaPhong.Text = tangMaphong(danhSachPhongTam.Rows(danhSachPhongTam.Rows.Count - 1).Item(0).ToString)

    End Sub

    Private Function tangMaphong(maPhong As String) As String

        If (maPhong = Nothing) Then
            Return "PH000"
        End If

        Dim maPhongTang As String

        maPhongTang = "PH" + ((Integer.Parse(maPhong.Substring(2)) + 1).ToString).PadLeft(3, "0")

        Return maPhongTang
    End Function

    Private Sub dgvDanhMucPhong_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhMucPhong.SelectionChanged
        If (dgvDanhMucPhong.CurrentRow IsNot Nothing) Then
            txtMaPhong.Text = dgvDanhMucPhong.CurrentRow.Cells("MaPhong").Value.ToString
            txtTenPhong.Text = dgvDanhMucPhong.CurrentRow.Cells("TenPhong").Value.ToString

            'cboTenLoaiPhong.SelectedIndex = 
            cboTenLoaiPhong.SelectedValue = dgvDanhMucPhong.CurrentRow.Cells("MaLoaiPhong").Value

            txtDonGia.Text = dgvDanhMucPhong.CurrentRow.Cells("DonGia").Value.ToString
            txtGhiChu.Text = dgvDanhMucPhong.CurrentRow.Cells("GhiChu").Value.ToString
        End If
    End Sub

    'Private Sub dgvDanhMucPhong_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvDanhMucPhong.CurrentCellChanged
    '    If (dgvDanhMucPhong.CurrentRow IsNot Nothing) Then
    '        txtMaPhong.Text = dgvDanhMucPhong.CurrentRow.Cells("MaPhong").Value.ToString
    '        txtTenPhong.Text = dgvDanhMucPhong.CurrentRow.Cells("TenPhong").Value.ToString

    '        'cboTenLoaiPhong.SelectedValue = dgvDanhMucPhong.CurrentRow.Cells("MaLoaiPhong").Value

    '        txtDonGia.Text = dgvDanhMucPhong.CurrentRow.Cells("DonGia").Value.ToString
    '        txtGhiChu.Text = dgvDanhMucPhong.CurrentRow.Cells("GhiChu").Value.ToString
    '    End If
    'End Sub
End Class