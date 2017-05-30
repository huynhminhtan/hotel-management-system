Imports DAO.DAO
Imports DTO.DTO
Imports System.Data.SqlClient

Namespace BUS

    Public Class PhongBUS

#Region "ReTrieving"

        Public Shared Function selectMaPhongMoiNhat() As String
            Dim maPhongMoiNhat As String = Nothing
            If (PhongDAO.selectPhongMoiNhat() IsNot Nothing) Then
                Dim PhongMoiNhat As PhongDTO = PhongDAO.selectPhongMoiNhat()
                maPhongMoiNhat = PhongMoiNhat.MaPhong
            End If
            Return maPhongMoiNhat
        End Function

#End Region

        Public Shared Function themDanhSachPhong(danhSachPhong As List(Of PhongDTO)) As Integer
            Dim ketQua As Integer = 0
            For i As Integer = 0 To danhSachPhong.Count - 1
                If (PhongDAO.themPhong(danhSachPhong(i))) Then
                    ketQua += 1
                End If
            Next
            Return ketQua
        End Function
    End Class

End Namespace
