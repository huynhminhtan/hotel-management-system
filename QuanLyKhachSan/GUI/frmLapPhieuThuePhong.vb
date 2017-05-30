Imports BUS.BUS


Public Class frmLapPhieuThuePhong

    Private Sub frmLapPhieuThuePhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' hiển thị danh sách mã phòng
        cboMaPhong.DataSource = PhongBUS.selectPhongAll()
        cboMaPhong.DisplayMember = "MaPhong"

        ' hiển thị tên phòng
        txtTenPhong.Text = cboMaPhong.SelectedItem.TenPhong

        ' hiển thị đơn giá
        txtDonGiaThue.Text = LoaiPhongBUS.selectDonGiaByMaLoaiPhong(cboMaPhong.SelectedItem.MaLoaiPhong)
    End Sub

    Private Sub cboMaPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaPhong.SelectedIndexChanged
        ' hiển thị tên phòng
        txtTenPhong.Text = cboMaPhong.SelectedItem.TenPhong

        ' hiển thị đơn giá
        txtDonGiaThue.Text = LoaiPhongBUS.selectDonGiaByMaLoaiPhong(cboMaPhong.SelectedItem.MaLoaiPhong)

        ' hiển thị mã phiếu thuê
        txtMaPhieuThue.Text = ""
    End Sub
End Class