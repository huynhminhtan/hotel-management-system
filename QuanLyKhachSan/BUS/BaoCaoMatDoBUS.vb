Imports DTO.DTO
Imports DAO.DAO

Namespace BUS

    Public Class BaoCaoMatDoBUS

#Region "Inserting"
        Public Shared Function themBaoCaoMatDo(baoCaoMatDo As BaoCaoMatDoDTO) As Boolean
            Return BaoCaoMatDoDAO.themBaoCaoMatDo(baoCaoMatDo)
        End Function

#End Region

#Region "Retrieving"
        Public Shared Function selectMaBaoCaoMatDoMoiNhat() As String
            If (BaoCaoMatDoDAO.selectBaoCaoMatDoMoiNhat() Is Nothing) Then
                Return Nothing
            End If

            Return BaoCaoMatDoDAO.selectBaoCaoMatDoMoiNhat().MaBaoCaoMatDo
        End Function

        Public Shared Function kiemTrabaoCaoMatDoByThang(thangBaoCaoMatDo As Date) As Boolean
            If (BaoCaoMatDoDAO.selectBaoCaoMatDoByThang(thangBaoCaoMatDo) Is Nothing) Then
                Return False
            End If

            Return True
        End Function
#End Region


    End Class

End Namespace
