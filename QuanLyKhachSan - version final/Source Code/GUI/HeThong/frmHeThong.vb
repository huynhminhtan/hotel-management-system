Public Class frmHeThong

    Private Sub btnThemLoaiPhong_Click(sender As Object, e As EventArgs) Handles btnThemLoaiPhong.Click
        Dim formThemLoaiPhong As New frmThemLoaiPhong(Me)
        formThemLoaiPhong.ShowDialog(Me)
    End Sub

    Private Sub btnThemLoaiKhach_Click(sender As Object, e As EventArgs) Handles btnThemLoaiKhach.Click
        Dim formThemLoaiKhach As New frmThemLoaiKhachHang(Me)
        formThemLoaiKhach.ShowDialog(Me)
    End Sub

    Public Sub CapNhat()

    End Sub
End Class