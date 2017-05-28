
Namespace DTO

Public Class LoaiPhongDTO
    Private strMaLoaiPhong As String
    Private strTenLoaiPhong As String
    Private DoubleDonGiaThue As Double

    Property MaLoaiPhong() As String
        Get
            Return strMaLoaiPhong
        End Get
        Set(ByVal value As String)
            strMaLoaiPhong = value
        End Set
    End Property

    Property TenLoaiPhong() As String
        Get
            Return strTenLoaiPhong
        End Get
        Set(ByVal value As String)
            strTenLoaiPhong = value
        End Set
    End Property

    Property DonGiaThue() As String
        Get
            Return DoubleDonGiaThue
        End Get
        Set(value As String)
            DoubleDonGiaThue = value
        End Set
    End Property

End Class

End Namespace