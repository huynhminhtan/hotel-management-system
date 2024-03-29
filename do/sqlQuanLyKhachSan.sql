﻿create database QuanLyKhachSan

use QuanLyKhachSan

create table LOAIPHONG	
(
	MaLoaiPhong char(5) primary key,
	TenLoaiPhong varchar(50),
	DonGiaThue float,
	isDeleted bit default 0,
)

create table PHONG
(
	MaPhong char(5) primary key,
	TenPhong nvarchar(50),
	MaLoaiPhong char(5),
	GhiChu nvarchar(300),
	isDeleted bit default 0,

	foreign key(MaLoaiPhong) references LOAIPHONG(MaLoaiPhong)
)

ALTER TABLE PHONG  ALTER COLUMN TenPhong nvarchar(50)

create table TINHTRANG
(
	MaTinhTrang char(22) primary key,
	LoaiTinhTrang char(15) default 'TRONG',
	MaPhong char(5),
	NgayCuaTinhTrang smalldatetime,

	foreign key (MaPhong) references PHONG(MaPhong)
)

create table LOAIKHACHHANG
(
	MaLoaiKhachHang char(5) primary key,
	TenLoaiKhachHang varchar(50),
	HeSoKhach float,

	isDeleted bit default 0,
)

create table HOADON
(
	MaHoaDon char(5) primary key,
	TenKhachHangHD nvarchar(50),
	DiaChiKhachHD nvarchar(100),
	TriGiaHoaDon float,

	isDeleted bit default 0,
)

create table PHIEUTHUE
(
	MaPhieuThue char(5) primary key,
	MaPhong char(5),
	foreign key (MaPhong) references PHONG(MaPhong),

	NgayTraPhong smalldatetime,
	NgayBatDauThue smalldatetime, 
	DonGiaThueThucTe float,
	ThanhTienPhong float,

	MaHoaDon char(5),
	--foreign key (MaHoaDon) references HOADON(MaHoaDon),

	PhuThuThucTe float,
	isDeleted bit default 0,
)

create table CHITIETPHIEUTHUE
(
	 MaChiTietPhieuThue char(5) primary key,
	 MaPhieuThue char(5),
	 foreign key (MaPhieuThue) references PHIEUTHUE(MaPhieuThue),

	 TenKhachHang nvarchar(50),
	 MaLoaiKhachHang char(5),
	 foreign key (MaLoaiKhachHang) references LOAIKHACHHANG(MaLoaiKhachHang),

	 CMND varchar(50),
	 DiaChi nvarchar(100),
	 HeSoThucTe float
)

create table THAMSO
(
	id tinyint not null default 1 primary key,
	SoKhachToiDa int default 3,
	TiLePhuThu float default 1.25,
)

create table BAOCAODOANHTHU
(
	MaBaoCaoDoanhThu char(5) primary key,
	ThangBaoCaoDoanhThu smalldatetime,
	TongDoanhThu float
)


create table CHITIETBAOCAODT
(
	MaChiTietBaoCaoDT char(5) primary key,
	MaBaoCaoDoanhThu char(5),
	foreign key (MaBaoCaoDoanhThu) references BAOCAODOANHTHU(MaBaoCaoDoanhThu),

	MaLoaiPhong char(5),
	foreign key (MaLoaiPhong) references LOAIPHONG(MaLoaiPhong),
	
	DoanhThuLoaiPhong float,
	TiLeDoanhThu varchar(50)
)


create table BAOCAOMATDO
(
	MaBaoCaoMatDo char(5) primary key,
	ThangBaoCaoMatDo smalldatetime,
)

create table CHITIETBAOCAOMD
(
	MaChiTietBaoCaoMD char(5) primary key,
	MaBaoCaoMatDo char(5),
	foreign key (MaBaoCaoMatDo) references BAOCAOMATDO(MaBaoCaoMatDo),

	MaPhong char(5),
	foreign key (MaPhong) references PHONG(MaPhong),

	SoNgayThueTrongThang int,
	TiLeSuDung varchar(50)
)



--------------------------------------------------------------------------
--------------------------------------------------------------------------

-- Insert LoaiPhong với mã tự động tăng
if exists (select * from sysobjects where name = 'LOAIPHONG' and type = 'P')
    drop procedure NewLoaiPhong
go
CREATE PROCEDURE NewLoaiPhong

     @TenLoaiPhong VARCHAR(50),
     @DonGiaThue float

AS BEGIN

     IF exists (SELECT *FROM LOAIPHONG)
     BEGIN
		 INSERT INTO LOAIPHONG(MaLoaiPhong, TenLoaiPhong, DonGiaThue)
		 SELECT 
				'LP' + RIGHT('000' + CAST(LoaiPhong_ID + 1 AS NVARCHAR(3)), 3)
			  , @TenLoaiPhong
			  ,@DonGiaThue
		 FROM (
			  SELECT TOP 1 LoaiPhong_ID = CAST(RIGHT(MaLoaiPhong, 3) AS INT)
			  FROM LOAIPHONG
			  ORDER BY MaLoaiPhong DESC
		 ) t
	END
	ELSE
	BEGIN
		INSERT INTO LOAIPHONG(MaLoaiPhong, TenLoaiPhong, DonGiaThue) VALUES ('LP000',@TenLoaiPhong, @DonGiaThue)
	END
END 

