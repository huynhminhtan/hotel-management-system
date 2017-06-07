Imports GUI.XuLy

Public Class frmQuanLyPhong

    Private Sub frmQuanLyPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnThemPhong_Click(sender As Object, e As EventArgs) Handles btnThemPhong.Click
        Dim formLapDanhMucPhong As New frmLapDanhMucPhong(Me)
        formLapDanhMucPhong.Show()
    End Sub

    Public Sub CapNhat()
        Using New CenteredMessageBox(Me)
            MessageBox.Show("Đã update!")
        End Using
    End Sub

    Private Sub btnTimPhong_Click(sender As Object, e As EventArgs) Handles btnTimPhong.Click
        Dim formTraCuuPhong As New frmTraCuuPhong(Me)
        formTraCuuPhong.Show()
    End Sub
End Class