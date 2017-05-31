Namespace DTO
    Public Class LoaiKhachHangDTO

#Region "Attribute"
        Private _maLoaiKhachHang As String
        Private _tenLoaiKhachHang As String
        Private _heSoKhach As Double
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

        Public Property HeSoKhach As Double
            Get
                Return _heSoKhach
            End Get
            Set(value As Double)
                _heSoKhach = value
            End Set
        End Property
#End Region

#Region "Default Constructor"
        Sub New()
            _maLoaiKhachHang = Nothing
            _tenLoaiKhachHang = Nothing
            _heSoKhach = 1
        End Sub
#End Region

    End Class
End Namespace
