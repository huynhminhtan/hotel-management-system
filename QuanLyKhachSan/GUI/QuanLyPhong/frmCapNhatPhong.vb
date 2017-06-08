Imports BUS.BUS
Imports GUI.XuLy
Imports DTO.DTO

Public Class frmCapNhatPhong

    Private fatherForm As frmQuanLyPhong

    Private Sub CapNhatPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' hiển thị danh sách loại phòng
        cboTenLoaiPhong.DisplayMember = "TenLoaiPhong" ' cột cần hiển thị ra ngoài comboboxs
        cboTenLoaiPhong.ValueMember = "MaLoaiPhong" ' giá trị tương ứng với displayMember được chọn
        cboTenLoaiPhong.DataSource = LoaiPhongBUS.selectLoaiPhongAll()

        '  dgvDanhSachPhong.AutoGenerateColumns = False

        dgvDanhSachPhong.DataSource = PhongBUS.selectPhongVoiTenLoaiPhong()

        txtMaPhong.Text = dgvDanhSachPhong.CurrentRow.Cells(0).Value
        txtTenPhong.Text = dgvDanhSachPhong.CurrentRow.Cells(1).Value
        txtGhiChu.Text = dgvDanhSachPhong.CurrentRow.Cells(4).Value
        txtDonGia.Text = dgvDanhSachPhong.CurrentRow.Cells(3).Value
        cboTenLoaiPhong.SelectedIndex = cboTenLoaiPhong.FindString(dgvDanhSachPhong.CurrentRow.Cells(2).Value)
    End Sub


    Private Sub dgvDanhSachPhong_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPhong.CellClick
        txtMaPhong.Text = dgvDanhSachPhong.CurrentRow.Cells(0).Value
        txtTenPhong.Text = dgvDanhSachPhong.CurrentRow.Cells(1).Value
        txtGhiChu.Text = dgvDanhSachPhong.CurrentRow.Cells(4).Value
        txtDonGia.Text = dgvDanhSachPhong.CurrentRow.Cells(3).Value
        cboTenLoaiPhong.SelectedIndex = cboTenLoaiPhong.FindString(dgvDanhSachPhong.CurrentRow.Cells(2).Value)

    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim luaChon As DialogResult

        Using New CenteredMessageBox(Me)
            luaChon = (MessageBox.Show(Me, "Bạn có muốn cập nhật lại phòng không?", "Cập nhật lại?",
                                           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
        End Using

        If (luaChon = DialogResult.Yes) Then

            Dim phong As New PhongDTO
            phong.MaPhong = txtMaPhong.Text
            phong.TenPhong = txtTenPhong.Text
            phong.MaLoaiPhong = cboTenLoaiPhong.SelectedValue.ToString
            phong.GhiChu = txtGhiChu.Text

            If (PhongBUS.capNhatPhongByMaPhong(phong) = True) Then
                MessageBox.Show("Cập nhật phòng thành công.")
            Else
                MessageBox.Show("Lỗi cập nhật phòng.")
            End If

            dgvDanhSachPhong.DataSource = PhongBUS.selectPhongVoiTenLoaiPhong()
        ElseIf (luaChon = DialogResult.Cancel) Then
            Return
        End If
    End Sub

    Sub New(formFather As frmQuanLyPhong)
        InitializeComponent()
        fatherForm = formFather
    End Sub


    Private Sub frmCapNhatPhong_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        fatherForm.CapNhat()
    End Sub

    Private Sub btntThoat_Click(sender As Object, e As EventArgs) Handles btntThoat.Click
        Me.Close()
    End Sub
End Class