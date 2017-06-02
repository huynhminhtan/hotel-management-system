Imports DTO.DTO
Imports System.Data.SqlClient

Namespace DAO

    Public Class HoaDonDAO
#Region "Retrieving"

        Public Shared Function selectHoaDonMoiNhatAll() As HoaDonDTO
            Dim hoaDon As New HoaDonDTO

            Try

                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectHoaDonMoiNhatAll", Nothing)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

                Dim hang As DataRow = dt.Rows(0)

                hoaDon.MaHoaDon = hang("MaHoaDon").ToString
                hoaDon.TenKhachHangHD = hang("TenKhachHangHD").ToString
                hoaDon.DiaChiKhachHD = hang("DiaChiKhachHD").ToString
                hoaDon.TriGiaHoaDon = Double.Parse(hang("TriGiaHoaDon").ToString)

            Catch ex As Exception
                Throw ex
            End Try
            Return hoaDon
        End Function

#End Region
    End Class

End Namespace
