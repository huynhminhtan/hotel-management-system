Namespace DTO
    Public Class LoaiKhachHangDTO

#Region "Attribute"
        Private _maLoaiKhachHang As String
        Private _tenLoaiKhachHang As String
        Private _heSo As Double
#End Region

#Region "Property"
        Public Property TenLoaiKhachHang As String
            Get
                Return _tenLoaiKhachHang
            End Get
            Set(value As String)
                _tenLoaiKhachHang = value
            End Set
        End Property

        Public Property MaLoaiKhachHang As String
            Get
                Return _maLoaiKhachHang
            End Get
            Set(value As String)
                _maLoaiKhachHang = value
            End Set
        End Property

        Public Property HeSo As Double
            Get
                Return _heSo
            End Get
            Set(value As Double)
                _heSo = value
            End Set
        End Property
#End Region

#Region "Default Constructor"
        Sub New()
            _maLoaiKhachHang = Nothing
            _tenLoaiKhachHang = Nothing
            _heSo = 1
        End Sub
#End Region

    End Class
End Namespace
