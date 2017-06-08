<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemLoaiPhong
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
        Me.txtTenLoaiPhong = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDonGiaThue = New System.Windows.Forms.TextBox()
        Me.lblDonGiaThue = New System.Windows.Forms.Label()
        Me.lblTenLoaiPhong = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btntThoat = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhSachLoaiPhong = New System.Windows.Forms.DataGridView()
        Me.MaLoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDanhSachLoaiPhong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTenLoaiPhong
        '
        Me.txtTenLoaiPhong.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenLoaiPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenLoaiPhong.Location = New System.Drawing.Point(143, 46)
        Me.txtTenLoaiPhong.Name = "txtTenLoaiPhong"
        Me.txtTenLoaiPhong.Size = New System.Drawing.Size(140, 20)
        Me.txtTenLoaiPhong.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDonGiaThue)
        Me.GroupBox1.Controls.Add(Me.lblDonGiaThue)
        Me.GroupBox1.Controls.Add(Me.txtTenLoaiPhong)
        Me.GroupBox1.Controls.Add(Me.lblTenLoaiPhong)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 102)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thêm Loại Phòng"
        '
        'txtDonGiaThue
        '
        Me.txtDonGiaThue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDonGiaThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDonGiaThue.Location = New System.Drawing.Point(393, 46)
        Me.txtDonGiaThue.Name = "txtDonGiaThue"
        Me.txtDonGiaThue.Size = New System.Drawing.Size(140, 20)
        Me.txtDonGiaThue.TabIndex = 7
        '
        'lblDonGiaThue
        '
        Me.lblDonGiaThue.AutoSize = True
        Me.lblDonGiaThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDonGiaThue.Location = New System.Drawing.Point(316, 49)
        Me.lblDonGiaThue.Name = "lblDonGiaThue"
        Me.lblDonGiaThue.Size = New System.Drawing.Size(71, 13)
        Me.lblDonGiaThue.TabIndex = 6
        Me.lblDonGiaThue.Text = "Đơn giá thuê:"
        '
        'lblTenLoaiPhong
        '
        Me.lblTenLoaiPhong.AutoSize = True
        Me.lblTenLoaiPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenLoaiPhong.Location = New System.Drawing.Point(51, 49)
        Me.lblTenLoaiPhong.Name = "lblTenLoaiPhong"
        Me.lblTenLoaiPhong.Size = New System.Drawing.Size(86, 13)
        Me.lblTenLoaiPhong.TabIndex = 0
        Me.lblTenLoaiPhong.Text = "Tên Loại Phòng:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLuu)
        Me.GroupBox2.Controls.Add(Me.btntThoat)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 49)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLuu.Location = New System.Drawing.Point(121, 15)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(90, 23)
        Me.btnLuu.TabIndex = 7
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDanhSachLoaiPhong)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 175)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(607, 266)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách phòng"
        '
        'dgvDanhSachLoaiPhong
        '
        Me.dgvDanhSachLoaiPhong.AllowUserToAddRows = False
        Me.dgvDanhSachLoaiPhong.AllowUserToDeleteRows = False
        Me.dgvDanhSachLoaiPhong.AllowUserToOrderColumns = True
        Me.dgvDanhSachLoaiPhong.AllowUserToResizeColumns = False
        Me.dgvDanhSachLoaiPhong.AllowUserToResizeRows = False
        Me.dgvDanhSachLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachLoaiPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDanhSachLoaiPhong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaLoaiPhong, Me.TenLoaiPhong, Me.DonGiaThue})
        Me.dgvDanhSachLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSachLoaiPhong.Location = New System.Drawing.Point(4, 17)
        Me.dgvDanhSachLoaiPhong.Name = "dgvDanhSachLoaiPhong"
        Me.dgvDanhSachLoaiPhong.ReadOnly = True
        Me.dgvDanhSachLoaiPhong.RowHeadersVisible = False
        Me.dgvDanhSachLoaiPhong.RowHeadersWidth = 10
        Me.dgvDanhSachLoaiPhong.Size = New System.Drawing.Size(599, 245)
        Me.dgvDanhSachLoaiPhong.TabIndex = 0
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
        'frmThemLoaiPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 453)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmThemLoaiPhong"
        Me.Text = "Thêm Loại Phòng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDanhSachLoaiPhong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTenLoaiPhong As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDonGiaThue As System.Windows.Forms.TextBox
    Friend WithEvents lblDonGiaThue As System.Windows.Forms.Label
    Friend WithEvents lblTenLoaiPhong As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btntThoat As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDanhSachLoaiPhong As System.Windows.Forms.DataGridView
    Friend WithEvents MaLoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenLoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGiaThue As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
