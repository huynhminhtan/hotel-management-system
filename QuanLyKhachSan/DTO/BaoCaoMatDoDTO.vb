Namespace DTO

    Public Class BaoCaoMatDoDTO
#Region "Attributes"
        Private _thangBaoCaoMatDo As Date
        Private _maBaoCaoMatDo As String
#End Region

#Region "Properties"
        Public Property ThangBaoCaoMatDo() As Date
            Get
                Return _thangBaoCaoMatDo
            End Get
            Set(value As Date)
                _thangBaoCaoMatDo = value
            End Set
        End Property

        Public Property MaBaoCaoMatDo() As String
            Get
                Return _maBaoCaoMatDo
            End Get
            Set(value As String)
                _maBaoCaoMatDo = value
            End Set
        End Property

        Public ReadOnly Property TenBaoCao() As String
            Get
                Return "Báo cáo mật độ sử dụng phòng tháng " + _thangBaoCaoMatDo.Month.ToString + "/" + _thangBaoCaoMatDo.Year.ToString
            End Get
        End Property
#End Region

#Region "Default constructor"
        Sub New()
            _thangBaoCaoMatDo = Date.Now
            _maBaoCaoMatDo = Nothing
        End Sub
#End Region

    End Class

End Namespace

