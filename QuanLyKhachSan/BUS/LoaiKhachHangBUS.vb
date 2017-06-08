Imports DAO.DAO
Imports DTO.DTO


Namespace BUS
    Public Class LoaiKhachHangBUS

#Region "Retrieving"

        Public Shared Function selectLoaiKhachHangAll() As List(Of LoaiKhachHangDTO)
            Return LoaiKhachHangDAO.selectLoaiKhachHangAll()
        End Function

        Public Shared Function selectHeSoKhachByMaLoaiKhach(MaLoaiKhach As String) As Double
            Return LoaiKhachHangDAO.selectLoaiKhachHangByMaLoaiKhach(MaLoaiKhach).HeSoKhach
        End Function

#End Region

#Region "Inserting"

        Public Shared Function themLoaiKhachHang(loaiKhachHang As LoaiKhachHangDTO) As Boolean
            Return LoaiKhachHangDAO.themLoaiKhachHang(loaiKhachHang)
        End Function

#End Region

    End Class
End Namespace