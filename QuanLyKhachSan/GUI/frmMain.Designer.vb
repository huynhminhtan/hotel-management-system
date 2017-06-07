<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.tabControlQuanLy = New System.Windows.Forms.TabControl()
        Me.tabQuanLyPhong = New System.Windows.Forms.TabPage()
        Me.tabQuanLyPhieuThue = New System.Windows.Forms.TabPage()
        Me.tabBaoCaoThang = New System.Windows.Forms.TabPage()
        Me.tabThayDoiQuyDinh = New System.Windows.Forms.TabPage()
        Me.tabHeThong = New System.Windows.Forms.TabPage()
        Me.tabControlQuanLy.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControlQuanLy
        '
        Me.tabControlQuanLy.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.tabControlQuanLy.Controls.Add(Me.tabQuanLyPhong)
        Me.tabControlQuanLy.Controls.Add(Me.tabQuanLyPhieuThue)
        Me.tabControlQuanLy.Controls.Add(Me.tabBaoCaoThang)
        Me.tabControlQuanLy.Controls.Add(Me.tabThayDoiQuyDinh)
        Me.tabControlQuanLy.Controls.Add(Me.tabHeThong)
        Me.tabControlQuanLy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlQuanLy.ItemSize = New System.Drawing.Size(200, 50)
        Me.tabControlQuanLy.Location = New System.Drawing.Point(0, 0)
        Me.tabControlQuanLy.Margin = New System.Windows.Forms.Padding(0)
        Me.tabControlQuanLy.Name = "tabControlQuanLy"
        Me.tabControlQuanLy.Padding = New System.Drawing.Point(59, 3)
        Me.tabControlQuanLy.SelectedIndex = 0
        Me.tabControlQuanLy.Size = New System.Drawing.Size(1304, 753)
        Me.tabControlQuanLy.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabControlQuanLy.TabIndex = 0
        Me.tabControlQuanLy.TabStop = False
        '
        'tabQuanLyPhong
        '
        Me.tabQuanLyPhong.Location = New System.Drawing.Point(4, 54)
        Me.tabQuanLyPhong.Margin = New System.Windows.Forms.Padding(0)
        Me.tabQuanLyPhong.Name = "tabQuanLyPhong"
        Me.tabQuanLyPhong.Size = New System.Drawing.Size(1296, 695)
        Me.tabQuanLyPhong.TabIndex = 0
        Me.tabQuanLyPhong.Text = "Quản Lý Phòng"
        Me.tabQuanLyPhong.UseVisualStyleBackColor = True
        '
        'tabQuanLyPhieuThue
        '
        Me.tabQuanLyPhieuThue.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tabQuanLyPhieuThue.Location = New System.Drawing.Point(4, 24)
        Me.tabQuanLyPhieuThue.Margin = New System.Windows.Forms.Padding(0)
        Me.tabQuanLyPhieuThue.Name = "tabQuanLyPhieuThue"
        Me.tabQuanLyPhieuThue.Size = New System.Drawing.Size(1296, 725)
        Me.tabQuanLyPhieuThue.TabIndex = 1
        Me.tabQuanLyPhieuThue.Text = "Quản Lý Phiếu Thuê"
        '
        'tabBaoCaoThang
        '
        Me.tabBaoCaoThang.Location = New System.Drawing.Point(4, 24)
        Me.tabBaoCaoThang.Margin = New System.Windows.Forms.Padding(0)
        Me.tabBaoCaoThang.Name = "tabBaoCaoThang"
        Me.tabBaoCaoThang.Size = New System.Drawing.Size(1296, 725)
        Me.tabBaoCaoThang.TabIndex = 2
        Me.tabBaoCaoThang.Text = "Báo Cáo Tháng"
        Me.tabBaoCaoThang.UseVisualStyleBackColor = True
        '
        'tabThayDoiQuyDinh
        '
        Me.tabThayDoiQuyDinh.Location = New System.Drawing.Point(4, 24)
        Me.tabThayDoiQuyDinh.Margin = New System.Windows.Forms.Padding(0)
        Me.tabThayDoiQuyDinh.Name = "tabThayDoiQuyDinh"
        Me.tabThayDoiQuyDinh.Size = New System.Drawing.Size(1296, 725)
        Me.tabThayDoiQuyDinh.TabIndex = 3
        Me.tabThayDoiQuyDinh.Text = "Thay Đổi Quy Định"
        Me.tabThayDoiQuyDinh.UseVisualStyleBackColor = True
        '
        'tabHeThong
        '
        Me.tabHeThong.Location = New System.Drawing.Point(4, 24)
        Me.tabHeThong.Margin = New System.Windows.Forms.Padding(0)
        Me.tabHeThong.Name = "tabHeThong"
        Me.tabHeThong.Size = New System.Drawing.Size(1296, 725)
        Me.tabHeThong.TabIndex = 4
        Me.tabHeThong.Text = "Hệ Thống"
        Me.tabHeThong.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 753)
        Me.Controls.Add(Me.tabControlQuanLy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Khách Sạn"
        Me.tabControlQuanLy.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControlQuanLy As System.Windows.Forms.TabControl
    Friend WithEvents tabQuanLyPhong As System.Windows.Forms.TabPage
    Friend WithEvents tabQuanLyPhieuThue As System.Windows.Forms.TabPage
    Friend WithEvents tabBaoCaoThang As System.Windows.Forms.TabPage
    Friend WithEvents tabThayDoiQuyDinh As System.Windows.Forms.TabPage
    Friend WithEvents tabHeThong As System.Windows.Forms.TabPage

End Class
