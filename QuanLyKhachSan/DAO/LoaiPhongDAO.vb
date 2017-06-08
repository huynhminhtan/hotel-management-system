Imports System.Data.SqlClient
Imports DTO.DTO

Namespace DAO

    Public Class LoaiPhongDAO

#Region "Inserting"

        Public Shared Function themLoaiPhong(lp As LoaiPhongDTO) As Boolean
            Try
                Dim slqParams As New List(Of SqlParameter)

                slqParams.Add(New SqlParameter("@TenLoaiPhong", lp.TenLoaiPhong))
                slqParams.Add(New SqlParameter("@DonGiaThue", lp.DonGiaThue))

                Dim n As Integer = SqlDataAccessHelper.ExecuteNoneQuery("NewLoaiPhong", slqParams)

                If (n <= 0) Then
                    Return False
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return True
        End Function

#End Region

#Region "Retrieving"
        Public Shared Function selectLoaiPhongAll() As List(Of LoaiPhongDTO)
            Dim dt As New DataTable
            Dim list As New List(Of LoaiPhongDTO)
            Try
                dt = SqlDataAccessHelper.ExecuteQuery("selectLoaiPhongAll", Nothing)

                For Each row As DataRow In dt.Rows
                    Dim loaiPhong As New LoaiPhongDTO

                    loaiPhong.MaLoaiPhong = row("MaLoaiPhong").ToString
                    loaiPhong.TenLoaiPhong = row("TenLoaiPhong").ToString
                    loaiPhong.DonGiaThue = Double.Parse(row("DonGiaThue").ToString)

                    list.Add(loaiPhong)
                Next

            Catch ex As Exception
                Throw ex
            End Try
            Return list

        End Function

        Public Shared Function kiemTraLoaiPhongByMaLoaiPhong(MaLoaiPhong As String) As Boolean
            Dim result As Boolean = False
            Try
                Dim SqlParams As New List(Of SqlParameter)

                SqlParams.Add(New SqlParameter("@MaLoaiPhong", MaLoaiPhong))

                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectLoaiPhongByMaLoaiPhong", SqlParams)

                If (dt.Rows.Count = 1) Then
                    result = True
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Shared Function selectLoaiPhongByMaLoaiPhong(MaLoaiPhong As String) As LoaiPhongDTO
            Dim lp As New LoaiPhongDTO

            Try
                Dim SqlParams As New List(Of SqlParameter)
                SqlParams.Add(New SqlParameter("@MaLoaiPhong", MaLoaiPhong))

                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectLoaiPhongByMaLoaiPhong", SqlParams)

                Dim row As DataRow = dt.Rows(0)

                lp.TenLoaiPhong = row("TenLoaiPhong").ToString
                lp.MaLoaiPhong = row("MaLoaiPhong").ToString
                lp.DonGiaThue = Double.Parse(row("DonGiaThue").ToString)

            Catch ex As Exception
                Throw ex
            End Try

            Return lp
        End Function

#End Region

    End Class

End Namespace