------------------------------------------------------------------------------------------
-- Select all LoaiPhong
CREATE PROCEDURE selectLoaiPhongAll
As begin
	Select MaLoaiPhong, TenLoaiPhong, DonGiaThue 
	From LOAIPHONG
	Where isDeleted = 0
end

------------------------------------------------------------------------------------------
-- Select LoaiPhong by id
CREATE PROCEDURE selectLoaiPhongByMaLoaiPhong
	@MaLoaiPhong char(5)
As begin
	Select MaLoaiPhong, TenLoaiPhong, DonGiaThue
	From LOAIPHONG
	Where (isDeleted = 0) AND (MaLoaiPhong = @MaLoaiPhong)
end


------------------------------------------------------------------------------------------
-- Select PhongMoiNhat
CREATE PROCEDURE selectPhongMoiNhat
AS begin
	Select top 1 *
	From PHONG
	Where (isDeleted = 0)
	Order by MaPhong DESC
end

------------------------------------------------------------------------------------------
--- Insert Phong với mã tự động tăng
CREATE PROCEDURE NewPhong

	@TenPhong nvarchar(50),
	@MaLoaiPhong char(5),
	@GhiChu nvarchar(300)

AS BEGIN
     IF exists (SELECT *FROM PHONG)
     BEGIN
		 INSERT INTO PHONG(MaPhong, TenPhong, MaLoaiPhong, GhiChu)
		 SELECT 
				'PH' + RIGHT('000' + CAST(Phong_ID + 1 AS NVARCHAR(3)), 3),
				@TenPhong ,
				@MaLoaiPhong ,
				@GhiChu 
		 FROM (
			  SELECT TOP 1 Phong_ID = CAST(RIGHT(MaPhong, 3) AS INT)
			  FROM PHONG
			  ORDER BY MaPhong DESC
		 ) t
	END
	ELSE
	BEGIN
		INSERT INTO PHONG(MaPhong, TenPhong, MaLoaiPhong, GhiChu) 
		VALUES ('PH000', @TenPhong, @MaLoaiPhong, @GhiChu)
	END
END

------------------------------------------------------------------------------------------
-- Select PhongAll
CREATE PROCEDURE selectPhongAll
AS BEGIN
	SELECT MaPhong, TenPhong, MaLoaiPhong, GhiChu
	FROM PHONG 
	WHERE isDeleted = 0
END	

------------------------------------------------------------------------------------------
-- Select PhieuthueMoiNhat
CREATE PROCEDURE selectPhieuThueMoiNhat
AS BEGIN
	SELECT TOP 1 
	 MaPhieuThue, MaPhong, NgayTraPhong,
	 NgayBatDauThue, DonGiaThueThucTe, 
	 ThanhTienPhong, MaHoaDon, PhuThuThucTe
	FROM PHIEUTHUE
	WHERE isDeleted = 0
END

------------------------------------------------------------------------------------------
-- Select ThamSoAll
CREATE PROCEDURE selectThamSoAll
AS BEGIN
	SELECT SoKhachToiDa, TiLePhuThu
	FROM THAMSO
	WHERE id = 1
END

------------------------------------------------------------------------------------------
-- Select LoaiKhachHangAll
CREATE PROCEDURE selectLoaiKhachHangAll
AS BEGIN
	SELECT MaLoaiKhachHang, TenLoaiKhachHang, HeSoKhach
	FROM LOAIKHACHHANG
	WHERE isDeleted = 0
END

------------------------------------------------------------------------------------------
-- Insert PhieuThue với mã tự động tăng
CREATE PROCEDURE NewPhieuThue

	@MaPhong char(5),
	@NgayTraPhong smalldatetime,
	@NgayBatDauThue smalldatetime, 
	@DonGiaThueThucTe float,
	@ThanhTienPhong float,
	--@MaHoaDon char(5),
	@PhuThuThucTe float

AS BEGIN

-- on show: X row(s) affected 
--SET NOCOUNT ON  

     IF exists (SELECT *FROM PHIEUTHUE)
     BEGIN
		 INSERT INTO PHIEUTHUE(MaPhieuThue, MaPhong, NgayTraPhong, NgayBatDauThue, DonGiaThueThucTe, ThanhTienPhong, PhuThuThucTe)
		 SELECT 
				'PT' + RIGHT('000' + CAST(PhieuThue_ID + 1 AS NVARCHAR(3)), 3),
				@MaPhong,
				@NgayTraPhong ,
				@NgayBatDauThue , 
				@DonGiaThueThucTe ,
				@ThanhTienPhong ,
				@PhuThuThucTe 
		 FROM (
			  SELECT TOP 1 PhieuThue_ID = CAST(RIGHT(MaPhieuThue, 3) AS INT)
			  FROM PHIEUTHUE
			  ORDER BY MaPhieuThue DESC
		 ) t
	END
	ELSE
	BEGIN
		INSERT INTO PHIEUTHUE(MaPhieuThue, MaPhong, NgayTraPhong, NgayBatDauThue, DonGiaThueThucTe, ThanhTienPhong, PhuThuThucTe) 
		VALUES ('PT000', @MaPhong, @NgayTraPhong, @NgayBatDauThue, @DonGiaThueThucTe, @ThanhTienPhong, @PhuThuThucTe)
	END
END 


