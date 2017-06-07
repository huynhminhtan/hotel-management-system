Imports GUI.XuLy

Public Class frmBaoCaoThang

    Private Sub btnBaoCaoDoanhThu_Click(sender As Object, e As EventArgs) Handles btnBaoCaoDoanhThu.Click

    End Sub

    Public Sub CapNhat()
        Using New CenteredMessageBox(Me)
            MessageBox.Show("Đã Update!")
        End Using
    End Sub
End Class