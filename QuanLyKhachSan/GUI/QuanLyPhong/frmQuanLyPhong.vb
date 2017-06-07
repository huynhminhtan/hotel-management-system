Imports BUS.BUS
Imports DTO.DTO
Imports GUI.XuLy

Public Class frmQuanLyPhong

    Private bangQuanLyPhong As New DataTable

    Private Sub frmQuanLyPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' khởi tạo bangQuanLyPhong
        bangQuanLyPhong.Columns.Add("MaPhong", GetType(String))
        bangQuanLyPhong.Columns.Add("TenPhong", GetType(String))
        bangQuanLyPhong.Columns.Add("TenLoaiPhong", GetType(String))
        bangQuanLyPhong.Columns.Add("DonGiaThue", GetType(Double))
        bangQuanLyPhong.Columns.Add("TinhTrang", GetType(String))

        ' lấy dữ liệu cho bảng
        Dim danhSachPhong As List(Of PhongDTO)
        danhSachPhong = PhongBUS.selectPhongAll()

        For Each phong As PhongDTO In danhSachPhong
            Dim tenLoaiPhong As String
        Next
    End Sub

    Private Sub btnThemPhong_Click(sender As Object, e As EventArgs) Handles btnThemPhong.Click
        Dim formLapDanhMucPhong As New frmLapDanhMucPhong(Me)
        formLapDanhMucPhong.Show()
    End Sub

    Public Sub CapNhat()
        Using New CenteredMessageBox(Me)
            MessageBox.Show("Đã update!")
        End Using
    End Sub

    Private Sub btnTimPhong_Click(sender As Object, e As EventArgs) Handles btnTimPhong.Click
        Dim formTraCuuPhong As New frmTraCuuPhong(Me)
        formTraCuuPhong.Show()
    End Sub
End Class