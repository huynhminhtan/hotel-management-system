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

        Shared Function selectHeSoKhachByMaLoaiKhach(MaLoaiKhach As String) As Double
            Dim heSoKhach As Double

            Try
                Dim SqlParams As New List(Of SqlParameter)
                SqlParams.Add(New SqlParameter("@MaLoaiKhach", MaLoaiKhach))

                Dim dt As New DataTable
                dt = SqlDataAccessHelper.ExecuteQuery("selectHeSoKhachByMaLoaiKhach", SqlParams)

                Dim row As DataRow = dt.Rows(0)

                heSoKhach = Double.Parse(row("HeSoKhach").ToString)

            Catch ex As Exception
                Throw ex
            End Try

            Return heSoKhach

        End Function

#End Region

    End Class

End Namespace
