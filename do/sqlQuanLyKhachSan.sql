create database QuanLyKhachSan

use QuanLyKhachSan

create table LOAIPHONG	
(
	MaLoaiPhong char(5) primary key,
	TenLoaiPhong varchar(50),
	DonGiaThue float,
	isDelete bit default 0,
)

create table PHONG
(
	MaPhong char(5) primary key,
	TenPhong varchar(50),
	MaLoaiPhong char(5),
	GhiChu nvarchar(300),
	isDelete bit default 0,

	foreign key(MaLoaiPhong) references LOAIPHONG(MaLoaiPhong)
)

create table TINHTRANG
(
	MaTinhTrang char(5) primary key,
	LoaiTinhTrang char(15),
	MaPhong char(5),
	Ngay smalldatetime,

	foreign key (MaPhong) references PHONG(MaPhong)
)

create table LOAIKHACHHANG
(
	MaLoaiKhachHang char(5) primary key,
	TenLoaiKhachHang varchar(50),
	HeSoKhach float
)

create table HOADON
(
	MaHoaDon char(5) primary key,
	TenKhachHangHD varchar(50),
	DiaChiKhachHD varchar(100),
	TriGiaHoaDon float
)

create table PHIEUTHUE
(
	MaPhieuthue char(5) primary key,
	MaPhong char(5),
	foreign key (MaPhong) references PHONG(MaPhong),

	NgayTraPhong smalldatetime,
	NgayBatDauThue smalldatetime, 
	DonGiaThueThucTe float,
	ThanhTienPhong float,

	MaHoaDon char(5),
	foreign key (MaHoaDon) references HOADON(MaHoaDon),

	PhuThuThucTe float,
)

create table CHITIETPHIEUTHUE
(
	 MaChiTietPhieuThue char(5) primary key,
	 MaPhieuThue char(5),
	 foreign key (MaPhieuThue) references PHIEUTHUE(MaPhieuThue),

	 TenKhachHang varchar(50),
	 MaLoaiKhachHang char(5),
	 foreign key (MaLoaiKhachHang) references LOAIKHACHHANG(MaLoaiKhachHang),

	 CMND varchar(50),
	 DiaChi varchar(100),
	 HeSoThucTe float
)

create table THAMSO
(
	SoKhachToiDa int,
	TiLePhuThu float
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
	Where isDelete = 0
end


-- Select LoaiPhong by id
CREATE PROCEDURE selectLoaiPhongByMaLoaiPhong
	@MaLoaiPhong char(5)
As begin
	Select MaLoaiPhong, TenLoaiPhong, DonGiaThue
	From LOAIPHONG
	Where (isDelete = 0) AND (MaLoaiPhong = @MaLoaiPhong)
end


-- Select PhongMoiNhat
CREATE PROCEDURE selectPhongMoiNhat
AS begin
	Select top 1 *
	From PHONG
	Where (isDelete = 0)
	Order by MaPhong DESC
end

--- Insert Phong
CREATE PROCEDURE insertPhong
	@MaPhong char(5),
	@TenPhong varchar(50),
	@MaLoaiPhong char(5),
	@GhiChu nvarchar(300)
AS BEGIN
	INSERT INTO PHONG(MaPhong, TenPhong, MaLoaiPhong, GhiChu) VALUES (@MaPhong, @TenPhong, @MaLoaiPhong, @GhiChu)
END

---------------------
-----------------

EXEC NewLoaiPhong 'VIP', 120000
EXEC NewLoaiPhong 'GOLD', 140000
EXEC NewLoaiPhong 'STANDAR', 100000

EXEC selectLoaiPhongAll 

EXEC selectLoaiPhongByMaLoaiPhong 'LP000'

EXEC insertPhong 'PH001', 'VIP69', 'LP001', N'Phòng này ở mát mẻ lắm nhé anh em - bà con' 

SELECT *FROM LOAIPHONG where isDelete = 0

Select top 1 * From PHONG where isDelete = 0 order by MaLoaiPhong DESC