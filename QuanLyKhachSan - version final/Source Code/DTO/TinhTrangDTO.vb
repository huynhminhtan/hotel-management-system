Namespace DTO

Public Class TinhTrangDTO

#Region "Attributes"
        Private _maTinhTrang As String  
        Private _loaiTinhTrang As String
        Private _maPhong As String
        Private _ngayCuaTinhTrang As Date
#End Region

#Region "Properties"
        Property MaTinhTrang() As String
            Get
                Return _maTinhTrang
            End Get
            Set(ByVal value As String)
                _maTinhTrang = value
            End Set
        End Property

        Property LoaiTinhTrang() As String
            Get
                Return _loaiTinhTrang
            End Get
            Set(value As String)
                _loaiTinhTrang = value
            End Set
        End Property

        Property MaPhong() As String
            Get
                Return _maPhong
            End Get
            Set(value As String)
                _maPhong = value
            End Set
        End Property

        Property NgayCuaTinhTrang() As Date
            Get
                Return _ngayCuaTinhTrang
            End Get
            Set(value As Date)
                _ngayCuaTinhTrang = value
            End Set
        End Property
#End Region

#Region "Default Constructor"
        Sub New()
            _loaiTinhTrang = Nothing
            _maPhong = Nothing
            _maTinhTrang = Nothing
            _ngayCuaTinhTrang = Nothing
        End Sub
#End Region

    End Class

End Namespace
