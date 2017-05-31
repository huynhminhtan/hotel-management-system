Imports DAO.DAO
Imports DTO.DTO

Namespace BUS

    Public Class PhieuThueBUS

#Region "ReTrieving"

        Public Shared Function selectMaPhieuThueMoiNhat() As String
            Dim maPhieuThue As String = Nothing

            If (PhieuThueDAO.selectPhieuThueMoiNhat() IsNot Nothing) Then
                Dim phieuThueMoiNhat As PhieuThueDTO = PhieuThueDAO.selectPhieuThueMoiNhat()

                maPhieuThue = phieuThueMoiNhat.MaPhieuThue
            End If
            Return maPhieuThue
        End Function

#End Region

#Region "Inserting"

        Public Shared Function themPhieuThue(phieuThue As PhieuThueDTO) As Boolean
            Return PhieuThueDAO.insertPhieuThue(phieuThue)
        End Function

#End Region

    End Class

End Namespace
