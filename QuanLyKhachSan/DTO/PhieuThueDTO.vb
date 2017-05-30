Namespace DTO
    Public Class PhieuThueDTO

#Region "Attributes"
        Private _maPieuThue As String
        Private _maPhong As String
        Private _ngayBatDauThue As Date
        Private _ngayTraPhong As Date
        Private _donGiaThueThucTe As Double
        Private _thanhTienPhong As Double
        Private _maHoaDon As String
        Private _phuThuThucTe As Double
#End Region

#Region "Properties"

        Public Property PhuThuThucTe As Double
            Get
                Return _phuThuThucTe
            End Get
            Set(value As Double)
                _phuThuThucTe = value
            End Set
        End Property

        Public Property MaHoaDon As String
            Get
                Return _maHoaDon
            End Get
            Set(value As String)
                _maHoaDon = value
            End Set
        End Property

        Public Property ThanhTienPhong As Double
            Get
                Return _thanhTienPhong
            End Get
            Set(value As Double)
                _thanhTienPhong = value
            End Set
        End Property

        Public Property DonGiaThueThucTe As Double
            Get
                Return _donGiaThueThucTe
            End Get
            Set(value As Double)
                _donGiaThueThucTe = value
            End Set
        End Property

        Public Property NgayTraPhong As Date
            Get
                Return _ngayTraPhong
            End Get
            Set(value As Date)
                _ngayTraPhong = value
            End Set
        End Property

        Public Property NgayBatDauThue As Date
            Get
                Return _ngayBatDauThue
            End Get
            Set(value As Date)
                _ngayBatDauThue = value
            End Set
        End Property

        Public Property MaPhong As String
            Get
                Return _maPhong
            End Get
            Set(value As String)
                _maPhong = value
            End Set
        End Property

        Public Property MaPieuThue As String
            Get
                Return _maPieuThue
            End Get
            Set(value As String)
                _maPieuThue = value
            End Set
        End Property

#End Region

#Region "Default Constructor"
        Sub New()
            _maPieuThue = Nothing
            _maPhong = Nothing
            _ngayBatDauThue = Nothing
            _ngayTraPhong = Nothing
            _donGiaThueThucTe = Nothing
            _thanhTienPhong = Nothing
            _maHoaDon = Nothing
            _phuThuThucTe = Nothing
        End Sub
#End Region

    End Class
End Namespace
