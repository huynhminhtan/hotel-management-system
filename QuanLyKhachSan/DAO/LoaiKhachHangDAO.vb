Imports System.Data.SqlClient
Imports DTO.DTO

Namespace DAO

    Public Class LoaiKhachHangDAO

#Region "Retrieving"

        Public Shared Function selectLoaiKhachHangAll() As List(Of LoaiKhachHangDTO)

            Dim list As New List(Of LoaiKhachHangDTO)
            Dim dt As New DataTable

            Try
                dt = SqlDataAccessHelper.ExecuteQuery("selectLoaiKhachHangAll", Nothing)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

                For Each row As DataRow In dt.Rows
                    Dim loaiKhachHang As New LoaiKhachHangDTO

                    loaiKhachHang.MaLoaiKhachHang = row("MaLoaiKhachHang").ToString
                    loaiKhachHang.TenLoaiKhachHang = row("TenLoaiKhachHang").ToString
                    loaiKhachHang.HeSoKhach = Double.Parse(row("HeSoKhach").ToString)

                    list.Add(loaiKhachHang)
                Next

            Catch ex As Exception
                Throw ex
            End Try
            Return list
        End Function

        Shared Function selectLoaiKhachHangByMaLoaiKhach(MaLoaiKhach As String) As LoaiKhachHangDTO
            Dim loaiKhachHang As New LoaiKhachHangDTO

            Try
                Dim SqlParams As New List(Of SqlParameter)
                SqlParams.Add(New SqlParameter("@MaLoaiKhach", MaLoaiKhach))

                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectLoaiKhachHangByMaLoaiKhach", SqlParams)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

                Dim row As DataRow = dt.Rows(0)

                loaiKhachHang.HeSoKhach = Double.Parse(row("HeSoKhach").ToString)
                loaiKhachHang.MaLoaiKhachHang = row("MaLoaiKhachHang").ToString
                loaiKhachHang.TenLoaiKhachHang = row("TenLoaiKhachHang").ToString

            Catch ex As Exception
                Throw ex
            End Try

            Return loaiKhachHang
        End Function

#End Region

#Region "Inserting"

        Public Shared Function themLoaiKhachHang(loaiKhachHang As LoaiKhachHangDTO) As Boolean
            Try
                Dim sqlPrams As New List(Of SqlParameter)
                sqlPrams.Add(New SqlParameter("@TenLoaiKhachHang", loaiKhachHang.TenLoaiKhachHang))
                sqlPrams.Add(New SqlParameter("@HeSoKhach", loaiKhachHang.HeSoKhach))

                Dim n As Integer
                n = SqlDataAccessHelper.ExecuteNoneQuery("NewLoaiKhachHang", sqlPrams)

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
