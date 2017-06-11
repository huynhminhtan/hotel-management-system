Imports DAO.DAO
Imports DTO.DTO
Imports System.Data.SqlClient

Namespace BUS

    Public Class PhongBUS

#Region "ReTrieving"

        Public Shared Function selectMaPhongMoiNhat() As String
            Dim maPhongMoiNhat As String = Nothing
            If (PhongDAO.selectPhongMoiNhat() IsNot Nothing) Then
                Dim PhongMoiNhat As PhongDTO = PhongDAO.selectPhongMoiNhat()
                maPhongMoiNhat = PhongMoiNhat.MaPhong
            End If
            Return maPhongMoiNhat
        End Function

        Public Shared Function selectPhongAll() As List(Of PhongDTO)
            Return PhongDAO.selectPhongALL()
        End Function

        Public Shared Function selectPhongAllisDeleted() As List(Of PhongDTO)
            Return PhongDAO.selectPhongAllisDeleted()
        End Function

        Public Shared Function selectPhongVoiTenLoaiPhong() As DataTable
            Return PhongDAO.selectPhongVoiTenLoaiPhong()
        End Function

        Public Shared Function selectPhongAllByNgayBatDauVaNgayTraPhong(ngayBatDau As Date,
                                                                        ngayTraPhong As Date) As DataTable
            Return PhongDAO.selectPhongAllByNgayBatDauVaNgayTraPhong(ngayBatDau, ngayTraPhong)
        End Function

        Public Shared Function selectPhongKhongMaPhongKhongTenPhong(maLoaiPhong As String,
                                                                    donGiaThue As Double,
                                                                    loaiTinhTrang As String,
                                                                    ngayBatDau As Date,
                                                                    ngayTraPhong As Date) As DataTable
            Return PhongDAO.selectPhongKhongMaPhongKhongTenPhong(maLoaiPhong, donGiaThue,
                                                                 loaiTinhTrang, ngayBatDau, ngayTraPhong)
        End Function

        Public Shared Function selectPhongByMaPhongNgayBatDauNgayTraPhong(maPhong As String,
                                                       ngayBatDau As Date,
                                                       ngayTraPhong As Date) As DataTable
            Return PhongDAO.selectPhongByMaPhongNgayBatDauNgayTraPhong(maPhong, ngayBatDau, ngayTraPhong)
        End Function

        Public Shared Function selectPhongByTenPhongNgayBatDauNgayTraPhong(tenPhong As String,
                                                       ngayBatDau As Date,
                                                       ngayTraPhong As Date) As DataTable
            Return PhongDAO.selectPhongByTenPhongNgayBatDauNgayTraPhong(tenPhong, ngayBatDau, ngayTraPhong)
        End Function

        Public Shared Function selectDanhSachPhongVoiSoNgayThuegByThang(thang As Date) As DataTable
            Return PhongDAO.selectDanhSachPhongVoiSoNgayThuegByThang(thang)
        End Function

#End Region

#Region "Inserting"

        Public Shared Function themDanhSachPhong(danhSachPhong As List(Of PhongDTO)) As Integer
            Dim ketQua As Integer = 0
            For i As Integer = 0 To (danhSachPhong.Count - 1)
                If (PhongDAO.themPhong(danhSachPhong(i))) Then
                    ketQua += 1

                    ' thêm tình trạng cho phòng
                    Dim tinhTrang As New TinhTrangDTO
                    tinhTrang.LoaiTinhTrang = "TRONG"
                    tinhTrang.MaPhong = danhSachPhong(i).MaPhong

                    If (TinhTrangBUS.themTinhTrang(tinhTrang, Date.Now) = False) Then
                        Return 0
                    End If
                End If
            Next
            Return ketQua
        End Function

#End Region

#Region "Updating"

        Public Shared Function xoaPhongByMaPhong(maPhong As String) As Boolean
            Return PhongDAO.xoaPhongByMaPhong(maPhong)
        End Function

        Public Shared Function capNhatPhongByMaPhong(phong As PhongDTO) As Boolean
            Return PhongDAO.capNhatPhongByMaPhong(phong)
        End Function

#End Region
    End Class

End Namespace
