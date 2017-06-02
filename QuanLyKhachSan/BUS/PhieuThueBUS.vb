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

        Public Shared Function kiemTraPhieuThueByMaPhieuThue(maPhieuThue As String) As Boolean
            Return PhieuThueDAO.kiemTraPhieuThueByMaPhieuThue(maPhieuThue)
        End Function

        Public Shared Function selectPhieuThueHDByMaPhieuThue(maPhieuThue As String) As DataTable
            Return PhieuThueDAO.selectPhieuThueHDByMaPhieuThue(maPhieuThue)
        End Function

        Public Shared Function kiemTraPhieuThueDaLapHoaDon(maPhieuThue As String) As Boolean
            Return PhieuThueDAO.kiemTraPhieuThueDaLapHoaDon(maPhieuThue)
        End Function
#End Region

#Region "Inserting"

        Public Shared Function themPhieuThue(phieuThue As PhieuThueDTO) As Boolean
            Return PhieuThueDAO.insertPhieuThue(phieuThue)
        End Function

#End Region

        Public Shared Function daThanhToanHoaDon(maHoaDon As String, maPhieuThue As String) As Boolean
            Return PhieuThueDAO.daThanhToanHoaDon(maHoaDon, maPhieuThue)
        End Function

    End Class

End Namespace
