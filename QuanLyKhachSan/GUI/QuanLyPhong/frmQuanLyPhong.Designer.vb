﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyPhong
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
        Me.dgvQuanLyPhong = New System.Windows.Forms.DataGridView()
        Me.MaPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnTimPhong = New System.Windows.Forms.Button()
        Me.btnCapNhatPhong = New System.Windows.Forms.Button()
        Me.btnThemPhong = New System.Windows.Forms.Button()
        Me.btnHuyPhong = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvQuanLyPhong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.5!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1296, 725)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvQuanLyPhong)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(5, 203)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox4.Size = New System.Drawing.Size(1286, 517)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Danh sách phòng trong khách sạn"
        '
        'dgvQuanLyPhong
        '
        Me.dgvQuanLyPhong.AllowUserToAddRows = False
        Me.dgvQuanLyPhong.AllowUserToDeleteRows = False
        Me.dgvQuanLyPhong.AllowUserToResizeColumns = False
        Me.dgvQuanLyPhong.AllowUserToResizeRows = False
        Me.dgvQuanLyPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQuanLyPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuanLyPhong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPhong, Me.TenPhong, Me.TenLoaiPhong, Me.DonGiaThue, Me.TinhTrang})
        Me.dgvQuanLyPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvQuanLyPhong.Location = New System.Drawing.Point(10, 25)
        Me.dgvQuanLyPhong.MultiSelect = False
        Me.dgvQuanLyPhong.Name = "dgvQuanLyPhong"
        Me.dgvQuanLyPhong.ReadOnly = True
        Me.dgvQuanLyPhong.RowHeadersVisible = False
        Me.dgvQuanLyPhong.RowTemplate.Height = 24
        Me.dgvQuanLyPhong.Size = New System.Drawing.Size(1266, 482)
        Me.dgvQuanLyPhong.TabIndex = 0
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
        'TenLoaiPhong
        '
        Me.TenLoaiPhong.DataPropertyName = "TenLoaiPhong"
        Me.TenLoaiPhong.HeaderText = "Loại Phòng"
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
        'TinhTrang
        '
        Me.TinhTrang.DataPropertyName = "TinhTrang"
        Me.TinhTrang.HeaderText = "Tình Trạng"
        Me.TinhTrang.Name = "TinhTrang"
        Me.TinhTrang.ReadOnly = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnTimPhong, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCapNhatPhong, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnThemPhong, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnHuyPhong, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1286, 192)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'btnTimPhong
        '
        Me.btnTimPhong.BackColor = System.Drawing.Color.White
        Me.btnTimPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTimPhong.Location = New System.Drawing.Point(50, 106)
        Me.btnTimPhong.Margin = New System.Windows.Forms.Padding(50, 10, 50, 10)
        Me.btnTimPhong.Name = "btnTimPhong"
        Me.btnTimPhong.Size = New System.Drawing.Size(543, 76)
        Me.btnTimPhong.TabIndex = 2
        Me.btnTimPhong.Text = "Tìm Phòng"
        Me.btnTimPhong.UseVisualStyleBackColor = False
        '
        'btnCapNhat
        '
        Me.btnCapNhatPhong.BackColor = System.Drawing.Color.White
        Me.btnCapNhatPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCapNhatPhong.Location = New System.Drawing.Point(693, 106)
        Me.btnCapNhatPhong.Margin = New System.Windows.Forms.Padding(50, 10, 50, 10)
        Me.btnCapNhatPhong.Name = "btnCapNhat"
        Me.btnCapNhatPhong.Size = New System.Drawing.Size(543, 76)
        Me.btnCapNhatPhong.TabIndex = 1
        Me.btnCapNhatPhong.Text = "Cập Nhật Phòng"
        Me.btnCapNhatPhong.UseVisualStyleBackColor = False
        '
        'btnThemPhong
        '
        Me.btnThemPhong.BackColor = System.Drawing.Color.White
        Me.btnThemPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnThemPhong.Location = New System.Drawing.Point(50, 10)
        Me.btnThemPhong.Margin = New System.Windows.Forms.Padding(50, 10, 50, 10)
        Me.btnThemPhong.Name = "btnThemPhong"
        Me.btnThemPhong.Size = New System.Drawing.Size(543, 76)
        Me.btnThemPhong.TabIndex = 0
        Me.btnThemPhong.Text = "Thêm Phòng"
        Me.btnThemPhong.UseVisualStyleBackColor = False
        '
        'btnHuyPhong
        '
        Me.btnHuyPhong.BackColor = System.Drawing.Color.White
        Me.btnHuyPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHuyPhong.Location = New System.Drawing.Point(693, 10)
        Me.btnHuyPhong.Margin = New System.Windows.Forms.Padding(50, 10, 50, 10)
        Me.btnHuyPhong.Name = "btnHuyPhong"
        Me.btnHuyPhong.Size = New System.Drawing.Size(543, 76)
        Me.btnHuyPhong.TabIndex = 3
        Me.btnHuyPhong.Text = "Hủy Phòng"
        Me.btnHuyPhong.UseVisualStyleBackColor = False
        '
        'frmQuanLyPhong
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1296, 725)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuanLyPhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmQuanLyPhong"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvQuanLyPhong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvQuanLyPhong As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnThemPhong As System.Windows.Forms.Button
    Friend WithEvents btnTimPhong As System.Windows.Forms.Button
    Friend WithEvents btnCapNhatPhong As System.Windows.Forms.Button
    Friend WithEvents btnHuyPhong As System.Windows.Forms.Button
    Friend WithEvents MaPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenLoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGiaThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TinhTrang As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
