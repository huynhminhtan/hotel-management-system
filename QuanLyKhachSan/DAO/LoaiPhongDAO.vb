Imports System.Data.SqlClient
Imports DTO.DTO

Namespace DAO

    Public Class LoaiPhongDAO

#Region "Inserting"

        Public Shared Function insertLoaiPhong(lp As LoaiPhongDTO)
            Dim res As Boolean = False
            Try
                Dim slqParams As New List(Of SqlParameter)

                slqParams.Add(New SqlParameter("@LoaiPhongName", lp.TenLoaiPhong))
                slqParams.Add(New SqlParameter("@DonGiaThue", lp.DonGiaThue))

                Dim n As Integer = SqlDataAccessHelper.ExecuteNoneQuery("NewLoaiPhong", slqParams)

                If (n = 1) Then
                    res = True
                End If

            Catch ex As Exception
                Throw ex
            End Try

            Return res
        End Function

#End Region

#Region "Retrieving"
        Public Shared Function selectAllLoaiPhong() As DataTable
            Dim dt As New DataTable
            Try
                dt = SqlDataAccessHelper.ExecuteQuery("selectAllLoaiPhong", Nothing)
            Catch ex As Exception
                Throw ex
            End Try
            Return dt

        End Function
#End Region

    End Class

End Namespace
