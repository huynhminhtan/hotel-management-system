Namespace DTO
    Public Class PhongDTO

#Region "Attributes"
        Private _maPhong As String
        Private _tenPhong As String
        Private _maLoaiPhong As String
        Private _ghiChu As String
#End Region

#Region "Properties"
        Property MaPhong() As String
            Get
                Return _maPhong
            End Get
            Set(ByVal value As String)
                _maPhong = value
            End Set
        End Property


        Property TenPhong() As String
            Get
                Return _tenPhong
            End Get
            Set(ByVal value As String)
                _tenPhong = value
            End Set
        End Property

        Property MaLoaiPhong() As String
            Get
                Return _maLoaiPhong
            End Get
            Set(value As String)
                _maLoaiPhong = value
            End Set
        End Property

        Property GhiChu() As String
            Get
                Return _ghiChu
            End Get
            Set(value As String)
                _ghiChu = value
            End Set
        End Property

#End Region

#Region "Default Constructor"
        Sub New()
            _maPhong = Nothing
            _tenPhong = Nothing
            _maLoaiPhong = Nothing
            _ghiChu = Nothing
        End Sub
#End Region
    End Class
End Namespace