------------------------------------------------------------------------------------------
-- Insert ChiTietPhieuThue với mã tự động tăng
CREATE PROCEDURE NewChiTietPhieuThue

	 @MaPhieuThue char(5),
	 @TenKhachHang nvarchar(50),
	 @MaLoaiKhachHang char(5),
	 @CMND varchar(50),
	 @DiaChi nvarchar(100),
	 @HeSoThucTe float

AS BEGIN
     IF exists (SELECT *FROM CHITIETPHIEUTHUE)
     BEGIN
		 INSERT INTO CHITIETPHIEUTHUE(MaChiTietPhieuThue, MaPhieuThue, TenKhachHang, MaLoaiKhachHang, CMND, DiaChi, HeSoThucTe)
		 SELECT 
				'CP' + RIGHT('000' + CAST(ChiTietPhieuThue_ID + 1 AS NVARCHAR(3)), 3),
				@MaPhieuThue,
				@TenKhachHang ,
				@MaLoaiKhachHang , 
				@CMND ,
				@DiaChi ,
				@HeSoThucTe
		 FROM (
			  SELECT TOP 1 ChiTietPhieuThue_ID = CAST(RIGHT(MaChiTietPhieuThue, 3) AS INT)
			  FROM CHITIETPHIEUTHUE
			  ORDER BY MaChiTietPhieuThue DESC
		 ) t
	END
	ELSE
	BEGIN
		INSERT INTO CHITIETPHIEUTHUE(MaChiTietPhieuThue, MaPhieuThue, TenKhachHang, MaLoaiKhachHang, CMND, DiaChi, HeSoThucTe) 
		VALUES ('CP000', @MaPhieuThue, @TenKhachHang, @MaLoaiKhachHang, @CMND, @DiaChi, @HeSoThucTe)
	END
END 

------------------------------------------------------------------------------------------
-- select LoaiKhachHangByMaLoaiKhach
CREATE PROCEDURE selectLoaiKhachHangByMaLoaiKhach
	@MaLoaiKhach char(5)
AS BEGIN
	SELECT MaLoaiKhachHang, TenLoaiKhachHang, HeSoKhach
	FROM LOAIKHACHHANG
	WHERE MaLoaiKhachHang = @MaLoaiKhach
END

------------------------------------------------------------------------------------------
-- Insert TinhTrang với mã tự động tăng
CREATE PROCEDURE NewTinhTrang

	@LoaiTinhTrang varchar(15),
	@MaPhong char(5),
	@NgayCuaTinhTrang smalldatetime

AS BEGIN

     IF exists (SELECT *FROM TINHTRANG)
     BEGIN
		 INSERT INTO TINHTRANG(MaTinhTrang, LoaiTinhTrang, MaPhong, NgayCuaTinhTrang)
		 SELECT 
				'TT' + RIGHT('00000000000000000000' + CAST(TinhTrang_ID + 1 AS NVARCHAR(20)), 20),
				@LoaiTinhTrang ,
				@MaPhong ,
				@NgayCuaTinhTrang 
		 FROM (
			  SELECT TOP 1 TinhTrang_ID = CAST(RIGHT(MaTinhTrang, 20) AS INT)
			  FROM TINHTRANG
			  ORDER BY MaTinhTrang DESC
		 ) t
	END
	ELSE
	BEGIN
		INSERT INTO TINHTRANG(MaTinhTrang, LoaiTinhTrang, MaPhong, NgayCuaTinhTrang) 
		VALUES ('TT00000000000000000000', @LoaiTinhTrang, @MaPhong, @NgayCuaTinhTrang)
	END
END 

------------------------------------------------------------------------------------------
-- select TinhTrangPhongByThoiGian
CREATE PROCEDURE selectTinhTrangPhongByThoiGian
	@NgayBatDau smalldatetime,
	@NgayKetThuc smalldatetime
AS BEGIN
	SELECT TenPhong as 'Tên Phòng', NgayCuaTinhTrang as 'Ngày', LoaiTinhTrang as 'Tình Trạng', DonGiaThue as 'Đơn Giá'
	FROM (TINHTRANG INNER JOIN PHONG ON PHONG.MaPhong = TINHTRANG.MaPhong)
		INNER JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong
	WHERE NgayCuaTinhTrang BETWEEN @NgayBatDau AND @NgayKetThuc
END

drop procedure selectTinhTrangPhongByThoiGian

------------------------------------------------------------------------------------------
-- update capNhatTinhTrangPhongByMaPhong
CREATE PROCEDURE capNhatTinhTrangPhongByMaPhong
	@MaPhong char(5),
	@NgayCuaTinhTrang smalldatetime
AS BEGIN
	UPDATE TINHTRANG
	SET LoaiTinhTrang = 'DA THUE'
	WHERE (MaPhong = @MaPhong) AND NgayCuaTinhTrang = @NgayCuaTinhTrang
END

------------------------------------------------------------------------------------------
-- kiemTraTinhTrangPhongByMaPhong
CREATE PROCEDURE phongDuocThue
	@MaPhong char(5),
	@NgayBatDau smalldatetime,
	@NgayTraPhong smalldatetime
AS BEGIN
	SELECT *
	FROM TINHTRANG
	WHERE (MaPhong = @MaPhong) AND 
		  ((@NgayBatDau <= NgayCuaTinhTrang) AND (NgayCuaTinhTrang <= @NgayTraPhong)) AND
		  (LoaiTinhTrang = 'DA THUE')
