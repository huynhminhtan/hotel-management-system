Imports BUS.BUS
Imports DTO.DTO
Imports GUI.XuLy

Public Class frmLapDanhMucPhong

    Private danhSachPhongTam As New DataTable
    Private fatherForm As frmQuanLyPhong

    Private Sub frmLapDanhMucPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' hiển thị danh sách loại phòng
        cboTenLoaiPhong.DisplayMember = "TenLoaiPhong" ' cột cần hiển thị ra ngoài comboboxs
        cboTenLoaiPhong.ValueMember = "MaLoaiPhong" ' giá trị tương ứng với displayMember được chọn
        cboTenLoaiPhong.DataSource = LoaiPhongBUS.selectLoaiPhongAll()

        ' hiển thị mã loại phòng đã tăng
        txtMaPhong.Text = tangMaPhong(PhongBUS.selectMaPhongMoiNhat())

        ' hiển thị danh sách các loại phòng tạm
        dgvDanhMucPhong.AutoGenerateColumns = False
        dgvDanhMucPhong.DataSource = danhSachPhongTam

        ' khởi tạo bảng phòng tạm
        danhSachPhongTam.Columns.Add("MaPhong", GetType(String))
        danhSachPhongTam.Columns.Add("TenPhong", GetType(String))
        danhSachPhongTam.Columns.Add("MaLoaiPhong", GetType(String))
        danhSachPhongTam.Columns.Add("TenLoaiPhong", GetType(String))
        danhSachPhongTam.Columns.Add("DonGia", GetType(Double))
        danhSachPhongTam.Columns.Add("GhiChu", GetType(String))

    End Sub

    Private Sub cboTenLoaiPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTenLoaiPhong.SelectedIndexChanged
        ' hiển thị đơn giá từ database tương ứng với cboTenLoaiPhong
        ' tip: int.Parse(cbEmployeeStyle.SelectedValue.ToString());

        txtDonGia.Text = LoaiPhongBUS.selectDonGiaByMaLoaiPhong(cboTenLoaiPhong.SelectedValue.ToString)

    End Sub

    Private Sub btnThemPhong_Click(sender As Object, e As EventArgs) Handles btnThemPhong.Click

        ' Kiểm tra nhập tên phòng hợp lệ
        If (XuLyGUI.laChuoiHopLe(txtTenPhong.Text) = False) Then

            Using New CenteredMessageBox(Me)
                MessageBox.Show("Vui lòng nhập tên phòng hợp lệ.")
            End Using

            Return
        End If

        Dim maPhong As String = txtMaPhong.Text

        If (danhSachPhongTam.Rows.Count - 1 >= 0) Then
            maPhong = danhSachPhongTam.Rows(danhSachPhongTam.Rows.Count - 1).Item(0).ToString
            maPhong = tangMaPhong(maPhong)
        End If

        danhSachPhongTam.Rows.Add(maPhong, txtTenPhong.Text, cboTenLoaiPhong.SelectedItem.MaLoaiPhong,
                                  cboTenLoaiPhong.SelectedItem.TenLoaiPhong, txtDonGia.Text, txtGhiChu.Text)

        dgvDanhMucPhong.ResetBindings()

        ' tăng mã phòng
        txtMaPhong.Text = tangMaPhong(danhSachPhongTam.Rows(danhSachPhongTam.Rows.Count - 1).Item(0).ToString)

        ' dọn dẹp các txtbox
        txtTenPhong.Text = ""
        txtGhiChu.Text = ""

    End Sub

    Private Function tangMaPhong(maPhong As String) As String
        Return XuLyGUI.tangMa(maPhong, "PH")
    End Function

    Private Sub dgvDanhMucPhong_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhMucPhong.SelectionChanged
        ' hiển thị thông tin phòng được chọn lên Label và Combobox
        If (dgvDanhMucPhong.CurrentRow IsNot Nothing) Then
            txtMaPhong.Text = dgvDanhMucPhong.CurrentRow.Cells("MaPhong").Value.ToString
            txtTenPhong.Text = dgvDanhMucPhong.CurrentRow.Cells("TenPhong").Value.ToString
            cboTenLoaiPhong.SelectedValue = dgvDanhMucPhong.CurrentRow.Cells("MaLoaiPhong").Value
            txtDonGia.Text = dgvDanhMucPhong.CurrentRow.Cells("DonGia").Value.ToString
            txtGhiChu.Text = dgvDanhMucPhong.CurrentRow.Cells("GhiChu").Value.ToString
        End If


    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' lấy chỉ số của hàng đang được chọn
        Dim chiSo As Integer
        chiSo = dgvDanhMucPhong.CurrentRow.Index

        ' Kiểm tra nhập tên phòng hợp lệ
        If (XuLyGUI.laChuoiHopLe(txtTenPhong.Text) = False) Then

            Using New CenteredMessageBox(Me)
                MessageBox.Show("Vui lòng nhập tên phòng hợp lệ.")
            End Using

            Return
        End If

        ' Cập nhật lại danhSachPhongTam
        danhSachPhongTam.Rows(chiSo)("TenPhong") = txtTenPhong.Text
        danhSachPhongTam.Rows(chiSo)("MaLoaiPhong") = cboTenLoaiPhong.SelectedItem.MaLoaiPhong
        danhSachPhongTam.Rows(chiSo)("TenLoaiPhong") = cboTenLoaiPhong.SelectedItem.TenLoaiPhong
        danhSachPhongTam.Rows(chiSo)("DonGia") = Double.Parse(txtDonGia.Text)
        danhSachPhongTam.Rows(chiSo)("GhiChu") = txtGhiChu.Text

        ' Hiển thị danhSachPhongTam mới
        dgvDanhMucPhong.ResetBindings()

        ' dọn dẹp các txtbox
        txtTenPhong.Text = ""
        txtGhiChu.Text = ""

    End Sub

    Private Sub btnXoaPhong_Click(sender As Object, e As EventArgs) Handles btnXoaPhong.Click
        ' lấy chỉ số của hàng đang được chọn
        Dim chiSo As Integer
        chiSo = dgvDanhMucPhong.CurrentRow.Index

        danhSachPhongTam.Rows(chiSo).Delete()

        ' cập nhật lại mã phòng khi đã xóa trong DanhSachPhongTam
        '' lấy mã phòng mới nhất từ CSDL
        Dim maPhongMoi As String = PhongBUS.selectMaPhongMoiNhat()

        '' lấy số lượng các phòng trong DanhSachPhongTam
        '' Tạo mã phòng mới và gán lại vào cột MaPhong trong DanhSachPhongTam
        For i As Integer = 0 To (danhSachPhongTam.Rows.Count - 1)
            maPhongMoi = tangMaPhong(maPhongMoi)
            danhSachPhongTam.Rows(i)("MaPhong") = maPhongMoi
        Next

        ' Hiển thị danhSachPhongTam mới
        dgvDanhMucPhong.ResetBindings()

        ' dọn dẹp các txtbox
        txtTenPhong.Text = ""
        txtGhiChu.Text = ""
        txtMaPhong.Text = tangMaPhong(maPhongMoi)

    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        themDanhSachPhong()

        ' dọn dẹp danhSachPhongTam
        danhSachPhongTam.Clear()

    End Sub

    Private Sub dgvDanhMucPhong_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvDanhMucPhong.DataBindingComplete
        ' hiển thị button "Lưu" và "Cập nhật"
        If (danhSachPhongTam.Rows.Count > 0) Then
            btnCapNhat.Enabled = True
            btnLuu.Enabled = True
            btnXoaPhong.Enabled = True
        Else
            btnCapNhat.Enabled = False
            btnLuu.Enabled = False
            btnXoaPhong.Enabled = False
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub frmLapDanhMucPhong_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (danhSachPhongTam.Rows.Count > 0) Then
            Dim luaChon As DialogResult

            Using New CenteredMessageBox(Me)
                luaChon = (MessageBox.Show(Me, "Bạn có muốn lưu các phòng đã nhập không?", "Lưu lại?",
                                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            End Using

            If (luaChon = DialogResult.Yes) Then
                themDanhSachPhong()
            ElseIf (luaChon = DialogResult.Cancel) Then
                e.Cancel() = True
            End If
        End If
    End Sub

    Private Sub themDanhSachPhong()
        Dim danhSachPhong As New List(Of PhongDTO)
        For i As Integer = 0 To danhSachPhongTam.Rows.Count - 1
            Dim phong As New PhongDTO
            phong.MaPhong = danhSachPhongTam.Rows(i).Item("MaPhong")
            phong.TenPhong = danhSachPhongTam.Rows(i).Item("TenPhong")
            phong.MaLoaiPhong = danhSachPhongTam.Rows(i).Item("MaLoaiPhong")
            phong.GhiChu = danhSachPhongTam.Rows(i).Item("GhiChu")
            danhSachPhong.Add(phong)
        Next

        Dim ketQua = PhongBUS.themDanhSachPhong(danhSachPhong)

        Using New CenteredMessageBox(Me)
            If (ketQua = 0) Then
                MessageBox.Show(Me, "Thêm phòng thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(Me, "Thêm " + ketQua.ToString + " phòng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End Using
        
    End Sub

    Sub New(frmFather As frmQuanLyPhong)
        InitializeComponent()
        fatherForm = frmFather
    End Sub

    Private Sub frmLapDanhMucPhong_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        fatherForm.CapNhat()
    End Sub
End Class