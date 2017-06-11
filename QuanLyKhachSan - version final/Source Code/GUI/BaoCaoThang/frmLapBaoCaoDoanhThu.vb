Imports BUS.BUS
Imports DTO.DTO
Imports GUI.XuLy

Public Class frmLapBaoCaoDoanhThu

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
End Class

