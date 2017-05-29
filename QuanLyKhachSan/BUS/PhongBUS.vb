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

        Public Shared Function selectDonGiaByMaLoaiPhong(MaLoaiPhong As String) As String
            Dim donGia As String = ""
            If (LoaiPhongDAO.kiemTraLoaiPhongByMaLoaiPhong(MaLoaiPhong) = True) Then
                Dim lp As New LoaiPhongDTO
                lp = LoaiPhongDAO.selectLoaiPhongByMaLoaiPhong(MaLoaiPhong)
                donGia = lp.DonGiaThue.ToString
            End If
            Return donGia
        End Function

#End Region

    End Class

End Namespace
