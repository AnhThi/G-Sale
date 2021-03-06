-----------------------------------BACKUP
alter proc sp_Backup
@tencsdl varchar(20),
@duongdan varchar(100)
as
	begin
		backup database @tencsdl
		to disk=@duongdan
	end
-----------------------------------RESTORE
alter proc sp_Restore
@tencsdl varchar(20),
@duongdan varchar(100)
as
	begin
		restore database @tencsdl
		from disk=@duongdan
	end
-----------------------------------NHAP BAN QUYEN
alter proc sp_Nhapbanquyen
@banquyen char(19)
as
	begin
		insert into MABANQUYEN
		values(@banquyen)
	end
-----------------------------------TRA VE MA BAN QUYEN
create proc sp_Tramabanquyen
@mabanquyen varchar(19) output
as
	begin
		set @mabanquyen=	(select mabq
									from MABANQUYEN)
	end

-----------------------------------KIEM TRA DANG KY
create proc sp_Kiemtradangky
as
	begin
		select *
		from QUANTRIVIEN
	end
-------------------------------------DOC BANG QUAN TRI VIEN
alter proc sp_Layquantrivien
@tenquantrivien nvarchar(30) output,
@tencuahang nvarchar(30) output,
@logo varbinary(8000) output,
@diachi nvarchar(50) output,
@sdt varchar(12) output,
@email varchar(25) output,
@website varchar(20) output

as
	begin
		set @tenquantrivien =(	select tenquantrivien
								from QUANTRIVIEN)
		set @tencuahang =(	select tencuahang
								from QUANTRIVIEN)
		set @logo =(	select logo
								from QUANTRIVIEN)
		set @diachi =(	select diachi
								from QUANTRIVIEN)
		set @sdt =(	select sdt
								from QUANTRIVIEN)
		set @email =(	select email
								from QUANTRIVIEN)
		set @website =(	select website
								from QUANTRIVIEN)
	end
-------------------------------------THEM QUAN TRI VIEN
alter proc sp_Themquantrivien
@tenquantrivien nvarchar(30),
@matkhau varchar(50),
@tencuahang nvarchar(30),
@logo image,
@diachi nvarchar(50),
@sdt varchar(12),
@email varchar(25),
@website varchar(20)
as
	begin
		if exists(	select *
					from QUANTRIVIEN
					where tenquantrivien=@tenquantrivien
				)
			return 1--QUAN TRI VIEN DA TON TAI
		else
			begin
				insert into QUANTRIVIEN
				values(@tenquantrivien, @matkhau, @tencuahang, @logo, @diachi, @sdt, @email, @website)
				return 0--THEM QUAN TRI VIEN THANH CONG
			end
	end
-------------------------------------SUA THONG TIN QUAN TRI VIEN
create proc sp_Suaquantrivien
@tenquantrivien nvarchar(30),
@matkhau varchar(50),
@tencuahang nvarchar(30),
@logo image,
@diachi nvarchar(50),
@sdt varchar(12),
@email varchar(25),
@website varchar(20)
as
	begin
		if exists(	select *
					from QUANTRIVIEN
					where tenquantrivien=@tenquantrivien)
			update QUANTRIVIEN
			set tenquantrivien=@tenquantrivien,
				matkhau=@matkhau,
				tencuahang=@tencuahang,
				logo=@logo,
				diachi=@diachi,
				sdt=@sdt,
				email=@email,
				website=@website
			where tenquantrivien=@tenquantrivien
	end
------------------------------------KIEM TRA DANG NHAP
create proc sp_Kiemtradangnhap
@ten nvarchar(30),
@matkhau varchar(50)
as
	begin
		if exists(	select *
					from QUANTRIVIEN
					where tenquantrivien=@ten and matkhau=@matkhau)
			return 0--DANG NHAP THANH CONG
		else
			return 1--DANG NHAP THAT BAI
	end
------------------------------------DOC BANG NHAN VIEN
alter proc sp_Docnhanvien
as
	begin
		select manv, hoten, ngaysinh, case when gioitinh=1 then 'Nam' else N'Nữ' end as[gioitinh], quequan, cmnd, loaicongviec, lcb, case when tinhtrang=0 then N'Đang làm việc' else N'Đã nghỉ việc' end as[tinhtrang]
		from NHANVIEN
	end
------------------------------------DOC BANG NHAN VIEN BAN HANG
alter proc sp_Docnhanvienbanhang
as
	begin
		select manv, hoten
		from NHANVIEN
		where loaicongviec like N'Bán Hàng'
	end
	
------------------------------------DOC SO LUONG NHAN VIEN TRONG BANG NHAN VIEN
create proc sp_Docsoluongnhanvien
@soluong int output
as
	begin
		set @soluong=(	select COUNT(manv)
						from NHANVIEN)
	end
-------------------------------------THEM NHAN VIEN
create proc sp_Themnhanvien
@manv char(4),
@hoten nvarchar(40),
@ngaysinh datetime,
@gioitinh bit,
@quequan nvarchar(50),
@cmnd varchar(12),
@loaicongviec nvarchar(12),
@lcb money,
@tinhtrang int
as
	begin
		if exists(	select *
					from NHANVIEN
					where manv=@manv)
			return 1--NHAN VIEN DA TON TAI
		else
			begin
				insert into NHANVIEN
				values(@manv, @hoten, @ngaysinh, @gioitinh, @quequan, @cmnd, @loaicongviec, @lcb, @tinhtrang)
				return 0--THEM NHAN VIEN THANH CONG
			end	
	end
