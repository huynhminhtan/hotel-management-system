Imports BUS.BUS
Imports GUI.XuLy

Public Class frmLapHoaDon

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
                ' không cho thêm hàng mới khi chưa nhập xong hàng hiện tại
                dgvDanhSachPhieuThue.AllowUserToAddRows = False
                Return
            End If
        Next

        ' cho phép thêm hàng để thêm mã phiếu thuê khi mã nhập trước đó hợp lệ
        dgvDanhSachPhieuThue.AllowUserToAddRows = True

        dgvDanhSachPhieuThue.CurrentRow.Cells("DonGiaThue").Value = dt.Rows(0)("DonGiaThue").ToString
        dgvDanhSachPhieuThue.CurrentRow.Cells("TenPhong").Value = dt.Rows(0)("TenPhong").ToString
        dgvDanhSachPhieuThue.CurrentRow.Cells("SoNgayThue").Value = dt.Rows(0)("SoNgayThue").ToString
        dgvDanhSachPhieuThue.CurrentRow.Cells("DonGiaThue").Value = dt.Rows(0)("DonGiaThue").ToString
        dgvDanhSachPhieuThue.CurrentRow.Cells("ThanhTien").Value = dt.Rows(0)("ThanhTien").ToString

    End Sub

    Private Sub btnLapHoaDon_Click(sender As Object, e As EventArgs) Handles btnLapHoaDon.Click

        '' bla bla

        ' cập nhật lại MaHoaDon trong tất cả các phiếu thuê được nhập 
        ' >> chạy vòng for
        '' lấy mã hóa đơn hiện tại
        Dim maHoaDon As String = ""
        ' maHoaDon = HoaDonBUS.tangMaHoaDon(HoaDonBUS.selectHoaDonMoiNhatAll())
        ' PhieuThueBUS.daThanhToanHoaDon(maHoaDon, MaPhieuThue)

        MessageBox.Show(dgvDanhSachPhieuThue.RowCount.ToString())

    End Sub
End Class