<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapPhieuThuePhong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpNgayKetThuc = New System.Windows.Forms.DateTimePicker()
        Me.lblNgayKetThuc = New System.Windows.Forms.Label()
        Me.lblNgayBatDau = New System.Windows.Forms.Label()
        Me.dtpNgayBatDau = New System.Windows.Forms.DateTimePicker()
        Me.cboMaPhong = New System.Windows.Forms.ComboBox()
        Me.txtDonGiaThue = New System.Windows.Forms.TextBox()
        Me.txtTenPhong = New System.Windows.Forms.TextBox()
        Me.txtMaPhieuThue = New System.Windows.Forms.TextBox()
        Me.lblTenPhong = New System.Windows.Forms.Label()
        Me.lblMaPhong = New System.Windows.Forms.Label()
        Me.lblDonGiaThue = New System.Windows.Forms.Label()
        Me.lblMaPhieuThue = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhSachKhachThue = New System.Windows.Forms.DataGridView()
        Me.TenKhachHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaiKhach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvTrangThaiPhong = New System.Windows.Forms.DataGridView()
        Me.TenPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ngay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDanhSachKhachThue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvTrangThaiPhong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpNgayKetThuc)
        Me.GroupBox1.Controls.Add(Me.lblNgayKetThuc)
        Me.GroupBox1.Controls.Add(Me.lblNgayBatDau)
        Me.GroupBox1.Controls.Add(Me.dtpNgayBatDau)
        Me.GroupBox1.Controls.Add(Me.cboMaPhong)
        Me.GroupBox1.Controls.Add(Me.txtDonGiaThue)
        Me.GroupBox1.Controls.Add(Me.txtTenPhong)
        Me.GroupBox1.Controls.Add(Me.txtMaPhieuThue)
        Me.GroupBox1.Controls.Add(Me.lblTenPhong)
        Me.GroupBox1.Controls.Add(Me.lblMaPhong)
        Me.GroupBox1.Controls.Add(Me.lblDonGiaThue)
        Me.GroupBox1.Controls.Add(Me.lblMaPhieuThue)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 147)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LẬP DANH PHIẾU THUÊ PHÒNG"
        '
        'dtpNgayKetThuc
        '
        Me.dtpNgayKetThuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayKetThuc.Location = New System.Drawing.Point(392, 104)
        Me.dtpNgayKetThuc.Name = "dtpNgayKetThuc"
        Me.dtpNgayKetThuc.Size = New System.Drawing.Size(140, 20)
        Me.dtpNgayKetThuc.TabIndex = 14
        '
        'lblNgayKetThuc
        '
        Me.lblNgayKetThuc.AutoSize = True
        Me.lblNgayKetThuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNgayKetThuc.Location = New System.Drawing.Point(311, 107)
        Me.lblNgayKetThuc.Name = "lblNgayKetThuc"
        Me.lblNgayKetThuc.Size = New System.Drawing.Size(77, 13)
        Me.lblNgayKetThuc.TabIndex = 13
        Me.lblNgayKetThuc.Text = "Ngày kết thúc:"
        '
        'lblNgayBatDau
        '
        Me.lblNgayBatDau.AutoSize = True
        Me.lblNgayBatDau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNgayBatDau.Location = New System.Drawing.Point(51, 107)
        Me.lblNgayBatDau.Name = "lblNgayBatDau"
        Me.lblNgayBatDau.Size = New System.Drawing.Size(75, 13)
        Me.lblNgayBatDau.TabIndex = 12
        Me.lblNgayBatDau.Text = "Ngày bắt đầu:"
        '
        'dtpNgayBatDau
        '
        Me.dtpNgayBatDau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayBatDau.Location = New System.Drawing.Point(143, 104)
        Me.dtpNgayBatDau.Name = "dtpNgayBatDau"
        Me.dtpNgayBatDau.Size = New System.Drawing.Size(140, 20)
        Me.dtpNgayBatDau.TabIndex = 11
        '
        'cboMaPhong
        '
        Me.cboMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboMaPhong.FormattingEnabled = True
        Me.cboMaPhong.Location = New System.Drawing.Point(143, 68)
        Me.cboMaPhong.Name = "cboMaPhong"
        Me.cboMaPhong.Size = New System.Drawing.Size(140, 21)
        Me.cboMaPhong.TabIndex = 10
        '
        'txtDonGiaThue
        '
        Me.txtDonGiaThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDonGiaThue.Location = New System.Drawing.Point(392, 31)
        Me.txtDonGiaThue.Name = "txtDonGiaThue"
        Me.txtDonGiaThue.ReadOnly = True
        Me.txtDonGiaThue.Size = New System.Drawing.Size(140, 20)
        Me.txtDonGiaThue.TabIndex = 9
        '
        'txtTenPhong
        '
        Me.txtTenPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenPhong.Location = New System.Drawing.Point(392, 68)
        Me.txtTenPhong.Name = "txtTenPhong"
        Me.txtTenPhong.Size = New System.Drawing.Size(140, 20)
        Me.txtTenPhong.TabIndex = 8
        '
        'txtMaPhieuThue
        '
        Me.txtMaPhieuThue.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtMaPhieuThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaPhieuThue.Location = New System.Drawing.Point(143, 34)
        Me.txtMaPhieuThue.Name = "txtMaPhieuThue"
        Me.txtMaPhieuThue.ReadOnly = True
        Me.txtMaPhieuThue.Size = New System.Drawing.Size(140, 20)
        Me.txtMaPhieuThue.TabIndex = 0
        '
        'lblTenPhong
        '
        Me.lblTenPhong.AutoSize = True
        Me.lblTenPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenPhong.Location = New System.Drawing.Point(324, 71)
        Me.lblTenPhong.Name = "lblTenPhong"
        Me.lblTenPhong.Size = New System.Drawing.Size(62, 13)
        Me.lblTenPhong.TabIndex = 4
        Me.lblTenPhong.Text = "Tên phòng:"
        '
        'lblMaPhong
        '
        Me.lblMaPhong.AutoSize = True
        Me.lblMaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaPhong.Location = New System.Drawing.Point(68, 71)
        Me.lblMaPhong.Name = "lblMaPhong"
        Me.lblMaPhong.Size = New System.Drawing.Size(58, 13)
        Me.lblMaPhong.TabIndex = 3
        Me.lblMaPhong.Text = "Mã phòng:"
        '
        'lblDonGiaThue
        '
        Me.lblDonGiaThue.AutoSize = True
        Me.lblDonGiaThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDonGiaThue.Location = New System.Drawing.Point(317, 34)
        Me.lblDonGiaThue.Name = "lblDonGiaThue"
        Me.lblDonGiaThue.Size = New System.Drawing.Size(71, 13)
        Me.lblDonGiaThue.TabIndex = 1
        Me.lblDonGiaThue.Text = "Đơn giá thuê:"
        '
        'lblMaPhieuThue
        '
        Me.lblMaPhieuThue.AutoSize = True
        Me.lblMaPhieuThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaPhieuThue.Location = New System.Drawing.Point(48, 37)
        Me.lblMaPhieuThue.Name = "lblMaPhieuThue"
        Me.lblMaPhieuThue.Size = New System.Drawing.Size(78, 13)
        Me.lblMaPhieuThue.TabIndex = 0
        Me.lblMaPhieuThue.Text = "Mã phiếu thuê:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHuy)
        Me.GroupBox2.Controls.Add(Me.btnLuu)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 281)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 49)
        Me.GroupBox2.TabIndex = 3
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
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLuu.Location = New System.Drawing.Point(102, 15)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(90, 23)
        Me.btnLuu.TabIndex = 5
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDanhSachKhachThue)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 164)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.GroupBox3.Size = New System.Drawing.Size(607, 110)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách khách thuê"
        '
        'dgvDanhSachKhachThue
        '
        Me.dgvDanhSachKhachThue.AllowUserToDeleteRows = False
        Me.dgvDanhSachKhachThue.AllowUserToResizeColumns = False
        Me.dgvDanhSachKhachThue.AllowUserToResizeRows = False
        Me.dgvDanhSachKhachThue.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvDanhSachKhachThue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDanhSachKhachThue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDanhSachKhachThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachKhachThue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TenKhachHang, Me.LoaiKhach, Me.CMND, Me.DiaChi})
        Me.dgvDanhSachKhachThue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSachKhachThue.Location = New System.Drawing.Point(0, 17)
        Me.dgvDanhSachKhachThue.MultiSelect = False
        Me.dgvDanhSachKhachThue.Name = "dgvDanhSachKhachThue"
        Me.dgvDanhSachKhachThue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDanhSachKhachThue.RowHeadersVisible = False
        Me.dgvDanhSachKhachThue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDanhSachKhachThue.Size = New System.Drawing.Size(607, 93)
        Me.dgvDanhSachKhachThue.TabIndex = 0
        '
        'TenKhachHang
        '
        Me.TenKhachHang.DataPropertyName = "TenKhachHang"
        Me.TenKhachHang.HeaderText = "Tên Khách Hàng"
        Me.TenKhachHang.Name = "TenKhachHang"
        Me.TenKhachHang.Width = 150
        '
        'LoaiKhach
        '
        Me.LoaiKhach.DataPropertyName = "LoaiKhach"
        Me.LoaiKhach.HeaderText = "Loại Khách"
        Me.LoaiKhach.Name = "LoaiKhach"
        Me.LoaiKhach.Width = 150
        '
        'CMND
        '
        Me.CMND.DataPropertyName = "CMND"
        Me.CMND.HeaderText = "CMND"
        Me.CMND.Name = "CMND"
        Me.CMND.Width = 150
        '
        'DiaChi
        '
        Me.DiaChi.DataPropertyName = "DiaChi"
        Me.DiaChi.HeaderText = "Địa Chỉ"
        Me.DiaChi.Name = "DiaChi"
        Me.DiaChi.Width = 154
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvTrangThaiPhong)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 336)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.GroupBox4.Size = New System.Drawing.Size(607, 161)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Trạng thái phòng"
        '
        'dgvTrangThaiPhong
        '
        Me.dgvTrangThaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrangThaiPhong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TenPhong, Me.Ngay, Me.TinhTrang, Me.DonGia})
        Me.dgvTrangThaiPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTrangThaiPhong.Location = New System.Drawing.Point(0, 17)
        Me.dgvTrangThaiPhong.Name = "dgvTrangThaiPhong"
        Me.dgvTrangThaiPhong.RowHeadersVisible = False
        Me.dgvTrangThaiPhong.Size = New System.Drawing.Size(607, 144)
        Me.dgvTrangThaiPhong.TabIndex = 0
        '
        'TenPhong
        '
        Me.TenPhong.HeaderText = "Tên Phòng"
        Me.TenPhong.Name = "TenPhong"
        Me.TenPhong.Width = 150
        '
        'Ngay
        '
        Me.Ngay.HeaderText = "Ngày"
        Me.Ngay.Name = "Ngay"
        Me.Ngay.Width = 150
        '
        'TinhTrang
        '
        Me.TinhTrang.HeaderText = "Tình Trạng"
        Me.TinhTrang.Name = "TinhTrang"
        Me.TinhTrang.Width = 150
        '
        'DonGia
        '
        Me.DonGia.HeaderText = "Đơn Giá"
        Me.DonGia.Name = "DonGia"
        Me.DonGia.Width = 154
        '
        'frmLapPhieuThuePhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 509)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLapPhieuThuePhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmLapPhieuThuePhong"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDanhSachKhachThue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvTrangThaiPhong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMaPhong As System.Windows.Forms.ComboBox
    Friend WithEvents txtDonGiaThue As System.Windows.Forms.TextBox
    Friend WithEvents txtTenPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtMaPhieuThue As System.Windows.Forms.TextBox
    Friend WithEvents lblTenPhong As System.Windows.Forms.Label
    Friend WithEvents lblMaPhong As System.Windows.Forms.Label
    Friend WithEvents lblDonGiaThue As System.Windows.Forms.Label
    Friend WithEvents lblMaPhieuThue As System.Windows.Forms.Label
    Friend WithEvents dtpNgayKetThuc As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNgayKetThuc As System.Windows.Forms.Label
    Friend WithEvents lblNgayBatDau As System.Windows.Forms.Label
    Friend WithEvents dtpNgayBatDau As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDanhSachKhachThue As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTrangThaiPhong As System.Windows.Forms.DataGridView
    Friend WithEvents TenPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TinhTrang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenKhachHang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoaiKhach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
