create database QuanLyKhachSan

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
	TenKhachHangHD varchar(50),
	DiaChiKhachHD varchar(100),
	TriGiaHoaDon float

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

	MaHoaDon char(5) default null,
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
	TiLeDoanhThu float
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
	TiLeSuDung float
)


-- Insert LoaiPhong với mã tự động tăng

if exists (select * from sysobjects where name = 'LOAIPHONG' and type = 'P')
    drop procedure NewLoaiPhong
go
CREATE PROCEDURE NewLoaiPhong

     @TenLoaiPhong VARCHAR(50),
     @DonGiaThue float

AS BEGIN

-- on show: X row(s) affected 
--SET NOCOUNT ON  

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

-- Select all LoaiPhong
CREATE PROCEDURE selectLoaiPhongAll
As begin
	Select MaLoaiPhong, TenLoaiPhong, DonGiaThue 
	From LOAIPHONG
	Where isDeleted = 0
end


-- Select LoaiPhong by id
CREATE PROCEDURE selectLoaiPhongByMaLoaiPhong
	@MaLoaiPhong char(5)
As begin
	Select MaLoaiPhong, TenLoaiPhong, DonGiaThue
	From LOAIPHONG
	Where (isDeleted = 0) AND (MaLoaiPhong = @MaLoaiPhong)
end


-- Select PhongMoiNhat
CREATE PROCEDURE selectPhongMoiNhat
AS begin
	Select top 1 *
	From PHONG
	Where (isDeleted = 0)
	Order by MaPhong DESC
end

--- Insert Phong với mã tự động tăng
CREATE PROCEDURE NewPhong

	@TenPhong nvarchar(50),
	@MaLoaiPhong char(5),
	@GhiChu nvarchar(300)

AS BEGIN

-- on show: X row(s) affected 
--SET NOCOUNT ON  

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

-- Select PhongAll
CREATE PROCEDURE selectPhongAll
AS BEGIN
	SELECT MaPhong, TenPhong, MaLoaiPhong, GhiChu
	FROM PHONG 
	WHERE isDeleted = 0
END	

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

-- Select ThamSoAll
CREATE PROCEDURE selectThamSoAll
AS BEGIN
	SELECT SoKhachToiDa, TiLePhuThu
	FROM THAMSO
	WHERE id = 1
END

-- Select LoaiKhachHangAll
CREATE PROCEDURE selectLoaiKhachHangAll
AS BEGIN
	SELECT MaLoaiKhachHang, TenLoaiKhachHang, HeSoKhach
	FROM LOAIKHACHHANG
	WHERE isDeleted = 0
END

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
		 INSERT INTO PHIEUTHUE(MaPhieuThue, MaPhong, NgayTraPhong, NgayBatDauThue, DonGiaThueThucTe, ThanhTienPhong, MaHoaDon, PhuThuThucTe)
		 SELECT 
				'PT' + RIGHT('000' + CAST(PhieuThue_ID + 1 AS NVARCHAR(3)), 3),
				@MaPhong,
				@NgayTraPhong ,
				@NgayBatDauThue , 
				@DonGiaThueThucTe ,
				@ThanhTienPhong ,
				null,
				@PhuThuThucTe 
		 FROM (
			  SELECT TOP 1 PhieuThue_ID = CAST(RIGHT(MaPhieuThue, 3) AS INT)
			  FROM PHIEUTHUE
			  ORDER BY MaPhieuThue DESC
		 ) t
	END
	ELSE
	BEGIN
		INSERT INTO PHIEUTHUE(MaPhieuThue, MaPhong, NgayTraPhong, NgayBatDauThue, DonGiaThueThucTe, ThanhTienPhong, MaHoaDon, PhuThuThucTe) 
		VALUES ('PT000', @MaPhong, @NgayTraPhong, @NgayBatDauThue, @DonGiaThueThucTe, @ThanhTienPhong, null, @PhuThuThucTe)
	END
END 


-- Insert ChiTietPhieuThue với mã tự động tăng
CREATE PROCEDURE NewChiTietPhieuThue

	 @MaPhieuThue char(5),
	 @TenKhachHang nvarchar(50),
	 @MaLoaiKhachHang char(5),
	 @CMND varchar(50),
	 @DiaChi nvarchar(100),
	 @HeSoThucTe float

AS BEGIN

-- on show: X row(s) affected 
--SET NOCOUNT ON  

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

