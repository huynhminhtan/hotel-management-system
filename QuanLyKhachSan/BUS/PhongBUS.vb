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

        Public Shared Function selectPhongAll() As List(Of PhongDTO)
            Return PhongDAO.selectPhongALL()
        End Function

#End Region

        Public Shared Function themDanhSachPhong(danhSachPhong As List(Of PhongDTO)) As Integer
            Dim ketQua As Integer = 0
            For i As Integer = 0 To (danhSachPhong.Count - 1)
                If (PhongDAO.insertPhong(danhSachPhong(i))) Then
                    ketQua += 1

                    ' thêm tình trạng cho phòng
                    Dim tinhTrang As New TinhTrangDTO
                    tinhTrang.LoaiTinhTrang = "TRONG"
                    tinhTrang.MaPhong = danhSachPhong(i).MaPhong

                    If (TinhTrangBUS.themTinhTrang(tinhTrang, Date.Now) = False) Then
                        Return 0
                    End If
                End If
            Next
            Return ketQua
        End Function
    End Class

End Namespace