-------------------------------------XOA NHAN VIEN
create proc sp_Xoanhanvien
@manv char(4)
as
	begin
		if exists(	select*
					from NHANVIEN
					where manv=@manv)
			begin
				delete NHANVIEN
				where manv=@manv
			end
	end
-------------------------------------SUA NHAN VIEN
create proc sp_Suanhanvien
@manv char(4),
@hoten nvarchar(40),
@ngaysinh datetime,
@gioitinh bit,
@quequan nvarchar(50),
@cmnd varchar(12),
@loaicongviec nvarchar(12),
@lcb money,
@tinhtrang int
as
	begin
		if exists(	select *
					from NHANVIEN
					where manv=@manv)
			begin
				update NHANVIEN
				set hoten=@hoten,
					ngaysinh=@ngaysinh,
					gioitinh=@gioitinh,
					quequan=@quequan,
					cmnd=@cmnd,
					loaicongviec=@loaicongviec,
					lcb=@lcb,
					tinhtrang=@tinhtrang
				where manv=@manv
			end
	end
----------------------------------------DOC BANG DANH MUC HANG HOA
create proc sp_Docdanhmuc
as
	begin
		select *
		from DANHMUCHH
	end
	
---------------------------------------THEM DANH MUC
alter proc sp_Themdanhmuc
@madm char(4),
@tendm nvarchar(50)
as
	begin
		if exists(	select *
					from DANHMUCHH
					where madm=@madm)
			return 1--DANH MUC DA TON TAI
		else
			begin
				insert into DANHMUCHH
				values(@madm, @tendm)
				return 0--THEM THANH CONG
			end
			
	end

-----------------------------------------XOA DANH MUC	
create proc sp_Xoadanhmuc
@madm char(4)
as
	begin
		if exists(	select *
					from DANHMUCHH
					where madm=@madm)
			begin
				delete DANHMUCHH
				where madm=@madm
			end
	end

-----------------------------------------SUA DANH MUC
alter proc sp_Suadanhmuc
@madm char(4),
@tendm nvarchar(50)
as
	begin
		update DANHMUCHH
		set madm=@madm, tendm=@tendm
		where madm=@madm
	end
---------------------------------------DOC BANG HANG HOA
create proc sp_Dochanghoa
as
	begin
		select *
		from HANGHOA
	end
---------------------------------------THEM HANG HOA
alter proc sp_Themhanghoa
@mahh char(4),
@tenhh nvarchar(100),
@madm char(4),
@dvt nvarchar(10),
@giagoc money,
@giaban money
as
	begin
		if exists(	select *
					from HANGHOA
					where mahh=@mahh)
			return 1
		else
			begin
				insert into HANGHOA
				values(@mahh, @tenhh, @madm, @dvt, @giagoc, @giaban)
				return 0
			end
	end
---------------------------------------XOA HANG HOA
create proc sp_Xoahanghoa
@mahh char(4)
as
	begin
		if exists (	select *
					from HANGHOA
					where mahh=@mahh)
			delete HANGHOA
			where mahh=@mahh
	end
---------------------------------------SUA HANG HOA
create proc sp_Suahanghoa
@mahh char(4),
@tenhh nvarchar(100),
@madm char(4),
@dvt nvarchar(10),
@giagoc money,
@giaban money
as
	begin
		if exists(	select *
					from HANGHOA
					where mahh=@mahh)
			update HANGHOA
			set mahh=@mahh,
				tenhh=@tenhh,
				madm=@madm,
				dvt=@dvt,
				giagoc=@giagoc,
				giaban=@giaban
			where mahh=@mahh
	end
---------------------------------------DOC BANG NHA CUNG CAP
create proc sp_Docnhacc
as
	begin
		select *
		from NHACC
	end
---------------------------------------THÊM NHÀ CUNG CẤP
alter proc sp_Themnhacc
@manhacc char(4),
@tennhacc nvarchar(100),
@diachi nvarchar(100),
@sdt varchar(12)
as
	begin
		if exists(	select *
					from NHACC
					where manhacc=@manhacc)
			return 1
		else
			begin
				insert into NHACC
				values(@manhacc, @tennhacc, @diachi, @sdt)
				return 0
			end
	end
---------------------------------------XÓA NHA CUNG CAP
create proc sp_Xoanhacc
@manhacc char(4)
as
	begin
		if exists(	select *
					from NHACC
					where manhacc=@manhacc)
			delete NHACC
			where manhacc=@manhacc
	end
---------------------------------------SUA NHA CUNG CAP
alter proc sp_Suanhacc
@manhacc char(4),
@tennhacc nvarchar(100),
@diachi nvarchar(100),
@sdt varchar(12)
as
	begin
		if exists(	select *
					from NHACC
					where manhacc=@manhacc)
			update NHACC
			set manhacc=@manhacc,
				tennhacc=@tennhacc,
				diachi=@diachi,
				sdt=@sdt
			where manhacc=@manhacc
	end
---------------------------------------LAY HANG HOA
alter proc sp_Layhanghoa
@tenhh nvarchar(100),
@tenhh_lay nvarchar(100) output,
@giaban money output
as
	begin
		set @tenhh_lay=(	select tenhh
							from HANGHOA
							where tenhh like '%'+@tenhh+'%')
		set @giaban=(	select giaban
							from HANGHOA
							where tenhh like '%'+@tenhh+'%')
	end