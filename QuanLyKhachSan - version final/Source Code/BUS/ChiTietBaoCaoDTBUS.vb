Imports DTO.DTO
Imports DAO.DAO

Namespace BUS

    Public Class ChiTietBaoCaoDTBUS
#Region "Inserting"
        Public Shared Function themDanhSachChiTietBaoCaoDT(danhSachChiTietBaoCaoDT As List(Of ChiTietBaoCaoDTDTO)) As Integer
            Dim ketQua As Integer = 0

            For Each chiTietBaoCaoDoanhDT As ChiTietBaoCaoDTDTO In danhSachChiTietBaoCaoDT
                If (ChiTietBaoCaoDTDAO.themChiTietBaoCaoDT(chiTietBaoCaoDoanhDT) = True) Then
                    ketQua += 1
                End If
            Next

            Return ketQua
        End Function
#End Region

#Region "Retrieving"
        Public Shared Function selectChiTietBaoCaoDoanhThuByMaBaoCaoDoanhThu(maBaoCaoDoanhThu As String) As List(Of ChiTietBaoCaoDTDTO)
            Return ChiTietBaoCaoDTDAO.selectChiTietBaoCaoDoanhThuByMaBaoCaoDoanhThu(maBaoCaoDoanhThu)
        End Function
#End Region

    End Class

End Namespace

