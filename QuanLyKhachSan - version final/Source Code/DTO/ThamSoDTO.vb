Namespace DTO
    Public Class ThamSoDTO
#Region "Attribute"
        Private _soKhachToiDa As Integer
        Private _tiLePhuThu As Double
#End Region

#Region "Property"
        Public Property TiLePhuThu As Double
            Get
                Return _tiLePhuThu
            End Get
            Set(value As Double)
                _tiLePhuThu = value
            End Set
        End Property

        Public Property SoKhachToiDa As Integer
            Get
                Return _soKhachToiDa
            End Get
            Set(value As Integer)
                _soKhachToiDa = value
            End Set
        End Property

#End Region

#Region "Default Constructor"
        Sub New()
            _soKhachToiDa = 0
            _tiLePhuThu = 0
        End Sub
#End Region

    End Class
End Namespace
