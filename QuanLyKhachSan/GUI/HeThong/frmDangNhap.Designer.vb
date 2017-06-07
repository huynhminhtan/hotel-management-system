<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.groupBoxDangNhap = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBoxTenDangNhap = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.groupBoxDangNhap.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnDangNhap, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnThoat, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 365)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(794, 69)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.groupBoxDangNhap, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 90)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(794, 269)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'groupBoxDangNhap
        '
        Me.groupBoxDangNhap.BackColor = System.Drawing.Color.CornflowerBlue
        Me.groupBoxDangNhap.Controls.Add(Me.TableLayoutPanel4)
        Me.groupBoxDangNhap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBoxDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxDangNhap.Location = New System.Drawing.Point(163, 5)
        Me.groupBoxDangNhap.Margin = New System.Windows.Forms.Padding(5)
        Me.groupBoxDangNhap.Name = "groupBoxDangNhap"
        Me.groupBoxDangNhap.Padding = New System.Windows.Forms.Padding(10)
        Me.groupBoxDangNhap.Size = New System.Drawing.Size(466, 259)
        Me.groupBoxDangNhap.TabIndex = 0
        Me.groupBoxDangNhap.TabStop = False
        Me.groupBoxDangNhap.Text = "Đăng Nhập"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TextBox1, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtBoxTenDangNhap, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(10, 41)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(446, 208)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'txtBoxTenDangNhap
        '
        Me.txtBoxTenDangNhap.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtBoxTenDangNhap.Location = New System.Drawing.Point(233, 56)
        Me.txtBoxTenDangNhap.Margin = New System.Windows.Forms.Padding(10, 3, 10, 10)
        Me.txtBoxTenDangNhap.Name = "txtBoxTenDangNhap"
        Me.txtBoxTenDangNhap.Size = New System.Drawing.Size(203, 38)
        Me.txtBoxTenDangNhap.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.Label2.Size = New System.Drawing.Size(217, 98)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mật Khẩu:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5, 5, 5, 10)
        Me.Label1.Size = New System.Drawing.Size(217, 98)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên Đăng Nhập:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Location = New System.Drawing.Point(233, 114)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(10, 10, 10, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(203, 38)
        Me.TextBox1.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 500)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDangNhap.Location = New System.Drawing.Point(217, 10)
        Me.btnDangNhap.Margin = New System.Windows.Forms.Padding(30, 10, 30, 20)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(150, 39)
        Me.btnDangNhap.TabIndex = 0
        Me.btnDangNhap.Text = "Đăng Nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnThoat.Location = New System.Drawing.Point(427, 10)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(30, 10, 30, 20)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(150, 39)
        Me.btnThoat.TabIndex = 1
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DangNhap"
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.groupBoxDangNhap.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents groupBoxDangNhap As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBoxTenDangNhap As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnDangNhap As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
End Class
