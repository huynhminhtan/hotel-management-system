<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHuyPhong
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTenPhong = New System.Windows.Forms.TextBox()
        Me.txtMaPhong = New System.Windows.Forms.TextBox()
        Me.lblTenPhong = New System.Windows.Forms.Label()
        Me.lblMaPhong = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHuyPhong = New System.Windows.Forms.Button()
        Me.btntThoat = New System.Windows.Forms.Button()
        Me.btnTimPhong = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhSachPhong = New System.Windows.Forms.DataGridView()
        Me.MaPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ngay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDanhSachPhong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTenPhong)
        Me.GroupBox1.Controls.Add(Me.txtMaPhong)
        Me.GroupBox1.Controls.Add(Me.lblTenPhong)
        Me.GroupBox1.Controls.Add(Me.lblMaPhong)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 107)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HỦY PHÒNG"
        '
        'txtTenPhong
        '
        Me.txtTenPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenPhong.Location = New System.Drawing.Point(385, 46)
        Me.txtTenPhong.Name = "txtTenPhong"
        Me.txtTenPhong.Size = New System.Drawing.Size(140, 20)
        Me.txtTenPhong.TabIndex = 8
        '
        'txtMaPhong
        '
        Me.txtMaPhong.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaPhong.Location = New System.Drawing.Point(126, 46)
        Me.txtMaPhong.Name = "txtMaPhong"
        Me.txtMaPhong.Size = New System.Drawing.Size(140, 20)
        Me.txtMaPhong.TabIndex = 5
        '
        'lblTenPhong
        '
        Me.lblTenPhong.AutoSize = True
        Me.lblTenPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenPhong.Location = New System.Drawing.Point(317, 49)
        Me.lblTenPhong.Name = "lblTenPhong"
        Me.lblTenPhong.Size = New System.Drawing.Size(62, 13)
        Me.lblTenPhong.TabIndex = 3
        Me.lblTenPhong.Text = "Tên phòng:"
        '
        'lblMaPhong
        '
        Me.lblMaPhong.AutoSize = True
        Me.lblMaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaPhong.Location = New System.Drawing.Point(62, 49)
        Me.lblMaPhong.Name = "lblMaPhong"
        Me.lblMaPhong.Size = New System.Drawing.Size(58, 13)
        Me.lblMaPhong.TabIndex = 0
        Me.lblMaPhong.Text = "Mã phòng:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHuyPhong)
        Me.GroupBox2.Controls.Add(Me.btntThoat)
        Me.GroupBox2.Controls.Add(Me.btnTimPhong)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 49)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'btnHuyPhong
        '
        Me.btnHuyPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnHuyPhong.Location = New System.Drawing.Point(255, 15)
        Me.btnHuyPhong.Name = "btnHuyPhong"
        Me.btnHuyPhong.Size = New System.Drawing.Size(90, 23)
        Me.btnHuyPhong.TabIndex = 7
        Me.btnHuyPhong.Text = "Hủy phòng"
        Me.btnHuyPhong.UseVisualStyleBackColor = True
        '
        'btntThoat
        '
        Me.btntThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btntThoat.Location = New System.Drawing.Point(408, 15)
        Me.btntThoat.Name = "btntThoat"
        Me.btntThoat.Size = New System.Drawing.Size(90, 23)
        Me.btntThoat.TabIndex = 6
        Me.btntThoat.Text = "Thoát"
        Me.btntThoat.UseVisualStyleBackColor = True
        '
        'btnTimPhong
        '
        Me.btnTimPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnTimPhong.Location = New System.Drawing.Point(102, 15)
        Me.btnTimPhong.Name = "btnTimPhong"
        Me.btnTimPhong.Size = New System.Drawing.Size(90, 23)
        Me.btnTimPhong.TabIndex = 5
        Me.btnTimPhong.Text = "Tìm phòng"
        Me.btnTimPhong.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDanhSachPhong)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 192)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(607, 239)
        Me.GroupBox3.TabIndex = 9
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
        Me.dgvDanhSachPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDanhSachPhong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPhong, Me.TenPhong, Me.LoaiPhong, Me.DonGiaThue, Me.TinhTrang, Me.Ngay})
        Me.dgvDanhSachPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSachPhong.Location = New System.Drawing.Point(4, 17)
        Me.dgvDanhSachPhong.Name = "dgvDanhSachPhong"
        Me.dgvDanhSachPhong.ReadOnly = True
        Me.dgvDanhSachPhong.RowHeadersVisible = False
        Me.dgvDanhSachPhong.RowHeadersWidth = 10
        Me.dgvDanhSachPhong.Size = New System.Drawing.Size(599, 218)
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
        'frmHuyPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 453)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmHuyPhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHuyPhong"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDanhSachPhong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTenPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtMaPhong As System.Windows.Forms.TextBox
    Friend WithEvents lblTenPhong As System.Windows.Forms.Label
    Friend WithEvents lblMaPhong As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHuyPhong As System.Windows.Forms.Button
    Friend WithEvents btntThoat As System.Windows.Forms.Button
    Friend WithEvents btnTimPhong As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDanhSachPhong As System.Windows.Forms.DataGridView
    Friend WithEvents MaPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGiaThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TinhTrang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
