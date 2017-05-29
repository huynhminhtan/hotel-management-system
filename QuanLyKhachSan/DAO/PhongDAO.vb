Imports System.Data.SqlClient
Imports DTO.DTO

Namespace DAO

    Public Class PhongDAO

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
