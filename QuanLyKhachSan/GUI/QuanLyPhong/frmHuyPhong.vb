Imports BUS.BUS
Imports GUI.XuLy

Public Class frmHuyPhong

    Private fatherForm As frmQuanLyPhong

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmHuyPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDanhSachPhong.DataSource = PhongBUS.selectPhongAllByNgayBatDauVaNgayTraPhong(Date.Now,
                                                                                       Date.Now)
        If (String.IsNullOrEmpty(txtMaPhong.Text)) And (String.IsNullOrEmpty(txtTenPhong.Text)) Then
            btnTimPhong.Enabled = True
        End If
    End Sub

    Private Sub btnTimPhong_Click(sender As Object, e As EventArgs) Handles btnTimPhong.Click
        If ((String.IsNullOrEmpty(txtMaPhong.Text) = False) And (String.IsNullOrEmpty(txtTenPhong.Text))) Then

            dgvDanhSachPhong.DataSource = PhongBUS.selectPhongByMaPhongNgayBatDauNgayTraPhong((txtMaPhong.Text),
                                                            Date.Now,
                                                            Date.Now)
            dgvDanhSachPhong.Refresh()
        ElseIf ((String.IsNullOrEmpty(txtMaPhong.Text)) And (String.IsNullOrEmpty(txtTenPhong.Text) = False)) Then

            dgvDanhSachPhong.DataSource = PhongBUS.selectPhongByTenPhongNgayBatDauNgayTraPhong((txtTenPhong.Text),
                                                            Date.Now,
                                                            Date.Now)
            dgvDanhSachPhong.Refresh()

        End If

        ' xóa giá trị đã có
        txtTenPhong.Text = ""
        txtMaPhong.Text = ""
    End Sub

    'Private Sub txtMaPhong_TextChanged(sender As Object, e As EventArgs) Handles txtMaPhong.TextChanged
    '    txtTenPhong.Enabled = False

    '    If (String.IsNullOrEmpty(txtMaPhong.Text) = True) Then
    '        txtTenPhong.Enabled = True
    '    End If
    'End Sub

    Private Sub btntThoat_Click(sender As Object, e As EventArgs) Handles btntThoat.Click
        Me.Close()
    End Sub

    Private Sub dgvDanhSachPhong_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvDanhSachPhong.RowValidating
        Try
            txtMaPhong.Text = dgvDanhSachPhong.CurrentRow.Cells("MaPhong").Value.ToString
            txtTenPhong.Text = dgvDanhSachPhong.CurrentRow.Cells("TenPhong").Value.ToString
        Catch ex As Exception
        End Try
      
    End Sub


    'Private Sub dgvDanhSachPhong_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvDanhSachPhong.CellValidating
    '    txtMaPhong.Text = dgvDanhSachPhong.CurrentCell.Value = "asdfd"
    '    txtTenPhong.Text = dgvDanhSachPhong.CurrentRow.Cells("TenPhong").Value.ToString
    'End Sub

    Private Sub btnHuyPhong_Click(sender As Object, e As EventArgs) Handles btnHuyPhong.Click

        If (String.Compare((dgvDanhSachPhong.CurrentRow.Cells("TinhTrang").Value).Replace(" ", ""), ("DA THUE").Replace(" ", "")) = 0) Then
            MessageBox.Show("Phòng đang được thuê, không thể xóa.")
            Return
        End If

        Dim luaChon As DialogResult

        Using New CenteredMessageBox(Me)
            luaChon = (MessageBox.Show(Me, "Bạn có muốn xóa phòng không?", "Lưu lại?",
                                           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
        End Using
        If (luaChon = DialogResult.Yes) Then

            If (PhongBUS.xoaPhongByMaPhong(txtMaPhong.Text) = True) Then
                Using New CenteredMessageBox(Me)
                    MessageBox.Show("Xóa phòng thành công.")
                End Using
            Else
                Using New CenteredMessageBox(Me)
                    MessageBox.Show("Lỗi xóa phòng.")
                End Using
            End If

            dgvDanhSachPhong.DataSource = PhongBUS.selectPhongAllByNgayBatDauVaNgayTraPhong(Date.Now,
                                                                                      Date.Now)
        ElseIf (luaChon = DialogResult.Cancel) Then
            Return
        End If

    End Sub

    Sub New(formFather As frmQuanLyPhong)
        InitializeComponent()
        fatherForm = formFather
    End Sub

    Private Sub frmHuyPhong_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        fatherForm.CapNhat()
    End Sub
End Class