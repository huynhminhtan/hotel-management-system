Namespace DTO

    Public Class BaoCaoDoanhThuDTO

#Region "Attribute"
        Private _maBaoCaoDoanhThu As String
        Private _thangBaoCaoDoanhThu As Date
        Private _tongDoanhThu As Double
#End Region

#Region "Properties"
        Public Property MaBaoCaoDoanhThu As String
            Get
                Return _maBaoCaoDoanhThu
            End Get
            Set(value As String)
                _maBaoCaoDoanhThu = value
            End Set
        End Property

        Public Property ThangbaoCaoDoanhThu() As Date
            Get
                Return _thangBaoCaoDoanhThu
            End Get
            Set(value As Date)
                _thangBaoCaoDoanhThu = value
            End Set
        End Property

        Public Property TongDoanhThu() As Double
            Get
                Return _tongDoanhThu
            End Get
            Set(value As Double)
                _tongDoanhThu = value
            End Set
        End Property

        Public ReadOnly Property TenBaoCao() As String
            Get
                Return "Báo cáo doanh thu theo loại phòng tháng " + _thangBaoCaoDoanhThu.Month.ToString + "/" + _thangBaoCaoDoanhThu.Year.ToString
            End Get
        End Property

#End Region

#Region "Default Constructor"
        Sub New()
            _thangBaoCaoDoanhThu = Date.Now
            _tongDoanhThu = 0
            _maBaoCaoDoanhThu = Nothing
        End Sub
#End Region

    End Class

End Namespace

