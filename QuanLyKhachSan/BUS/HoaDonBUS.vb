Imports System.Globalization
Imports DTO.DTO
Imports DAO.DAO

Namespace BUS

    Public Class HoaDonBUS

#Region "Processing"

        Public Shared Function hienThiPhieuThueLapHoaDon(maPhieuThue As String) As DataTable
            Dim bangKetQua As New DataTable

            bangKetQua.Columns.Add("MaPhieuThue", GetType(String))
            bangKetQua.Columns.Add("TenPhong", GetType(String))
            bangKetQua.Columns.Add("SoNgayThue", GetType(Integer))
            bangKetQua.Columns.Add("DonGiaThue", GetType(Double))
            bangKetQua.Columns.Add("ThanhTien", GetType(Double))

            ' kiểm tra có tồn tại mã phiếu thuê trong hệ thống không
            ' kiểm tra phiếu thuê thanh toán chưa.
            If (((PhieuThueBUS.kiemTraPhieuThueByMaPhieuThue(maPhieuThue) = False)) Or
                (PhieuThueBUS.kiemTraPhieuThueDaLapHoaDon(maPhieuThue) = True) Or
                (maPhieuThue.Length > 5)) Then
                Return Nothing
            End If

            Dim dt As New DataTable
            dt = PhieuThueBUS.selectPhieuThueHDByMaPhieuThue(maPhieuThue)

            ' kiểm tra lại cái cho chắc
            If (dt Is Nothing) Then
                Return Nothing
            End If

            Dim hang As DataRow = dt.Rows(0)

            ' lấy dữ liệu cần thiết từ CSDL
            Dim tenPhong As String
            tenPhong = hang("TenPhong").ToString
            Dim ngayBatDauThue As Date
            ngayBatDauThue = Date.Parse(hang("NgayBatDauThue").ToString)
            Dim ngayTraPhong As Date
            ngayTraPhong = Date.Parse(hang("NgayTraPhong").ToString)
            Dim donGiaThue As Double
            donGiaThue = Double.Parse(hang("DonGiaThueThucTe").ToString)
            Dim thanhTienTamThoi As Double
            thanhTienTamThoi = Double.Parse(hang("ThanhTienPhong").ToString)
            Dim phuThu As Double
            phuThu = Double.Parse(hang("PhuThuThucTe").ToString)

            ' tính số ngày thuê
            Dim soNgayThue As Integer
            soNgayThue = (ngayTraPhong - ngayBatDauThue).Days + 1

            ' tính thành tiền
            Dim thanhTien As Double = 0
            thanhTien = thanhTienTamThoi
            '' lấy danh sách chi tiết phiếu thuê ứng với MaPhieuThue
            Dim dsCTPT As New List(Of ChiTietPhieuThueDTO)
            dsCTPT = ChiTietPhieuThueBUS.selectDanhSachChiTietPhieuAllThueByMaPhieuThue(maPhieuThue)

            '' tìm hệ số lớn nhất trong danh sách phiếu thuê ứng với MaPhieuThue
            Dim topCTPTCoHeSoLonNhat As ChiTietPhieuThueDTO
            topCTPTCoHeSoLonNhat = dsCTPT.OrderByDescending(Function(m) m.HeSoThucTe).FirstOrDefault
            Dim heSoLonKhachsLonNhat As Double
            heSoLonKhachsLonNhat = topCTPTCoHeSoLonNhat.HeSoThucTe

            '' tính thành tiền với hệ số lớn nhất
            thanhTien = thanhTienTamThoi * heSoLonKhachsLonNhat

            '' nếu phòng > 2 khách thì phụ thu thêm
            Dim soKhachTrongPhong As Integer
            soKhachTrongPhong = dsCTPT.Count
            If (soKhachTrongPhong > 2) Then
                thanhTien = thanhTien + thanhTienTamThoi * phuThu
            End If

            ' lưu các giá trị vào banKetQua
            bangKetQua.Rows.Add(maPhieuThue, tenPhong, soNgayThue, donGiaThue, thanhTien)
            Return bangKetQua
        End Function

#End Region

#Region "Retrieving"

        Public Shared Function selectHoaDonMoiNhatAll() As String
            Dim hoaDon As HoaDonDTO = HoaDonDAO.selectHoaDonMoiNhatAll()
            If (hoaDon Is Nothing) Then
                Return Nothing
            End If

            Return hoaDon.MaHoaDon
        End Function
#End Region

#Region "Inserting"
        Public Shared Function themHoaDon(hoaDon As HoaDonDTO) As Boolean
            Return HoaDonDAO.themHoaDon(hoaDon)
        End Function
#End Region

    End Class

End Namespace
