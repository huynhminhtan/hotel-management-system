Imports BUS.BUS

Public Class frmLapDanhMucPhong

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
        'txtMaPhong.Text = tangMaPhong(PhongBUS.selectMaPhongMoiNhat() 'as String)

        ' hiển thị danh sách các loại phòng tạm
        ' Dim danhSachPhongTam As New List(Of PhongDTO)


    End Sub


    Private Sub cboTenLoaiPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTenLoaiPhong.SelectedIndexChanged
        ' hiển thị đơn giá từ database tương ứng với cboTenLoaiPhong
        ' tip: int.Parse(cbEmployeeStyle.SelectedValue.ToString());

        txtDonGia.Text = LoaiPhongBUS.selectDonGiaByMaLoaiPhong(cboTenLoaiPhong.SelectedValue.ToString)

    End Sub

    Private Sub btnThemPhong_Click(sender As Object, e As EventArgs) Handles btnThemPhong.Click


    End Sub

    Private Function tangMaphong(maPhong As String) As String

        If (maPhong = Nothing) Then
            Return "PH000"
        End If

        Return ""
    End Function

End Class