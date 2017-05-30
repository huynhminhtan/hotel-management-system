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
                phieuThue.NgayBatDayThue = row("NgayBatDayThue").ToString

                phieuThue.DonGiaThueThucTe = Double.Parse(row("DonGiaThueThucTe").ToString)
                phieuThue.ThanhTienPhong = Double.Parse(row("ThanhTienPhong").ToString)
                phieuThue.MaHoaDon = row("MaHoaDon").ToString
                phieuThue.PhuThuThucTe = Double.Parse(row("PhuThuThucTe").ToString)

            Catch ex As Exception

            End Try
            Return phieuThue
        End Function

#End Region

    End Class

End Namespace
