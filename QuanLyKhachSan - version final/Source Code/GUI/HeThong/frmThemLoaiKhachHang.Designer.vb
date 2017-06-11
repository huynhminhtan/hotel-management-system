<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemLoaiKhachHang
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
        Me.txtHeSoKhach = New System.Windows.Forms.TextBox()
        Me.lblHeSoKhach = New System.Windows.Forms.Label()
        Me.txtTenLoaiKhachHang = New System.Windows.Forms.TextBox()
        Me.lblTenLoaiKhach = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btntThoat = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhSachLoaiKhachHang = New System.Windows.Forms.DataGridView()
        Me.MaLoaiKhach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLoaiKhachHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeSoKhach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDanhSachLoaiKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHeSoKhach)
        Me.GroupBox1.Controls.Add(Me.lblHeSoKhach)
        Me.GroupBox1.Controls.Add(Me.txtTenLoaiKhachHang)
        Me.GroupBox1.Controls.Add(Me.lblTenLoaiKhach)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(809, 126)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thêm Loại Khách"
        '
        'txtHeSoKhach
        '
        Me.txtHeSoKhach.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHeSoKhach.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtHeSoKhach.Location = New System.Drawing.Point(524, 57)
        Me.txtHeSoKhach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHeSoKhach.Name = "txtHeSoKhach"
        Me.txtHeSoKhach.Size = New System.Drawing.Size(185, 23)
        Me.txtHeSoKhach.TabIndex = 7
        '
        'lblHeSoKhach
        '
        Me.lblHeSoKhach.AutoSize = True
        Me.lblHeSoKhach.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblHeSoKhach.Location = New System.Drawing.Point(421, 60)
        Me.lblHeSoKhach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeSoKhach.Name = "lblHeSoKhach"
        Me.lblHeSoKhach.Size = New System.Drawing.Size(91, 17)
        Me.lblHeSoKhach.TabIndex = 6
        Me.lblHeSoKhach.Text = "Hệ số khách:"
        '
        'txtTenLoaiKhachHang
        '
        Me.txtTenLoaiKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenLoaiKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenLoaiKhachHang.Location = New System.Drawing.Point(191, 57)
        Me.txtTenLoaiKhachHang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTenLoaiKhachHang.Name = "txtTenLoaiKhachHang"
        Me.txtTenLoaiKhachHang.Size = New System.Drawing.Size(185, 23)
        Me.txtTenLoaiKhachHang.TabIndex = 5
        '
        'lblTenLoaiKhach
        '
        Me.lblTenLoaiKhach.AutoSize = True
        Me.lblTenLoaiKhach.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenLoaiKhach.Location = New System.Drawing.Point(68, 60)
        Me.lblTenLoaiKhach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTenLoaiKhach.Name = "lblTenLoaiKhach"
        Me.lblTenLoaiKhach.Size = New System.Drawing.Size(112, 17)
        Me.lblTenLoaiKhach.TabIndex = 0
        Me.lblTenLoaiKhach.Text = "Tên Loại Khách:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLuu)
        Me.GroupBox2.Controls.Add(Me.btntThoat)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 148)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(809, 60)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLuu.Location = New System.Drawing.Point(161, 18)
        Me.btnLuu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(120, 28)
        Me.btnLuu.TabIndex = 7
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btntThoat
        '
        Me.btntThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btntThoat.Location = New System.Drawing.Point(544, 18)
        Me.btntThoat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btntThoat.Name = "btntThoat"
        Me.btntThoat.Size = New System.Drawing.Size(120, 28)
        Me.btntThoat.TabIndex = 6
        Me.btntThoat.Text = "Thoát"
        Me.btntThoat.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDanhSachLoaiKhachHang)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 215)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(809, 327)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách loại khách"
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
        Me.dgvDanhSachLoaiKhachHang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaLoaiKhach, Me.TenLoaiKhachHang, Me.HeSoKhach})
        Me.dgvDanhSachLoaiKhachHang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSachLoaiKhachHang.Location = New System.Drawing.Point(5, 20)
        Me.dgvDanhSachLoaiKhachHang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDanhSachLoaiKhachHang.Name = "dgvDanhSachLoaiKhachHang"
        Me.dgvDanhSachLoaiKhachHang.ReadOnly = True
        Me.dgvDanhSachLoaiKhachHang.RowHeadersVisible = False
        Me.dgvDanhSachLoaiKhachHang.RowHeadersWidth = 10
        Me.dgvDanhSachLoaiKhachHang.Size = New System.Drawing.Size(799, 302)
        Me.dgvDanhSachLoaiKhachHang.TabIndex = 0
        '
        'MaLoaiKhach
        '
        Me.MaLoaiKhach.DataPropertyName = "MaLoaiKhachHang"
        Me.MaLoaiKhach.HeaderText = "Mã Loại Khách"
        Me.MaLoaiKhach.Name = "MaLoaiKhach"
        Me.MaLoaiKhach.ReadOnly = True
        '
        'TenLoaiKhachHang
        '
        Me.TenLoaiKhachHang.DataPropertyName = "TenLoaiKhachHang"
        Me.TenLoaiKhachHang.HeaderText = "Tên Loại Khách Hàng"
        Me.TenLoaiKhachHang.Name = "TenLoaiKhachHang"
        Me.TenLoaiKhachHang.ReadOnly = True
        '
        'HeSoKhach
        '
        Me.HeSoKhach.DataPropertyName = "HeSoKhach"
        Me.HeSoKhach.HeaderText = "Hệ Số Khách"
        Me.HeSoKhach.Name = "HeSoKhach"
        Me.HeSoKhach.ReadOnly = True
        '
        'frmThemLoaiKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 558)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmThemLoaiKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Loại Khách Hàng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDanhSachLoaiKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTenLoaiKhachHang As System.Windows.Forms.TextBox
    Friend WithEvents lblTenLoaiKhach As System.Windows.Forms.Label
    Friend WithEvents txtHeSoKhach As System.Windows.Forms.TextBox
    Friend WithEvents lblHeSoKhach As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btntThoat As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDanhSachLoaiKhachHang As System.Windows.Forms.DataGridView
    Friend WithEvents MaLoaiKhach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenLoaiKhachHang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HeSoKhach As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
