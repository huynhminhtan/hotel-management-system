<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHeThong
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnThemLoaiPhong = New System.Windows.Forms.Button()
        Me.btnThemLoaiKhach = New System.Windows.Forms.Button()
        Me.btnKhuyenMai = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(972, 589)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnKhuyenMai, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnThemLoaiPhong, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnThemLoaiKhach, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(968, 231)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnThemLoaiPhong
        '
        Me.btnThemLoaiPhong.BackColor = System.Drawing.Color.White
        Me.btnThemLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnThemLoaiPhong.Location = New System.Drawing.Point(56, 20)
        Me.btnThemLoaiPhong.Margin = New System.Windows.Forms.Padding(56, 20, 56, 20)
        Me.btnThemLoaiPhong.Name = "btnThemLoaiPhong"
        Me.btnThemLoaiPhong.Size = New System.Drawing.Size(372, 75)
        Me.btnThemLoaiPhong.TabIndex = 9
        Me.btnThemLoaiPhong.Text = "Thêm Loại Phòng"
        Me.btnThemLoaiPhong.UseVisualStyleBackColor = False
        '
        'btnThemLoaiKhach
        '
        Me.btnThemLoaiKhach.BackColor = System.Drawing.Color.White
        Me.btnThemLoaiKhach.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnThemLoaiKhach.Location = New System.Drawing.Point(540, 20)
        Me.btnThemLoaiKhach.Margin = New System.Windows.Forms.Padding(56, 20, 56, 20)
        Me.btnThemLoaiKhach.Name = "btnThemLoaiKhach"
        Me.btnThemLoaiKhach.Size = New System.Drawing.Size(372, 75)
        Me.btnThemLoaiKhach.TabIndex = 10
        Me.btnThemLoaiKhach.Text = "Thêm Loại Khách"
        Me.btnThemLoaiKhach.UseVisualStyleBackColor = False
        '
        'btnKhuyenMai
        '
        Me.btnKhuyenMai.BackColor = System.Drawing.Color.White
        Me.btnKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKhuyenMai.Location = New System.Drawing.Point(56, 135)
        Me.btnKhuyenMai.Margin = New System.Windows.Forms.Padding(56, 20, 56, 20)
        Me.btnKhuyenMai.Name = "btnKhuyenMai"
        Me.btnKhuyenMai.Size = New System.Drawing.Size(372, 76)
        Me.btnKhuyenMai.TabIndex = 11
        Me.btnKhuyenMai.Text = "Thêm Khuyến Mãi"
        Me.btnKhuyenMai.UseVisualStyleBackColor = False
        '
        'frmHeThong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 589)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmHeThong"
        Me.Text = "frmHeThong"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnThemLoaiPhong As System.Windows.Forms.Button
    Friend WithEvents btnThemLoaiKhach As System.Windows.Forms.Button
    Friend WithEvents btnKhuyenMai As Button
End Class
