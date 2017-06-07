Imports DTO.DTO
Imports DAO.DAO

Namespace BUS

    Public Class BaoCaoDoanhThuBUS

#Region "Retrieving"
        Public Shared Function themBaoCao(baoCaoDoanhThu As BaoCaoDoanhThuDTO) As Boolean
            Return BaoCaoDoanhThuDAO.themBaoCaoDoanhThu(baoCaoDoanhThu)
        End Function

        Public Shared Function selecBaoCaoDoanhThuMoiNhat() As BaoCaoDoanhThuDTO
            Return BaoCaoDoanhThuDAO.selecBaoCaoDoanhThuMoiNhat()
        End Function

        Public Shared Function selectMaBaoCaoDoanhThuMoiNhat() As String
            If (BaoCaoDoanhThuDAO.selecBaoCaoDoanhThuMoiNhat() Is Nothing) Then
                Return Nothing
            End If

            Return BaoCaoDoanhThuDAO.selecBaoCaoDoanhThuMoiNhat().MaBaoCaoDoanhThu
        End Function

        Public Shared Function kiemTraBaoCaoDTByThangBaoCaoVaTongDoanhThu(baoCaoDoanhThu As BaoCaoDoanhThuDTO) As Boolean
            Return BaoCaoDoanhThuDAO.kiemTraBaoCaoDTByThangBaoCaoVaTongDoanhThu(baoCaoDoanhThu)
        End Function

#End Region

        

    End Class

End Namespace