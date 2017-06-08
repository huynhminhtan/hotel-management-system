Imports BUS.BUS

Public Class frmThemLoaiPhong

    Private Sub btntThoat_Click(sender As Object, e As EventArgs) Handles btntThoat.Click
        Me.Close()
    End Sub


    Private Sub frmThemLoaiPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDanhSachLoaiPhong.DataSource = LoaiPhongBUS.selectLoaiPhongAll()
    End Sub
End Class