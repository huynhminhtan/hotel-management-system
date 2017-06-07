Namespace DTO
    Public Class HoaDonDTO

#Region "Attributes"
        Private _maHoaDon As String
        Private _tenKhachHangHD As String
        Private _diaChiKhachHD As String
        Private _triGiaHoaDon As Double
#End Region

#Region "Properties"
        Public Property MaHoaDon As String
            Get
                Return _maHoaDon
            End Get
            Set(value As String)
                _maHoaDon = value
            End Set
        End Property

        Public Property TenKhachHangHD As String
            Get
                Return _tenKhachHangHD
            End Get
            Set(value As String)
                _tenKhachHangHD = value
            End Set
        End Property

        Public Property DiaChiKhachHD As String
            Get
                Return _diaChiKhachHD
            End Get
            Set(value As String)
                _diaChiKhachHD = value
            End Set
        End Property

        Public Property TriGiaHoaDon As Double
            Get
                Return _triGiaHoaDon
            End Get
            Set(value As Double)
                _triGiaHoaDon = value
            End Set
        End Property
#End Region

#Region "Default constructor"
        Sub New()
            _maHoaDon = Nothing
            _tenKhachHangHD = Nothing
            _diaChiKhachHD = Nothing
            _triGiaHoaDon = 0
        End Sub
#End Region

    End Class
End Namespace
