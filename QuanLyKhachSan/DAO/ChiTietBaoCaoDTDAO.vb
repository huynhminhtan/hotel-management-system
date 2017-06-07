Imports System.Data.SqlClient
Imports DTO.DTO

Namespace DAO

    Public Class ChiTietBaoCaoDTDAO
#Region "Inserting"
        Public Shared Function themChiTietBaoCaoDT(chiTietBaoCaoDT As ChiTietBaoCaoDTDTO) As Boolean
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@MaBaoCaoDoanhThu", chiTietBaoCaoDT.MaBaoCaoDoanhThu))
                sqlParams.Add(New SqlParameter("@MaLoaiPhong", chiTietBaoCaoDT.MaLoaiPhong))
                sqlParams.Add(New SqlParameter("@DoanhThuLoaiPhong", chiTietBaoCaoDT.DoanhThuLoaiPhong))
                sqlParams.Add(New SqlParameter("@TiLeDoanhThu", chiTietBaoCaoDT.TiLeDoanhThu))

                Dim n As Integer
                n = SqlDataAccessHelper.ExecuteNoneQuery("NewChiTietBaoCaoDT", sqlParams)

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

