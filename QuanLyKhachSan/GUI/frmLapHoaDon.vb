Imports BUS.BUS
Imports GUI.XuLy
Imports DTO.DTO

Public Class frmLapHoaDon
    Private _triGiaHoaDon As Double = 0

    Private Sub dgvDanhSachPhieuThue_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPhieuThue.CellEndEdit

        Dim maPhieuThue As String = ""
        'maPhieuThue = dgvDanhSachPhieuThue.CurrentRow.Cells("MaPhieuThue").Value
        maPhieuThue = dgvDanhSachPhieuThue.CurrentCell.Value.ToString

        If (String.IsNullOrEmpty(maPhieuThue)) Then
            Return
        ElseIf (String.IsNullOrWhiteSpace(maPhieuThue)) Then
            ' e.Cancel = True
            Using New CenteredMessageBox(Me)
                MessageBox.Show(Me, "Vui lòng nhập giá trị hợp lệ!")
            End Using
            Return
        End If


        ' hiển thị các giá trị lên Danh sách phiếu thuê
        Dim dt As New DataTable
        dt = HoaDonBUS.hienThiPhieuThueLapHoaDon(maPhieuThue)

        If (dt Is Nothing) Then
            Using New CenteredMessageBox(Me)
                ' phiếu thuê đã thanh toán
                ' phiếu thuê không tồn tại
                MessageBox.Show("Phiếu thuê đã được thanh toán hoặc không tồn tại.")
            End Using
            dgvDanhSachPhieuThue.CurrentCell.Value = ""
            ' không cho thêm hàng mới khi chưa nhập xong hàng hiện tại
            dgvDanhSachPhieuThue.AllowUserToAddRows = False
            dgvDanhSachPhieuThue.AllowUserToDeleteRows = False
            Return
        End If

        ' không cho phép nhập mã phiếu thuê hai lần cùng hóa đơn
        For ihang As Integer = 0 To (dgvDanhSachPhieuThue.Rows.Count - 3)
            Dim chuoi As String = dgvDanhSachPhieuThue.Rows(ihang).Cells("MaPhieuThue").Value.ToString
            If (chuoi = maPhieuThue) Then
                Using New CenteredMessageBox(Me)
                    MessageBox.Show("Phiếu thuê đã được nhập trước đó.")
                End Using
                dgvDanhSachPhieuThue.CurrentCell.Value = ""

                dgvDanhSachPhieuThue.AllowUserToAddRows = False
                dgvDanhSachPhieuThue.AllowUserToDeleteRows = False
                Return
            End If
        Next

        dgvDanhSachPhieuThue.AllowUserToAddRows = True
        dgvDanhSachPhieuThue.AllowUserToDeleteRows = True

        dgvDanhSachPhieuThue.CurrentRow.Cells("DonGiaThue").Value = dt.Rows(0)("DonGiaThue").ToString
        dgvDanhSachPhieuThue.CurrentRow.Cells("TenPhong").Value = dt.Rows(0)("TenPhong").ToString
        dgvDanhSachPhieuThue.CurrentRow.Cells("SoNgayThue").Value = dt.Rows(0)("SoNgayThue").ToString
        dgvDanhSachPhieuThue.CurrentRow.Cells("DonGiaThue").Value = dt.Rows(0)("DonGiaThue").ToString
        dgvDanhSachPhieuThue.CurrentRow.Cells("ThanhTien").Value = dt.Rows(0)("ThanhTien").ToString

        tinhTriGiaHoaDon()
    End Sub

    Private Sub btnLapHoaDon_Click(sender As Object, e As EventArgs) Handles btnLapHoaDon.Click
        themHoaDon()
    End Sub

    Private Sub dgvDanhSachPhieuThue_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvDanhSachPhieuThue.RowsRemoved
        tinhTriGiaHoaDon()
    End Sub

    Private Sub tinhTriGiaHoaDon()
        _triGiaHoaDon = 0

        ' tính trị giá của hóa đơn
        For ihang As Integer = 0 To (dgvDanhSachPhieuThue.Rows.Count - 2)
            _triGiaHoaDon += Double.Parse(dgvDanhSachPhieuThue.Rows(ihang).Cells("ThanhTien").Value.ToString)
        Next

        ' hiển thị trị giá hóa đơn
        txtTriGiaHoaDon.Text = _triGiaHoaDon.ToString
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub

    Private Sub frmLapHoaDon_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (dgvDanhSachPhieuThue.Rows(0).Cells("MaPhieuThue").Value IsNot Nothing) Then
            If (XuLyGUI.laChuoiHopLe(dgvDanhSachPhieuThue.Rows(0).Cells("MaPhieuThue").Value.ToString) = True) Then
                Dim luaChon As DialogResult

                Using New CenteredMessageBox(Me)
                    luaChon = (MessageBox.Show(Me, "Bạn có muốn lập hóa đơn đã nhập không?", "Lưu lại?",
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                End Using

                If (luaChon = DialogResult.Yes) Then
                    themHoaDon()
                ElseIf (luaChon = DialogResult.Cancel) Then
                    e.Cancel() = True
                End If
            End If
        End If
    End Sub

    Private Sub themHoaDon()
        ' Kiểm tra giá trị hợp lệ
        Using New CenteredMessageBox(Me)
            If (String.IsNullOrEmpty(txtTenKhachHang.Text) Or (String.IsNullOrWhiteSpace(txtTenKhachHang.Text))) Then
                MessageBox.Show("Vui lòng nhập tên khách hàng cần lập hóa đơn.")
                Return
            End If

            If (String.IsNullOrEmpty(txtDiaChi.Text) Or (String.IsNullOrWhiteSpace(txtDiaChi.Text))) Then
                MessageBox.Show("Vui lòng nhập địa chỉ.")
                Return
            End If
        End Using

        ' lưu hóa đơn xuống hệ thống
        '' cập nhật lại maHoaDon cho tất cả các phiếu thuê muốn thanh toán
        Dim maHoaDon As String = ""
        maHoaDon = XuLyGUI.tangMa(HoaDonBUS.selectHoaDonMoiNhatAll(), "HD")

        For ihang As Integer = 0 To (dgvDanhSachPhieuThue.Rows.Count - 2)
            Dim maPhieuThue As String
            maPhieuThue = dgvDanhSachPhieuThue.Rows(ihang).Cells("MaPhieuThue").Value.ToString
            PhieuThueBUS.daThanhToanHoaDon(maHoaDon, maPhieuThue)
        Next

        '' lưu thông tin hóa đơn
        Dim hoaDon As New HoaDonDTO
        hoaDon.TenKhachHangHD = txtTenKhachHang.Text.ToString
        hoaDon.DiaChiKhachHD = txtDiaChi.Text.ToString
        hoaDon.TriGiaHoaDon = _triGiaHoaDon

        Using New CenteredMessageBox(Me)
            If (HoaDonBUS.themHoaDon(hoaDon) = True) Then
                MessageBox.Show("Lập hóa đơn thành công.")

                dgvDanhSachPhieuThue.Rows.Clear()
                txtDiaChi.Text = ""
                txtTenKhachHang.Text = ""
                txtTriGiaHoaDon.Text = ""

            Else
                MessageBox.Show("Lập hóa đơn bị lỗi.")
            End If
        End Using
    End Sub

End Class