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
	maPhieuTiepNhan nvarchar(10) PRIMARY KEY,
	ngayTiepNhan datetime2
)

CREATE TABLE HIEUXE
(
	maHieuXe nvarchar(10) PRIMARY KEY,
	tenHieuXe nvarchar(10)
)
CREATE TABLE KHACHHANG
(
	MaKhachHang nvarchar(10) PRIMARY KEY,
	TenChuXe nvarchar(10),
	TienNo int,
	Email nvarchar(10),
	DiaChi nvarchar(10),
	DienTho	ai nvarchar(10)
)


CREATE TABLE XE
(
	bienSo nvarchar(10) PRIMARY KEY,
	maHieuXe nvarchar(10)  FOREIGN KEY REFERENCES HIEUXE(maHieuXe),
	maKhachHang nvarchar(10)  FOREIGN KEY REFERENCES KHACHHANG(maKhachHang)
)

CREATE TABLE CHITIETPHIEUTIEPNHAN
(
	maCTPTN	nvarchar(10)PRIMARY KEY not null,
	maPhieuTiepNhan nvarchar(10) FOREIGN KEY REFERENCES PHIEUTIEPNHAN(maPhieuTiepNhan),
	bienSo nvarchar(10)  FOREIGN KEY REFERENCES Xe(bienSo),
	soLuongTiepNhan int
)

CREATE TABLE VATTU
(
	MaVatTu nvarchar(10) PRIMARY KEY,
	TenVatTu nvarchar(10),
	SoLuong int,
	DonGia int
)

CREATE TABLE PHIEUSUACHUA
(
	maPSC nvarchar(10) PRIMARY KEY,
	ngaySuaChua datetime2
)

CREATE TABLE CHITIETPSC
(
	MaPhieuSuaChua nvarchar(10) FOREIGN KEY REFERENCES PHIEUSUACHUA(maPSC),
	BienSo nvarchar(10) FOREIGN KEY REFERENCES Xe(bienSO),
	NoiDungSuaChua nvarchar(10),
	MaVatTu nvarchar(10) FOREIGN KEY REFERENCES VATTU(maVatTu),
	TienCong int,
	ThanhTien int
)

CREATE TABLE PHIEUTHUTIEN
(
	MaPhieuThu nvarchar(10) PRIMARY KEY,
	BienSo nvarchar(10) FOREIGN KEY REFERENCES XE(BienSo),
	NgayThuTien datetime2,
	SoTienThu int
)
CREATE TABLE DOANHTHU
(
	Thang int,
	TongDoanhThu int,
	MaPhieuSuaChua nvarchar(10) FOREIGN KEY REFERENCES CHITIETPSC(MaPhieuSuaChua),
	SoLuotSua int,	
	ThanhTien int
)
CREATE TABLE BAOCAOTON
(
	MaBaoCaoTon nvarchar(10) PRIMARY KEY,
	ThangBaoCao nvarchar(10), 
	MaVatTu nvarchar(10) FOREIGN KEY REFERENCES VATTU(MaVatTu),
	TonDau int,
	PhatSinh int,
	TonCuoi int
)
CREATE TABLE THAMSO
(
	soLuongNhapToiDa int
)


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

