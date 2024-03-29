﻿Imports System.Data.SqlClient
Imports DTO.DTO

Namespace DAO

    Public Class PhongDAO

#Region "Inserting"

        Public Shared Function themPhong(phong As PhongDTO) As Boolean
            Dim trangThai As Boolean = False

            Try
                Dim sqlParams As New List(Of SqlParameter)
                'sqlParams.Add(New SqlParameter("@MaPhong", phong.MaPhong))
                Dim sqlpa As New SqlParameter("@TenPhong", SqlDbType.NVarChar)
                sqlpa.Value = phong.TenPhong
                sqlParams.Add(sqlpa)
                sqlParams.Add(New SqlParameter("@MaLoaiPhong", phong.MaLoaiPhong))
                sqlParams.Add(New SqlParameter("@GhiChu", phong.GhiChu))

                Dim n As Integer = SqlDataAccessHelper.ExecuteNoneQuery("NewPhong", sqlParams)

                ' SqlDataAccessHelper.ExecuteNoneQuery : trả về số row bị ảnh hưởng trong CSDL
                If (n = 1) Then
                    trangThai = True
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return trangThai

        End Function

#End Region

#Region "Retrieving"
        Public Shared Function selectPhongMoiNhat() As PhongDTO
            Dim phong As New PhongDTO

            Try
                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectPhongMoiNhat", Nothing)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing ' không có phòng nào trong CSDL
                End If

                Dim row As DataRow = dt.Rows(0)

                phong.MaPhong = row("MaPhong").ToString
                phong.TenPhong = row("TenPhong").ToString
                phong.MaLoaiPhong = row("MaLoaiPhong").ToString
                phong.GhiChu = row("GhiChu").ToString

            Catch ex As Exception
                Throw ex
            End Try

            Return phong

        End Function

        Public Shared Function selectPhongVoiTenLoaiPhong() As DataTable
            Dim dt As New DataTable

            Try
                dt = SqlDataAccessHelper.ExecuteQuery("selectPhongVoiTenLoaiPhong", Nothing)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing ' Không có phòng nào trong CSDL
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function

        Public Shared Function selectPhongALL() As List(Of PhongDTO)
            Dim listPhong As New List(Of PhongDTO)
            Dim dt As New DataTable

            Try
                dt = SqlDataAccessHelper.ExecuteQuery("selectPhongAll", Nothing)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing ' Không có phòng nào trong CSDL
                End If

                For Each row As DataRow In dt.Rows

                    Dim phong As New PhongDTO
                    phong.MaPhong = row("MaPhong").ToString
                    phong.MaLoaiPhong = row("MaLoaiPhong").ToString
                    phong.TenPhong = row("TenPhong").ToString
                    phong.GhiChu = row("GhiChu").ToString

                    listPhong.Add(phong)
                Next

            Catch ex As Exception
                Throw ex
            End Try
            Return listPhong
        End Function


        Public Shared Function selectPhongAllisDeleted() As List(Of PhongDTO)
            Dim listPhong As New List(Of PhongDTO)
            Dim dt As New DataTable

            Try
                dt = SqlDataAccessHelper.ExecuteQuery("selectPhongAllisDeleted", Nothing)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing ' Không có phòng nào trong CSDL
                End If

                For Each row As DataRow In dt.Rows

                    Dim phong As New PhongDTO
                    phong.MaPhong = row("MaPhong").ToString
                    phong.MaLoaiPhong = row("MaLoaiPhong").ToString
                    phong.TenPhong = row("TenPhong").ToString
                    phong.GhiChu = row("GhiChu").ToString

                    listPhong.Add(phong)
                Next

            Catch ex As Exception
                Throw ex
            End Try
            Return listPhong
        End Function

        Public Shared Function selectPhongAllByNgayBatDauVaNgayTraPhong(ngayBatDau As Date,
                                                                        ngayTraPhong As Date) As DataTable
            Dim dt As New DataTable

            Try
                Dim sqlParams As New List(Of SqlParameter)

                sqlParams.Add(New SqlParameter("@NgayBatDau", ngayBatDau.Date))
                sqlParams.Add(New SqlParameter("@NgayTraPhong", ngayTraPhong.Date))

                dt = SqlDataAccessHelper.ExecuteQuery("selectPhongAllByNgayBatDauVaNgayTraPhong", sqlParams)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function

        Public Shared Function selectPhongKhongMaPhongKhongTenPhong(maLoaiPhong As String,
                                                                    donGiaThue As Double,
                                                                    loaiTinhTrang As String,
                                                                    ngayBatDau As Date,
                                                                    ngayTraPhong As Date) As DataTable
            Dim dt As New DataTable

            Try
                Dim sqlParams As New List(Of SqlParameter)

                sqlParams.Add(New SqlParameter("@MaLoaiPhong", maLoaiPhong))
                sqlParams.Add(New SqlParameter("@DonGiaThue", donGiaThue))
                sqlParams.Add(New SqlParameter("@LoaiTinhTrang", loaiTinhTrang))
                sqlParams.Add(New SqlParameter("@NgayBatDau", ngayBatDau.Date))
                sqlParams.Add(New SqlParameter("@NgayTraPhong", ngayTraPhong.Date))

                dt = SqlDataAccessHelper.ExecuteQuery("selectPhongKhongMaPhongKhongTenPhong", sqlParams)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function

        Public Shared Function selectPhongByMaPhongNgayBatDauNgayTraPhong(maPhong As String,
                                                       ngayBatDau As Date,
                                                       ngayTraPhong As Date) As DataTable
            Dim dt As New DataTable

            Try
                Dim sqlParams As New List(Of SqlParameter)

                sqlParams.Add(New SqlParameter("@MaPhong", maPhong))
                sqlParams.Add(New SqlParameter("@NgayBatDau", ngayBatDau.Date))
                sqlParams.Add(New SqlParameter("@NgayTraPhong", ngayTraPhong.Date))

                dt = SqlDataAccessHelper.ExecuteQuery("selectPhongByMaPhongNgayBatDauNgayTraPhong", sqlParams)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function

        Public Shared Function selectPhongByTenPhongNgayBatDauNgayTraPhong(tenPhong As String,
                                                      ngayBatDau As Date,
                                                      ngayTraPhong As Date) As DataTable
            Dim dt As New DataTable

            Try
                Dim sqlParams As New List(Of SqlParameter)

                sqlParams.Add(New SqlParameter("@TenPhong", tenPhong.ToUpper()))
                sqlParams.Add(New SqlParameter("@NgayBatDau", ngayBatDau.Date))
                sqlParams.Add(New SqlParameter("@NgayTraPhong", ngayTraPhong.Date))

                dt = SqlDataAccessHelper.ExecuteQuery("selectPhongByTenPhongNgayBatDauNgayTraPhong", sqlParams)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function

        Public Shared Function selectDanhSachPhongVoiSoNgayThuegByThang(thang As Date) As DataTable
            Dim dt As New DataTable

            Try
                Dim sqlParams As New List(Of SqlParameter)

                sqlParams.Add(New SqlParameter("@Thang", thang))

                dt = SqlDataAccessHelper.ExecuteQuery("selectDanhSachPhongVoiSoNgayThueByThang", sqlParams)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function

#End Region

#Region "Updating"

        Public Shared Function xoaPhongByMaPhong(maPhong As String) As Boolean
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@MaPhong", maPhong))

                Dim n As Integer
                n = SqlDataAccessHelper.ExecuteNoneQuery("xoaPhongByMaPhong", sqlParams)

                If (n <= 0) Then
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return True
        End Function

        Public Shared Function capNhatPhongByMaPhong(phong As PhongDTO) As Boolean
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@MaPhong", phong.MaPhong))
                sqlParams.Add(New SqlParameter("@TenPhong", phong.TenPhong))
                sqlParams.Add(New SqlParameter("@MaLoaiPhong", phong.MaLoaiPhong))
                sqlParams.Add(New SqlParameter("@GhiChu", phong.GhiChu))

                Dim n As Integer
                n = SqlDataAccessHelper.ExecuteNoneQuery("capNhatPhongByMaPhong", sqlParams)

                If (n <= 0) Then
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return True
        End Function

#End Region

    End Class

End Namespace
