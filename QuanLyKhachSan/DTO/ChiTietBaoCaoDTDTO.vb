Namespace DTO

    Public Class ChiTietBaoCaoDTDTO

#Region "Attributes"
        Private _maChiTietBaoCaoDT As String
        Private _maBaoCaoDoanhThu As String
        Private _maLoaiPhong As String
        Private _doanhThuLoaiPhong As Double
        Private _tiLeDoanhThu As String

#End Region

#Region "Properties"
        Public Property MaChiTietBaoCaoDT() As String
            Get
                Return _maChiTietBaoCaoDT
            End Get
            Set(value As String)
                _maChiTietBaoCaoDT = value
            End Set
        End Property

        Public Property MaBaoCaoDoanhThu() As String
            Get
                Return _maBaoCaoDoanhThu
            End Get
            Set(value As String)
                _maBaoCaoDoanhThu = value
            End Set
        End Property

        Public Property MaLoaiPhong() As String
            Get
                Return _maLoaiPhong
            End Get
            Set(value As String)
                _maLoaiPhong = value
            End Set
        End Property

        Public Property DoanhThuLoaiPhong() As Double
            Get
                Return _doanhThuLoaiPhong
            End Get
            Set(value As Double)
                _doanhThuLoaiPhong = value
            End Set
        End Property

        Public Property TiLeDoanhThu() As String
            Get
                Return _tiLeDoanhThu
            End Get
            Set(value As String)
                _tiLeDoanhThu = value
            End Set
        End Property
#End Region

#Region "Default Constructor"
        Sub New()
            _maChiTietBaoCaoDT = Nothing
            _maBaoCaoDoanhThu = Nothing
            _maLoaiPhong = Nothing
            _doanhThuLoaiPhong = 0
            _tiLeDoanhThu = Nothing
        End Sub
#End Region

    End Class

End Namespace

