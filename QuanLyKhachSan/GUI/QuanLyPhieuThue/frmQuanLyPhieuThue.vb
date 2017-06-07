Imports GUI.XuLy

Public Class frmQuanLyPhieuThue

    Private Sub frmQuanLyPhieuThue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboTinhTrangPhieuThue.SelectedIndex = 2

    End Sub


    Private Sub btnLapPhieuThuePhong_Click(sender As Object, e As EventArgs) Handles btnLapPhieuThuePhong.Click
        Dim formLapPhieuThuePhong As New frmLapPhieuThuePhong(Me)
        formLapPhieuThuePhong.Show()
    End Sub

    Public Sub CapNhat()
        Using New CenteredMessageBox(Me)
            MessageBox.Show("Đã update!")
        End Using
    End Sub

    Private Sub btnLapHoaDon_Click(sender As Object, e As EventArgs) Handles btnLapHoaDon.Click
        Dim formLapHoaDon As New frmLapHoaDon(Me)
        formLapHoaDon.Show()
    End Sub
End Class