END

------------------------------------------------------------------------------------------
-- selectPhongAllByNgayBatDauVaNgayKetThuc
CREATE PROCEDURE selectPhongAllByNgayBatDauVaNgayTraPhong
	@NgayBatDau smalldatetime,
	@NgayTraPhong smalldatetime
AS BEGIN
	SELECT DISTINCT PHONG.MaPhong, TenPhong, TenLoaiPhong, DonGiaThue, LoaiTinhTrang, NgayCuaTinhTrang
	FROM ((TINHTRANG INNER JOIN PHONG ON PHONG.MaPhong = TINHTRANG.MaPhong)
			INNER JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong)
	WHERE ((@NgayBatDau <= NgayCuaTinhTrang) AND (NgayCuaTinhTrang <= @NgayTraPhong)) AND
			(PHONG.isDeleted = 0)
END

------------------------------------------------------------------------------------------
-- selectPhongKhongMaPhongKhongTenPhong
CREATE PROCEDURE selectPhongKhongMaPhongKhongTenPhong
	@MaLoaiPhong char(5),
	@DonGiaThue float,
	@LoaiTinhTrang char(15),
	@NgayBatDau smalldatetime,
	@NgayTraPhong smalldatetime
AS BEGIN
	SELECT DISTINCT PHONG.MaPhong, TenPhong, TenLoaiPhong, DonGiaThue, LoaiTinhTrang, NgayCuaTinhTrang
	FROM ((TINHTRANG INNER JOIN PHONG ON PHONG.MaPhong = TINHTRANG.MaPhong)
			INNER JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong)
	WHERE ((@NgayBatDau <= NgayCuaTinhTrang) AND (NgayCuaTinhTrang <= @NgayTraPhong)) AND
			(PHONG.isDeleted = 0) AND
			(LOAIPHONG.MaLoaiPhong = @MaLoaiPhong) AND
			(DonGiaThue = @DonGiaThue) AND
			(LoaiTinhTrang = @LoaiTinhTrang)
END

------------------------------------------------------------------------------------------
-- selectPhongByMaPhongNgayBatDauNgayTraPhong
CREATE PROCEDURE selectPhongByMaPhongNgayBatDauNgayTraPhong
	@MaPhong char(5),
	@NgayBatDau smalldatetime,
	@NgayTraPhong smalldatetime
AS BEGIN
		SELECT PHONG.MaPhong as 'Mã Phòng', TenPhong as 'Tên Phòng', TenLoaiPhong as 'Tên Loại Phòng', DonGiaThue as 'Đơn Giá Thuê', LoaiTinhTrang as 'Tình Trạng', NgayCuaTinhTrang as 'Ngày'
	FROM ((TINHTRANG INNER JOIN PHONG ON PHONG.MaPhong = TINHTRANG.MaPhong)
			INNER JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong)
	WHERE ((@NgayBatDau <= NgayCuaTinhTrang) AND (NgayCuaTinhTrang <= @NgayTraPhong)) AND
			(PHONG.isDeleted = 0) AND
			(PHONG.MaPhong = @MaPhong)
END

------------------------------------------------------------------------------------------
-- selectPhongByTenPhongNgayBatDauNgayTraPhong
CREATE PROCEDURE selectPhongByTenPhongNgayBatDauNgayTraPhong
	@TenPhong nvarchar(50),
	@NgayBatDau smalldatetime,
	@NgayTraPhong smalldatetime
AS BEGIN
	SELECT PHONG.MaPhong as 'Mã Phòng', TenPhong as 'Tên Phòng', TenLoaiPhong as 'Tên Loại Phòng', DonGiaThue as 'Đơn Giá Thuê', LoaiTinhTrang as 'Tình Trạng', NgayCuaTinhTrang as 'Ngày'
	FROM ((TINHTRANG INNER JOIN PHONG ON PHONG.MaPhong = TINHTRANG.MaPhong)
			INNER JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong)
	WHERE ((@NgayBatDau <= NgayCuaTinhTrang) AND (NgayCuaTinhTrang <= @NgayTraPhong)) AND
			(PHONG.isDeleted = 0) AND
			(PHONG.TenPhong = @TenPhong)
END

------------------------------------------------------------------------------------------
-- selectPhieuThueHDByMaPhieuThue
CREATE PROCEDURE selectPhieuThueHDByMaPhieuThue
	@MaPhieuThue char(5)
AS BEGIN
	SELECT TenPhong, NgayBatDauThue, NgayTraPhong, DonGiaThueThucTe, ThanhTienPhong, PhuThuThucTe
	FROM PHONG INNER JOIN PHIEUTHUE ON PHONG.MaPhong = PHIEUTHUE.MaPhong
	WHERE (PHIEUTHUE.isDeleted = 0) AND 
			(PHIEUTHUE.MaPhieuThue = @MaPhieuThue) AND
			(MaHoaDon IS NULL)
END

------------------------------------------------------------------------------------------
-- kiemTraPhieuThueByMaPhieuThue
CREATE PROCEDURE kiemTraPhieuThueByMaPhieuThue
	@MaPhieuThue char(5)
AS BEGIN
	SELECT *
	FROM PHIEUTHUE
	WHERE (isDeleted = 0) AND 
			(MaPhieuThue = @MaPhieuThue) AND
			(MaHoaDon IS NULL)

