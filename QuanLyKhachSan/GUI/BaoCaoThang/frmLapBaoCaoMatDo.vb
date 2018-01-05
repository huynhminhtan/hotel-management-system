
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Imports BUS.BUS
Imports DTO.DTO
Imports GUI.XuLy
Imports System.Text

Public Class frmLapBaoCaoMatDo

    Private fatherForm As frmBaoCaoThang
    Private locationFilePDF As String

    Private Sub frmLapBaoCaoMatDo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpThang.MaxDate = Date.Now


        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        locationFilePDF = "BaoCaoDoanhThuMatDoSuDung.pdf"

        '' hiển thị chi tiết phiếu thuê
        hienThiChiTietBaoCaoMatDo()
    End Sub

    Private Sub hienThiChiTietBaoCaoMatDo()
        Dim bangBaoCaoMatDo As New DataTable

        bangBaoCaoMatDo.Columns.Add("MaPhong", GetType(String))
        bangBaoCaoMatDo.Columns.Add("TenPhong", GetType(String))
        bangBaoCaoMatDo.Columns.Add("TenLoaiPhong", GetType(String))
        bangBaoCaoMatDo.Columns.Add("SoNgayThueTrongThang", GetType(String))
        bangBaoCaoMatDo.Columns.Add("TiLeSuDung", GetType(String))

        If ((PhongBUS.selectDanhSachPhongVoiSoNgayThuegByThang(dtpThang.Value)) Is Nothing) Then
            bangBaoCaoMatDo.Clear()
            dgvBaoCao.ResetBindings()
            dgvBaoCao.DataSource = bangBaoCaoMatDo
            btnLapBaoCao.Enabled = False
            Return
        Else
            For Each hang As DataRow In (PhongBUS.selectDanhSachPhongVoiSoNgayThuegByThang(dtpThang.Value).Rows)
                bangBaoCaoMatDo.Rows.Add(hang("MaPhong"), hang("TenPhong"),
                                         hang("TenLoaiPhong"), hang("SoNgayThue"),
                                        String.Format("{0:0.0%}", hang("SoNgayThue") / System.DateTime.DaysInMonth(dtpThang.Value.Year,
                                                                                                                   dtpThang.Value.Month)))
            Next

            btnLapBaoCao.Enabled = True
            dgvBaoCao.ResetBindings()
            dgvBaoCao.DataSource = bangBaoCaoMatDo

        End If

    End Sub

    Private Sub dtpThang_ValueChanged(sender As Object, e As EventArgs) Handles dtpThang.ValueChanged
        hienThiChiTietBaoCaoMatDo()
    End Sub

    Private Sub btnLapBaoCao_Click(sender As Object, e As EventArgs) Handles btnLapBaoCao.Click
        Dim baoCaoMatDo As New BaoCaoMatDoDTO
        baoCaoMatDo.ThangBaoCaoMatDo = dtpThang.Value.ToShortDateString()

        Using New CenteredMessageBox(Me)
            If (BaoCaoMatDoBUS.kiemTrabaoCaoMatDoByThang(baoCaoMatDo.ThangBaoCaoMatDo) = True) Then
                MessageBox.Show("Báo cáo đã tồn tại trong hệ thống.")
                Return
            End If
            If ((PhongBUS.selectDanhSachPhongVoiSoNgayThuegByThang(dtpThang.Value)) Is Nothing) Then
                MessageBox.Show("Không có phòng nào tương ứng với tháng.")
                Return
            End If
        End Using

        Dim bangBaoCaoMatDo As New DataTable
        Dim danhSachChiTietBaoCaoMD As New List(Of ChiTietBaoCaoMDDTO)
        Dim maBaoCaoMatDo = XuLyGUI.tangMa(BaoCaoMatDoBUS.selectMaBaoCaoMatDoMoiNhat(), "MD")

        bangBaoCaoMatDo = dgvBaoCao.DataSource

        For Each hang As DataRow In bangBaoCaoMatDo.Rows
            Dim chiTietBaoCaoMatDo As New ChiTietBaoCaoMDDTO

            chiTietBaoCaoMatDo.MaBaoCaoMatDo = maBaoCaoMatDo
            chiTietBaoCaoMatDo.MaPhong = hang("MaPhong").ToString
            chiTietBaoCaoMatDo.SoNgayThueTrongThang = Integer.Parse(hang("SoNgayThueTrongThang").ToString)
            chiTietBaoCaoMatDo.TiLeSuDung = hang("TiLeSuDung").ToString

            danhSachChiTietBaoCaoMD.Add(chiTietBaoCaoMatDo)
        Next

        Using New CenteredMessageBox(Me)
            '' lưu chi tiết báo cáo xuống hệ thống
            '' lưu báo cáo mật độ xuống hệ thống
            If (((BaoCaoMatDoBUS.themBaoCaoMatDo(baoCaoMatDo)) = True) And
                (ChiTietBaoCaoMDBUS.themDanhSachChiTietBaoCaoMD(danhSachChiTietBaoCaoMD) > 0)) Then
                MessageBox.Show("Lập báo cáo mật độ thành công.")
            Else
                MessageBox.Show("Lập báo cáo mật độ bị lỗi.")
                Return
            End If
        End Using

    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub

    Sub New(formFather As frmBaoCaoThang)
        InitializeComponent()
        fatherForm = formFather
    End Sub


    Private Sub frmLapBaoCaoMatDo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        fatherForm.CapNhat()
    End Sub

    Private Sub btnXuatPDF_Click(sender As Object, e As EventArgs) Handles btnXuatPDF.Click

        Dim Paragraph As New Paragraph
        Dim Pdffile As New Document(PageSize.A4, 40, 40, 40, 20)
        Pdffile.AddTitle("Bao Cao Doanh Thu")
        Dim Write As PdfWriter = PdfWriter.GetInstance(Pdffile, New FileStream(locationFilePDF, FileMode.Create))

        Pdffile.Open()

        Dim arial As BaseFont = BaseFont.CreateFont("..\..\..\Fonts\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED)

        Dim pTitle As New Font(arial, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim pTime As New Font(arial, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim pTable As New Font(arial, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

        'Paragraph = New Paragraph(New Chunk("BÁO CÁO DOANH THU THEO LOAI PHÒNG", pTitle))

        Paragraph = New Paragraph(New Chunk("BÁO CÁO DOANH THU THEO MẬT ĐỘ SỬ DỤNG", pTitle))
        Paragraph.Alignment = Element.ALIGN_CENTER
        Paragraph.SpacingAfter = 5.0F

        Pdffile.Add(Paragraph)

        ' insert data 

        Dim PdfTable As New PdfPTable(dgvBaoCao.Columns.Count)

        PdfTable.TotalWidth = 500.0F
        PdfTable.LockedWidth = True

        Dim widths(0 To dgvBaoCao.Columns.Count - 1) As Single
        For i As Integer = 0 To dgvBaoCao.Columns.Count - 1
            widths(i) = 1.0F
        Next

        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 0
        PdfTable.SpacingBefore = 5.0F


        Dim pdfcell As PdfPCell = New PdfPCell

        For i As Integer = 0 To dgvBaoCao.Columns.Count - 1
            pdfcell = New PdfPCell(New Phrase(New Chunk(dgvBaoCao.Columns(i).HeaderText, pTable)))

            pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            PdfTable.AddCell(pdfcell)
        Next

        For i As Integer = 0 To dgvBaoCao.Rows.Count - 1

            For j As Integer = 0 To dgvBaoCao.Columns.Count - 1
                pdfcell = New PdfPCell(New Phrase(dgvBaoCao(j, i).Value.ToString(), pTable))
                PdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                PdfTable.AddCell(pdfcell)
            Next
        Next

        Pdffile.Add(PdfTable)

        Paragraph = New Paragraph(New Chunk("Tháng: " + dtpThang.Value.ToShortDateString(), pTime))
        Paragraph.Alignment = Element.ALIGN_RIGHT
        Paragraph.SpacingBefore = 5.0F

        Pdffile.Add(Paragraph)

        Pdffile.Close()

        MessageBox.Show("Tạo PDF thành công!", "PDF format", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            locationFilePDF = SaveFileDialog1.FileName
        End If
    End Sub
End Class