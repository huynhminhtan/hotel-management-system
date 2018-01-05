
Namespace DTO

    Public Class KhuyenMaiDTO
#Region "Attributes"
        Private _maKhuyenMai As String
        Private _tenKhuyenMai As String
        Private _heSoKhuyenMai As Double
        Private _ghiChu As String
#End Region

#Region "Properties"

        Property MaKhuyenMai() As String
            Get
                Return _maKhuyenMai
            End Get
            Set(ByVal value As String)
                _maKhuyenMai = value
            End Set
        End Property

        Property TenKhuyenMai() As String
            Get
                Return _tenKhuyenMai
            End Get
            Set(ByVal value As String)
                _tenKhuyenMai = value
            End Set
        End Property

        Property GhiChu() As String
            Get
                Return _ghiChu
            End Get
            Set(ByVal value As String)
                _ghiChu = value
            End Set
        End Property

        Property HeSoKhuyenMai() As Double
            Get
                Return _heSoKhuyenMai
            End Get
            Set(value As Double)
                _heSoKhuyenMai = value
            End Set
        End Property
#End Region

#Region "Default Constructor"
        Sub New()
            _maKhuyenMai = Nothing
            _tenKhuyenMai = Nothing
            _ghiChu = Nothing
            _heSoKhuyenMai = 0
        End Sub

        Sub New(maKhuyenMai As String, tenKhuyenMai As String, heSo As Double, ghiChu As String)
            _maKhuyenMai = maKhuyenMai
            _tenKhuyenMai = tenKhuyenMai
            _ghiChu = ghiChu
            _heSoKhuyenMai = heSo
        End Sub
#End Region
    End Class

End Namespace