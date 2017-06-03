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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvChiTietBaoCao = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnLapBaoCao = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTongDoanhThu = New System.Windows.Forms.TextBox()
        Me.lblTongDoanhThu = New System.Windows.Forms.Label()
        Me.lblThang = New System.Windows.Forms.Label()
        Me.dtpThang = New System.Windows.Forms.DateTimePicker()
        Me.LoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoanhThu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tyle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvChiTietBaoCao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvChiTietBaoCao)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 204)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(607, 207)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Chi tiết báo cáo"
        '
        'dgvChiTietBaoCao
        '
        Me.dgvChiTietBaoCao.AllowUserToAddRows = False
        Me.dgvChiTietBaoCao.AllowUserToDeleteRows = False
        Me.dgvChiTietBaoCao.AllowUserToOrderColumns = True
        Me.dgvChiTietBaoCao.AllowUserToResizeColumns = False
        Me.dgvChiTietBaoCao.AllowUserToResizeRows = False
        Me.dgvChiTietBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvChiTietBaoCao.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvChiTietBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietBaoCao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoaiPhong, Me.DonGia, Me.DoanhThu, Me.Tyle})
        Me.dgvChiTietBaoCao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvChiTietBaoCao.Location = New System.Drawing.Point(4, 17)
        Me.dgvChiTietBaoCao.Name = "dgvChiTietBaoCao"
        Me.dgvChiTietBaoCao.ReadOnly = True
        Me.dgvChiTietBaoCao.RowHeadersWidth = 15
        Me.dgvChiTietBaoCao.Size = New System.Drawing.Size(599, 186)
        Me.dgvChiTietBaoCao.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHuy)
        Me.GroupBox2.Controls.Add(Me.btnLapBaoCao)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 49)
        Me.GroupBox2.TabIndex = 10
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
        'btnLapBaoCao
        '
        Me.btnLapBaoCao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLapBaoCao.Location = New System.Drawing.Point(102, 15)
        Me.btnLapBaoCao.Name = "btnLapBaoCao"
        Me.btnLapBaoCao.Size = New System.Drawing.Size(90, 23)
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
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 118)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BÁO CÁO DOANH THU THEO LOẠI PHÒNG"
        '
        'txtTongDoanhThu
        '
        Me.txtTongDoanhThu.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTongDoanhThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTongDoanhThu.Location = New System.Drawing.Point(398, 54)
        Me.txtTongDoanhThu.Name = "txtTongDoanhThu"
        Me.txtTongDoanhThu.ReadOnly = True
        Me.txtTongDoanhThu.Size = New System.Drawing.Size(140, 20)
        Me.txtTongDoanhThu.TabIndex = 8
        '
        'lblTongDoanhThu
        '
        Me.lblTongDoanhThu.AutoSize = True
        Me.lblTongDoanhThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTongDoanhThu.Location = New System.Drawing.Point(307, 57)
        Me.lblTongDoanhThu.Name = "lblTongDoanhThu"
        Me.lblTongDoanhThu.Size = New System.Drawing.Size(86, 13)
        Me.lblTongDoanhThu.TabIndex = 4
        Me.lblTongDoanhThu.Text = "Tổng doanh thu:"
        '
        'lblThang
        '
        Me.lblThang.AutoSize = True
        Me.lblThang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblThang.Location = New System.Drawing.Point(59, 59)
        Me.lblThang.Name = "lblThang"
        Me.lblThang.Size = New System.Drawing.Size(41, 13)
        Me.lblThang.TabIndex = 0
        Me.lblThang.Text = "Tháng:"
        '
        'dtpThang
        '
        Me.dtpThang.CustomFormat = "MM/yyyy"
        Me.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThang.Location = New System.Drawing.Point(106, 54)
        Me.dtpThang.Name = "dtpThang"
        Me.dtpThang.Size = New System.Drawing.Size(128, 22)
        Me.dtpThang.TabIndex = 9
        '
        'LoaiPhong
        '
        Me.LoaiPhong.HeaderText = "Loại Phòng"
        Me.LoaiPhong.Name = "LoaiPhong"
        Me.LoaiPhong.ReadOnly = True
        '
        'DonGia
        '
        Me.DonGia.HeaderText = "Đơn Giá"
        Me.DonGia.Name = "DonGia"
        Me.DonGia.ReadOnly = True
        '
        'DoanhThu
        '
        Me.DoanhThu.HeaderText = "Doanh Thu"
        Me.DoanhThu.Name = "DoanhThu"
        Me.DoanhThu.ReadOnly = True
        '
        'Tyle
        '
        Me.Tyle.HeaderText = "Tỷ Lệ"
        Me.Tyle.Name = "Tyle"
        Me.Tyle.ReadOnly = True
        '
        'frmLapBaoCaoDoanhThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 423)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLapBaoCaoDoanhThu"
        Me.Text = "frmLapBaoCaoDoanhThu"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvChiTietBaoCao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvChiTietBaoCao As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnLapBaoCao As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpThang As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTongDoanhThu As System.Windows.Forms.TextBox
    Friend WithEvents lblTongDoanhThu As System.Windows.Forms.Label
    Friend WithEvents lblThang As System.Windows.Forms.Label
    Friend WithEvents LoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoanhThu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tyle As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
