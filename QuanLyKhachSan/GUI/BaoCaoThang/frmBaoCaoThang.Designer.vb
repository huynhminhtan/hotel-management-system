<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaoCaoThang
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.chartDoanhThuLoaiPhong = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartMatDoSuDung = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cboBaoCaoDoanhThu = New System.Windows.Forms.ComboBox()
        Me.cboBaoCaoMatDo = New System.Windows.Forms.ComboBox()
        Me.btnBaoCaoDoanhThu = New System.Windows.Forms.Button()
        Me.btnBaoCaoMatDo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.chartDoanhThuLoaiPhong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartMatDoSuDung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnBaoCaoMatDo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chartMatDoSuDung, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.chartDoanhThuLoaiPhong, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cboBaoCaoDoanhThu, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cboBaoCaoMatDo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBaoCaoDoanhThu, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1296, 725)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'chartDoanhThuLoaiPhong
        '
        Me.chartDoanhThuLoaiPhong.BackColor = System.Drawing.Color.Transparent
        ChartArea2.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartAreaDoanhThuLoaiPhong"
        Me.chartDoanhThuLoaiPhong.ChartAreas.Add(ChartArea2)
        Me.chartDoanhThuLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.chartDoanhThuLoaiPhong.Legends.Add(Legend2)
        Me.chartDoanhThuLoaiPhong.Location = New System.Drawing.Point(3, 220)
        Me.chartDoanhThuLoaiPhong.Name = "chartDoanhThuLoaiPhong"
        Series2.ChartArea = "ChartAreaDoanhThuLoaiPhong"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.Name = "SeriesPieDoanhThu"
        Me.chartDoanhThuLoaiPhong.Series.Add(Series2)
        Me.chartDoanhThuLoaiPhong.Size = New System.Drawing.Size(642, 502)
        Me.chartDoanhThuLoaiPhong.TabIndex = 0
        Me.chartDoanhThuLoaiPhong.Text = "Doanh thu của từng loại phòng"
        '
        'chartMatDoSuDung
        '
        Me.chartMatDoSuDung.BackColor = System.Drawing.Color.Transparent
        ChartArea1.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartAreaMatDoSuDung"
        Me.chartMatDoSuDung.ChartAreas.Add(ChartArea1)
        Me.chartMatDoSuDung.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chartMatDoSuDung.Legends.Add(Legend1)
        Me.chartMatDoSuDung.Location = New System.Drawing.Point(651, 220)
        Me.chartMatDoSuDung.Name = "chartMatDoSuDung"
        Series1.ChartArea = "ChartAreaMatDoSuDung"
        Series1.IsVisibleInLegend = False
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "SeriesColumeMatDo"
        Me.chartMatDoSuDung.Series.Add(Series1)
        Me.chartMatDoSuDung.Size = New System.Drawing.Size(642, 502)
        Me.chartMatDoSuDung.TabIndex = 5
        Me.chartMatDoSuDung.Text = "Mật độ sử dụng phòng trong tháng"
        '
        'cboBaoCaoDoanhThu
        '
        Me.cboBaoCaoDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboBaoCaoDoanhThu.DropDownHeight = 200
        Me.cboBaoCaoDoanhThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaoCaoDoanhThu.FormattingEnabled = True
        Me.cboBaoCaoDoanhThu.IntegralHeight = False
        Me.cboBaoCaoDoanhThu.Location = New System.Drawing.Point(798, 148)
        Me.cboBaoCaoDoanhThu.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.cboBaoCaoDoanhThu.MaxDropDownItems = 12
        Me.cboBaoCaoDoanhThu.Name = "cboBaoCaoDoanhThu"
        Me.cboBaoCaoDoanhThu.Size = New System.Drawing.Size(348, 24)
        Me.cboBaoCaoDoanhThu.TabIndex = 6
        '
        'cboBaoCaoMatDo
        '
        Me.cboBaoCaoMatDo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboBaoCaoMatDo.DropDownHeight = 200
        Me.cboBaoCaoMatDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaoCaoMatDo.FormattingEnabled = True
        Me.cboBaoCaoMatDo.IntegralHeight = False
        Me.cboBaoCaoMatDo.Location = New System.Drawing.Point(150, 148)
        Me.cboBaoCaoMatDo.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.cboBaoCaoMatDo.MaxDropDownItems = 12
        Me.cboBaoCaoMatDo.Name = "cboBaoCaoMatDo"
        Me.cboBaoCaoMatDo.Size = New System.Drawing.Size(348, 24)
        Me.cboBaoCaoMatDo.TabIndex = 7
        '
        'btnBaoCaoDoanhThu
        '
        Me.btnBaoCaoDoanhThu.BackColor = System.Drawing.Color.White
        Me.btnBaoCaoDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBaoCaoDoanhThu.Location = New System.Drawing.Point(75, 25)
        Me.btnBaoCaoDoanhThu.Margin = New System.Windows.Forms.Padding(75, 25, 75, 25)
        Me.btnBaoCaoDoanhThu.Name = "btnBaoCaoDoanhThu"
        Me.btnBaoCaoDoanhThu.Size = New System.Drawing.Size(498, 95)
        Me.btnBaoCaoDoanhThu.TabIndex = 8
        Me.btnBaoCaoDoanhThu.Text = "Lập Báo Cáo Tháng Theo Doanh Thu Loại Phòng"
        Me.btnBaoCaoDoanhThu.UseVisualStyleBackColor = False
        '
        'btnBaoCaoMatDo
        '
        Me.btnBaoCaoMatDo.BackColor = System.Drawing.Color.White
        Me.btnBaoCaoMatDo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBaoCaoMatDo.Location = New System.Drawing.Point(723, 25)
        Me.btnBaoCaoMatDo.Margin = New System.Windows.Forms.Padding(75, 25, 75, 25)
        Me.btnBaoCaoMatDo.Name = "btnBaoCaoMatDo"
        Me.btnBaoCaoMatDo.Size = New System.Drawing.Size(498, 95)
        Me.btnBaoCaoMatDo.TabIndex = 9
        Me.btnBaoCaoMatDo.Text = "Lập Báo Cáo Tháng Theo Mật Độ Sử Dụng Phòng"
        Me.btnBaoCaoMatDo.UseVisualStyleBackColor = False
        '
        'frmBaoCaoThang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1296, 725)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBaoCaoThang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmBaoCaoThang"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.chartDoanhThuLoaiPhong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartMatDoSuDung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chartMatDoSuDung As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents chartDoanhThuLoaiPhong As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cboBaoCaoDoanhThu As System.Windows.Forms.ComboBox
    Friend WithEvents cboBaoCaoMatDo As System.Windows.Forms.ComboBox
    Friend WithEvents btnBaoCaoDoanhThu As System.Windows.Forms.Button
    Friend WithEvents btnBaoCaoMatDo As System.Windows.Forms.Button
End Class
