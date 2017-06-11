Namespace DTO
    Public Class ChiTietPhieuThueDTO

#Region "Attribute"
        Private _maChiTietPhieuThue As String
        Private _maPhieuThue As String
        Private _tenKhachHang As String
        Private _maLoaiKhachHang As String
        Private _cMND As String
        Private _diaChi As String
        Private _heSoThucTe As Double
#End Region

#Region "Property"

        Public Property MaChiTietPhieuThue As String
            Get
                Return _maChiTietPhieuThue
            End Get
            Set(value As String)
                _maChiTietPhieuThue = value
            End Set
        End Property

        Public Property MaPhieuThue As String
            Get
                Return _maPhieuThue
            End Get
            Set(value As String)
                _maPhieuThue = value
            End Set
        End Property

        Public Property TenKhachHang As String
            Get
                Return _tenKhachHang
            End Get
            Set(value As String)
                _tenKhachHang = value
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

        Public Property CMND As String
            Get
                Return _cMND
            End Get
            Set(value As String)
                _cMND = value
            End Set
        End Property

        Public Property DiaChi As String
            Get
                Return _diaChi
            End Get
            Set(value As String)
                _diaChi = value
            End Set
        End Property

        Public Property HeSoThucTe As Double
            Get
                Return _heSoThucTe
            End Get
            Set(value As Double)
                _heSoThucTe = value
            End Set
        End Property

#End Region

#Region "Default Constructor"
        Sub New()
            _maChiTietPhieuThue = Nothing
            _maPhieuThue = Nothing
            _tenKhachHang = Nothing
            _maLoaiKhachHang = Nothing
            _cMND = Nothing
            _diaChi = Nothing
            _heSoThucTe = 1
        End Sub
#End Region

    End Class
End Namespace
