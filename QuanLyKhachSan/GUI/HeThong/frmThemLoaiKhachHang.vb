Imports BUS.BUS
Imports GUI.XuLy
Imports DTO.DTO

Public Class frmThemLoaiKhachHang

    Private Sub frmThemLoaiKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDanhSachLoaiKhachHang.DataSource = LoaiKhachHangBUS.selectLoaiKhachHangAll()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Using New CenteredMessageBox(Me)
            If ((XuLyGUI.laChuoiHopLe(txtTenLoaiKhachHang.Text) = False)) Then
                MessageBox.Show("Vui lòng nhập tên loại khách hàng hợp lệ.")
                Return
            End If

            If (XuLyGUI.laChuoiHopLe(txtHeSoKhach.Text) = False) Then
                MessageBox.Show("Vui lòng nhập tên hệ số khách hợp lệ.")
                Return
            End If

            'If (IsNumeric(Double.Parse(txtHeSoKhach.Text)) = False) Then
            '    MessageBox.Show("Nhập tên hệ số khách hợp lệ.")
            '    Return
            'End If

            Dim loaiKhachHang As New LoaiKhachHangDTO
            loaiKhachHang.HeSoKhach = txtHeSoKhach.Text
            loaiKhachHang.TenLoaiKhachHang = txtTenLoaiKhachHang.Text

            If (LoaiKhachHangBUS.themLoaiKhachHang(loaiKhachHang)) Then
                Using New CenteredMessageBox(Me)
                    MessageBox.Show("Thêm loại khách thành công.")
                End Using
            End If

            dgvDanhSachLoaiKhachHang.DataSource = LoaiKhachHangBUS.selectLoaiKhachHangAll()

        End Using
    End Sub

    Private Sub btntThoat_Click(sender As Object, e As EventArgs) Handles btntThoat.Click
        Me.Close()
    End Sub
End Class