Imports BUS.BUS
Imports GUI.XuLy

Public Class frmHuyPhong

    Private fatherForm As frmQuanLyPhong

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmHuyPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDanhSachPhong.DataSource = PhongBUS.selectPhongAllByNgayBatDauVaNgayTraPhong(Date.Now,
                                                                                       Date.Now)

        txtMaPhong.Text = dgvDanhSachPhong.CurrentRow.Cells(0).Value.ToString
        txtTenPhong.Text = dgvDanhSachPhong.CurrentRow.Cells(1).Value.ToString

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

        If (dgvDanhSachPhong.DataSource Is Nothing) Then
            Using New CenteredMessageBox(Me)
                MessageBox.Show("Không có phòng phù hợp.")
            End Using
            dgvDanhSachPhong.DataSource = PhongBUS.selectPhongAllByNgayBatDauVaNgayTraPhong(Date.Now,
                                                                                     Date.Now)
            txtMaPhong.Text = dgvDanhSachPhong.CurrentRow.Cells(0).Value.ToString
            txtTenPhong.Text = dgvDanhSachPhong.CurrentRow.Cells(1).Value.ToString

            Return
        End If

        Try
            txtMaPhong.Text = dgvDanhSachPhong.CurrentRow.Cells(0).Value.ToString
            txtTenPhong.Text = dgvDanhSachPhong.CurrentRow.Cells(1).Value.ToString
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btntThoat_Click(sender As Object, e As EventArgs) Handles btntThoat.Click
        Me.Close()
    End Sub

    Private Sub btnHuyPhong_Click(sender As Object, e As EventArgs) Handles btnHuyPhong.Click
        Using New CenteredMessageBox(Me)
            If (String.Compare((dgvDanhSachPhong.CurrentRow.Cells(4).Value).Replace(" ", ""), ("DA THUE").Replace(" ", "")) = 0) Then
                MessageBox.Show("Phòng đang được thuê, không thể xóa.")
                Return
            End If
        End Using

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

    Private Sub dgvDanhSachPhong_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPhong.CellClick
        Try
            txtMaPhong.Text = dgvDanhSachPhong.CurrentRow.Cells(0).Value.ToString
            txtTenPhong.Text = dgvDanhSachPhong.CurrentRow.Cells(1).Value.ToString
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtMaPhong_Click(sender As Object, e As EventArgs) Handles txtMaPhong.Click
        txtTenPhong.Text = ""
    End Sub

    Private Sub txtTenPhong_Click(sender As Object, e As EventArgs) Handles txtTenPhong.Click
        txtMaPhong.Text = ""
    End Sub
End Class