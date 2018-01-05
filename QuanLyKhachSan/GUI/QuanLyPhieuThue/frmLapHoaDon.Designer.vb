<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLapHoaDon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhSachPhieuThue = New System.Windows.Forms.DataGridView()
        Me.MaPhieuThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoNgayThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThanhTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnLapHoaDon = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTongTien = New System.Windows.Forms.Label()
        Me.lblTienThemGio = New System.Windows.Forms.Label()
        Me.txtThemGio = New System.Windows.Forms.TextBox()
        Me.lblThemGio = New System.Windows.Forms.Label()
        Me.txtPhuThu = New System.Windows.Forms.TextBox()
        Me.lblPhuThu = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtTriGiaHoaDon = New System.Windows.Forms.TextBox()
        Me.txtTenKhachHang = New System.Windows.Forms.TextBox()
        Me.lblTriGiaHoaDon = New System.Windows.Forms.Label()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.lblTenKhachHang = New System.Windows.Forms.Label()
        Me.cboTenKhuyenMai = New System.Windows.Forms.ComboBox()
        Me.lblKhuyenMai = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvDanhSachPhieuThue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvDanhSachPhieuThue)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(607, 207)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Danh sách phiếu thuê"
        '
        'dgvDanhSachPhieuThue
        '
        Me.dgvDanhSachPhieuThue.AllowUserToAddRows = False
        Me.dgvDanhSachPhieuThue.AllowUserToDeleteRows = False
        Me.dgvDanhSachPhieuThue.AllowUserToResizeColumns = False
        Me.dgvDanhSachPhieuThue.AllowUserToResizeRows = False
        Me.dgvDanhSachPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDanhSachPhieuThue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDanhSachPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhieuThue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPhieuThue, Me.TenPhong, Me.SoNgayThue, Me.DonGiaThue, Me.ThanhTien})
        Me.dgvDanhSachPhieuThue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSachPhieuThue.Location = New System.Drawing.Point(4, 17)
        Me.dgvDanhSachPhieuThue.Name = "dgvDanhSachPhieuThue"
        Me.dgvDanhSachPhieuThue.ReadOnly = True
        Me.dgvDanhSachPhieuThue.RowHeadersWidth = 15
        Me.dgvDanhSachPhieuThue.Size = New System.Drawing.Size(599, 186)
        Me.dgvDanhSachPhieuThue.TabIndex = 0
        '
        'MaPhieuThue
        '
        Me.MaPhieuThue.DataPropertyName = "MaPhieuThue"
        Me.MaPhieuThue.HeaderText = "Mã Phiếu Thuê"
        Me.MaPhieuThue.Name = "MaPhieuThue"
        Me.MaPhieuThue.ReadOnly = True
        '
        'TenPhong
        '
        Me.TenPhong.DataPropertyName = "TenPhong"
        Me.TenPhong.HeaderText = "Tên Phòng"
        Me.TenPhong.Name = "TenPhong"
        Me.TenPhong.ReadOnly = True
        '
        'SoNgayThue
        '
        Me.SoNgayThue.DataPropertyName = "SoNgayThue"
        Me.SoNgayThue.HeaderText = "Số Ngày Thuê"
        Me.SoNgayThue.Name = "SoNgayThue"
        Me.SoNgayThue.ReadOnly = True
        '
        'DonGiaThue
        '
        Me.DonGiaThue.DataPropertyName = "DonGiaThue"
        Me.DonGiaThue.HeaderText = "Đơn Giá"
        Me.DonGiaThue.Name = "DonGiaThue"
        Me.DonGiaThue.ReadOnly = True
        '
        'ThanhTien
        '
        Me.ThanhTien.DataPropertyName = "ThanhTien"
        Me.ThanhTien.HeaderText = "Thành Tiền"
        Me.ThanhTien.Name = "ThanhTien"
        Me.ThanhTien.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHuy)
        Me.GroupBox2.Controls.Add(Me.btnLapHoaDon)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 49)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'btnHuy
        '
        Me.btnHuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnHuy.Location = New System.Drawing.Point(408, 15)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(90, 23)
        Me.btnHuy.TabIndex = 6
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnLapHoaDon
        '
        Me.btnLapHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLapHoaDon.Location = New System.Drawing.Point(102, 15)
        Me.btnLapHoaDon.Name = "btnLapHoaDon"
        Me.btnLapHoaDon.Size = New System.Drawing.Size(90, 23)
        Me.btnLapHoaDon.TabIndex = 5
        Me.btnLapHoaDon.Text = "Lập hóa đơn"
        Me.btnLapHoaDon.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboTenKhuyenMai)
        Me.GroupBox1.Controls.Add(Me.lblKhuyenMai)
        Me.GroupBox1.Controls.Add(Me.lblTongTien)
        Me.GroupBox1.Controls.Add(Me.lblTienThemGio)
        Me.GroupBox1.Controls.Add(Me.txtThemGio)
        Me.GroupBox1.Controls.Add(Me.lblThemGio)
        Me.GroupBox1.Controls.Add(Me.txtPhuThu)
        Me.GroupBox1.Controls.Add(Me.lblPhuThu)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtTriGiaHoaDon)
        Me.GroupBox1.Controls.Add(Me.txtTenKhachHang)
        Me.GroupBox1.Controls.Add(Me.lblTriGiaHoaDon)
        Me.GroupBox1.Controls.Add(Me.lblDiaChi)
        Me.GroupBox1.Controls.Add(Me.lblTenKhachHang)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 151)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LẬP HÓA ĐƠN THANH TOÁN"
        '
        'lblTongTien
        '
        Me.lblTongTien.AutoSize = True
        Me.lblTongTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTongTien.Location = New System.Drawing.Point(187, 119)
        Me.lblTongTien.Name = "lblTongTien"
        Me.lblTongTien.Size = New System.Drawing.Size(59, 13)
        Me.lblTongTien.TabIndex = 16
        Me.lblTongTien.Text = "Tổng Tiền:"
        '
        'lblTienThemGio
        '
        Me.lblTienThemGio.AutoSize = True
        Me.lblTienThemGio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTienThemGio.Location = New System.Drawing.Point(246, 119)
        Me.lblTienThemGio.Name = "lblTienThemGio"
        Me.lblTienThemGio.Size = New System.Drawing.Size(13, 13)
        Me.lblTienThemGio.TabIndex = 14
        Me.lblTienThemGio.Text = "0"
        '
        'txtThemGio
        '
        Me.txtThemGio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtThemGio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtThemGio.Location = New System.Drawing.Point(125, 116)
        Me.txtThemGio.Name = "txtThemGio"
        Me.txtThemGio.Size = New System.Drawing.Size(39, 20)
        Me.txtThemGio.TabIndex = 12
        '
        'lblThemGio
        '
        Me.lblThemGio.AutoSize = True
        Me.lblThemGio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblThemGio.Location = New System.Drawing.Point(30, 119)
        Me.lblThemGio.Name = "lblThemGio"
        Me.lblThemGio.Size = New System.Drawing.Size(54, 13)
        Me.lblThemGio.TabIndex = 13
        Me.lblThemGio.Text = "Thêm giờ:"
        '
        'txtPhuThu
        '
        Me.txtPhuThu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhuThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtPhuThu.Location = New System.Drawing.Point(125, 80)
        Me.txtPhuThu.Name = "txtPhuThu"
        Me.txtPhuThu.Size = New System.Drawing.Size(140, 20)
        Me.txtPhuThu.TabIndex = 10
        '
        'lblPhuThu
        '
        Me.lblPhuThu.AutoSize = True
        Me.lblPhuThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblPhuThu.Location = New System.Drawing.Point(30, 83)
        Me.lblPhuThu.Name = "lblPhuThu"
        Me.lblPhuThu.Size = New System.Drawing.Size(47, 13)
        Me.lblPhuThu.TabIndex = 11
        Me.lblPhuThu.Text = "Phụ thu:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(392, 37)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(140, 20)
        Me.txtDiaChi.TabIndex = 9
        '
        'txtTriGiaHoaDon
        '
        Me.txtTriGiaHoaDon.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTriGiaHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTriGiaHoaDon.Location = New System.Drawing.Point(392, 115)
        Me.txtTriGiaHoaDon.Name = "txtTriGiaHoaDon"
        Me.txtTriGiaHoaDon.ReadOnly = True
        Me.txtTriGiaHoaDon.Size = New System.Drawing.Size(140, 20)
        Me.txtTriGiaHoaDon.TabIndex = 8
        '
        'txtTenKhachHang
        '
        Me.txtTenKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenKhachHang.Location = New System.Drawing.Point(125, 37)
        Me.txtTenKhachHang.Name = "txtTenKhachHang"
        Me.txtTenKhachHang.Size = New System.Drawing.Size(140, 20)
        Me.txtTenKhachHang.TabIndex = 0
        '
        'lblTriGiaHoaDon
        '
        Me.lblTriGiaHoaDon.AutoSize = True
        Me.lblTriGiaHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTriGiaHoaDon.Location = New System.Drawing.Point(301, 118)
        Me.lblTriGiaHoaDon.Name = "lblTriGiaHoaDon"
        Me.lblTriGiaHoaDon.Size = New System.Drawing.Size(82, 13)
        Me.lblTriGiaHoaDon.TabIndex = 4
        Me.lblTriGiaHoaDon.Text = "Trị giá hóa đơn:"
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDiaChi.Location = New System.Drawing.Point(330, 40)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(43, 13)
        Me.lblDiaChi.TabIndex = 1
        Me.lblDiaChi.Text = "Địa chỉ:"
        '
        'lblTenKhachHang
        '
        Me.lblTenKhachHang.AutoSize = True
        Me.lblTenKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenKhachHang.Location = New System.Drawing.Point(30, 40)
        Me.lblTenKhachHang.Name = "lblTenKhachHang"
        Me.lblTenKhachHang.Size = New System.Drawing.Size(89, 13)
        Me.lblTenKhachHang.TabIndex = 0
        Me.lblTenKhachHang.Text = "Tên khách hàng:"
        '
        'cboTenKhuyenMai
        '
        Me.cboTenKhuyenMai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTenKhuyenMai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboTenKhuyenMai.FormattingEnabled = True
        Me.cboTenKhuyenMai.Location = New System.Drawing.Point(392, 75)
        Me.cboTenKhuyenMai.Name = "cboTenKhuyenMai"
        Me.cboTenKhuyenMai.Size = New System.Drawing.Size(140, 21)
        Me.cboTenKhuyenMai.TabIndex = 18
        '
        'lblKhuyenMai
        '
        Me.lblKhuyenMai.AutoSize = True
        Me.lblKhuyenMai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblKhuyenMai.Location = New System.Drawing.Point(317, 76)
        Me.lblKhuyenMai.Name = "lblKhuyenMai"
        Me.lblKhuyenMai.Size = New System.Drawing.Size(59, 13)
        Me.lblKhuyenMai.TabIndex = 17
        Me.lblKhuyenMai.Text = "Khyến mãi:"
        '
        'frmLapHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 448)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmLapHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lập Hóa Đơn Thanh Toán"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvDanhSachPhieuThue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDanhSachPhieuThue As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnLapHoaDon As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKhachHang As System.Windows.Forms.TextBox
    Friend WithEvents lblTriGiaHoaDon As System.Windows.Forms.Label
    Friend WithEvents lblDiaChi As System.Windows.Forms.Label
    Friend WithEvents lblTenKhachHang As System.Windows.Forms.Label
    Friend WithEvents MaPhieuThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoNgayThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGiaThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThanhTien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPhuThu As TextBox
    Friend WithEvents lblPhuThu As Label
    Friend WithEvents txtThemGio As TextBox
    Friend WithEvents lblThemGio As Label
    Friend WithEvents lblTienThemGio As Label
    Friend WithEvents lblTongTien As Label
    Friend WithEvents txtTriGiaHoaDon As TextBox
    Friend WithEvents cboTenKhuyenMai As ComboBox
    Friend WithEvents lblKhuyenMai As Label
End Class
