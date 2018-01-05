Imports DAO.DAO
Imports DTO.DTO


Namespace BUS
    Public Class KhuyenMaiBUS

#Region "Retrieving"

        Public Shared Function selectKhuyenMaiAll() As List(Of KhuyenMaiDTO)
            Return KhuyenMaiDAO.selectKhuyenMaiAll()
        End Function

        'Public Shared Function selectHeSoKhachByMaLoaiKhach(MaLoaiKhach As String) As Double
        '    Return LoaiKhachHangDAO.selectLoaiKhachHangByMaLoaiKhach(MaLoaiKhach).HeSoKhach
        'End Function

        'Public Shared Function selectTenLoaiKhachHangByMaLoaiKhach(MaLoaiKhach As String) As String
        '    Return LoaiKhachHangDAO.selectLoaiKhachHangByMaLoaiKhach(MaLoaiKhach).TenLoaiKhachHang
        'End Function

#End Region

#Region "Inserting"

        Public Shared Function themKhuyenMaiAll(khuyenMai As KhuyenMaiDTO) As Boolean
            Return KhuyenMaiDAO.themKhuyenMai(khuyenMai)
        End Function

#End Region

    End Class
End Namespace