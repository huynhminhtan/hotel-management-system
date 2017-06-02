<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapHoaDon
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
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtTraGiaHoaDon = New System.Windows.Forms.TextBox()
        Me.txtTenKhachHang = New System.Windows.Forms.TextBox()
        Me.lblTriGiaHoaDon = New System.Windows.Forms.Label()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.lblTenKhachHang = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvDanhSachPhieuThue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvDanhSachPhieuThue)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 204)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(607, 207)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Danh sách phiếu thuê"
        '
        'dgvDanhSachPhieuThue
        '
        Me.dgvDanhSachPhieuThue.AllowUserToResizeColumns = False
        Me.dgvDanhSachPhieuThue.AllowUserToResizeRows = False
        Me.dgvDanhSachPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDanhSachPhieuThue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDanhSachPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhieuThue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPhieuThue, Me.TenPhong, Me.SoNgayThue, Me.DonGiaThue, Me.ThanhTien})
        Me.dgvDanhSachPhieuThue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSachPhieuThue.Location = New System.Drawing.Point(4, 17)
        Me.dgvDanhSachPhieuThue.Name = "dgvDanhSachPhieuThue"
        Me.dgvDanhSachPhieuThue.RowHeadersWidth = 15
        Me.dgvDanhSachPhieuThue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDanhSachPhieuThue.Size = New System.Drawing.Size(599, 186)
        Me.dgvDanhSachPhieuThue.TabIndex = 0
        '
        'MaPhieuThue
        '
        Me.MaPhieuThue.DataPropertyName = "MaPhieuThue"
        Me.MaPhieuThue.HeaderText = "Mã Phiếu Thuê"
        Me.MaPhieuThue.Name = "MaPhieuThue"
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
        Me.GroupBox2.Location = New System.Drawing.Point(16, 149)
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
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtTraGiaHoaDon)
        Me.GroupBox1.Controls.Add(Me.txtTenKhachHang)
        Me.GroupBox1.Controls.Add(Me.lblTriGiaHoaDon)
        Me.GroupBox1.Controls.Add(Me.lblDiaChi)
        Me.GroupBox1.Controls.Add(Me.lblTenKhachHang)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 131)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LẬP HÓA ĐƠN THANH TOÁN"
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
        'txtTraGiaHoaDon
        '
        Me.txtTraGiaHoaDon.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTraGiaHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTraGiaHoaDon.Location = New System.Drawing.Point(392, 80)
        Me.txtTraGiaHoaDon.Name = "txtTraGiaHoaDon"
        Me.txtTraGiaHoaDon.ReadOnly = True
        Me.txtTraGiaHoaDon.Size = New System.Drawing.Size(140, 20)
        Me.txtTraGiaHoaDon.TabIndex = 8
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
        Me.lblTriGiaHoaDon.Location = New System.Drawing.Point(301, 83)
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
        'frmLapHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 423)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLapHoaDon"
        Me.Text = "frmLapHoaDon"
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
    Friend WithEvents txtTraGiaHoaDon As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKhachHang As System.Windows.Forms.TextBox
    Friend WithEvents lblTriGiaHoaDon As System.Windows.Forms.Label
    Friend WithEvents lblDiaChi As System.Windows.Forms.Label
    Friend WithEvents lblTenKhachHang As System.Windows.Forms.Label
    Friend WithEvents MaPhieuThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoNgayThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGiaThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThanhTien As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
