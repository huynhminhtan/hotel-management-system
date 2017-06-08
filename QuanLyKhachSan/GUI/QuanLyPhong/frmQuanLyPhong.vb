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
        CapNhat()

        ' hiện dữ liệu lên datagridview
        dgvQuanLyPhong.DataSource = bangQuanLyPhong

    End Sub

    Private Sub btnThemPhong_Click(sender As Object, e As EventArgs) Handles btnThemPhong.Click
        Dim formLapDanhMucPhong As New frmLapDanhMucPhong(Me)
        formLapDanhMucPhong.ShowDialog(Me)
    End Sub

    Public Sub CapNhat()

        bangQuanLyPhong.Clear()

        Dim danhSachPhong As List(Of PhongDTO)
        danhSachPhong = PhongBUS.selectPhongAll()

        For Each phongTam As PhongDTO In danhSachPhong
            Dim tenLoaiPhongTam As String = LoaiPhongBUS.selectTenLoaiPhongByMaLoaiPhong(phongTam.MaLoaiPhong)
            Dim donGiaTam As Double = LoaiPhongBUS.selectDonGiaByMaLoaiPhong(phongTam.MaLoaiPhong)

            Dim tinhTrangTam As String
            If (TinhTrangBUS.phongDuocThue(phongTam.MaPhong, Date.Today, Date.Today) = True) Then
                tinhTrangTam = "Đang thuê"
            Else
                tinhTrangTam = "Đang trống"
            End If

            bangQuanLyPhong.Rows.Add(phongTam.MaPhong, phongTam.TenPhong, tenLoaiPhongTam, donGiaTam, tinhTrangTam)
        Next
    End Sub

    Private Sub btnTimPhong_Click(sender As Object, e As EventArgs) Handles btnTimPhong.Click
        Dim formTraCuuPhong As New frmTraCuuPhong(Me)
        formTraCuuPhong.ShowDialog(Me)
    End Sub

    Private Sub btnHuyPhong_Click(sender As Object, e As EventArgs) Handles btnHuyPhong.Click
        Dim formHuyPhong As New frmHuyPhong(Me)
        formHuyPhong.ShowDialog(Me)
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhatPhong.Click
        Dim formCapNhatPhong As New frmCapNhatPhong(Me)
        formCapNhatPhong.ShowDialog(Me)
    End Sub
End Class