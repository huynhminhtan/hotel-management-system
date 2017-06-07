Namespace DTO

Public Class ChiTietBaoCaoMDDTO
#Region "Attributes"
        Private _maChiTietBaoCaoMD As String
        Private _maBaoCaoMatDo As String
        Private _maPhong As String
        Private _soNgayThueTrongThang As Integer
        Private _tiLeSuDung As String
#End Region

#Region "Properties"
        Public Property MaChiTietBaoCaoMD() As String
            Get
                Return _maChiTietBaoCaoMD
            End Get
            Set(value As String)
                _maChiTietBaoCaoMD = value
            End Set
        End Property

        Public Property MaBaoCaoMatDo As String
            Get
                Return _maBaoCaoMatDo
            End Get
            Set(value As String)
                _maBaoCaoMatDo = value
            End Set
        End Property

        Public Property MaPhong() As String
            Get
                Return _maPhong
            End Get
            Set(value As String)
                _maPhong = value
            End Set
        End Property

        Public Property SoNgayThueTrongThang() As Integer
            Get
                Return _soNgayThueTrongThang
            End Get
            Set(value As Integer)
                _soNgayThueTrongThang = value
            End Set
        End Property

        Public Property TiLeSuDung() As String
            Get
                Return _tiLeSuDung
            End Get
            Set(value As String)
                _tiLeSuDung = value
            End Set
        End Property
#End Region

#Region "Default Constructor"
        Sub New()
            _maChiTietBaoCaoMD = Nothing
            _maBaoCaoMatDo = Nothing
            _maPhong = Nothing
            _soNgayThueTrongThang = 0
            _tiLeSuDung = Nothing
        End Sub
#End Region
    End Class

End Namespace