END

------------------------------------------------------------------------------------------
-- kiemTraPhieuThueDaLapHoaDon
CREATE PROCEDURE kiemTraPhieuThueDaLapHoaDon
	@MaPhieuThue char(5)
AS BEGIN
	SELECT *
	FROM PHIEUTHUE
	WHERE (isDeleted = 0) AND 
			(MaPhieuThue = @MaPhieuThue) AND
			(MaHoaDon IS NOT NULL)
END

------------------------------------------------------------------------------------------
-- selectChiTietPhieuThueByMaPhieuThue :: kiểm tra số khách có trong 1 phiếu thuê (1 phòng)
CREATE PROCEDURE selectChiTietPhieuAllThueByMaPhieuThue
	@MaPhieuThue char(5)
AS BEGIN
	SELECT MaChiTietPhieuThue, MaPhieuThue, TenKhachHang, MaLoaiKhachHang, CMND, DiaChi, HeSoThucTe
	FROM CHITIETPHIEUTHUE
	WHERE MaPhieuThue = @MaPhieuThue
END

------------------------------------------------------------------------------------------
-- capNhatMaHoaDonByMaPhieuThue
CREATE PROCEDURE capNhatMaHoaDonByMaPhieuThue
	@MaPhieuThue char(5),
	@MaHoaDon char(5)
AS BEGIN
	UPDATE PHIEUTHUE
	SET MaHoaDon = @MaHoaDon
	WHERE MaPhieuThue = @MaPhieuThue
END

------------------------------------------------------------------------------------------
-- selectHoaDonMoiNhatAll
CREATE PROCEDURE selectHoaDonMoiNhatAll
AS BEGIN
	SELECT TOP 1 MaHoaDon, TenKhachHangHD, DiaChiKhachHD, TriGiaHoaDon
	FROM HOADON
	WHERE (isDeleted = 0)
	ORDER BY MaHoaDon DESC
END

------------------------------------------------------------------------------------------
-- insert HoaDon với mã tự động tăng
CREATE PROCEDURE NewHoaDon

	@TenKhachHangHD nvarchar(50),
	@DiaChiKhachHD nvarchar(100),
	@TriGiaHoaDon float

AS BEGIN

-- on show: X row(s) affected 
--SET NOCOUNT ON  

     IF exists (SELECT *FROM HOADON)
     BEGIN
		 INSERT INTO HOADON(MaHoaDon, TenKhachHangHD, DiaChiKhachHD, TriGiaHoaDon)
		 SELECT 
				'HD' + RIGHT('000' + CAST(HoaDon_ID + 1 AS NVARCHAR(3)), 3),
				@TenKhachHangHD ,
				@DiaChiKhachHD ,
				@TriGiaHoaDon
		 FROM (
			  SELECT TOP 1 HoaDon_ID = CAST(RIGHT(MaHoaDon, 3) AS INT)
			  FROM HOADON
			  ORDER BY MaHoaDon DESC
		 ) t
	END
	ELSE
	BEGIN
		INSERT INTO HOADON(MaHoaDon, TenKhachHangHD, DiaChiKhachHD, TriGiaHoaDon)
		VALUES ('HD000', @TenKhachHangHD, @DiaChiKhachHD, @TriGiaHoaDon)
	END
END 

------------------------------------------------------------------------------------------
-- selectPhieuThueByNgayTraPhongMaLoaiPhong
CREATE PROCEDURE selectPhieuThueByNgayTraPhongMaLoaiPhong
	@NgayTraPhong smalldatetime,
	@MaLoaiPhong char(5)
AS BEGIN
	SELECT MaPhieuThue, PHIEUTHUE.MaPhong, NgayBatDauThue, NgayTraPhong,
				DonGiaThueThucTe, ThanhTienPhong, MaHoaDon, PhuThuThucTe
	FROM ((PHIEUTHUE INNER JOIN PHONG ON PHONG.MaPhong = PHIEUTHUE.MaPhong) INNER JOIN
			LOAIPHONG ON LOAIPHONG.MaLoaiPhong = PHONG.MaLoaiPhong)
	WHERE (PHIEUTHUE.isDeleted = 0) AND 
			(MONTH(NgayTraPhong) = MONTH(@NgayTraPhong)) AND
			(LOAIPHONG.MaLoaiPhong = @MaLoaiPhong)
END

------------------------------------------------------------------------------------------
-- NewBaoCaoDoanhThu với mã tự động tăng
CREATE PROCEDURE NewBaoCaoDoanhThu

	@ThangBaoCaoDoanhThu smalldatetime,
	@TongDoanhThu float

AS BEGIN

-- on show: X row(s) affected 
--SET NOCOUNT ON  

     IF exists (SELECT *FROM BAOCAODOANHTHU)
     BEGIN
		 INSERT INTO BAOCAODOANHTHU(MaBaoCaoDoanhThu, ThangBaoCaoDoanhThu, TongDoanhThu)
		 SELECT 
				'DT' + RIGHT('000' + CAST(DoanhThu_ID + 1 AS NVARCHAR(3)), 3),
				@ThangBaoCaoDoanhThu ,
				@TongDoanhThu
		 FROM (
			  SELECT TOP 1 DoanhThu_ID = CAST(RIGHT(MaBaoCaoDoanhThu, 3) AS INT)
			  FROM BAOCAODOANHTHU
			  ORDER BY MaBaoCaoDoanhThu DESC
		 ) t
	END
	ELSE
	BEGIN
		INSERT INTO BAOCAODOANHTHU(MaBaoCaoDoanhThu, ThangBaoCaoDoanhThu, TongDoanhThu)
		VALUES ('DT000', @ThangBaoCaoDoanhThu, @TongDoanhThu)
	END
