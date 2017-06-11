Imports DAO.DAO
Imports DTO.DTO
Imports System.Data.SqlClient

Namespace BUS

    Public Class LoaiPhongBUS

#Region "ReTrieving"

        Public Shared Function selectLoaiPhongAll() As List(Of LoaiPhongDTO)
            Return LoaiPhongDAO.selectLoaiPhongAll()
        End Function

        Public Shared Function selectDonGiaByMaLoaiPhong(MaLoaiPhong As String) As String
            Dim donGia As String = Nothing
            If (DAO.DAO.LoaiPhongDAO.kiemTraLoaiPhongByMaLoaiPhong(MaLoaiPhong) = True) Then
                Dim lp As New LoaiPhongDTO
                lp = DAO.DAO.LoaiPhongDAO.selectLoaiPhongByMaLoaiPhong(MaLoaiPhong)
                donGia = lp.DonGiaThue.ToString
            End If
            Return donGia
        End Function

        Public Shared Function selectTenLoaiPhongByMaLoaiPhong(MaLoaiPhong As String) As String
            Dim tenLoaiPhong As String = Nothing
            If (DAO.DAO.LoaiPhongDAO.kiemTraLoaiPhongByMaLoaiPhong(MaLoaiPhong) = True) Then
                Dim lp As New LoaiPhongDTO
                lp = DAO.DAO.LoaiPhongDAO.selectLoaiPhongByMaLoaiPhong(MaLoaiPhong)
                tenLoaiPhong = lp.TenLoaiPhong
            End If
            Return tenLoaiPhong
        End Function

#End Region

#Region "Inserting"

        Public Shared Function themLoaiPhong(loaiPhong As LoaiPhongDTO) As Boolean
            Return LoaiPhongDAO.themLoaiPhong(loaiPhong)
        End Function

#End Region

    End Class

End Namespace
