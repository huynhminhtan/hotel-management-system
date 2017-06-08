Imports BUS.BUS
Imports GUI.XuLy

Public Class frmBaoCaoThang

    Private Sub btnBaoCaoDoanhThu_Click(sender As Object, e As EventArgs) Handles btnBaoCaoDoanhThu.Click
        Dim formBaoCaoDoanhThu As New frmLapBaoCaoDoanhThu(Me)
        formBaoCaoDoanhThu.ShowDialog(Me)

    End Sub

    Public Sub CapNhat()

        ' đưa danh sách báo cáo doanh thu vào combobox
        cboBaoCaoDoanhThu.DataSource = BaoCaoDoanhThuBUS.selectBaoCaoDoanhThuAll()
        cboBaoCaoDoanhThu.ValueMember = "MaBaoCaoDoanhThu"
        cboBaoCaoDoanhThu.DisplayMember = "TenBaoCao"

        ' đưa danh sách báo cáo mật độ vào combobox
        cboBaoCaoMatDo.DataSource = BaoCaoMatDoBUS.selectBaoCaoMatDoAll()
        cboBaoCaoMatDo.ValueMember = "MaBaoCaoMatDo"
        cboBaoCaoMatDo.DisplayMember = "TenBaoCao"

        ' vẽ biểu đồ báo cáo doanh thu

    End Sub

    Private Sub frmBaoCaoThang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CapNhat()
    End Sub

    Private Sub btnBaoCaoMatDo_Click(sender As Object, e As EventArgs) Handles btnBaoCaoMatDo.Click
        Dim formBaoCaoDoanhThu As New frmLapBaoCaoDoanhThu(Me)
        formBaoCaoDoanhThu.ShowDialog(Me)
    End Sub
End Class