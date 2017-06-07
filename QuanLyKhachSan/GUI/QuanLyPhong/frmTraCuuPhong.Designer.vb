<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraCuuPhong
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhSachPhong = New System.Windows.Forms.DataGridView()
        Me.MaPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ngay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTinhTrang = New System.Windows.Forms.Label()
        Me.cboTinhTrang = New System.Windows.Forms.ComboBox()
        Me.cboDonGiaThue = New System.Windows.Forms.ComboBox()
        Me.txtTenPhong = New System.Windows.Forms.TextBox()
        Me.lblTenPhong = New System.Windows.Forms.Label()
        Me.lblTenLoaiPhong = New System.Windows.Forms.Label()
        Me.dtpNgayTraPhong = New System.Windows.Forms.DateTimePicker()
        Me.lblNgayTraPhong = New System.Windows.Forms.Label()
        Me.lblNgayBatDauThue = New System.Windows.Forms.Label()
        Me.dtpNgayBatDauThue = New System.Windows.Forms.DateTimePicker()
        Me.cboTenLoaiPhong = New System.Windows.Forms.ComboBox()
        Me.txtMaPhong = New System.Windows.Forms.TextBox()
        Me.lblMaPhong = New System.Windows.Forms.Label()
        Me.lblDonGiaThue = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDanhSachPhong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDanhSachPhong)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 318)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(809, 294)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách phòng"
        '
        'dgvDanhSachPhong
        '
        Me.dgvDanhSachPhong.AllowUserToAddRows = False
        Me.dgvDanhSachPhong.AllowUserToDeleteRows = False
        Me.dgvDanhSachPhong.AllowUserToOrderColumns = True
        Me.dgvDanhSachPhong.AllowUserToResizeColumns = False
        Me.dgvDanhSachPhong.AllowUserToResizeRows = False
        Me.dgvDanhSachPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPhong, Me.TenPhong, Me.LoaiPhong, Me.DonGiaThue, Me.TinhTrang, Me.Ngay})
        Me.dgvDanhSachPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSachPhong.Location = New System.Drawing.Point(5, 20)
        Me.dgvDanhSachPhong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDanhSachPhong.Name = "dgvDanhSachPhong"
        Me.dgvDanhSachPhong.ReadOnly = True
        Me.dgvDanhSachPhong.RowHeadersWidth = 10
        Me.dgvDanhSachPhong.Size = New System.Drawing.Size(799, 269)
        Me.dgvDanhSachPhong.TabIndex = 0
        '
        'MaPhong
        '
        Me.MaPhong.DataPropertyName = "MaPhong"
        Me.MaPhong.HeaderText = "Mã Phòng"
        Me.MaPhong.Name = "MaPhong"
        Me.MaPhong.ReadOnly = True
        '
        'TenPhong
        '
        Me.TenPhong.DataPropertyName = "TenPhong"
        Me.TenPhong.HeaderText = "Tên Phòng"
        Me.TenPhong.Name = "TenPhong"
        Me.TenPhong.ReadOnly = True
        '
        'LoaiPhong
        '
        Me.LoaiPhong.DataPropertyName = "TenLoaiPhong"
        Me.LoaiPhong.HeaderText = "Loại Phòng"
        Me.LoaiPhong.Name = "LoaiPhong"
        Me.LoaiPhong.ReadOnly = True
        '
        'DonGiaThue
        '
        Me.DonGiaThue.DataPropertyName = "DonGiaThue"
        Me.DonGiaThue.HeaderText = "Đơn Giá Thuê"
        Me.DonGiaThue.Name = "DonGiaThue"
        Me.DonGiaThue.ReadOnly = True
        '
        'TinhTrang
        '
        Me.TinhTrang.DataPropertyName = "LoaiTinhTrang"
        Me.TinhTrang.HeaderText = "Tình Trạng"
        Me.TinhTrang.Name = "TinhTrang"
        Me.TinhTrang.ReadOnly = True
        '
        'Ngay
        '
        Me.Ngay.DataPropertyName = "NgayCuaTinhTrang"
        Me.Ngay.HeaderText = "Ngày"
        Me.Ngay.Name = "Ngay"
        Me.Ngay.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTinhTrang)
        Me.GroupBox1.Controls.Add(Me.cboTinhTrang)
        Me.GroupBox1.Controls.Add(Me.cboDonGiaThue)
        Me.GroupBox1.Controls.Add(Me.txtTenPhong)
        Me.GroupBox1.Controls.Add(Me.lblTenPhong)
        Me.GroupBox1.Controls.Add(Me.lblTenLoaiPhong)
        Me.GroupBox1.Controls.Add(Me.dtpNgayTraPhong)
        Me.GroupBox1.Controls.Add(Me.lblNgayTraPhong)
        Me.GroupBox1.Controls.Add(Me.lblNgayBatDauThue)
        Me.GroupBox1.Controls.Add(Me.dtpNgayBatDauThue)
        Me.GroupBox1.Controls.Add(Me.cboTenLoaiPhong)
        Me.GroupBox1.Controls.Add(Me.txtMaPhong)
        Me.GroupBox1.Controls.Add(Me.lblMaPhong)
        Me.GroupBox1.Controls.Add(Me.lblDonGiaThue)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(809, 228)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRA CỨU PHÒNG"
        '
        'lblTinhTrang
        '
        Me.lblTinhTrang.AutoSize = True
        Me.lblTinhTrang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTinhTrang.Location = New System.Drawing.Point(84, 132)
        Me.lblTinhTrang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTinhTrang.Name = "lblTinhTrang"
        Me.lblTinhTrang.Size = New System.Drawing.Size(77, 17)
        Me.lblTinhTrang.TabIndex = 20
        Me.lblTinhTrang.Text = "Tình trạng:"
        '
        'cboTinhTrang
        '
        Me.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTinhTrang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboTinhTrang.FormattingEnabled = True
        Me.cboTinhTrang.Items.AddRange(New Object() {"TRONG", "DA THUE"})
        Me.cboTinhTrang.Location = New System.Drawing.Point(191, 128)
        Me.cboTinhTrang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTinhTrang.Name = "cboTinhTrang"
        Me.cboTinhTrang.Size = New System.Drawing.Size(185, 25)
        Me.cboTinhTrang.TabIndex = 19
        '
        'cboDonGiaThue
        '
        Me.cboDonGiaThue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDonGiaThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboDonGiaThue.FormattingEnabled = True
        Me.cboDonGiaThue.Location = New System.Drawing.Point(523, 82)
        Me.cboDonGiaThue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboDonGiaThue.Name = "cboDonGiaThue"
        Me.cboDonGiaThue.Size = New System.Drawing.Size(185, 25)
        Me.cboDonGiaThue.TabIndex = 18
        '
        'txtTenPhong
        '
        Me.txtTenPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenPhong.Location = New System.Drawing.Point(523, 42)
        Me.txtTenPhong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTenPhong.Name = "txtTenPhong"
        Me.txtTenPhong.Size = New System.Drawing.Size(185, 23)
        Me.txtTenPhong.TabIndex = 17
        '
        'lblTenPhong
        '
        Me.lblTenPhong.AutoSize = True
        Me.lblTenPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenPhong.Location = New System.Drawing.Point(432, 46)
        Me.lblTenPhong.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTenPhong.Name = "lblTenPhong"
        Me.lblTenPhong.Size = New System.Drawing.Size(81, 17)
        Me.lblTenPhong.TabIndex = 16
        Me.lblTenPhong.Text = "Tên phòng:"
        '
        'lblTenLoaiPhong
        '
        Me.lblTenLoaiPhong.AutoSize = True
        Me.lblTenLoaiPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenLoaiPhong.Location = New System.Drawing.Point(84, 87)
        Me.lblTenLoaiPhong.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTenLoaiPhong.Name = "lblTenLoaiPhong"
        Me.lblTenLoaiPhong.Size = New System.Drawing.Size(83, 17)
        Me.lblTenLoaiPhong.TabIndex = 15
        Me.lblTenLoaiPhong.Text = "Loại phòng:"
        '
        'dtpNgayTraPhong
        '
        Me.dtpNgayTraPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.dtpNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayTraPhong.Location = New System.Drawing.Point(523, 174)
        Me.dtpNgayTraPhong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpNgayTraPhong.Name = "dtpNgayTraPhong"
        Me.dtpNgayTraPhong.Size = New System.Drawing.Size(185, 23)
        Me.dtpNgayTraPhong.TabIndex = 14
        '
        'lblNgayTraPhong
        '
        Me.lblNgayTraPhong.AutoSize = True
        Me.lblNgayTraPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNgayTraPhong.Location = New System.Drawing.Point(404, 181)
        Me.lblNgayTraPhong.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNgayTraPhong.Name = "lblNgayTraPhong"
        Me.lblNgayTraPhong.Size = New System.Drawing.Size(110, 17)
        Me.lblNgayTraPhong.TabIndex = 13
        Me.lblNgayTraPhong.Text = "Ngày trả phòng:"
        '
        'lblNgayBatDauThue
        '
        Me.lblNgayBatDauThue.AutoSize = True
        Me.lblNgayBatDauThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNgayBatDauThue.Location = New System.Drawing.Point(415, 132)
        Me.lblNgayBatDauThue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNgayBatDauThue.Name = "lblNgayBatDauThue"
        Me.lblNgayBatDauThue.Size = New System.Drawing.Size(97, 17)
        Me.lblNgayBatDauThue.TabIndex = 12
        Me.lblNgayBatDauThue.Text = "Ngày bắt đầu:"
        '
        'dtpNgayBatDauThue
        '
        Me.dtpNgayBatDauThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.dtpNgayBatDauThue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayBatDauThue.Location = New System.Drawing.Point(523, 128)
        Me.dtpNgayBatDauThue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpNgayBatDauThue.Name = "dtpNgayBatDauThue"
        Me.dtpNgayBatDauThue.Size = New System.Drawing.Size(185, 23)
        Me.dtpNgayBatDauThue.TabIndex = 11
        '
        'cboTenLoaiPhong
        '
        Me.cboTenLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTenLoaiPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboTenLoaiPhong.FormattingEnabled = True
        Me.cboTenLoaiPhong.Location = New System.Drawing.Point(191, 84)
        Me.cboTenLoaiPhong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTenLoaiPhong.Name = "cboTenLoaiPhong"
        Me.cboTenLoaiPhong.Size = New System.Drawing.Size(185, 25)
        Me.cboTenLoaiPhong.TabIndex = 10
        '
        'txtMaPhong
        '
        Me.txtMaPhong.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaPhong.Location = New System.Drawing.Point(191, 42)
        Me.txtMaPhong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaPhong.Name = "txtMaPhong"
        Me.txtMaPhong.Size = New System.Drawing.Size(185, 23)
        Me.txtMaPhong.TabIndex = 0
        '
        'lblMaPhong
        '
        Me.lblMaPhong.AutoSize = True
        Me.lblMaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaPhong.Location = New System.Drawing.Point(91, 46)
        Me.lblMaPhong.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaPhong.Name = "lblMaPhong"
        Me.lblMaPhong.Size = New System.Drawing.Size(75, 17)
        Me.lblMaPhong.TabIndex = 3
        Me.lblMaPhong.Text = "Mã phòng:"
        '
        'lblDonGiaThue
        '
        Me.lblDonGiaThue.AutoSize = True
        Me.lblDonGiaThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDonGiaThue.Location = New System.Drawing.Point(420, 87)
        Me.lblDonGiaThue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDonGiaThue.Name = "lblDonGiaThue"
        Me.lblDonGiaThue.Size = New System.Drawing.Size(93, 17)
        Me.lblDonGiaThue.TabIndex = 1
        Me.lblDonGiaThue.Text = "Đơn giá thuê:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHuy)
        Me.GroupBox2.Controls.Add(Me.btnTim)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 250)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(809, 60)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'btnHuy
        '
        Me.btnHuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnHuy.Location = New System.Drawing.Point(544, 18)
        Me.btnHuy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(120, 28)
        Me.btnHuy.TabIndex = 6
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnTim
        '
        Me.btnTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnTim.Location = New System.Drawing.Point(136, 18)
        Me.btnTim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(120, 28)
        Me.btnTim.TabIndex = 5
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'frmTraCuuPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 626)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmTraCuuPhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTraCuuPhong"
        Me.GroupBox3.ResumeLayout(false)
        CType(Me.dgvDanhSachPhong,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTenLoaiPhong As System.Windows.Forms.Label
    Friend WithEvents dtpNgayTraPhong As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNgayTraPhong As System.Windows.Forms.Label
    Friend WithEvents lblNgayBatDauThue As System.Windows.Forms.Label
    Friend WithEvents dtpNgayBatDauThue As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTenLoaiPhong As System.Windows.Forms.ComboBox
    Friend WithEvents txtMaPhong As System.Windows.Forms.TextBox
    Friend WithEvents lblMaPhong As System.Windows.Forms.Label
    Friend WithEvents lblDonGiaThue As System.Windows.Forms.Label
    Friend WithEvents cboDonGiaThue As System.Windows.Forms.ComboBox
    Friend WithEvents txtTenPhong As System.Windows.Forms.TextBox
    Friend WithEvents lblTenPhong As System.Windows.Forms.Label
    Friend WithEvents lblTinhTrang As System.Windows.Forms.Label
    Friend WithEvents cboTinhTrang As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents dgvDanhSachPhong As System.Windows.Forms.DataGridView
    Friend WithEvents MaPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGiaThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TinhTrang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
