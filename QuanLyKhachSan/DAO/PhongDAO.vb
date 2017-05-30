Imports System.Data.SqlClient
Imports DTO.DTO

Namespace DAO

    Public Class PhongDAO

#Region "Inserting"

        Public Shared Function themPhong(phong As PhongDTO) As Boolean
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
            Dim ph As New PhongDTO

            Try
                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectPhongMoiNhat", Nothing)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing ' không có phòng nào trong CSDL
                End If

                Dim row As DataRow = dt.Rows(0)

                ph.MaPhong = row("MaPhong").ToString
                ph.TenPhong = row("TenPhong").ToString
                ph.MaLoaiPhong = row("MaLoaiPhong").ToString
                ph.GhiChu = row("GhiChu").ToString

            Catch ex As Exception
                Throw ex
            End Try

            Return ph

        End Function
#End Region

    End Class

End Namespace
