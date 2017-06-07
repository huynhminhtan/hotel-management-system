Imports DTO.DTO
Imports DAO.DAO

Namespace BUS

    Public Class ChiTietBaoCaoMDBUS
#Region "Inserting"

        Public Shared Function themDanhSachChiTietBaoCaoMD(danhSachChiTietBaoCaoMD As List(Of ChiTietBaoCaoMDDTO)) As Integer
            Dim ketQua As Integer = 0

            For Each chiTietBaoCaoMD As ChiTietBaoCaoMDDTO In danhSachChiTietBaoCaoMD
                If (ChiTietBaoCaoMDDAO.themChiTietBaoCaoMD(chiTietBaoCaoMD) = True) Then
                    ketQua += 1
                End If
            Next

            Return ketQua
        End Function
#End Region

    End Class

End Namespace
