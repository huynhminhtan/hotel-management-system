Imports DTO.DTO
Imports System.Data.SqlClient

Namespace DAO

    Public Class PhieuThueDAO

#Region "Retrieving"

        Public Shared Function selectPhieuThueMoiNhat() As PhieuThueDTO
            Dim phieuThue As New PhieuThueDTO

            Try
                Dim dt As New DataTable

                dt = SqlDataAccessHelper.ExecuteQuery("selectPhieuThueMoiNhat", Nothing)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

                Dim row As DataRow = dt.Rows(0)

                phieuThue.MaPhieuThue = row("MaPhieuThue").ToString
                phieuThue.MaPhong = row("MaPhong").ToString

                ' Kiểu ngày trả phòng
                phieuThue.NgayTraPhong = row("NgayTraPhong").ToString
                phieuThue.NgayBatDauThue = row("NgayBatDauThue").ToString

                phieuThue.DonGiaThueThucTe = Double.Parse(row("DonGiaThueThucTe").ToString)
                phieuThue.ThanhTienPhong = Double.Parse(row("ThanhTienPhong").ToString)
                phieuThue.MaHoaDon = row("MaHoaDon").ToString
                phieuThue.PhuThuThucTe = Double.Parse(row("PhuThuThucTe").ToString)

            Catch ex As Exception
                Throw ex
            End Try
            Return phieuThue
        End Function

#End Region

#Region "Inserting"

        Public Shared Function insertPhieuThue(phieuThue As PhieuThueDTO) As Boolean
            Dim trangThai As Boolean = False

            Try
                Dim sqlParams As New List(Of SqlParameter)

                sqlParams.Add(New SqlParameter("@MaPhong", phieuThue.MaPhong))
                sqlParams.Add(New SqlParameter("@NgayTraPhong", phieuThue.NgayTraPhong))
                sqlParams.Add(New SqlParameter("@NgayBatDauThue", phieuThue.NgayBatDauThue))
                sqlParams.Add(New SqlParameter("@DonGiaThueThucTe", phieuThue.DonGiaThueThucTe))
                sqlParams.Add(New SqlParameter("@ThanhTienPhong", phieuThue.ThanhTienPhong))
                sqlParams.Add(New SqlParameter("@PhuThuThucTe", phieuThue.PhuThuThucTe))

                Dim n As Integer = SqlDataAccessHelper.ExecuteNoneQuery("NewPhieuThue", sqlParams)

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

    End Class

End Namespace
