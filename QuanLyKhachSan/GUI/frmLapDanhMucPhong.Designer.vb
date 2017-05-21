<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapDanhMucPhong
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
        Me.lblMaPhong = New System.Windows.Forms.Label()
        Me.lblTenLoaiPhong = New System.Windows.Forms.Label()
        Me.lblGhiChu = New System.Windows.Forms.Label()
        Me.lblTenPhong = New System.Windows.Forms.Label()
        Me.lblDonGia = New System.Windows.Forms.Label()
        Me.txtMaPhong = New System.Windows.Forms.TextBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtTenPhong = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.cboTenLoaiPhong = New System.Windows.Forms.ComboBox()
        Me.btnLapPhong = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnTimPhong = New System.Windows.Forms.Button()
        Me.btnPhongMoi = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoaPhong = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.lblTenLoaiPhong)
        Me.GroupBox1.Controls.Add(Me.lblMaPhong)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 193)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LẬP DANH MỤC PHÒNG"
        '
        'lblMaPhong
        '
        Me.lblMaPhong.AutoSize = True
        Me.lblMaPhong.Location = New System.Drawing.Point(40, 43)
        Me.lblMaPhong.Name = "lblMaPhong"
        Me.lblMaPhong.Size = New System.Drawing.Size(78, 18)
        Me.lblMaPhong.TabIndex = 0
        Me.lblMaPhong.Text = "Mã phòng:"
        '
        'lblTenLoaiPhong
        '
        Me.lblTenLoaiPhong.AutoSize = True
        Me.lblTenLoaiPhong.Location = New System.Drawing.Point(40, 86)
        Me.lblTenLoaiPhong.Name = "lblTenLoaiPhong"
        Me.lblTenLoaiPhong.Size = New System.Drawing.Size(109, 18)
        Me.lblTenLoaiPhong.TabIndex = 1
        Me.lblTenLoaiPhong.Text = "Tên loại phòng:"
        '
        'lblGhiChu
        '
        Me.lblGhiChu.AutoSize = True
        Me.lblGhiChu.Location = New System.Drawing.Point(40, 128)
        Me.lblGhiChu.Name = "lblGhiChu"
        Me.lblGhiChu.Size = New System.Drawing.Size(63, 18)
        Me.lblGhiChu.TabIndex = 2
        Me.lblGhiChu.Text = "Ghi chú:"
        '
        'lblTenPhong
        '
        Me.lblTenPhong.AutoSize = True
        Me.lblTenPhong.Location = New System.Drawing.Point(376, 43)
        Me.lblTenPhong.Name = "lblTenPhong"
        Me.lblTenPhong.Size = New System.Drawing.Size(82, 18)
        Me.lblTenPhong.TabIndex = 3
        Me.lblTenPhong.Text = "Tên phòng:"
        '
        'lblDonGia
        '
        Me.lblDonGia.AutoSize = True
        Me.lblDonGia.Location = New System.Drawing.Point(376, 86)
        Me.lblDonGia.Name = "lblDonGia"
        Me.lblDonGia.Size = New System.Drawing.Size(63, 18)
        Me.lblDonGia.TabIndex = 4
        Me.lblDonGia.Text = "Đơn giá:"
        '
        'txtMaPhong
        '
        Me.txtMaPhong.Location = New System.Drawing.Point(173, 40)
        Me.txtMaPhong.Name = "txtMaPhong"
        Me.txtMaPhong.Size = New System.Drawing.Size(157, 24)
        Me.txtMaPhong.TabIndex = 5
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(173, 128)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(157, 24)
        Me.txtGhiChu.TabIndex = 7
        '
        'txtTenPhong
        '
        Me.txtTenPhong.Location = New System.Drawing.Point(484, 40)
        Me.txtTenPhong.Name = "txtTenPhong"
        Me.txtTenPhong.Size = New System.Drawing.Size(157, 24)
        Me.txtTenPhong.TabIndex = 8
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(484, 83)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(157, 24)
        Me.txtDonGia.TabIndex = 9
        '
        'cboTenLoaiPhong
        '
        Me.cboTenLoaiPhong.FormattingEnabled = True
        Me.cboTenLoaiPhong.Location = New System.Drawing.Point(173, 83)
        Me.cboTenLoaiPhong.Name = "cboTenLoaiPhong"
        Me.cboTenLoaiPhong.Size = New System.Drawing.Size(157, 26)
        Me.cboTenLoaiPhong.TabIndex = 10
        '
        'btnLapPhong
        '
        Me.btnLapPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLapPhong.Location = New System.Drawing.Point(129, 19)
        Me.btnLapPhong.Name = "btnLapPhong"
        Me.btnLapPhong.Size = New System.Drawing.Size(94, 28)
        Me.btnLapPhong.TabIndex = 1
        Me.btnLapPhong.Text = "Lập phòng"
        Me.btnLapPhong.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnXoaPhong)
        Me.GroupBox2.Controls.Add(Me.btnCapNhat)
        Me.GroupBox2.Controls.Add(Me.btnPhongMoi)
        Me.GroupBox2.Controls.Add(Me.btnTimPhong)
        Me.GroupBox2.Controls.Add(Me.btnThoat)
        Me.GroupBox2.Controls.Add(Me.btnLapPhong)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(698, 118)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(484, 19)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(94, 28)
        Me.btnThoat.TabIndex = 2
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnTimPhong
        '
        Me.btnTimPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnTimPhong.Location = New System.Drawing.Point(129, 68)
        Me.btnTimPhong.Name = "btnTimPhong"
        Me.btnTimPhong.Size = New System.Drawing.Size(94, 28)
        Me.btnTimPhong.TabIndex = 3
        Me.btnTimPhong.Text = "Tìm  phòng"
        Me.btnTimPhong.UseVisualStyleBackColor = True
        '
        'btnPhongMoi
        '
        Me.btnPhongMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnPhongMoi.Location = New System.Drawing.Point(251, 68)
        Me.btnPhongMoi.Name = "btnPhongMoi"
        Me.btnPhongMoi.Size = New System.Drawing.Size(94, 28)
        Me.btnPhongMoi.TabIndex = 4
        Me.btnPhongMoi.Text = "Phòng mới"
        Me.btnPhongMoi.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnCapNhat.Location = New System.Drawing.Point(372, 68)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(94, 28)
        Me.btnCapNhat.TabIndex = 5
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoaPhong
        '
        Me.btnXoaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoaPhong.Location = New System.Drawing.Point(484, 68)
        Me.btnXoaPhong.Name = "btnXoaPhong"
        Me.btnXoaPhong.Size = New System.Drawing.Size(94, 28)
        Me.btnXoaPhong.TabIndex = 6
        Me.btnXoaPhong.Text = "Xóa phòng"
        Me.btnXoaPhong.UseVisualStyleBackColor = True
        '
        'frmLapDanhMucPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 341)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLapDanhMucPhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLapDanhMucPhong"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDonGia As System.Windows.Forms.Label
    Friend WithEvents lblTenPhong As System.Windows.Forms.Label
    Friend WithEvents lblGhiChu As System.Windows.Forms.Label
    Friend WithEvents lblTenLoaiPhong As System.Windows.Forms.Label
    Friend WithEvents lblMaPhong As System.Windows.Forms.Label
    Friend WithEvents txtMaPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents txtTenPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtGhiChu As System.Windows.Forms.TextBox
    Friend WithEvents cboTenLoaiPhong As System.Windows.Forms.ComboBox
    Friend WithEvents btnLapPhong As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents btnPhongMoi As System.Windows.Forms.Button
    Friend WithEvents btnTimPhong As System.Windows.Forms.Button
    Friend WithEvents btnXoaPhong As System.Windows.Forms.Button
End Class
