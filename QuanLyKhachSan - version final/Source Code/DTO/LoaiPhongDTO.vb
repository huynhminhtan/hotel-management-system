
Namespace DTO

    Public Class LoaiPhongDTO
#Region "Attributes"
        Private _maLoaiPhong As String
        Private _tenLoaiPhong As String
        Private _donGiaThue As Double
#End Region

#Region "Properties"

        Property MaLoaiPhong() As String
            Get
                Return _maLoaiPhong
            End Get
            Set(ByVal value As String)
                _maLoaiPhong = value
            End Set
        End Property

        Property TenLoaiPhong() As String
            Get
                Return _tenLoaiPhong
            End Get
            Set(ByVal value As String)
                _tenLoaiPhong = value
            End Set
        End Property

        Property DonGiaThue() As Double
            Get
                Return _donGiaThue
            End Get
            Set(value As Double)
                _donGiaThue = value
            End Set
        End Property
#End Region

#Region "Default Constructor"
        Sub New()
            _maLoaiPhong = Nothing
            _tenLoaiPhong = Nothing
            _donGiaThue = 0
        End Sub

        Sub New(maLoaiPhong As String, tenLoaiPhong As String, donGiaThue As Double)
            _maLoaiPhong = maLoaiPhong
            _tenLoaiPhong = tenLoaiPhong
            _donGiaThue = donGiaThue
        End Sub
#End Region
    End Class

End Namespace