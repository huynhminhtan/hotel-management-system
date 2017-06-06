Imports BUS.BUS
Imports DTO.DTO

Public Class frmLapBaoCaoDoanhThu

    'Private bangBaoCao As New DataTable

    Private Sub btnLapBaoCao_Click(sender As Object, e As EventArgs) Handles btnLapBaoCao.Click
        Dim bangBaoCao As New DataTable
        Dim baoCaoDoanhThu As New BaoCaoDoanhThuDTO

        bangBaoCao.Columns.Add("TenLoaiPhong", GetType(String))
        bangBaoCao.Columns.Add("DonGiaThue", GetType(Double))
        bangBaoCao.Columns.Add("DoanhThu", GetType(Double))
        bangBaoCao.Columns.Add("TiLe", GetType(Double))
       
        ' tạo 1 table/listDTO lưu danh sách loại phòng
        Dim danhSachLoaiPhong As New List(Of LoaiPhongDTO)
        danhSachLoaiPhong = LoaiPhongBUS.selectLoaiPhongAll()
        ' duyệt qua từng loại phòng 
        For Each loaiPhong As LoaiPhongDTO In danhSachLoaiPhong
            ' tạo 1 danh sách lưu tất cả các phiếu thuê có ngày trả phòng trong tháng của loại phòng đó
            Dim danhSachPhieuThueTrongThang As New List(Of PhieuThueDTO)
            danhSachPhieuThueTrongThang = PhieuThueBUS.selectPhieuThueByNgayTraPhongMaLoaiPhong(dtpThang.Value, MaLoaiPhong)

            '' tính doanh thu theo loại phòng
            Dim doanhThuTam As Double = 0
            For Each phieuThue As PhieuThueDTO In danhSachPhieuThueTrongThang
                doanhThuTam += phieuThue.ThanhTienPhong
            Next

            ' đưa dữ liệu vừa tính vào bangBaoCao
            bangBaoCao.Rows.Add(loaiPhong.TenLoaiPhong, loaiPhong.DonGiaThue, doanhThuTam, Nothing)

        Next

        ' tính tổng doanh thu
        baoCaoDoanhThu.TongDoanhThu = 
        ' tính tỉ lệ từng loại phòng

        ' hiện bangBaoCao lên datagridview
        dgvBaoCao.DataSource = bangBaoCao

        ' lưu báo cáo xuống csdl
        ' lưu chi tiết báo cáo xuống csdl
    End Sub

    Private Sub frmLapBaoCaoDoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       

    End Sub
End Class

