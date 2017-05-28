Imports System.Data.SqlClient
Imports System.Xml

Namespace DAO

    Public Class SqlDataAccessHelper

#Region "ConnectionString"

        Public Shared ReadOnly Property ConnectionString() As String
            Get
                Return ReadConnectionString("ConnectionString.xml")
            End Get
        End Property

        Private Shared Function ReadConnectionString(file As String) As String

            Dim doc As New XmlDocument()
            doc.Load(file)
            Dim root As XmlElement = doc.DocumentElement
            Dim connString As String = root.InnerText

            Return connString
        End Function

#End Region

#Region "ExecuteNoneQuery"
        Public Shared Function ExecuteNoneQuery(spName As String, sqlParams As List(Of SqlParameter))

            'MsgBox(ConnectionString)

            Dim n As Integer = 0
            Try
                Dim conn As New SqlConnection(ConnectionString)
                conn.Open()

                Try
                    Dim comm As New SqlCommand()
                    comm.Connection = conn
                    comm.CommandText = spName
                    comm.CommandType = CommandType.StoredProcedure

                    If (sqlParams IsNot Nothing) Then
                        For Each Param As SqlParameter In sqlParams
                            comm.Parameters.Add(Param)
                        Next
                    End If

                    n = comm.ExecuteNonQuery()

                Catch ex As Exception
                    Throw ex
                Finally
                    conn.Close()
                End Try

            Catch ex As Exception
                Throw ex
            End Try

            Return n

        End Function

#End Region

#Region "ExecuteQuery"

        Public Shared Function ExecuteQuery(spName As String, sqlParams As List(Of SqlParameter)) As DataTable

            Dim dt As New DataTable

            Try
                Dim conn As New SqlConnection(ConnectionString)
                conn.Open()

                Try
                    Dim comm As New SqlCommand()
                    comm.Connection = conn
                    comm.CommandText = spName
                    comm.CommandType = CommandType.StoredProcedure

                    If (sqlParams IsNot Nothing) Then
                        For Each Param As SqlParameter In sqlParams
                            comm.Parameters.Add(Param)
                        Next
                    End If

                    Dim adapter As New SqlDataAdapter()
                    adapter.SelectCommand = comm
                    adapter.Fill(dt)

                Catch ex As Exception
                    Throw ex
                Finally
                    conn.Close()
                End Try

            Catch ex As Exception
                Throw ex
            End Try

            Return dt

        End Function

#End Region

    End Class

End Namespace