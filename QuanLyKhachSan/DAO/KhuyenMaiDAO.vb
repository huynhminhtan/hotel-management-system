Imports System.Data.SqlClient
Imports DTO.DTO

Namespace DAO

    Public Class KhuyenMaiDAO

#Region "Retrieving"

        Public Shared Function selectKhuyenMaiAll() As List(Of KhuyenMaiDTO)

            Dim list As New List(Of KhuyenMaiDTO)
            Dim dt As New DataTable

            Try
                dt = SqlDataAccessHelper.ExecuteQuery("selectKhuyenMaiAll", Nothing)

                If (dt.Rows.Count <= 0) Then
                    Return Nothing
                End If

                For Each row As DataRow In dt.Rows
                    Dim khuyenMai As New KhuyenMaiDTO

                    khuyenMai.MaKhuyenMai = row("MaKhuyenMai").ToString
                    khuyenMai.TenKhuyenMai = row("TenKhuyenMai").ToString
                    khuyenMai.GhiChu = row("GhiChu").ToString
                    khuyenMai.HeSoKhuyenMai = Double.Parse(row("HeSoKhuyenMai").ToString)

                    list.Add(khuyenMai)
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

        Public Shared Function themKhuyenMai(khuyenMai As KhuyenMaiDTO) As Boolean
            Try
                Dim sqlPrams As New List(Of SqlParameter)
                sqlPrams.Add(New SqlParameter("@TenKhuyenMai", khuyenMai.TenKhuyenMai))
                sqlPrams.Add(New SqlParameter("@GhiChu", khuyenMai.GhiChu))
                sqlPrams.Add(New SqlParameter("@HeSoKhuyenMai", khuyenMai.HeSoKhuyenMai))

                Dim n As Integer
                n = SqlDataAccessHelper.ExecuteNoneQuery("NewKhuyenMai", sqlPrams)

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
