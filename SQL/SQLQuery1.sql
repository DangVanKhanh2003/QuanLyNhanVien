CREATE DATABASE QuanLyNhanVien
USE QuanLyNhanVien

CREATE TABLE PhongBan(
		maPhongBan VARCHAR(20),
		tenPhongBan NVARCHAR(70),
		CONSTRAINT PK_PhongBan PRIMARY KEY(maPhongBan)

)

CREATE TABLE ChucVu(
		maChucVu VARCHAR(20),
		tenChucVu NVARCHAR(70),
		maPhongBan VARCHAR(20),
		CONSTRAINT PK_ChucVu PRIMARY KEY(maChucVu),
		CONSTRAINT FK_ChucVu_PhongBan FOREIGN KEY (maPhongBan) REFERENCES PhongBan(maPhongBan)
)


CREATE TABLE NhanVien(
		maNV VARCHAR(20),
		hoTen NVARCHAR(40),
		diaChi NVARCHAR(300),
		sdt VARCHAR(11),
		cccd VARCHAR(15),
		mail VARCHAR(100),
		ngaySinh Date,
		ngayVaoCTy Date,
		gioiTinh NVARCHAR(3),
		maChucVu VARCHAR(20),
		CONSTRAINT PK_NhanVien PRIMARY KEY (maNV),
		CONSTRAINT FK_NhanVien_ChucVu FOREIGN KEY (maChucVu) REFERENCES ChucVu(maChucVu)
		)

CREATE TABLE NghiPhep(
		maNghiPhep VARCHAR(20),
		maNV VARCHAR(20),
		tuNgay Date,
		denNgay Date
		CONSTRAINT PK_NghiPhep PRIMARY KEY (maNghiPhep),
		CONSTRAINT FK_NghiPhep_NhanVien FOREIGN KEY (maNV) REFERENCES NhanVien(maNV)
)

CREATE TABLE Luong(
		maLuong VARCHAR(20),
		maNV VARCHAR(20),
		thangNam Varchar(10),
		luongCung MONEY,
		luongThuong MONEY,
		luongUngTruoc MONEY,
		phuCap MONEY,
		CONSTRAINT PK_Luong PRIMARY KEY (maLuong),
		CONSTRAINT FK_Luong_NhanVien FOREIGN KEY (maNV) REFERENCES NhanVien(maNV)
)


CREATE TABLE TaiKhoan(
		maTK VARCHAR(20),
		tenDangNhap VARCHAR(50),
		matKhau Varchar(50),
		maNV VARCHAR(20),
		loaiTK VARCHAR(20),
		CONSTRAINT PK_TaiKhoan PRIMARY KEY (maTK),
		CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY (maNV) REFERENCES NhanVien(maNV)
)

CREATE TABLE PhanHoi(
		maPhanHoi VARCHAR(20),
		maNV VARCHAR(20),
		noiDung VARCHAR(MAX),
		thoiGian DATETIME,
		CONSTRAINT PK_PhanHoi PRIMARY KEY (maPhanHoi),
		CONSTRAINT FK_PhanHoi_NhanVien FOREIGN KEY (maNV) REFERENCES NhanVien(maNV)
)

