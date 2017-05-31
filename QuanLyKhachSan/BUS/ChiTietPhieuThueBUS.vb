Imports DAO.DAO
Imports DTO.DTO

Namespace BUS

    Public Class ChiTietPhieuThueBUS

#Region "Inserting"

        Public Shared Function themChiTietPhieuThue(danhSachChiTietPhieuThue As List(Of ChiTietPhieuThueDTO)) As Integer
            Dim ketQua As Integer = 0
            For i As Integer = 0 To danhSachChiTietPhieuThue.Count - 1
                If (ChiTietPhieuThueDAO.insertChiTietPhieuThue(danhSachChiTietPhieuThue(i))) Then
                    ketQua += 1
                End If
            Next
            Return ketQua
        End Function

#End Region

    End Class
End Namespace