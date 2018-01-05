<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemKhuyenMai
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
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.Ghu = New System.Windows.Forms.Label()
        Me.txtHeSoKhuyenMai = New System.Windows.Forms.TextBox()
        Me.lblHeSoKhuyenMai = New System.Windows.Forms.Label()
        Me.txtTenKhuyenMai = New System.Windows.Forms.TextBox()
        Me.lblTenLoaiKhach = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btntThoat = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhSachLoaiKhachHang = New System.Windows.Forms.DataGridView()
        Me.MaKhuyenMai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKhuyenMai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeSoKhuyenMai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDanhSachLoaiKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGhiChu)
        Me.GroupBox1.Controls.Add(Me.Ghu)
        Me.GroupBox1.Controls.Add(Me.txtHeSoKhuyenMai)
        Me.GroupBox1.Controls.Add(Me.lblHeSoKhuyenMai)
        Me.GroupBox1.Controls.Add(Me.txtTenKhuyenMai)
        Me.GroupBox1.Controls.Add(Me.lblTenLoaiKhach)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 102)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thêm Khuyến Mãi"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGhiChu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtGhiChu.Location = New System.Drawing.Point(136, 66)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(140, 20)
        Me.txtGhiChu.TabIndex = 9
        '
        'Ghu
        '
        Me.Ghu.AutoSize = True
        Me.Ghu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Ghu.Location = New System.Drawing.Point(44, 69)
        Me.Ghu.Name = "Ghu"
        Me.Ghu.Size = New System.Drawing.Size(47, 13)
        Me.Ghu.TabIndex = 8
        Me.Ghu.Text = "Ghi chú:"
        '
        'txtHeSoKhuyenMai
        '
        Me.txtHeSoKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHeSoKhuyenMai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtHeSoKhuyenMai.Location = New System.Drawing.Point(404, 33)
        Me.txtHeSoKhuyenMai.Name = "txtHeSoKhuyenMai"
        Me.txtHeSoKhuyenMai.Size = New System.Drawing.Size(140, 20)
        Me.txtHeSoKhuyenMai.TabIndex = 7
        '
        'lblHeSoKhuyenMai
        '
        Me.lblHeSoKhuyenMai.AutoSize = True
        Me.lblHeSoKhuyenMai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblHeSoKhuyenMai.Location = New System.Drawing.Point(304, 36)
        Me.lblHeSoKhuyenMai.Name = "lblHeSoKhuyenMai"
        Me.lblHeSoKhuyenMai.Size = New System.Drawing.Size(95, 13)
        Me.lblHeSoKhuyenMai.TabIndex = 6
        Me.lblHeSoKhuyenMai.Text = "Hệ số khuyến mãi:"
        '
        'txtTenKhuyenMai
        '
        Me.txtTenKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenKhuyenMai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenKhuyenMai.Location = New System.Drawing.Point(136, 33)
        Me.txtTenKhuyenMai.Name = "txtTenKhuyenMai"
        Me.txtTenKhuyenMai.Size = New System.Drawing.Size(140, 20)
        Me.txtTenKhuyenMai.TabIndex = 5
        '
        'lblTenLoaiKhach
        '
        Me.lblTenLoaiKhach.AutoSize = True
        Me.lblTenLoaiKhach.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenLoaiKhach.Location = New System.Drawing.Point(44, 36)
        Me.lblTenLoaiKhach.Name = "lblTenLoaiKhach"
        Me.lblTenLoaiKhach.Size = New System.Drawing.Size(88, 13)
        Me.lblTenLoaiKhach.TabIndex = 0
        Me.lblTenLoaiKhach.Text = "Tên Khuyến Mãi:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLuu)
        Me.GroupBox2.Controls.Add(Me.btntThoat)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 120)
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
        Me.GroupBox3.Controls.Add(Me.dgvDanhSachLoaiKhachHang)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 175)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(607, 266)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách khyến mãi"
        '
        'dgvDanhSachLoaiKhachHang
        '
        Me.dgvDanhSachLoaiKhachHang.AllowUserToAddRows = False
        Me.dgvDanhSachLoaiKhachHang.AllowUserToDeleteRows = False
        Me.dgvDanhSachLoaiKhachHang.AllowUserToOrderColumns = True
        Me.dgvDanhSachLoaiKhachHang.AllowUserToResizeColumns = False
        Me.dgvDanhSachLoaiKhachHang.AllowUserToResizeRows = False
        Me.dgvDanhSachLoaiKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachLoaiKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDanhSachLoaiKhachHang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaKhuyenMai, Me.TenKhuyenMai, Me.HeSoKhuyenMai, Me.GhiChu})
        Me.dgvDanhSachLoaiKhachHang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSachLoaiKhachHang.Location = New System.Drawing.Point(4, 17)
        Me.dgvDanhSachLoaiKhachHang.Name = "dgvDanhSachLoaiKhachHang"
        Me.dgvDanhSachLoaiKhachHang.ReadOnly = True
        Me.dgvDanhSachLoaiKhachHang.RowHeadersVisible = False
        Me.dgvDanhSachLoaiKhachHang.RowHeadersWidth = 10
        Me.dgvDanhSachLoaiKhachHang.Size = New System.Drawing.Size(599, 245)
        Me.dgvDanhSachLoaiKhachHang.TabIndex = 0
        '
        'MaKhuyenMai
        '
        Me.MaKhuyenMai.DataPropertyName = "MaKhuyenMai"
        Me.MaKhuyenMai.HeaderText = "Mã Khuyến Mãi"
        Me.MaKhuyenMai.Name = "MaKhuyenMai"
        Me.MaKhuyenMai.ReadOnly = True
        '
        'TenKhuyenMai
        '
        Me.TenKhuyenMai.DataPropertyName = "TenKhuyenMai"
        Me.TenKhuyenMai.HeaderText = "Tên Khuyến Mãi"
        Me.TenKhuyenMai.Name = "TenKhuyenMai"
        Me.TenKhuyenMai.ReadOnly = True
        '
        'HeSoKhuyenMai
        '
        Me.HeSoKhuyenMai.DataPropertyName = "HeSoKhuyenMai"
        Me.HeSoKhuyenMai.HeaderText = "Hệ Số Khuyến Mãi"
        Me.HeSoKhuyenMai.Name = "HeSoKhuyenMai"
        Me.HeSoKhuyenMai.ReadOnly = True
        '
        'GhiChu
        '
        Me.GhiChu.DataPropertyName = "GhiChu"
        Me.GhiChu.HeaderText = "Ghi Chú"
        Me.GhiChu.Name = "GhiChu"
        Me.GhiChu.ReadOnly = True
        '
        'frmThemKhuyenMai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 446)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmThemKhuyenMai"
        Me.Text = "frmThemKhuyenMai"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDanhSachLoaiKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHeSoKhuyenMai As TextBox
    Friend WithEvents lblHeSoKhuyenMai As Label
    Friend WithEvents txtTenKhuyenMai As TextBox
    Friend WithEvents lblTenLoaiKhach As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnLuu As Button
    Friend WithEvents btntThoat As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvDanhSachLoaiKhachHang As DataGridView
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents Ghu As Label
    Friend WithEvents MaKhuyenMai As DataGridViewTextBoxColumn
    Friend WithEvents TenKhuyenMai As DataGridViewTextBoxColumn
    Friend WithEvents HeSoKhuyenMai As DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As DataGridViewTextBoxColumn
End Class
