Imports DTO.DTO
Imports System.Data.SqlClient

Namespace DAO


    Public Class ChiTietPhieuThueDAO

#Region "Inserting"

        Public Function insertChiTietPhieuThue(chiTietPhieuThue As ChiTietPhieuThueDTO) As Boolean
            Dim trangThai As Boolean = False

            Try
                Dim SqlParams As New List(Of SqlParameter)

                SqlParams.Add(New SqlParameter("@MaPhieuThue", chiTietPhieuThue.MaPhieuThue))
                SqlParams.Add(New SqlParameter("@TenKhachHang", chiTietPhieuThue.TenKhachHang))
                SqlParams.Add(New SqlParameter("@MaLoaiKhachHang", chiTietPhieuThue.MaLoaiKhachHang))
                SqlParams.Add(New SqlParameter("@CMND", chiTietPhieuThue.CMnd))
                SqlParams.Add(New SqlParameter("@DiaChi", chiTietPhieuThue.DiaChi))
                SqlParams.Add(New SqlParameter("@HeSoThucTe", chiTietPhieuThue.HeSoThucTe))

                Dim n As Integer = SqlDataAccessHelper.ExecuteNoneQuery("NewChiTietPhieuThue", SqlParams)

                If (n = 1) Then
                    trangThai = True
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return trangThai
        End Function

#End Region

    End Class

End Namespace

