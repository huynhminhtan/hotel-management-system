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

    End Class
End Namespace