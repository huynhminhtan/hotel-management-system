Imports DAO.DAO
Imports DTO.DTO
Imports System.Data.SqlClient

Namespace BUS

    Public Class LoaiPhongBUS

#Region "ReTrieving"

        Public Shared Function selectLoaiPhongAll() As List(Of LoaiPhongDTO)
            Return LoaiPhongDAO.selectLoaiPhongAll()
        End Function

        Public Shared Function kiemTraLoaiPhongByMaLoaiPhong(MaLoaiPhong As String) As Boolean
            Dim result As Boolean = False

            If (DAO.DAO.LoaiPhongDAO.kiemTraLoaiPhongByMaLoaiPhong(MaLoaiPhong) = True) Then
                result = True
            End If

            Return result
        End Function

        Public Shared Function selectDonGiaByMaLoaiPhong(MaLoaiPhong As String) As String
            Dim result As String = ""
            If (DAO.DAO.LoaiPhongDAO.kiemTraLoaiPhongByMaLoaiPhong(MaLoaiPhong) = True) Then
                Dim lp As New LoaiPhongDTO
                lp = DAO.DAO.LoaiPhongDAO.selectLoaiPhongByMaLoaiPhong(MaLoaiPhong)
                result = lp.DonGiaThue.ToString
            End If
            Return result
        End Function

#End Region

    End Class

End Namespace
