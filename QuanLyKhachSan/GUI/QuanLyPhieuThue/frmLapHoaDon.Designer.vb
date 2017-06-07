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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.txtTriGiaHoaDon = New System.Windows.Forms.TextBox()
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
        Me.GroupBox4.Location = New System.Drawing.Point(16, 251)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(809, 255)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Danh sách phiếu thuê"
        '
        'dgvDanhSachPhieuThue
        '
        Me.dgvDanhSachPhieuThue.AllowUserToResizeColumns = False
        Me.dgvDanhSachPhieuThue.AllowUserToResizeRows = False
        Me.dgvDanhSachPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDanhSachPhieuThue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDanhSachPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhieuThue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPhieuThue, Me.TenPhong, Me.SoNgayThue, Me.DonGiaThue, Me.ThanhTien})
        Me.dgvDanhSachPhieuThue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSachPhieuThue.Location = New System.Drawing.Point(5, 20)
        Me.dgvDanhSachPhieuThue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDanhSachPhieuThue.Name = "dgvDanhSachPhieuThue"
        Me.dgvDanhSachPhieuThue.RowHeadersWidth = 15
        Me.dgvDanhSachPhieuThue.Size = New System.Drawing.Size(799, 230)
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
        Me.GroupBox2.Location = New System.Drawing.Point(21, 183)
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
        'btnLapHoaDon
        '
        Me.btnLapHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLapHoaDon.Location = New System.Drawing.Point(136, 18)
        Me.btnLapHoaDon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLapHoaDon.Name = "btnLapHoaDon"
        Me.btnLapHoaDon.Size = New System.Drawing.Size(120, 28)
        Me.btnLapHoaDon.TabIndex = 5
        Me.btnLapHoaDon.Text = "Lập hóa đơn"
        Me.btnLapHoaDon.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtTriGiaHoaDon)
        Me.GroupBox1.Controls.Add(Me.txtTenKhachHang)
        Me.GroupBox1.Controls.Add(Me.lblTriGiaHoaDon)
        Me.GroupBox1.Controls.Add(Me.lblDiaChi)
        Me.GroupBox1.Controls.Add(Me.lblTenKhachHang)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(809, 161)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LẬP HÓA ĐƠN THANH TOÁN"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(523, 46)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(185, 23)
        Me.txtDiaChi.TabIndex = 9
        '
        'txtTriGiaHoaDon
        '
        Me.txtTriGiaHoaDon.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTriGiaHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTriGiaHoaDon.Location = New System.Drawing.Point(523, 98)
        Me.txtTriGiaHoaDon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTriGiaHoaDon.Name = "txtTriGiaHoaDon"
        Me.txtTriGiaHoaDon.ReadOnly = True
        Me.txtTriGiaHoaDon.Size = New System.Drawing.Size(185, 23)
        Me.txtTriGiaHoaDon.TabIndex = 8
        '
        'txtTenKhachHang
        '
        Me.txtTenKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenKhachHang.Location = New System.Drawing.Point(167, 46)
        Me.txtTenKhachHang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTenKhachHang.Name = "txtTenKhachHang"
        Me.txtTenKhachHang.Size = New System.Drawing.Size(185, 23)
        Me.txtTenKhachHang.TabIndex = 0
        '
        'lblTriGiaHoaDon
        '
        Me.lblTriGiaHoaDon.AutoSize = True
        Me.lblTriGiaHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTriGiaHoaDon.Location = New System.Drawing.Point(401, 102)
        Me.lblTriGiaHoaDon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTriGiaHoaDon.Name = "lblTriGiaHoaDon"
        Me.lblTriGiaHoaDon.Size = New System.Drawing.Size(108, 17)
        Me.lblTriGiaHoaDon.TabIndex = 4
        Me.lblTriGiaHoaDon.Text = "Trị giá hóa đơn:"
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDiaChi.Location = New System.Drawing.Point(440, 49)
        Me.lblDiaChi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(55, 17)
        Me.lblDiaChi.TabIndex = 1
        Me.lblDiaChi.Text = "Địa chỉ:"
        '
        'lblTenKhachHang
        '
        Me.lblTenKhachHang.AutoSize = True
        Me.lblTenKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenKhachHang.Location = New System.Drawing.Point(40, 49)
        Me.lblTenKhachHang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTenKhachHang.Name = "lblTenKhachHang"
        Me.lblTenKhachHang.Size = New System.Drawing.Size(115, 17)
        Me.lblTenKhachHang.TabIndex = 0
        Me.lblTenKhachHang.Text = "Tên khách hàng:"
        '
        'frmLapHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 521)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmLapHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLapHoaDon"
        Me.GroupBox4.ResumeLayout(false)
        CType(Me.dgvDanhSachPhieuThue,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDanhSachPhieuThue As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnLapHoaDon As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtTriGiaHoaDon As System.Windows.Forms.TextBox
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