-- select LoaiKhachHangByMaLoaiKhach
CREATE PROCEDURE selectLoaiKhachHangByMaLoaiKhach
	@MaLoaiKhach char(5)
AS BEGIN
	SELECT MaLoaiKhachHang, TenLoaiKhachHang, HeSoKhach
	FROM LOAIKHACHHANG
	WHERE MaLoaiKhachHang = @MaLoaiKhach
END

-- Insert TinhTrang với mã tự động tăng
CREATE PROCEDURE NewTinhTrang

	@LoaiTinhTrang varchar(15),
	@MaPhong char(5),
	@NgayCuaTinhTrang smalldatetime

AS BEGIN

-- on show: X row(s) affected 
--SET NOCOUNT ON  

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

-- select TinhTrangPhongByThoiGian
CREATE PROCEDURE selectTinhTrangPhongByThoiGian
	@NgayBatDau smalldatetime,
	@NgayKetThuc smalldatetime
AS BEGIN
	SELECT TenPhong, NgayCuaTinhTrang, LoaiTinhTrang, DonGiaThue
	FROM (TINHTRANG INNER JOIN PHONG ON PHONG.MaPhong = TINHTRANG.MaPhong)
		INNER JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong
	WHERE NgayCuaTinhTrang BETWEEN @NgayBatDau AND @NgayKetThuc
END

-- update capNhatTinhTrangPhongByMaPhong
CREATE PROCEDURE capNhatTinhTrangPhongByMaPhong
	@MaPhong char(5),
	@NgayCuaTinhTrang smalldatetime
AS BEGIN
	UPDATE TINHTRANG
	SET LoaiTinhTrang = 'DA THUE'
	WHERE (MaPhong = @MaPhong) AND NgayCuaTinhTrang = @NgayCuaTinhTrang
END

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

-- selectPhongKhongTenPhong
CREATE PROCEDURE selectPhongKhongTenPhong
	@MaPhong char(5),
	@MaLoaiPhong char(5),
	@DonGiaThue float,
	@LoaiTinhTrang char(15),
	@NgayBatDau smalldatetime,
	@NgayTraPhong smalldatetime
AS BEGIN
	SELECT PHONG.MaPhong, TenPhong, TenLoaiPhong, DonGiaThue, LoaiTinhTrang, NgayCuaTinhTrang
	FROM ((TINHTRANG INNER JOIN PHONG ON PHONG.MaPhong = TINHTRANG.MaPhong)
			INNER JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong)
	WHERE ((@NgayBatDau <= NgayCuaTinhTrang) AND (NgayCuaTinhTrang <= @NgayTraPhong)) AND
			(PHONG.isDeleted = 0) AND
			(LOAIPHONG.MaLoaiPhong = @MaLoaiPhong) AND
			(DonGiaThue = @DonGiaThue) AND
			(LoaiTinhTrang = @LoaiTinhTrang) AND
			(PHONG.MaPhong = @MaPhong)
END

-- selectPhongKhongMaPhong
CREATE PROCEDURE selectPhongKhongMaPhong
	@TenPhong nvarchar(50),
	@MaLoaiPhong char(5),
	@DonGiaThue float,
	@LoaiTinhTrang char(15),
	@NgayBatDau smalldatetime,
	@NgayTraPhong smalldatetime
AS BEGIN
	SELECT PHONG.MaPhong, TenPhong, TenLoaiPhong, DonGiaThue, LoaiTinhTrang, NgayCuaTinhTrang
	FROM ((TINHTRANG INNER JOIN PHONG ON PHONG.MaPhong = TINHTRANG.MaPhong)
			INNER JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong)
	WHERE ((@NgayBatDau <= NgayCuaTinhTrang) AND (NgayCuaTinhTrang <= @NgayTraPhong)) AND
			(PHONG.isDeleted = 0) AND
			(LOAIPHONG.MaLoaiPhong = @MaLoaiPhong) AND
			(DonGiaThue = @DonGiaThue) AND
			(LoaiTinhTrang = @LoaiTinhTrang) AND
			(PHONG.TenPhong = @TenPhong)
END

-- selectPhongByMaPhongNgayBatDauNgayTraPhong
CREATE PROCEDURE selectPhongByMaPhongNgayBatDauNgayTraPhong
	@MaPhong char(5),
	@NgayBatDau smalldatetime,
	@NgayTraPhong smalldatetime
