Imports BUS.BUS
Imports GUI.XuLy
Imports DTO.DTO

Public Class frmThemKhuyenMai
    Private fatherForm As frmHeThong

    Private Sub frmThemKhuyenMai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDanhSachLoaiKhachHang.DataSource = KhuyenMaiBUS.selectKhuyenMaiAll()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Using New CenteredMessageBox(Me)
            If ((XuLyGUI.laChuoiHopLe(txtTenKhuyenMai.Text) = False)) Then
                MessageBox.Show("Vui lòng nhập tên khuyến mãi hợp lệ.")
                Return
            End If

            If (XuLyGUI.laChuoiHopLe(txtHeSoKhuyenMai.Text) = False) Then
                MessageBox.Show("Vui lòng nhập tên hệ số khuyến mãi hợp lệ.")
                Return
            End If

            'If (XuLyGUI.laChuoiHopLe(txtGhiChu.Text) = False) Then
            '    MessageBox.Show("Vui lòng nhập ghi chú hợp lệ.")
            '    Return
            'End If

            'If (IsNumeric(Double.Parse(txtHeSoKhach.Text)) = False) Then
            '    MessageBox.Show("Nhập tên hệ số khách hợp lệ.")
            '    Return
            'End If

            Dim khuyenMai As New KhuyenMaiDTO
            khuyenMai.HeSoKhuyenMai = txtHeSoKhuyenMai.Text
            khuyenMai.TenKhuyenMai = txtTenKhuyenMai.Text
            khuyenMai.GhiChu = txtGhiChu.Text

            If (KhuyenMaiBUS.themKhuyenMaiAll(khuyenMai)) Then
                Using New CenteredMessageBox(Me)
                    MessageBox.Show("Thêm khuyến mãi thành công.")
                End Using
            End If

            dgvDanhSachLoaiKhachHang.DataSource = KhuyenMaiBUS.selectKhuyenMaiAll()

            txtHeSoKhuyenMai.Text = ""
            txtTenKhuyenMai.Text = ""
            txtGhiChu.Text = ""
        End Using
    End Sub


    Sub New(formFather As frmHeThong)
        InitializeComponent()
        fatherForm = formFather
    End Sub

    Private Sub frmThemKhuyenMai_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        fatherForm.CapNhat()
    End Sub

    Private Sub btntThoat_Click(sender As Object, e As EventArgs) Handles btntThoat.Click
        Me.Close()
    End Sub
End Class