END 

------------------------------------------------------------------------------------------
-- selecBaoCaoDoanhThuMoiNhat
CREATE PROCEDURE selecBaoCaoDoanhThuMoiNhat 
AS BEGIN
	SELECT TOP 1 MaBaoCaoDoanhThu, ThangBaoCaoDoanhThu, TongDoanhThu
	FROM BAOCAODOANHTHU
	ORDER BY MaBaoCaoDoanhThu DESC
END

------------------------------------------------------------------------------------------
-- newChiTietBaoCaoDT với mã tự động tăng
CREATE PROCEDURE NewChiTietBaoCaoDT

	@MaBaoCaoDoanhThu char(5),
	@MaLoaiPhong char(5),
	@DoanhThuLoaiPhong float,
	@TiLeDoanhThu varchar(50)

AS BEGIN

-- on show: X row(s) affected 
--SET NOCOUNT ON  

     IF exists (SELECT *FROM CHITIETBAOCAODT)
     BEGIN
		 INSERT INTO CHITIETBAOCAODT(MaChiTietBaoCaoDT, MaBaoCaoDoanhThu, MaLoaiPhong, DoanhThuLoaiPhong, TiLeDoanhThu)
		 SELECT 
				'CD' + RIGHT('000' + CAST(CTBCDT_ID + 1 AS NVARCHAR(3)), 3),
				@MaBaoCaoDoanhThu,
				@MaLoaiPhong ,
				@DoanhThuLoaiPhong,
				@TiLeDoanhThu
		 FROM (
			  SELECT TOP 1 CTBCDT_ID = CAST(RIGHT(MaChiTietBaoCaoDT, 3) AS INT)
			  FROM CHITIETBAOCAODT
			  ORDER BY MaChiTietBaoCaoDT DESC
		 ) t
	END
	ELSE
	BEGIN
		INSERT INTO CHITIETBAOCAODT(MaChiTietBaoCaoDT, MaBaoCaoDoanhThu, MaLoaiPhong, DoanhThuLoaiPhong, TiLeDoanhThu)
		VALUES ('CD000',  @MaBaoCaoDoanhThu, @MaLoaiPhong, @DoanhThuLoaiPhong, @TiLeDoanhThu)
	END
END 

------------------------------------------------------------------------------------------
-- kiemTraBaoCaoDTByThangBaoCaoVaTongDoanhThu
CREATE PROCEDURE kiemTraBaoCaoDTByThangBaoCaoVaTongDoanhThu
	@ThangBaoCaoDoanhThu smalldatetime,
	@TongDoanhThu float
AS BEGIN
	SELECT MaBaoCaoDoanhThu, ThangBaoCaoDoanhThu, TongDoanhThu
	FROM BAOCAODOANHTHU
	WHERE (MONTH(ThangBaoCaoDoanhThu) = MONTH(@ThangBaoCaoDoanhThu)) AND
			(YEAR(ThangBaoCaoDoanhThu) = YEAR(@ThangBaoCaoDoanhThu)) AND
			TongDoanhThu = @TongDoanhThu
END

-- selectDanhSachPhongVoiSoNgayThuegByThang
CREATE PROCEDURE selectDanhSachPhongVoiSoNgayThueByThang
	@Thang smalldatetime
AS BEGIN
	SELECT COUNT(tenPhong) AS SoNgayThue, TenPhong, PHONG.MaPhong, TenLoaiPhong
	FROM ((PHONG INNER JOIN TINHTRANG ON PHONG.MaPhong = TINHTRANG.MaPhong )
			INNER JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong)
	WHERE MONTH(NgayCuaTinhTrang) = MONTH(@Thang) AND
		 YEAR(NgayCuaTinhTrang) = YEAR(@Thang) AND
		 (PHONG.isDeleted = 0) AND
		 (LoaiTinhTrang = 'DA THUE')
	GROUP BY PHONG.MaPhong, TenPhong, PHONG.MaPhong, TenLoaiPhong
END

------------------------------------------------------------------------------------------
-- themBaoCaoMatDo
CREATE PROCEDURE NewBaoCaoMatDo

	@ThangBaoCaoMatDo smalldatetime

AS BEGIN

-- on show: X row(s) affected 
--SET NOCOUNT ON  

     IF exists (SELECT *FROM BAOCAOMATDO)
     BEGIN
		 INSERT INTO BAOCAOMATDO(MaBaoCaoMatDo, ThangBaoCaoMatDo)
		 SELECT 
				'MD' + RIGHT('000' + CAST(BaoCaoMatDo_ID + 1 AS NVARCHAR(3)), 3),
				@ThangBaoCaoMatDo
		 FROM (
			  SELECT TOP 1 BaoCaoMatDo_ID = CAST(RIGHT(MaBaoCaoMatDo, 3) AS INT)
			  FROM BAOCAOMATDO
			  ORDER BY MaBaoCaoMatDo DESC
		 ) t
	END
	ELSE
	BEGIN
		INSERT INTO BAOCAOMATDO(MaBaoCaoMatDo, ThangBaoCaoMatDo)
		VALUES ('MD000',  @ThangBaoCaoMatDo)
	END