AS BEGIN
	SELECT PHONG.MaPhong, TenPhong, TenLoaiPhong, DonGiaThue, LoaiTinhTrang, NgayCuaTinhTrang
	FROM ((TINHTRANG INNER JOIN PHONG ON PHONG.MaPhong = TINHTRANG.MaPhong)
			INNER JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong)
	WHERE ((@NgayBatDau <= NgayCuaTinhTrang) AND (NgayCuaTinhTrang <= @NgayTraPhong)) AND
			(PHONG.isDeleted = 0) AND
			(PHONG.MaPhong = @MaPhong)
END

-- selectPhongByTenPhongNgayBatDauNgayTraPhong
CREATE PROCEDURE selectPhongByTenPhongNgayBatDauNgayTraPhong
	@TenPhong nvarchar(50),
	@NgayBatDau smalldatetime,
	@NgayTraPhong smalldatetime
AS BEGIN
	SELECT PHONG.MaPhong, TenPhong, TenLoaiPhong, DonGiaThue, LoaiTinhTrang, NgayCuaTinhTrang
	FROM ((TINHTRANG INNER JOIN PHONG ON PHONG.MaPhong = TINHTRANG.MaPhong)
			INNER JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong)
	WHERE ((@NgayBatDau <= NgayCuaTinhTrang) AND (NgayCuaTinhTrang <= @NgayTraPhong)) AND
			(PHONG.isDeleted = 0) AND
			(PHONG.TenPhong = @TenPhong)
END

---------------------
-----------------

EXEC NewLoaiPhong 'VIP', 120000
EXEC NewLoaiPhong 'GOLD', 140000
EXEC NewLoaiPhong 'STANDAR', 100000

EXEC selectLoaiPhongAll 

EXEC selectLoaiPhongByMaLoaiPhong 'LP000'

EXEC selectThamSoAll

EXEC NewPhong 'VIP69', 'LP001', 'Phòng này ở mát mẻ lắm nhé anh em - bà con' 

EXEC selectPhongMoiNhat

EXEC selectPhongAll

EXEC selectPhieuThueMoiNhat

EXEC selectLoaiKhachHangAll

EXEC NewChiTietPhieuThue 'PT027', N'Nguyễn Văn A', 'LK000', '299933234', N'Khóm An Lạc', 1.2

EXEC NewPhieuThue 'PH001', '01/01/2001', '01/01/2002', 1.2, 2999, 1.2

EXEC selectLoaiKhachHangByMaLoaiKhach 'LK000'

EXEC NewTinhTrang 'TRONG', 'PH000', '01/01/2001' 

EXEC selectTinhTrangPhongByThoiGian '9/1/2017','9/2/2017'

EXEC capNhatTinhTrangPhongByMaPhong 'PH000', '06/01/2017'

EXEC phongDuocThue 'PH000', '6/1/2017', '6/20/2017' 

EXEC selectPhongAllByNgayBatDauVaNgayTraPhong '6/1/2017', '6/1/2017' 

EXEC selectPhongKhongMaPhongKhongTenPhong 'LP000', '120000', 'TRONG', '6/1/2017', '6/5/2017'

EXEC selectPhongKhongTenPhong 'PH001', 'LP000', '120000', 'TRONG', '6/1/2017', '6/1/2017'

EXEC selectPhongKhongMaPhong N'Phòng Lạnh', 'LP000', '120000', 'TRONG', '6/1/2017', '6/1/2017'

Insert into LOAIKHACHHANG(MaLoaiKhachHang, TenLoaiKhachHang, HeSoKhach) values ('LK000', 'LKVIP', 1.2)
Insert into LOAIKHACHHANG(MaLoaiKhachHang, TenLoaiKhachHang, HeSoKhach) values ('LK001', 'LKSTANDAR', 1)

SELECT *FROM LOAIPHONG where isDelete = 0

Select top 1 * From PHONG where isDelete = 0 order by MaPhong DESC

INSERT INTO PHIEUTHUE(MaPhieuThue, MaPhong, NgayTraPhong, NgayBatDauThue, DonGiaThueThucTe, ThanhTienPhong, MaHoaDon, PhuThuThucTe) VALUES ('PT000', 'PH001', '01/21/2001', '02/13/2001', 170000, 200000, null, 1.1)

select * FRom CHITIETPHIEUTHUE

select* FRom PHIEUTHUE

DELETE FROM PHONG
