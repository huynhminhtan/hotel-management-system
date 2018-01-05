
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Imports BUS.BUS
Imports DTO.DTO
Imports GUI.XuLy


Public Class frmLapBaoCaoDoanhThu

    Private locationFilePDF As String

    Private baoCaoDoanhThu As New BaoCaoDoanhThuDTO
    Private danhSachChiTietBaoCaoDT As New List(Of ChiTietBaoCaoDTDTO)
    Private fatherForm As frmBaoCaoThang

    Private Sub btnLapBaoCao_Click(sender As Object, e As EventArgs) Handles btnLapBaoCao.Click
        Using New CenteredMessageBox(Me)
            ' lập báo cáo mới khi chưa có trong hệ thống
            If (BaoCaoDoanhThuBUS.kiemTraBaoCaoDTByThangBaoCaoVaTongDoanhThu(baoCaoDoanhThu) = True) Then
                MessageBox.Show("Báo cáo đã có trong hệ thống.")
                Return
            End If

            ' lập báo cáo khi đã có dữ liệu
            If (baoCaoDoanhThu.TongDoanhThu <= 0) Then
                MessageBox.Show("Tháng không có dữ liệu.")
                Return
            End If

            ' lưu báo cáo xuống csdl
            ' lưu chi tiết báo cáo xuống csdl
            If ((BaoCaoDoanhThuBUS.themBaoCao(baoCaoDoanhThu)) And
               (ChiTietBaoCaoDTBUS.themDanhSachChiTietBaoCaoDT(danhSachChiTietBaoCaoDT) > 0)) Then
                MessageBox.Show("Lập báo cáo doanh thu thành công.")
            End If
        End Using
    End Sub

    Private Sub frmLapBaoCaoDoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        locationFilePDF = "BaoCaoDoanhThuLoaiPhong.pdf"

        dtpThang.MaxDate = Date.Now
        xuLyBaoCaoDoanhThu()

    End Sub

    Private Sub xuLyBaoCaoDoanhThu()
        Dim bangBaoCao As New DataTable
        Dim tongDoanhThu As Double = 0

        bangBaoCao.Columns.Add("MaLoaiPhong", GetType(String))
        bangBaoCao.Columns.Add("TenLoaiPhong", GetType(String))
        bangBaoCao.Columns.Add("DonGiaThue", GetType(Double))
        bangBaoCao.Columns.Add("DoanhThuLoaiPhong", GetType(Double))
        bangBaoCao.Columns.Add("TiLeDoanhThu", GetType(String))

        ' tạo 1 table/listDTO lưu danh sách loại phòng
        Dim danhSachLoaiPhong As New List(Of LoaiPhongDTO)
        danhSachLoaiPhong = LoaiPhongBUS.selectLoaiPhongAll()

        ' duyệt qua từng loại phòng 
        For Each loaiPhong As LoaiPhongDTO In danhSachLoaiPhong
            ' tạo 1 danh sách lưu tất cả các phiếu thuê có ngày trả phòng trong tháng của loại phòng đó
            Dim danhSachPhieuThueTrongThang As New List(Of PhieuThueDTO)
            danhSachPhieuThueTrongThang = PhieuThueBUS.selectPhieuThueByNgayTraPhongMaLoaiPhong(dtpThang.Value, loaiPhong.MaLoaiPhong)

            '' tính doanh thu theo loại phòng
            Dim doanhThuTam As Double = 0
            If (danhSachPhieuThueTrongThang IsNot Nothing) Then
                For Each phieuThue As PhieuThueDTO In danhSachPhieuThueTrongThang
                    doanhThuTam += phieuThue.ThanhTienPhong
                Next
            End If

            '' tính tổng doanh thu
            tongDoanhThu += doanhThuTam

            ' đưa dữ liệu vừa tính vào bangBaoCao
            bangBaoCao.Rows.Add(loaiPhong.MaLoaiPhong, loaiPhong.TenLoaiPhong, loaiPhong.DonGiaThue, doanhThuTam, Nothing)

        Next

        ' tính tổng doanh thu
        baoCaoDoanhThu.TongDoanhThu = tongDoanhThu
        ' lưu tháng báo cáo
        baoCaoDoanhThu.ThangbaoCaoDoanhThu = dtpThang.Value.ToShortDateString()

        ' tính tỉ lệ từng loại phòng
        For Each hang As DataRow In bangBaoCao.Rows
            hang("TiLeDoanhThu") = String.Format("{0:0.0%}", (hang("DoanhThuLoaiPhong") / tongDoanhThu))
        Next

        ' hiển thị bangBaoCao lên datagridview
        dgvBaoCao.ResetBindings()
        dgvBaoCao.DataSource = bangBaoCao
        ' hiển thị tổng doanh thu
        txtTongDoanhThu.Text = tongDoanhThu

        Dim maBaoCaoDoanhThu As String
        maBaoCaoDoanhThu = XuLyGUI.tangMa(BaoCaoDoanhThuBUS.selectMaBaoCaoDoanhThuMoiNhat(), "DT")

        For Each hang As DataRow In bangBaoCao.Rows
            Dim chiTietBaoCaoDT As New ChiTietBaoCaoDTDTO
            chiTietBaoCaoDT.MaBaoCaoDoanhThu = maBaoCaoDoanhThu
            chiTietBaoCaoDT.MaLoaiPhong = hang("MaLoaiPhong").ToString
            chiTietBaoCaoDT.DoanhThuLoaiPhong = Double.Parse(hang("DoanhThuLoaiPhong").ToString)
            chiTietBaoCaoDT.TiLeDoanhThu = hang("TiLeDoanhThu").ToString

            danhSachChiTietBaoCaoDT.Add(chiTietBaoCaoDT)
        Next
    End Sub

    Private Sub dtpThang_ValueChanged(sender As Object, e As EventArgs) Handles dtpThang.ValueChanged
        xuLyBaoCaoDoanhThu()
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub

    Sub New(formFather As frmBaoCaoThang)
        InitializeComponent()
        fatherForm = formFather
    End Sub

    Private Sub frmLapBaoCaoDoanhThu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
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

        Paragraph = New Paragraph(New Chunk("BÁO CÁO DOANH THU THEO LOẠI PHÒNG", pTitle))
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

