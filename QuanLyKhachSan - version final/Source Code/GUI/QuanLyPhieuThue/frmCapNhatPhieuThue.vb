Imports GUI.XuLy
Imports DTO.DTO
Imports BUS.BUS

Public Class frmCapNhatPhieuThue

    Private fatherForm As frmQuanLyPhieuThue

    Private Sub frmCapNhatPhieuThue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub xuLyHienThiPhieuThue()
        ' hiển thị phiếu thuê theo MaPhieuThue
        If (XuLyGUI.laChuoiHopLe(txtMaPhieuThue.Text) = False) Then
            Using New CenteredMessageBox(Me)
                MessageBox.Show("Nhập mã phiếu thuê hợp lệ.")
                Return
            End Using
        End If

        Dim phieuThue As New PhieuThueDTO
        phieuThue = PhieuThueBUS.seledctPhieuThueByMaPhieuThue(txtMaPhieuThue.Text)

        If (phieuThue Is Nothing) Then
            Using New CenteredMessageBox(Me)
                MessageBox.Show("Phiếu thuê không tồn tại.")
                anThongTinDaCo()
                Return
            End Using
        End If

        ' hiển thị danh sách mã phòng
        Try
            cboMaPhong.DataSource = PhongBUS.selectPhongAllisDeleted()
            cboMaPhong.DisplayMember = "MaPhong"
            cboMaPhong.ValueMember = "MaPhong"

            ' hiển thị tên phòng
            txtTenPhong.Text = cboMaPhong.SelectedItem.TenPhong
            ' hiển thị đơn giá
            txtDonGiaThue.Text = LoaiPhongBUS.selectDonGiaByMaLoaiPhong(cboMaPhong.SelectedItem.MaLoaiPhong)
        Catch ex As Exception
            MessageBox.Show("Không có phòng nào trong hệ thống.")
            Return
        End Try


        cboMaPhong.SelectedIndex = cboMaPhong.FindString(phieuThue.MaPhong)
        dtpNgayBatDauThue.Value = phieuThue.NgayBatDauThue
        dtpNgayTraPhong.Value = phieuThue.NgayTraPhong

        Dim danhSachKhachHang As New DataTable
        danhSachKhachHang.Columns.Add("TenKhachHang", GetType(String))
        danhSachKhachHang.Columns.Add("TenLoaiKhachHang", GetType(String))
        danhSachKhachHang.Columns.Add("CMND", GetType(String))
        danhSachKhachHang.Columns.Add("DiaChi", GetType(String))

        Dim danhSachChiTietPhieuThue As New List(Of ChiTietPhieuThueDTO)
        danhSachChiTietPhieuThue = ChiTietPhieuThueBUS.selectDanhSachChiTietPhieuAllThueByMaPhieuThue(txtMaPhieuThue.Text)

        For Each chiTietPhieuThue As ChiTietPhieuThueDTO In danhSachChiTietPhieuThue
            danhSachKhachHang.Rows.Add(chiTietPhieuThue.TenKhachHang,
                                       LoaiKhachHangBUS.selectTenLoaiKhachHangByMaLoaiKhach(chiTietPhieuThue.MaLoaiKhachHang),
                                       chiTietPhieuThue.CMND, chiTietPhieuThue.DiaChi)
        Next

        ' hiển thị danh sách khách thuê
        dgvDanhSachKhachThue.AutoGenerateColumns = False
        dgvDanhSachKhachThue.DataSource = danhSachKhachHang

        ' hiển thị danh sách tình trạng của các phòng trong khoảng thời gian
        '  từ NgayBatDauThue đến NgayTraPhong
        hienThiDanhSachTinhTrangByThoiGian()

    End Sub

    Private Sub txtMaPhieuThue_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaPhieuThue.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            xuLyHienThiPhieuThue()
        End If

    End Sub

    Private Sub anThongTinDaCo()
        txtMaPhieuThue.Text = ""
        txtDonGiaThue.Text = ""
        txtTenPhong.Text = ""
        dtpNgayBatDauThue.Value = Date.Now
        dtpNgayTraPhong.Value = Date.Now
        cboMaPhong.DataSource = Nothing
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub

    Private Sub hienThiDanhSachTinhTrangByThoiGian()
        dgvTrangThaiPhong.DataSource = TinhTrangBUS.selectTinhTrangPhongByThoiGian(dtpNgayBatDauThue.Value.ToShortDateString(),
                                                   dtpNgayTraPhong.Value.ToShortDateString())
    End Sub

    Private Sub dtpNgayTraPhong_ValueChanged(sender As Object, e As EventArgs)
        hienThiDanhSachTinhTrangByThoiGian()
    End Sub

    Private Sub cboMaPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaPhong.SelectedIndexChanged
        ' hiển thị tên phòng
        txtTenPhong.Text = cboMaPhong.SelectedItem.TenPhong
        ' hiển thị đơn giá
        txtDonGiaThue.Text = LoaiPhongBUS.selectDonGiaByMaLoaiPhong(cboMaPhong.SelectedItem.MaLoaiPhong)
    End Sub


    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If (XuLyGUI.laChuoiHopLe(txtMaPhieuThue.Text) = False) Then
            Using New CenteredMessageBox(Me)
                MessageBox.Show("Nhập đúng mã phiếu thuê.")
                Return
            End Using
        End If

        Dim luaChon As DialogResult

        Using New CenteredMessageBox(Me)
            luaChon = (MessageBox.Show(Me, "Bạn có cập nhật phiếu thuê không?", "Lưu lại?",
                                           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
        End Using
        If (luaChon = DialogResult.Yes) Then

            Dim phieuThue As New PhieuThueDTO
            phieuThue.MaPhieuThue = txtMaPhieuThue.Text
            phieuThue.MaPhong = cboMaPhong.SelectedValue.ToString
            phieuThue.NgayBatDauThue = dtpNgayBatDauThue.Value
            phieuThue.NgayTraPhong = dtpNgayTraPhong.Value
            phieuThue.DonGiaThueThucTe = txtDonGiaThue.Text

            If (PhieuThueBUS.capNhatPhieuThueByMaPhieuThue(phieuThue) = True) Then
                Using New CenteredMessageBox(Me)
                    MessageBox.Show("Cập nhật phiếu thuê thành công.")
                End Using
            Else
                Using New CenteredMessageBox(Me)
                    MessageBox.Show("Lỗi cập nhật phiếu thuê.")
                End Using
            End If

        ElseIf (luaChon = DialogResult.Cancel) Then
            Return
        End If
    End Sub

    Private Sub txtMaPhieuThue_TextChanged(sender As Object, e As EventArgs) Handles txtMaPhieuThue.TextChanged
        btnLuu.Enabled = True
    End Sub

    Private Sub dtpNgayBatDauThue_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayBatDauThue.ValueChanged
        ' giới hạn NgayTraPhong
        dtpNgayTraPhong.MinDate = dtpNgayBatDauThue.Value

        hienThiDanhSachTinhTrangByThoiGian()
    End Sub

    Sub New(formFather As frmQuanLyPhieuThue)
        InitializeComponent()
        fatherForm = formFather
    End Sub

    Private Sub frmCapNhatPhieuThue_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        fatherForm.CapNhat()
    End Sub
End Class