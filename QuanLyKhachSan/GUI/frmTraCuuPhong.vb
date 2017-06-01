Imports BUS.BUS

Public Class frmTraCuuPhong


    Private Sub frmTraCuuPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' hiển thị danh sách loại phòng
        cboTenLoaiPhong.DataSource = LoaiPhongBUS.selectLoaiPhongAll()
        cboTenLoaiPhong.DisplayMember = "TenLoaiPhong"

        ' hiển thị đơn giá
        cboDonGiaThue.DataSource = LoaiPhongBUS.selectLoaiPhongAll()
        cboDonGiaThue.DisplayMember = "DonGiaThue"
        cboDonGiaThue.SelectedIndex = cboTenLoaiPhong.SelectedIndex

        ' hiển thị tình trạng
        cboTinhTrang.SelectedIndex = 0

        ' hiển thị giới hạn NgayBatDau
        dtpNgayBatDauThue.MinDate = Date.Now
        ' hiển thị giới hạn NgayTrPhong
        dtpNgayTraPhong.MinDate = dtpNgayBatDauThue.Value

        ' hiển thị danh sách phòng theo NgayBatDau và NgayKetThuc
        dgvDanhSachPhong.DataSource = PhongBUS.selectPhongAllByNgayBatDauVaNgayTraPhong(dtpNgayBatDauThue.Value,
                                                                                        dtpNgayTraPhong.Value)
    End Sub

    Private Sub cboTenLoaiPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTenLoaiPhong.SelectedIndexChanged
        If (cboDonGiaThue.Items.Count > 0) Then
            cboDonGiaThue.SelectedIndex = cboTenLoaiPhong.SelectedIndex
        End If
    End Sub

    Private Sub cboDonGiaThue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDonGiaThue.SelectedIndexChanged
        If (cboTenLoaiPhong.Items.Count > 0) Then
            cboTenLoaiPhong.SelectedIndex = cboDonGiaThue.SelectedIndex
        End If
    End Sub

    Private Sub dtpNgayBatDauThue_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayBatDauThue.ValueChanged
        ' hiển thị giới hạn NgayTrPhong
        dtpNgayTraPhong.MinDate = dtpNgayBatDauThue.Value
    End Sub
End Class