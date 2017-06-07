Imports DTO.DTO
Imports System.Data.SqlClient

Namespace DAO

    Public Class BaoCaoMatDoDAO
#Region "Inserting"
        Public Shared Function themBaoCaoMatDo(baoCaoMatDo As BaoCaoMatDoDTO) As Boolean
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@ThangBaoCaoMatDo", baoCaoMatDo.ThangBaoCaoMatDo))

                Dim n As Integer
                n = SqlDataAccessHelper.ExecuteNoneQuery("NewBaoCaoMatDo", sqlParams)

                If (n = 0) Then
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return True
        End Function
#End Region

#Region "Retrieving"
        Public Shared Function selectBaoCaoMatDoMoiNhat() As BaoCaoMatDoDTO
            Dim BaoCaoMatDo As New BaoCaoMatDoDTO
            Try
                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectBaoCaoMatDoMoiNhat", Nothing)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

                Dim hang As DataRow = dt.Rows(0)
                BaoCaoMatDo.ThangBaoCaoMatDo = hang("ThangBaoCaoMatDo").ToString
                BaoCaoMatDo.MaBaoCaoMatDo = hang("MaBaoCaoMatDo").ToString

            Catch ex As Exception
                Throw ex
            End Try
            Return BaoCaoMatDo
        End Function

        Public Shared Function kiemTraBaoCaoMatDoByThang(thangBaoCaoMatDo As Date) As Boolean
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@ThangBaoCaoMatDo", thangBaoCaoMatDo))

                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectBaoCaoMatDoByThang", sqlParams)

                If (dt.Rows.Count > 0) Then
                    Return True
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return False
        End Function
#End Region

    End Class

End Namespace
