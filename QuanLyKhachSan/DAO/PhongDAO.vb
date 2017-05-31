Imports System.Data.SqlClient
Imports DTO.DTO

Namespace DAO

    Public Class PhongDAO

#Region "Inserting"

        Public Shared Function insertPhong(phong As PhongDTO) As Boolean
            Dim trangThai As Boolean = False

            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@MaPhong", phong.MaPhong))
                sqlParams.Add(New SqlParameter("@TenPhong", phong.TenPhong))
                sqlParams.Add(New SqlParameter("@MaLoaiPhong", phong.MaLoaiPhong))
                sqlParams.Add(New SqlParameter("@GhiChu", phong.GhiChu))

                Dim n As Integer = SqlDataAccessHelper.ExecuteNoneQuery("insertPhong", sqlParams)

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
#End Region

    End Class

End Namespace
