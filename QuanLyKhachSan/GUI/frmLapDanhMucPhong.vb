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

    End Sub


    Private Sub cboTenLoaiPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTenLoaiPhong.SelectedIndexChanged
        ' hiển thị đơn giá từ database tương ứng với cboTenLoaiPhong
        ' tip: int.Parse(cbEmployeeStyle.SelectedValue.ToString());

        txtDonGia.Text = BUS.BUS.LoaiPhongBUS.selectDonGiaByMaLoaiPhong(cboTenLoaiPhong.SelectedValue.ToString)

    End Sub
End Class