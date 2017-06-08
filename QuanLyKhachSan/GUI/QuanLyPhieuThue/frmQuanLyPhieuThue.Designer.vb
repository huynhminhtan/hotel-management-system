<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyPhieuThue
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvQuanLyPhieuThue = New System.Windows.Forms.DataGridView()
        Me.ChonPhieuThue = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MaPhieuThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaThueThucTe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThanhTienPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaHoaDon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhuThuThucTe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayBatDauThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayTraPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLapHoaDon = New System.Windows.Forms.Button()
        Me.btnCapNhatPhieuThue = New System.Windows.Forms.Button()
        Me.btnLapPhieuThuePhong = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboTinhTrangPhieuThue = New System.Windows.Forms.ComboBox()
        Me.txtTinhTrangPhieuThue = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvQuanLyPhieuThue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.5!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(972, 589)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvQuanLyPhieuThue)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(4, 164)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.GroupBox4.Size = New System.Drawing.Size(964, 421)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Danh sách phiếu thuê"
        '
        'dgvQuanLyPhieuThue
        '
        Me.dgvQuanLyPhieuThue.AllowUserToAddRows = False
        Me.dgvQuanLyPhieuThue.AllowUserToDeleteRows = False
        Me.dgvQuanLyPhieuThue.AllowUserToResizeColumns = False
        Me.dgvQuanLyPhieuThue.AllowUserToResizeRows = False
        Me.dgvQuanLyPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQuanLyPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuanLyPhieuThue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChonPhieuThue, Me.MaPhieuThue, Me.TenPhong, Me.DonGiaThueThucTe, Me.ThanhTienPhong, Me.MaHoaDon, Me.PhuThuThucTe, Me.NgayBatDauThue, Me.NgayTraPhong, Me.GhiChu})
        Me.dgvQuanLyPhieuThue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvQuanLyPhieuThue.Location = New System.Drawing.Point(8, 21)
        Me.dgvQuanLyPhieuThue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvQuanLyPhieuThue.Name = "dgvQuanLyPhieuThue"
        Me.dgvQuanLyPhieuThue.RowHeadersVisible = False
        Me.dgvQuanLyPhieuThue.RowTemplate.Height = 24
        Me.dgvQuanLyPhieuThue.Size = New System.Drawing.Size(948, 392)
        Me.dgvQuanLyPhieuThue.TabIndex = 0
        '
        'ChonPhieuThue
        '
        Me.ChonPhieuThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ChonPhieuThue.DataPropertyName = "ChonPhieuThue"
        Me.ChonPhieuThue.FillWeight = 50.76142!
        Me.ChonPhieuThue.HeaderText = "Lập Hóa Đơn"
        Me.ChonPhieuThue.Name = "ChonPhieuThue"
        Me.ChonPhieuThue.Width = 60
        '
        'MaPhieuThue
        '
        Me.MaPhieuThue.DataPropertyName = "MaPhieuThue"
        Me.MaPhieuThue.FillWeight = 105.4709!
        Me.MaPhieuThue.HeaderText = "Mã Phiếu Thuê"
        Me.MaPhieuThue.Name = "MaPhieuThue"
        '
        'TenPhong
        '
        Me.TenPhong.DataPropertyName = "TenPhong"
        Me.TenPhong.FillWeight = 105.4709!
        Me.TenPhong.HeaderText = "Tên Phòng"
        Me.TenPhong.Name = "TenPhong"
        '
        'DonGiaThueThucTe
        '
        Me.DonGiaThueThucTe.DataPropertyName = "DonGiaThueThucTe"
        Me.DonGiaThueThucTe.FillWeight = 105.4709!
        Me.DonGiaThueThucTe.HeaderText = "Đơn Giá Thuê"
        Me.DonGiaThueThucTe.Name = "DonGiaThueThucTe"
        '
        'ThanhTienPhong
        '
        Me.ThanhTienPhong.DataPropertyName = "ThanhTienPhong"
        Me.ThanhTienPhong.FillWeight = 105.4709!
        Me.ThanhTienPhong.HeaderText = "Thành Tiền Phòng"
        Me.ThanhTienPhong.Name = "ThanhTienPhong"
        '
        'MaHoaDon
        '
        Me.MaHoaDon.DataPropertyName = "MaHoaDon"
        Me.MaHoaDon.FillWeight = 105.4709!
        Me.MaHoaDon.HeaderText = "Mã Hóa Đơn"
        Me.MaHoaDon.Name = "MaHoaDon"
        '
        'PhuThuThucTe
        '
        Me.PhuThuThucTe.DataPropertyName = "PhuThuThucTe"
        Me.PhuThuThucTe.FillWeight = 105.4709!
        Me.PhuThuThucTe.HeaderText = "Phụ Thu Thực Tế"
        Me.PhuThuThucTe.Name = "PhuThuThucTe"
        '
        'NgayBatDauThue
        '
        Me.NgayBatDauThue.DataPropertyName = "NgayBatDauThue"
        Me.NgayBatDauThue.FillWeight = 105.4709!
        Me.NgayBatDauThue.HeaderText = "Ngày Bắt Đầu Thuê"
        Me.NgayBatDauThue.Name = "NgayBatDauThue"
        '
        'NgayTraPhong
        '
        Me.NgayTraPhong.DataPropertyName = "NgayTraPhong"
        Me.NgayTraPhong.FillWeight = 105.4709!
        Me.NgayTraPhong.HeaderText = "Ngày Trả Phòng"
        Me.NgayTraPhong.Name = "NgayTraPhong"
        '
        'GhiChu
        '
        Me.GhiChu.DataPropertyName = "GhiChu"
        Me.GhiChu.FillWeight = 105.4709!
        Me.GhiChu.HeaderText = "Ghi Chú"
        Me.GhiChu.Name = "GhiChu"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnLapHoaDon, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCapNhatPhieuThue, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnLapPhieuThuePhong, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(964, 127)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnLapHoaDon
        '
        Me.btnLapHoaDon.BackColor = System.Drawing.Color.White
        Me.btnLapHoaDon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLapHoaDon.Location = New System.Drawing.Point(680, 16)
        Me.btnLapHoaDon.Margin = New System.Windows.Forms.Padding(38, 16, 38, 16)
        Me.btnLapHoaDon.Name = "btnLapHoaDon"
        Me.btnLapHoaDon.Size = New System.Drawing.Size(246, 95)
        Me.btnLapHoaDon.TabIndex = 2
        Me.btnLapHoaDon.Text = "Lập Hóa ĐơnThanh Toán"
        Me.btnLapHoaDon.UseVisualStyleBackColor = False
        '
        'btnCapNhatPhieuThue
        '
        Me.btnCapNhatPhieuThue.BackColor = System.Drawing.Color.White
        Me.btnCapNhatPhieuThue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCapNhatPhieuThue.Location = New System.Drawing.Point(359, 16)
        Me.btnCapNhatPhieuThue.Margin = New System.Windows.Forms.Padding(38, 16, 38, 16)
        Me.btnCapNhatPhieuThue.Name = "btnCapNhatPhieuThue"
        Me.btnCapNhatPhieuThue.Size = New System.Drawing.Size(245, 95)
        Me.btnCapNhatPhieuThue.TabIndex = 1
        Me.btnCapNhatPhieuThue.Text = "Cập Nhật Phiếu Thuê Phòng "
        Me.btnCapNhatPhieuThue.UseVisualStyleBackColor = False
        '
        'btnLapPhieuThuePhong
        '
        Me.btnLapPhieuThuePhong.BackColor = System.Drawing.Color.White
        Me.btnLapPhieuThuePhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLapPhieuThuePhong.Location = New System.Drawing.Point(38, 16)
        Me.btnLapPhieuThuePhong.Margin = New System.Windows.Forms.Padding(38, 16, 38, 16)
        Me.btnLapPhieuThuePhong.Name = "btnLapPhieuThuePhong"
        Me.btnLapPhieuThuePhong.Size = New System.Drawing.Size(245, 95)
        Me.btnLapPhieuThuePhong.TabIndex = 0
        Me.btnLapPhieuThuePhong.Text = "Lập Phiếu Thuê Phòng"
        Me.btnLapPhieuThuePhong.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.cboTinhTrangPhieuThue, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtTinhTrangPhieuThue, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 135)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(964, 25)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'cboTinhTrangPhieuThue
        '
        Me.cboTinhTrangPhieuThue.BackColor = System.Drawing.Color.White
        Me.cboTinhTrangPhieuThue.Dock = System.Windows.Forms.DockStyle.Left
        Me.cboTinhTrangPhieuThue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTinhTrangPhieuThue.FormattingEnabled = True
        Me.cboTinhTrangPhieuThue.Location = New System.Drawing.Point(194, 2)
        Me.cboTinhTrangPhieuThue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTinhTrangPhieuThue.Name = "cboTinhTrangPhieuThue"
        Me.cboTinhTrangPhieuThue.Size = New System.Drawing.Size(114, 21)
        Me.cboTinhTrangPhieuThue.TabIndex = 18
        '
        'txtTinhTrangPhieuThue
        '
        Me.txtTinhTrangPhieuThue.AutoSize = True
        Me.txtTinhTrangPhieuThue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTinhTrangPhieuThue.Location = New System.Drawing.Point(2, 0)
        Me.txtTinhTrangPhieuThue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtTinhTrangPhieuThue.Name = "txtTinhTrangPhieuThue"
        Me.txtTinhTrangPhieuThue.Size = New System.Drawing.Size(188, 25)
        Me.txtTinhTrangPhieuThue.TabIndex = 0
        Me.txtTinhTrangPhieuThue.Text = "Chọn tình trạng phiếu thuê"
        Me.txtTinhTrangPhieuThue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmQuanLyPhieuThue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 589)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmQuanLyPhieuThue"
        Me.Text = "frmQuanLyPhieuThue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvQuanLyPhieuThue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnLapHoaDon As System.Windows.Forms.Button
    Friend WithEvents btnCapNhatPhieuThue As System.Windows.Forms.Button
    Friend WithEvents btnLapPhieuThuePhong As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvQuanLyPhieuThue As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cboTinhTrangPhieuThue As System.Windows.Forms.ComboBox
    Friend WithEvents txtTinhTrangPhieuThue As System.Windows.Forms.Label
    Friend WithEvents ChonPhieuThue As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MaPhieuThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGiaThueThucTe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThanhTienPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaHoaDon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhuThuThucTe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayBatDauThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayTraPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
