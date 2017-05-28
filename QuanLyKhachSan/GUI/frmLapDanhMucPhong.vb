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
        dgvDanhMucPhong.DataSource = LoaiPhongBUS.SelectAllLoaiPhong()

    End Sub




End Class