END 

------------------------------------------------------------------------------------------
-- selectBaoCaoMatDoMoiNhat
CREATE PROCEDURE selectBaoCaoMatDoMoiNhat 
AS BEGIN
	SELECT TOP 1 MaBaoCaoMatDo, ThangBaoCaoMatDo
	FROM BAOCAOMATDO
	ORDER BY MaBaoCaoMatDo DESC
END

------------------------------------------------------------------------------------------
-- themChiTietBaoCaoMD với mã tự động tăng
CREATE PROCEDURE NewChiTietBaoCaoMD

	@MaBaoCaoMatDo char(5),
	@MaPhong char(5),
	@SoNgayThueTrongThang int,
	@TiLeSuDung varchar(50)

AS BEGIN

-- on show: X row(s) affected 
--SET NOCOUNT ON  

     IF exists (SELECT *FROM CHITIETBAOCAOMD)
     BEGIN
		 INSERT INTO CHITIETBAOCAOMD(MaChiTietBaoCaoMD, MaBaoCaoMatDo, MaPhong, SoNgayThueTrongThang, TiLeSuDung)
		 SELECT 
				'CD' + RIGHT('000' + CAST(CTBCMD_ID + 1 AS NVARCHAR(3)), 3),
				@MaBaoCaoMatDo,
				@MaPhong ,
				@SoNgayThueTrongThang ,
				@TiLeSuDung 
		 FROM (
			  SELECT TOP 1 CTBCMD_ID = CAST(RIGHT(MaChiTietBaoCaoMD, 3) AS INT)
			  FROM CHITIETBAOCAOMD
			  ORDER BY MaChiTietBaoCaoMD DESC
		 ) t
	END
	ELSE
	BEGIN
		INSERT INTO CHITIETBAOCAOMD(MaChiTietBaoCaoMD, MaBaoCaoMatDo, MaPhong, SoNgayThueTrongThang, TiLeSuDung)
		VALUES ('CD000',  @MaBaoCaoMatDo, @MaPhong, @SoNgayThueTrongThang, @TiLeSuDung)
	END
END 

------------------------------------------------------------------------------------------
-- selectBaoCaoMatDoByThang
CREATE PROCEDURE selectBaoCaoMatDoByThang
	@ThangBaoCaoMatDo smalldatetime
AS BEGIN
	SELECT MaBaoCaoMatDo, ThangBaoCaoMatDo
	FROM BAOCAOMATDO
	WHERE ((MONTH(ThangBaoCaoMatDo) = MONTH(@ThangBaoCaoMatDo) AND
		YEAR(ThangBaoCaoMatDo) = YEAR(@ThangBaoCaoMatDo)))
END

-- selectPhieuThueChuaLapHoaDon
CREATE PROCEDURE selectPhieuThueChuaLapHoaDon
AS BEGIN
	SELECT MaPhieuThue, MaPhong, NgayTraPhong, NgayBatDauThue, DonGiaThueThucTe, ThanhTienPhong, MaHoaDon, PhuThuThucTe
	FROM PHIEUTHUE
	WHERE (isDeleted = 0) AND
		(MaHoaDon is null)
END

------------------------------------------------------------------------------------------
-- selectPhieuThueByTinhTrangHoaDon
CREATE PROCEDURE selectPhieuThueByTinhTrangHoaDon
	@TinhTrangHoaDon nvarchar(50)
AS BEGIN
	IF (@TinhTrangHoaDon = 'DA THUE')
		select MaPhieuThue, TenPhong, DonGiaThueThucTe, ThanhTienPhong, MaHoaDon, PhuThuThucTe,   NgayBatDauThue, NgayTraPhong, GhiChu 
		from PHIEUTHUE inner join PHONG on PHIEUTHUE.MaPhong = PHONG.MaPhong
		WHERE (MaHoaDon IS NOT NULL)
	ELSE IF (@TinhTrangHoaDon = 'TRONG')
		select MaPhieuThue, TenPhong, DonGiaThueThucTe, ThanhTienPhong, MaHoaDon, PhuThuThucTe,   NgayBatDauThue, NgayTraPhong, GhiChu 
		from PHIEUTHUE inner join PHONG on PHIEUTHUE.MaPhong = PHONG.MaPhong
		WHERE (MaHoaDon IS NULL)
	ELSE IF (@TinhTrangHoaDon = 'TAT CA')
		select MaPhieuThue, TenPhong, DonGiaThueThucTe, ThanhTienPhong, MaHoaDon, PhuThuThucTe,   NgayBatDauThue, NgayTraPhong, GhiChu  
		from PHIEUTHUE inner join PHONG on PHIEUTHUE.MaPhong = PHONG.MaPhong
	END

------------------------------------------------------------------------------------------
-- selectBaoCaoDoanhThuAll
CREATE PROCEDURE selectBaoCaoDoanhThuAll
AS BEGIN
	SELECT *
	FROM BAOCAODOANHTHU
END

