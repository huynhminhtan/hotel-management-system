Imports DTO.DTO
Imports System.Data.SqlClient

Namespace DAO

    Public Class ThamSoDAO

#Region "ReTrieving"

        Public Shared Function selectThamSoALL() As ThamSoDTO

            Dim thamSo As New ThamSoDTO

            Try
                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectThamSoAll", Nothing)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing ' không có dữ liệu nào trong CSDL
                End If

                Dim row As DataRow = dt.Rows(0)

                thamSo.SoKhachToiDa = Integer.Parse(row("SoKhachToiDa").ToString)
                thamSo.TiLePhuThu = Double.Parse(row("TiLePhuThu").ToString)

            Catch ex As Exception
                Throw ex
            End Try
            Return thamSo
        End Function

#End Region

#Region "Inserting"

        Public Shared Function themThamSo(thamSo As ThamSoDTO) As Boolean
            Try
                Dim sqlPrams As New List(Of SqlParameter)
                sqlPrams.Add(New SqlParameter("@SoKhachToiDa", thamSo.SoKhachToiDa))
                sqlPrams.Add(New SqlParameter("@TiLePhuThu", thamSo.TiLePhuThu))

                Dim n As Integer
                n = SqlDataAccessHelper.ExecuteNoneQuery("themThamSo", sqlPrams)

                If (n <= 0) Then
                    Return False
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return True
        End Function

#End Region

#Region "Updating"

        Public Shared Function capNhatThamSo(thamSo As ThamSoDTO) As Boolean
            Try
                Dim sqlPrams As New List(Of SqlParameter)
                sqlPrams.Add(New SqlParameter("@SoKhachToiDa", thamSo.SoKhachToiDa))
                sqlPrams.Add(New SqlParameter("@TiLePhuThu", thamSo.TiLePhuThu))

                Dim n As Integer
                n = SqlDataAccessHelper.ExecuteNoneQuery("capNhatThamSo", sqlPrams)

                If (n <= 0) Then
                    Return False
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return True
        End Function

#End Region

    End Class

End Namespace
