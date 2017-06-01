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

    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        If (String.IsNullOrEmpty(txtMaPhong.Text)) And (String.IsNullOrEmpty(txtTenPhong.Text)) Then
            dgvDanhSachPhong.DataSource = PhongBUS.selectPhongKhongMaPhongKhongTenPhong(cboTenLoaiPhong.SelectedItem.MaLoaiPhong.ToString,
                                                              Double.Parse(cboDonGiaThue.SelectedItem.DonGiaThue.ToString),
                                                              cboTinhTrang.SelectedItem.ToString,
                                                              dtpNgayBatDauThue.Value,
                                                              dtpNgayTraPhong.Value)
        ElseIf ((String.IsNullOrEmpty(txtMaPhong.Text) = False) And (String.IsNullOrEmpty(txtTenPhong.Text))) Then
            ' khi tìm kiếm phòng thì phải biết được loại phòng hoặc đơn giá
            'dgvDanhSachPhong.DataSource = PhongBUS.selectPhongKhongTenPhong((txtMaPhong.Text),
            '                                                  cboTenLoaiPhong.SelectedItem.MaLoaiPhong.ToString,
            '                                                  Double.Parse(cboDonGiaThue.SelectedItem.DonGiaThue.ToString),
            '                                                  cboTinhTrang.SelectedItem.ToString,
            '                                                  dtpNgayBatDauThue.Value,
            '                                                  dtpNgayTraPhong.Value)

            dgvDanhSachPhong.DataSource = PhongBUS.selectPhongByMaPhongNgayBatDauNgayTraPhong((txtMaPhong.Text),
                                                            dtpNgayBatDauThue.Value,
                                                            dtpNgayTraPhong.Value)
        ElseIf ((String.IsNullOrEmpty(txtMaPhong.Text)) And (String.IsNullOrEmpty(txtTenPhong.Text) = False)) Then
            ' khi tìm kiếm phòng thì phải biết được loại phòng hoặc đơn giá
            'dgvDanhSachPhong.DataSource = PhongBUS.selectPhongKhongMaPhong((txtTenPhong.Text),
            '                                                  cboTenLoaiPhong.SelectedItem.MaLoaiPhong.ToString,
            '                                                  Double.Parse(cboDonGiaThue.SelectedItem.DonGiaThue.ToString),
            '                                                  cboTinhTrang.SelectedItem.ToString,
            '                                                  dtpNgayBatDauThue.Value,
            '                                                  dtpNgayTraPhong.Value)

            dgvDanhSachPhong.DataSource = PhongBUS.selectPhongByTenPhongNgayBatDauNgayTraPhong((txtTenPhong.Text),
                                                              dtpNgayBatDauThue.Value,
                                                              dtpNgayTraPhong.Value)
        End If

        ' xóa giá trị đã có
        txtTenPhong.Text = ""
        txtMaPhong.Text = ""
    End Sub

   
    Private Sub txtMaPhong_TextChanged(sender As Object, e As EventArgs) Handles txtMaPhong.TextChanged
        txtTenPhong.Text = ""
    End Sub

    Private Sub txtTenPhong_TextChanged(sender As Object, e As EventArgs) Handles txtTenPhong.TextChanged
        txtMaPhong.Text = ""
    End Sub
End Class