﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapNhatPhong
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
        Me.cboTenLoaiPhong = New System.Windows.Forms.ComboBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtTenPhong = New System.Windows.Forms.TextBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtMaPhong = New System.Windows.Forms.TextBox()
        Me.lblDonGia = New System.Windows.Forms.Label()
        Me.lblTenPhong = New System.Windows.Forms.Label()
        Me.lblGhiChu = New System.Windows.Forms.Label()
        Me.lblLoaiPhong = New System.Windows.Forms.Label()
        Me.lblMaPhong = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btntThoat = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhSachPhong = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDanhSachPhong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboTenLoaiPhong)
        Me.GroupBox1.Controls.Add(Me.txtDonGia)
        Me.GroupBox1.Controls.Add(Me.txtTenPhong)
        Me.GroupBox1.Controls.Add(Me.txtGhiChu)
        Me.GroupBox1.Controls.Add(Me.txtMaPhong)
        Me.GroupBox1.Controls.Add(Me.lblDonGia)
        Me.GroupBox1.Controls.Add(Me.lblTenPhong)
        Me.GroupBox1.Controls.Add(Me.lblGhiChu)
        Me.GroupBox1.Controls.Add(Me.lblLoaiPhong)
        Me.GroupBox1.Controls.Add(Me.lblMaPhong)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 170)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CẬP NHẬT THÔNG TIN PHÒNG"
        '
        'cboTenLoaiPhong
        '
        Me.cboTenLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTenLoaiPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboTenLoaiPhong.FormattingEnabled = True
        Me.cboTenLoaiPhong.Location = New System.Drawing.Point(392, 45)
        Me.cboTenLoaiPhong.Name = "cboTenLoaiPhong"
        Me.cboTenLoaiPhong.Size = New System.Drawing.Size(140, 21)
        Me.cboTenLoaiPhong.TabIndex = 10
        '
        'txtDonGia
        '
        Me.txtDonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDonGia.Location = New System.Drawing.Point(392, 83)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.ReadOnly = True
        Me.txtDonGia.Size = New System.Drawing.Size(140, 20)
        Me.txtDonGia.TabIndex = 9
        '
        'txtTenPhong
        '
        Me.txtTenPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenPhong.Location = New System.Drawing.Point(143, 83)
        Me.txtTenPhong.Name = "txtTenPhong"
        Me.txtTenPhong.Size = New System.Drawing.Size(140, 20)
        Me.txtTenPhong.TabIndex = 8
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtGhiChu.Location = New System.Drawing.Point(143, 118)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(140, 20)
        Me.txtGhiChu.TabIndex = 7
        '
        'txtMaPhong
        '
        Me.txtMaPhong.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtMaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaPhong.Location = New System.Drawing.Point(143, 46)
        Me.txtMaPhong.Name = "txtMaPhong"
        Me.txtMaPhong.ReadOnly = True
        Me.txtMaPhong.Size = New System.Drawing.Size(140, 20)
        Me.txtMaPhong.TabIndex = 5
        '
        'lblDonGia
        '
        Me.lblDonGia.AutoSize = True
        Me.lblDonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDonGia.Location = New System.Drawing.Point(317, 83)
        Me.lblDonGia.Name = "lblDonGia"
        Me.lblDonGia.Size = New System.Drawing.Size(47, 13)
        Me.lblDonGia.TabIndex = 4
        Me.lblDonGia.Text = "Đơn giá:"
        '
        'lblTenPhong
        '
        Me.lblTenPhong.AutoSize = True
        Me.lblTenPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenPhong.Location = New System.Drawing.Point(68, 83)
        Me.lblTenPhong.Name = "lblTenPhong"
        Me.lblTenPhong.Size = New System.Drawing.Size(62, 13)
        Me.lblTenPhong.TabIndex = 3
        Me.lblTenPhong.Text = "Tên phòng:"
        '
        'lblGhiChu
        '
        Me.lblGhiChu.AutoSize = True
        Me.lblGhiChu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblGhiChu.Location = New System.Drawing.Point(83, 121)
        Me.lblGhiChu.Name = "lblGhiChu"
        Me.lblGhiChu.Size = New System.Drawing.Size(47, 13)
        Me.lblGhiChu.TabIndex = 2
        Me.lblGhiChu.Text = "Ghi chú:"
        '
        'lblLoaiPhong
        '
        Me.lblLoaiPhong.AutoSize = True
        Me.lblLoaiPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblLoaiPhong.Location = New System.Drawing.Point(317, 46)
        Me.lblLoaiPhong.Name = "lblLoaiPhong"
        Me.lblLoaiPhong.Size = New System.Drawing.Size(63, 13)
        Me.lblLoaiPhong.TabIndex = 1
        Me.lblLoaiPhong.Text = "Loại phòng:"
        '
        'lblMaPhong
        '
        Me.lblMaPhong.AutoSize = True
        Me.lblMaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaPhong.Location = New System.Drawing.Point(72, 46)
        Me.lblMaPhong.Name = "lblMaPhong"
        Me.lblMaPhong.Size = New System.Drawing.Size(58, 13)
        Me.lblMaPhong.TabIndex = 0
        Me.lblMaPhong.Text = "Mã phòng:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCapNhat)
        Me.GroupBox2.Controls.Add(Me.btntThoat)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 49)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnCapNhat.Location = New System.Drawing.Point(121, 15)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(90, 23)
        Me.btnCapNhat.TabIndex = 7
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
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
        Me.GroupBox3.Controls.Add(Me.dgvDanhSachPhong)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 243)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(607, 251)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách phòng"
        '
        'dgvDanhSachPhong
        '
        Me.dgvDanhSachPhong.AllowUserToAddRows = False
        Me.dgvDanhSachPhong.AllowUserToDeleteRows = False
        Me.dgvDanhSachPhong.AllowUserToResizeColumns = False
        Me.dgvDanhSachPhong.AllowUserToResizeRows = False
        Me.dgvDanhSachPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSachPhong.Location = New System.Drawing.Point(4, 17)
        Me.dgvDanhSachPhong.Name = "dgvDanhSachPhong"
        Me.dgvDanhSachPhong.ReadOnly = True
        Me.dgvDanhSachPhong.RowHeadersVisible = False
        Me.dgvDanhSachPhong.Size = New System.Drawing.Size(599, 230)
        Me.dgvDanhSachPhong.TabIndex = 1
        '
        'frmCapNhatPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 506)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCapNhatPhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cập Nhật Phòng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDanhSachPhong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboTenLoaiPhong As System.Windows.Forms.ComboBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents txtTenPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtGhiChu As System.Windows.Forms.TextBox
    Friend WithEvents txtMaPhong As System.Windows.Forms.TextBox
    Friend WithEvents lblDonGia As System.Windows.Forms.Label
    Friend WithEvents lblTenPhong As System.Windows.Forms.Label
    Friend WithEvents lblGhiChu As System.Windows.Forms.Label
    Friend WithEvents lblLoaiPhong As System.Windows.Forms.Label
    Friend WithEvents lblMaPhong As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents btntThoat As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDanhSachPhong As System.Windows.Forms.DataGridView
End Class
