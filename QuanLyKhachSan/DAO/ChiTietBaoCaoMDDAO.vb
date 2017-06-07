Imports DTO.DTO
Imports System.Data.SqlClient

Namespace DAO

    Public Class ChiTietBaoCaoMDDAO

        Public Shared Function themChiTietBaoCaoMD(chiTietBaoCaoMD As ChiTietBaoCaoMDDTO) As Boolean
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@MaBaoCaoMatDo", chiTietBaoCaoMD.MaBaoCaoMatDo))
                sqlParams.Add(New SqlParameter("@MaPhong", chiTietBaoCaoMD.MaPhong))
                sqlParams.Add(New SqlParameter("@SoNgayThueTrongThang", chiTietBaoCaoMD.SoNgayThueTrongThang))
                sqlParams.Add(New SqlParameter("@TiLeSuDung", chiTietBaoCaoMD.TiLeSuDung))

                Dim n As Integer
                n = SqlDataAccessHelper.ExecuteNoneQuery("NewChiTietBaoCaoMD", sqlParams)

                If (n <= 0) Then
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return True
        End Function

    End Class

End Namespace
