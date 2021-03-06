USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLGARA')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLGARA') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLGARA]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLGARA]
GO

USE [QLGARA]
GO



CREATE TABLE PHIEUTIEPNHAN
(	
	maPhieuTiepNhan nvarchar(50) PRIMARY KEY,
	ngayTiepNhan datetime2
)

CREATE TABLE HIEUXE
(
	maHieuXe nvarchar(50) PRIMARY KEY,
	tenHieuXe nvarchar(50)
)

CREATE TABLE KHACHHANG
(
	maKhachHang nvarchar(50) PRIMARY KEY,
	tenChuXe nvarchar(50),
	tienNo int,
	email nvarchar(50),
	diachi nvarchar(50),
	dienthoai nvarchar(50)
)


CREATE TABLE XE
(
	bienSo nvarchar(50) PRIMARY KEY,
	maHieuXe nvarchar(50)  FOREIGN KEY REFERENCES HIEUXE(maHieuXe),
	maKhachHang nvarchar(50)  FOREIGN KEY REFERENCES KHACHHANG(maKhachHang)
)


CREATE TABLE CHITIETPHIEUTIEPNHAN
(
	maCTPTN	nvarchar(50)PRIMARY KEY not null,
	maPhieuTiepNhan nvarchar(50) FOREIGN KEY REFERENCES PHIEUTIEPNHAN(maPhieuTiepNhan),
	bienSo nvarchar(50)  FOREIGN KEY REFERENCES Xe(bienSo))

CREATE TABLE VATTU
(
	maVatTu nvarchar(50) PRIMARY KEY,
	tenVatTu nvarchar(50),
	soLuong int,
	donGia int
)


CREATE TABLE CHITIETPSC
(
    maChiTietPSC nvarchar(50) PRIMARY KEY,
	maPSC nvarchar(50) ,
	ngaySuaChua datetime2,
	bienSo nvarchar(50) FOREIGN KEY REFERENCES XE(bienSO),
	noidung nvarchar(50),
	maVatTu nvarchar(50) FOREIGN KEY REFERENCES VATTU(maVatTu),
	tienCong int ,
	thanhTien int
)


CREATE TABLE PHIEUTHUTIEN
(
	maPhieuThu nvarchar(50) PRIMARY KEY,
	bienSo nvarchar(50) FOREIGN KEY REFERENCES XE(bienSo),
	ngayThuTien datetime2,
	soTienThu int
)
CREATE TABLE DOANHTHU
(
	thang int,
	tongDoanhThu int,
	
	soLuotSua int	
)
CREATE TABLE BAOCAOTON
(
	maBaoCaoTon nvarchar(50) PRIMARY KEY,
	thangBaoCao nvarchar(50), 
	maVatTu nvarchar(50) FOREIGN KEY REFERENCES VATTU(maVatTu),
	tonDau int,
	phatSinh int,
	tonCuoi int
)

CREATE TABLE THAMSO
(
	soLuongNhapToiDa int
,soLuongXeTrongNgay int)


INSERT INTO HIEUXE(maHieuXe,tenHieuXe) VALUES('HD','HONDA')
INSERT INTO HIEUXE(maHieuXe,tenHieuXe) VALUES('TY','TOYOTA')
INSERT INTO HIEUXE(maHieuXe,tenHieuXe) VALUES('TS','TESLA')
INSERT INTO HIEUXE(maHieuXe,tenHieuXe) VALUES('KA','KIA')
INSERT INTO HIEUXE(maHieuXe,tenHieuXe) VALUES('PC','PORSCHE')
INSERT INTO HIEUXE(maHieuXe,tenHieuXe) VALUES('LX','LEXUS')
INSERT INTO HIEUXE(maHieuXe,tenHieuXe) VALUES('BM','BMW')
INSERT INTO HIEUXE(maHieuXe,tenHieuXe) VALUES('AD','AUDI')
INSERT INTO HIEUXE(maHieuXe,tenHieuXe) VALUES('GE','GENESIS')
INSERT INTO HIEUXE(maHieuXe,tenHieuXe) VALUES('TF','TOMFORD')
INSERT INTO THAMSO(soLuongNhapToiDa,soLuongXeTrongNgay) VALUES (30,0)


