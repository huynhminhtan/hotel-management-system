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

#End Region

    End Class

End Namespace
