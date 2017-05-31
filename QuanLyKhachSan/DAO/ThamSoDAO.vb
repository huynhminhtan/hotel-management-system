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

    End Class

End Namespace