------------------------------------------------------------------------------------------
-- selectBaoCaoMatDoAll
CREATE PROCEDURE selectBaoCaoMatDoAll
AS BEGIN
	SELECT *
	FROM BAOCAOMATDO
END

------------------------------------------------------------------------------------------
-- selectChiTietBaoCaoDoanhThuByMaBaoCaoDoanhThu
CREATE PROCEDURE selectChiTietBaoCaoDoanhThuByMaBaoCaoDoanhThu
	@MaBaoCaoDoanhThu char(5)
AS BEGIN
	SELECT *
	FROM CHITIETBAOCAODT
	WHERE MaBaoCaoDoanhThu = @MaBaoCaoDoanhThu
END

------------------------------------------------------------------------------------------
-- selectChiTietBaoCaoMDByMaBaoCaoMaDo
CREATE PROCEDURE selectChiTietBaoCaoMDByMaBaoCaoMaDo
	@MaBaoCaoMatDo char(5)
AS BEGIN
	SELECT *
	FROM CHITIETBAOCAOMD
	WHERE MaBaoCaoMatDo = @MaBaoCaoMatDo
END

------------------------------------------------------------------------------------------
-- upload Phong by MaPhong
CREATE PROCEDURE xoaPhongByMaPhong
	@MaPhong char(5)
as begin
	UPDATE PHONG
	SET isDeleted = 1
	WHERE MaPhong = @MaPhong 
end	

------------------------------------------------------------------------------------------
-- selectPhongVoiTenPhong
CREATE PROCEDURE selectPhongVoiTenLoaiPhong
AS BEGIN
	SELECT MaPhong as 'Mã Phòng', TenPhong as 'Tên Phòng', TenLoaiPhong as 'Tên Loại Phòng', DonGiaThue as 'Đơn Giá Thuê', GhiChu as 'Ghi Chú' 
	FROM (PHONG inner join LOAIPHONG on	PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong) 
	WHere (PHONG.isDeleted = 0)
END

EXEC selectPhongVoiTenLoaiPhong

------------------------------------------------------------------------------------------
-- capNhatPhongByMaPhong 
CREATE PROCEDURE capNhatPhongByMaPhong
	@MaPhong char(5),
	@TenPhong nvarchar(50),
	@MaLoaiPhong char(5),
	@GhiChu nvarchar(300)
as begin
	UPDATE PHONG 
	SET TenPhong = @TenPhong,
		MaLoaiPhong = @MaLoaiPhong,
		GhiChu = @GhiChu	
	WHERE (MaPhong = @MaPhong)
end

------------------------------------------------------------------------------------------
-- NewLoaiKhachHang bởi mã tự động tăng
CREATE PROCEDURE NewLoaiKhachHang

	@TenLoaiKhachHang nvarchar(50),
	@HeSoKhach float

AS BEGIN

     IF exists (SELECT *FROM LOAIKHACHHANG)
     BEGIN
		 INSERT INTO LOAIKHACHHANG(MaLoaiKhachHang, TenLoaiKhachHang, HeSoKhach)
		 SELECT 
				'LK' + RIGHT('000' + CAST(LoaiKhach_ID + 1 AS NVARCHAR(3)), 3),
				@TenLoaiKhachHang,
				@HeSoKhach
		 FROM (
			  SELECT TOP 1 LoaiKhach_ID = CAST(RIGHT(MaLoaiKhachHang, 3) AS INT)
			  FROM LOAIKHACHHANG
			  ORDER BY MaLoaiKhachHang DESC
		 ) t
	END
	ELSE
	BEGIN
		INSERT INTO LOAIKHACHHANG(MaLoaiKhachHang, TenLoaiKhachHang, HeSoKhach)
		VALUES ('LK000', @TenLoaiKhachHang, @HeSoKhach)
	END
END 

------------------------------------------------------------------------------------------
-- capNhatThamSo
CREATE PROCEDURE capNhatThamSo
	@SoKhachToiDa int,
	@TiLePhuThu float

AS BEGIN
	Update THAMSO
	SET SoKhachToiDa = @SoKhachToiDa, TiLePhuThu = @TiLePhuThu
END

------------------------------------------------------------------------------------------
-- seledctPhieuThueByMaPhieuThue
CREATE PROCEDURE seledctPhieuThueByMaPhieuThue
	@MaPhieuThue char(5)
AS BEGIN
	SELECT * 
	FROM PHIEUTHUE
	WHERE (isDeleted = 0) AND
	(MaPhieuThue = @MaPhieuThue)
END

------------------------------------------------------------------------------------------
---- selectPhongAllisDelete
CREATE PROCEDURE selectPhongAllisDeleted
AS BEGIN
	SELECT * 
	FROM PHONG
END

------------------------------------------------------------------------------------------
---- capNhatPhieuThueByMaPhieuThue
CREATE PROCEDURE capNhatPhieuThueByMaPhieuThue
	@MaPhieuThue char(5),
	@MaPhong char(5),
	@NgayTraPhong smalldatetime,
	@NgayBatDauThue smalldatetime, 
	@DonGiaThueThucTe float

AS BEGIN
	UPDATE PHIEUTHUE
	SET MaPhong = @MaPhong, NgayTraPhong = @NgayTraPhong, NgayBatDauThue = @NgayBatDauThue, DonGiaThueThucTe = @DonGiaThueThucTe
	WHERE MaPhieuThue = @MaPhieuThue
END

------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------