Imports DAO
Imports DTO
Imports DTO.DTO

Namespace BUS
    Public Class LoaiKhachHangBUS

#Region "Retrieving"

        Public Shared Function selectLoaiKhachHangAll() As List(Of LoaiKhachHangDTO)
            Return LoaiKhachHangDAO.selectLoaiPhongAll()
        End Function

#End Region

    End Class
End Namespace