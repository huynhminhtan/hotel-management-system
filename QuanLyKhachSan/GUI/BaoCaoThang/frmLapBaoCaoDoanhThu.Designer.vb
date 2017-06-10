<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapBaoCaoDoanhThu
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvBaoCao = New System.Windows.Forms.DataGridView()
        Me.MaLoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoanhThuLoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiLeDoanhThu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnLapBaoCao = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpThang = New System.Windows.Forms.DateTimePicker()
        Me.txtTongDoanhThu = New System.Windows.Forms.TextBox()
        Me.lblTongDoanhThu = New System.Windows.Forms.Label()
        Me.lblThang = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvBaoCao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvBaoCao)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 251)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox4.Size = New System.Drawing.Size(809, 255)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Chi tiết báo cáo"
        '
        'dgvBaoCao
        '
        Me.dgvBaoCao.AllowUserToAddRows = False
        Me.dgvBaoCao.AllowUserToDeleteRows = False
        Me.dgvBaoCao.AllowUserToResizeColumns = False
        Me.dgvBaoCao.AllowUserToResizeRows = False
        Me.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaLoaiPhong, Me.TenLoaiPhong, Me.DonGiaThue, Me.DoanhThuLoaiPhong, Me.TiLeDoanhThu})
        Me.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBaoCao.Location = New System.Drawing.Point(5, 20)
        Me.dgvBaoCao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvBaoCao.Name = "dgvBaoCao"
        Me.dgvBaoCao.ReadOnly = True
        Me.dgvBaoCao.RowHeadersVisible = False
        Me.dgvBaoCao.RowTemplate.Height = 24
        Me.dgvBaoCao.Size = New System.Drawing.Size(799, 230)
        Me.dgvBaoCao.TabIndex = 0
        '
        'MaLoaiPhong
        '
        Me.MaLoaiPhong.DataPropertyName = "MaLoaiPhong"
        Me.MaLoaiPhong.HeaderText = "Mã Loại Phòng"
        Me.MaLoaiPhong.Name = "MaLoaiPhong"
        Me.MaLoaiPhong.ReadOnly = True
        '
        'TenLoaiPhong
        '
        Me.TenLoaiPhong.DataPropertyName = "TenLoaiPhong"
        Me.TenLoaiPhong.HeaderText = "Tên Loại Phòng"
        Me.TenLoaiPhong.Name = "TenLoaiPhong"
        Me.TenLoaiPhong.ReadOnly = True
        '
        'DonGiaThue
        '
        Me.DonGiaThue.DataPropertyName = "DonGiaThue"
        Me.DonGiaThue.HeaderText = "Đơn Giá Thuê"
        Me.DonGiaThue.Name = "DonGiaThue"
        Me.DonGiaThue.ReadOnly = True
        '
        'DoanhThuLoaiPhong
        '
        Me.DoanhThuLoaiPhong.DataPropertyName = "DoanhThuLoaiPhong"
        Me.DoanhThuLoaiPhong.HeaderText = "Doanh Thu "
        Me.DoanhThuLoaiPhong.Name = "DoanhThuLoaiPhong"
        Me.DoanhThuLoaiPhong.ReadOnly = True
        '
        'TiLeDoanhThu
        '
        Me.TiLeDoanhThu.DataPropertyName = "TiLeDoanhThu"
        Me.TiLeDoanhThu.HeaderText = "Tỉ Lệ Doanh Thu"
        Me.TiLeDoanhThu.Name = "TiLeDoanhThu"
        Me.TiLeDoanhThu.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHuy)
        Me.GroupBox2.Controls.Add(Me.btnLapBaoCao)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 167)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(809, 60)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'btnHuy
        '
        Me.btnHuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnHuy.Location = New System.Drawing.Point(544, 18)
        Me.btnHuy.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(120, 28)
        Me.btnHuy.TabIndex = 6
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnLapBaoCao
        '
        Me.btnLapBaoCao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLapBaoCao.Location = New System.Drawing.Point(136, 18)
        Me.btnLapBaoCao.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLapBaoCao.Name = "btnLapBaoCao"
        Me.btnLapBaoCao.Size = New System.Drawing.Size(120, 28)
        Me.btnLapBaoCao.TabIndex = 5
        Me.btnLapBaoCao.Text = "Lập báo cáo"
        Me.btnLapBaoCao.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpThang)
        Me.GroupBox1.Controls.Add(Me.txtTongDoanhThu)
        Me.GroupBox1.Controls.Add(Me.lblTongDoanhThu)
        Me.GroupBox1.Controls.Add(Me.lblThang)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(809, 145)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BÁO CÁO DOANH THU THEO LOẠI PHÒNG"
        '
        'dtpThang
        '
        Me.dtpThang.CustomFormat = "MM/yyyy"
        Me.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThang.Location = New System.Drawing.Point(141, 66)
        Me.dtpThang.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpThang.Name = "dtpThang"
        Me.dtpThang.Size = New System.Drawing.Size(169, 26)
        Me.dtpThang.TabIndex = 9
        '
        'txtTongDoanhThu
        '
        Me.txtTongDoanhThu.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTongDoanhThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTongDoanhThu.Location = New System.Drawing.Point(531, 66)
        Me.txtTongDoanhThu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTongDoanhThu.Name = "txtTongDoanhThu"
        Me.txtTongDoanhThu.ReadOnly = True
        Me.txtTongDoanhThu.Size = New System.Drawing.Size(185, 23)
        Me.txtTongDoanhThu.TabIndex = 8
        '
        'lblTongDoanhThu
        '
        Me.lblTongDoanhThu.AutoSize = True
        Me.lblTongDoanhThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTongDoanhThu.Location = New System.Drawing.Point(409, 70)
        Me.lblTongDoanhThu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTongDoanhThu.Name = "lblTongDoanhThu"
        Me.lblTongDoanhThu.Size = New System.Drawing.Size(113, 17)
        Me.lblTongDoanhThu.TabIndex = 4
        Me.lblTongDoanhThu.Text = "Tổng doanh thu:"
        '
        'lblThang
        '
        Me.lblThang.AutoSize = True
        Me.lblThang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblThang.Location = New System.Drawing.Point(79, 73)
        Me.lblThang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThang.Name = "lblThang"
        Me.lblThang.Size = New System.Drawing.Size(53, 17)
        Me.lblThang.TabIndex = 0
        Me.lblThang.Text = "Tháng:"
        '
        'frmLapBaoCaoDoanhThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 521)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLapBaoCaoDoanhThu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Báo Cáo Tháng Theo Doanh Thu Loại Phòng"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvBaoCao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnLapBaoCao As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpThang As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTongDoanhThu As System.Windows.Forms.TextBox
    Friend WithEvents lblTongDoanhThu As System.Windows.Forms.Label
    Friend WithEvents lblThang As System.Windows.Forms.Label
    Friend WithEvents dgvBaoCao As System.Windows.Forms.DataGridView
    Friend WithEvents MaLoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenLoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGiaThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoanhThuLoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiLeDoanhThu As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
