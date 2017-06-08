Public Class frmThayDoiQuyDinh

    Private Sub txtBoxSoKhachToiDa_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSoKhachToiDa.TextChanged
        For Each kiTu As Char In txtBoxSoKhachToiDa.Text
            If (Not (Char.IsControl(kiTu) Or Char.IsDigit(kiTu))) Then
                txtBoxSoKhachToiDa.Text = Nothing
            End If
        Next
    End Sub

    Private Sub txtBoxTiLePhuThu_TextChanged(sender As Object, e As EventArgs) Handles txtBoxTiLePhuThu.TextChanged
        For Each kiTu As Char In txtBoxTiLePhuThu.Text
            If (Not (Char.IsControl(kiTu) Or Char.IsDigit(kiTu))) Then
                txtBoxTiLePhuThu.Text = Nothing
            End If
        Next
    End Sub
End Class