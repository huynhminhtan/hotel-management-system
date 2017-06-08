Imports GUI.XuLy
Imports BUS.BUS

Public Class frmQuanLyPhieuThue

    Private Sub frmQuanLyPhieuThue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' hiển thị danh sách phiếu thuê
        hienThiComBoBoxTinhTrangPhieuThue()

        hienThiDanhSachPhieuThue()
    End Sub


    Private Sub btnLapPhieuThuePhong_Click(sender As Object, e As EventArgs) Handles btnLapPhieuThuePhong.Click
        Dim formLapPhieuThuePhong As New frmLapPhieuThuePhong(Me)
        formLapPhieuThuePhong.Show()
    End Sub

    Public Sub CapNhat()
        hienThiDanhSachPhieuThue()
    End Sub

    Private Sub btnLapHoaDon_Click(sender As Object, e As EventArgs) Handles btnLapHoaDon.Click
        Dim danhSachPhieuThue As New DataTable
        danhSachPhieuThue.Columns.Add("MaPhieuThue")

        For Each hang As DataGridViewRow In dgvQuanLyPhieuThue.Rows
            If (Convert.ToBoolean(hang.Cells("ChonPhieuThue").Value) = True) Then
                danhSachPhieuThue.Rows.Add(hang.Cells("MaPhieuThue").Value.ToString)
            End If
        Next

        Dim formLapHoaDon As New frmLapHoaDon(Me, danhSachPhieuThue)
        formLapHoaDon.Show()

    End Sub

    Private Sub hienThiDanhSachPhieuThue()

        dgvQuanLyPhieuThue.ResetBindings()
        dgvQuanLyPhieuThue.DataSource = PhieuThueBUS.selectPhieuThueByTinhTrangHoaDon(cboTinhTrangPhieuThue.SelectedValue.ToString)

    End Sub

    Private Sub hienThiComBoBoxTinhTrangPhieuThue()
        Dim tinhTrangPhieuThue As New DataTable
        tinhTrangPhieuThue.Columns.Add("TenTinhTrang", GetType(String))
        tinhTrangPhieuThue.Columns.Add("GiaTriTinhTrang", GetType(String))

        tinhTrangPhieuThue.Rows.Add("Tất Cả", "TAT CA")
        tinhTrangPhieuThue.Rows.Add("Đã Thuê", "DA THUE")
        tinhTrangPhieuThue.Rows.Add("Còn Trống", "TRONG")

        cboTinhTrangPhieuThue.DataSource = tinhTrangPhieuThue
        cboTinhTrangPhieuThue.DisplayMember = "TenTinhTrang"
        cboTinhTrangPhieuThue.ValueMember = "GiaTriTinhTrang"
    End Sub

    Private Sub cboTinhTrangPhieuThue_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTinhTrangPhieuThue.SelectedValueChanged
        hienThiDanhSachPhieuThue()
    End Sub

    Private Sub dgvQuanLyPhieuThue_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQuanLyPhieuThue.CellClick
        If (String.IsNullOrEmpty(dgvQuanLyPhieuThue.CurrentRow.Cells("MaHoaDon").Value.ToString) = False) Then
            dgvQuanLyPhieuThue.CurrentRow.Cells("ChonPhieuThue").ReadOnly = True
            MessageBox.Show("Phiếu thuê đã được lập hóa đơn.")
        End If
    End Sub
End Class