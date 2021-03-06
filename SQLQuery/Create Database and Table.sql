create database GSale_App on primary
(
	name='G-Sale',
	filename='D:\Studying\SQL\G-Sale App\G-Sale.mdf',
	size=3mb,
	maxsize=unlimited,
	filegrowth=2MB
)
log on
(
	name='G-Sale_Log',
	filename='D:\Studying\SQL\G-Sale App\G-Sale_log.ldf',
	size=3mb,
	maxsize=unlimited,
	filegrowth=2MB
)
-----TAO BANG CHUOI KET NOI------------
create table Chuoiketnoi
(
	chuoiketnoi varchar(120)
)

-----TAO BANG QUAN TRI VIÊN------------
create table QUANTRIVIEN
(
	tenquantrivien nvarchar(30) unique,
	matkhau varchar(50) not null,
	tencuahang nvarchar(30) not null,
	logo image,
	diachi nvarchar(50) not null,
	sdt varchar(12) not null,
	email varchar(25),
	website varchar(20)
)

-----TAO BANG NHANVIEN-----------------
create table NHANVIEN
(
	manv char(4) unique,
	hoten nvarchar(40) not null,
	ngaysinh datetime default(1995/01/01),
	gioitinh bit default(0),--la nu
	quequan nvarchar(50),
	cmnd varchar(12) not null,
	loaicongviec nvarchar(12) not null,
	lcb money not null,
	tinhtranghoatdong int default(0)--mac dinh dang hoat dong
	
	constraint PK_NHANVIEN primary key(manv)
)
---TAO BANG DANH MUC HANG HOA
create table DANHMUCHH-----------------
(
	madm char(4) unique,
	tendm nvarchar(20)
	
	constraint PK_DANHMUCHH primary key(madm),
)

---TAO BANG HANG HOA-------------------
create table HANGHOA
(
	mahh char(4) unique,
	tenhh nvarchar(100),
	madm char(4),
	dvt nvarchar(10),
	giagoc money,
	giaban money,
	tienloi as giaban-giagoc
	
	constraint PK_HANGHOA primary key(mahh),
	constraint FK_HANGHOA_DANHMUCHH foreign key(madm) references DANHMUCHH(madm) 
)

---TAO BANG NHA CUNG CAP-----------------
create table NHACC
(
	manhacc char(4) unique,
	tennhacc nvarchar(100),
	diachi nvarchar(100),
	sdt varchar(12)
	
	constraint PK_NHACC primary key(manhacc)
)

---TAO BANG DON DAT HANG-----------------
create table DONDH
(
	sodh char(4) unique,
	ngaydh datetime,
	manhacc char(4)
	
	constraint PK_DONDH primary key(sodh),
	constraint FK_DONDH_NHACC foreign key(manhacc) references NHACC(manhacc) 
)

---TAO BANG CHI TIET DON DAT HANG---------
create table CTDONDH
(
	sodh char(4),
	mahh char(4),
	soluongdat int
	
	constraint PK_CTDONDH primary key(sodh, mahh),
	constraint FK_CTDONDH_HANGHOA foreign key(mahh) references HANGHOA(mahh),
	constraint FK_CTDONDH_DONDH foreign key(sodh) references DONDH(sodh)   
)

---TAO BANG PHIEU NHAP--------------------
create table PNHAP
(
	sopn char(4),
	ngaynhap datetime,
	sodh char(4)
	
	constraint PK_PNHAP primary key(sopn),
	constraint FK_PNHAP_DONDH foreign key(sodh) references DONDH(sodh)
)

---TAO BANG CHI TIET PHIEU NHAP------------
create table CTPNHAP
(
	sopn char(4),
	mahh char(4),
	slnhap int,
	dgnhap money
	
	constraint PK_CTPNHAP primary key(sopn, mahh),
	constraint FK_CTPNHAP_HANGHOA foreign key(mahh) references HANGHOA(mahh),
	constraint FK_CTPNHAP_PNHAP foreign key(sopn) references PNHAP(sopn) 
)

--TAO BANG PHIEU XUAT----------------------
create table PXUAT
(
	sopx char(4),
	manv char(4),
	ngayxuat datetime,
	tenkh nvarchar(30)
	
	constraint PK_PXUAT primary key(sopx),
	constraint FK_PXUAT_NHANVIEN foreign key(manv) references NHANVIEN(manv) 
)

--TAO BANG CHI TIET PHIEU XUAT--------------
create table CTPXUAT
(
	sopx char(4),
	mahh char(4),
	slxuat int,
	dgxuat money
	
	constraint PK_XTPXUAT primary key(sopx, mahh),
	constraint FK_CTPXUAT_HANGHOA foreign key(mahh) references HANGHOA(mahh),
	constraint FK_CTPXUAT_PXUAT foreign key(sopx) references PXUAT(sopx) 
)

--TAO BANG TON KHO---------------------------
create table TONKHO
(
	namthang char(6),
	mahh char(4),
	sldau int,
	tongslnhap int,
	tongslxuat int,
	slcuoi as (sldau + tongslnhap) - tongslxuat
	
	constraint PK_TONKHO primary key(namthang, mahh),
	constraint FK_TONKHO_HANGHOA FOREIGN KEY(mahh) REFERENCES HANGHOA(mahh) 
)

--TAO BANG MA BAN QUYEN
create table MABANQUYEN
(
	mabq char(19)
)