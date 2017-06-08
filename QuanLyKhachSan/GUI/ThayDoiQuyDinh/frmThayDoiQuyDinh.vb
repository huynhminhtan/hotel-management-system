Imports BUS.BUS
Imports DTO.DTO
Imports GUI.XuLy

Namespace ThayDoiQuyDinh

    Public Class frmThayDoiQuyDinh

        Private thamSo As ThamSoDTO

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

        Private Sub frmThayDoiQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            thamSo = ThamSoBUS.selectThamSoAll()
            txtBoxSoKhachToiDa.Text = thamSo.SoKhachToiDa
            txtBoxTiLePhuThu.Text = (thamSo.TiLePhuThu * 100 - 100).ToString
        End Sub

        Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
            Dim thamSoMoi As New ThamSoDTO()
            thamSoMoi.SoKhachToiDa = txtBoxSoKhachToiDa.Text
            thamSoMoi.TiLePhuThu = Double.Parse(txtBoxTiLePhuThu.Text) / 100 + 1

            If (Not ((thamSoMoi.SoKhachToiDa = thamSo.SoKhachToiDa) And Not (Math.Abs(thamSoMoi.TiLePhuThu - thamSo.TiLePhuThu) > 0))) Then
                Using New CenteredMessageBox(Me.Parent.FindForm())
                    If (MessageBox.Show(Me, "Bạn có muốn cập nhật quy định mới không?", "Cập Nhật", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                        If (ThamSoBUS.capNhatThamSo(thamSoMoi)) Then
                            MessageBox.Show("Cập nhật quy định thành công!")
                            thamSo.SoKhachToiDa = thamSoMoi.SoKhachToiDa
                            thamSo.TiLePhuThu = thamSoMoi.TiLePhuThu
                        Else
                            MessageBox.Show("Cập nhật quy định thất bại!")
                        End If
                    End If
                End Using
            End If
        End Sub
    End Class
End Namespace