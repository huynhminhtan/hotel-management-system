Imports DTO.DTO
Imports System.Data.SqlClient

Namespace DAO

    Public Class BaoCaoDoanhThuDAO
#Region "Retrieving"
        Public Shared Function themBaoCaoDoanhThu(baoCaoDoanhThu As BaoCaoDoanhThuDTO) As Boolean
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@ThangBaoCaoDoanhThu", baoCaoDoanhThu.ThangbaoCaoDoanhThu))
                sqlParams.Add(New SqlParameter("@TongDoanhThu", baoCaoDoanhThu.TongDoanhThu.ToString))

                Dim n As Integer
                n = SqlDataAccessHelper.ExecuteNoneQuery("NewBaoCaoDoanhThu", sqlParams)

                If (n = 1) Then
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return False
        End Function

        Public Shared Function selecBaoCaoDoanhThuMoiNhat() As BaoCaoDoanhThuDTO
            Dim baoCaoDoanhThu As New BaoCaoDoanhThuDTO

            Try
                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selecBaoCaoDoanhThuMoiNhat", Nothing)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

                Dim hang As DataRow = dt.Rows(0)

                baoCaoDoanhThu.MaBaoCaoDoanhThu = hang("MaBaoCaoDoanhThu").ToString
                baoCaoDoanhThu.ThangbaoCaoDoanhThu = hang("ThangBaoCaoDoanhThu").ToString
                baoCaoDoanhThu.TongDoanhThu = Double.Parse(hang("TongDoanhThu").ToString)

            Catch ex As Exception
                Throw ex
            End Try
            Return baoCaoDoanhThu
        End Function

        Shared Function kiemTraBaoCaoDTByThangBaoCaoVaTongDoanhThu(baoCaoDoanhThu As BaoCaoDoanhThuDTO) As Boolean
            Try
                Dim sqlParams As New List(Of SqlParameter)
                sqlParams.Add(New SqlParameter("@ThangBaoCaoDoanhThu", baoCaoDoanhThu.ThangbaoCaoDoanhThu))
                sqlParams.Add(New SqlParameter("@TongDoanhThu", baoCaoDoanhThu.TongDoanhThu))

                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("kiemTraBaoCaoDTByThangBaoCaoVaTongDoanhThu", sqlParams)

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
