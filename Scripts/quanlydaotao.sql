CREATE TABLE [buoihoc] (
[MaBH] varchar(15) NOT NULL,
[Ngay] date NULL DEFAULT NULL,
[TietBatDau] tinyint NULL DEFAULT NULL,
[SoTiet] tinyint NULL DEFAULT NULL,
PRIMARY KEY ([MaBH]) 
)
GO

CREATE TABLE [chucvu] (
[MaCV] varchar(15) NOT NULL,
[TenCV] varchar(255) NULL DEFAULT NULL,
PRIMARY KEY ([MaCV]) 
)
GO

CREATE TABLE [damnhiem] (
[MaGV] varchar(15) NOT NULL,
[MaCV] varchar(15) NOT NULL,
[NgayNC] date NULL DEFAULT NULL,
PRIMARY KEY ([MaGV], [MaCV]) 
)
GO

CREATE INDEX [MaCV] ON [damnhiem] ([MaCV])
GO

CREATE TABLE [giangday] (
[MaGD] varchar(15) NOT NULL,
[MaGV] varchar(15) NOT NULL,
[MaNHP] varchar(15) NOT NULL,
[MaHK] varchar(15) NOT NULL,
[GhiChuGD] varchar(255) NULL DEFAULT NULL,
PRIMARY KEY ([MaGD]) 
)
GO

CREATE INDEX [MaGD] ON [giangday] ([MaGD])
GO
CREATE INDEX [MaGV] ON [giangday] ([MaGV])
GO
CREATE INDEX [MaNHP] ON [giangday] ([MaNHP])
GO
CREATE INDEX [MaHK] ON [giangday] ([MaHK])
GO

CREATE TABLE [giaovien] (
[MaGV] varchar(15) NOT NULL,
[HoTenGV] varchar(255) NULL DEFAULT NULL,
[NgaySinh] date NULL DEFAULT NULL,
[DiaChi] varchar(255) NULL DEFAULT NULL,
[GioiTinh] tinyint NULL DEFAULT NULL,
[CMND] varchar(15) NULL DEFAULT NULL,
[MaKhoa] varchar(15) NOT NULL,
[MaHV] varchar(15) NOT NULL,
PRIMARY KEY ([MaGV]) 
)
GO

CREATE INDEX [giaovien_ibfk_1] ON [giaovien] ([MaKhoa])
GO
CREATE INDEX [MaHV] ON [giaovien] ([MaHV])
GO

CREATE TABLE [gvcn] (
[MaGV] varchar(15) NOT NULL,
[MaNL] varchar(15) NOT NULL,
[MaNH] varchar(15) NOT NULL,
[GhiChu] varchar(MAX) NULL DEFAULT NULL,
PRIMARY KEY ([MaGV], [MaNL], [MaNH]) 
)
GO

CREATE INDEX [MaNL] ON [gvcn] ([MaNL])
GO
CREATE INDEX [MaNH] ON [gvcn] ([MaNH])
GO

CREATE TABLE [hedt] (
[MaHDT] varchar(15) NOT NULL,
[TenHDT] varchar(255) NULL DEFAULT NULL,
PRIMARY KEY ([MaHDT]) 
)
GO

CREATE TABLE [hocky] (
[MaHK] varchar(15) NOT NULL,
[TenHK] varchar(255) NULL DEFAULT NULL,
[MaNH] varchar(15) NULL DEFAULT NULL,
PRIMARY KEY ([MaHK]) 
)
GO

CREATE TABLE [hocphan] (
[MaHP] varchar(15) NOT NULL,
[TenHP] varchar(255) NULL DEFAULT NULL,
[SoTietLT] int NULL DEFAULT NULL,
[SoTietTH] int NULL DEFAULT NULL,
[SoTC] int NULL DEFAULT NULL,
[MaKHDT] varchar(15) NULL DEFAULT NULL,
PRIMARY KEY ([MaHP]) 
)
GO

CREATE INDEX [MaKHDT] ON [hocphan] ([MaKHDT])
GO

CREATE TABLE [hocvi] (
[MaHV] varchar(15) NOT NULL,
[TenHV] varchar(255) NULL DEFAULT NULL,
[MoTa] varchar(MAX) NULL DEFAULT NULL,
PRIMARY KEY ([MaHV]) 
)
GO

CREATE TABLE [khdt] (
[MaKHDT] varchar(15) NOT NULL,
[TenKHDT] varchar(255) NULL DEFAULT NULL,
[MaTD] varchar(15) NULL DEFAULT NULL,
[MaHDT] varchar(15) NOT NULL,
[MaNganh] varchar(15) NOT NULL,
PRIMARY KEY ([MaKHDT]) 
)
GO

CREATE INDEX [MaHDT] ON [khdt] ([MaHDT])
GO
CREATE INDEX [MaTD] ON [khdt] ([MaTD])
GO
CREATE INDEX [MaNganh] ON [khdt] ([MaNganh])
GO

CREATE TABLE [khoa] (
[MaKhoa] varchar(15) NOT NULL,
[TenKhoa] varchar(255) NULL DEFAULT NULL,
PRIMARY KEY ([MaKhoa]) 
)
GO

CREATE TABLE [khoilop] (
[MaKL] varchar(15) NOT NULL,
[TenKL] varchar(255) NULL DEFAULT NULL,
[MaKhoa] varchar(15) NOT NULL,
[MaHDT] varchar(15) NOT NULL,
[MaTDDT] varchar(15) NOT NULL,
PRIMARY KEY ([MaKL]) 
)
GO

CREATE INDEX [MaKhoa] ON [khoilop] ([MaKhoa])
GO
CREATE INDEX [MaHDT] ON [khoilop] ([MaHDT])
GO
CREATE INDEX [MaTDDT] ON [khoilop] ([MaTDDT])
GO

CREATE TABLE [namhoc] (
[MaNH] varchar(15) NOT NULL,
[TenNH] varchar(255) NULL DEFAULT NULL,
PRIMARY KEY ([MaNH]) 
)
GO

CREATE INDEX [MaNH] ON [namhoc] ([MaNH])
GO

CREATE TABLE [nganh] (
[MaNganh] varchar(15) NOT NULL,
[TenNganh] varchar(255) NULL DEFAULT NULL,
[MaKhoa] varchar(15) NULL DEFAULT NULL,
PRIMARY KEY ([MaNganh]) 
)
GO

CREATE INDEX [MaKhoa] ON [nganh] ([MaKhoa])
GO

CREATE TABLE [nguoidung] (
[MaND] varchar(15) NOT NULL,
[TenDN] varchar(255) NULL DEFAULT NULL,
[MatKhau] varchar(255) NULL DEFAULT NULL,
[TenND] varchar(255) NULL DEFAULT NULL,
[Quyen] tinyint NULL DEFAULT NULL,
[MoTaQuyen] varchar(255) NULL DEFAULT NULL,
PRIMARY KEY ([MaND]) 
)
GO

CREATE TABLE [nhomhp] (
[MaNHP] varchar(15) NOT NULL,
[TenNHP] varchar(255) NULL DEFAULT NULL,
[MaHP] varchar(15) NULL DEFAULT NULL,
[MaKL] varchar(15) NULL DEFAULT NULL,
PRIMARY KEY ([MaNHP]) 
)
GO

CREATE INDEX [MaHP] ON [nhomhp] ([MaHP])
GO
CREATE INDEX [MaKL] ON [nhomhp] ([MaKL])
GO

CREATE TABLE [nhomlop] (
[MaNL] varchar(15) NOT NULL,
[TenNL] varchar(255) NULL DEFAULT NULL,
[MaKL] varchar(15) NOT NULL,
PRIMARY KEY ([MaNL]) 
)
GO

CREATE INDEX [MaKL] ON [nhomlop] ([MaKL])
GO

CREATE TABLE [phonghoc] (
[MaPhong] varchar(15) NOT NULL,
[ChucNang] varchar(255) NULL DEFAULT NULL,
[SucChua] int NULL DEFAULT NULL,
[DiaChi] varchar(255) NULL DEFAULT NULL,
PRIMARY KEY ([MaPhong]) 
)
GO

CREATE TABLE [tddt] (
[MaTD] varchar(15) NOT NULL,
[TenTD] varchar(255) NULL DEFAULT NULL,
PRIMARY KEY ([MaTD]) 
)
GO

CREATE TABLE [thoikhoabieu] (
[MaGD] varchar(15) NOT NULL,
[MaBH] varchar(15) NOT NULL,
[MaPhong] varchar(15) NOT NULL,
[CoDay] tinyint NULL DEFAULT NULL,
PRIMARY KEY ([MaGD], [MaBH], [MaPhong]) 
)
GO

CREATE INDEX [MaBH] ON [thoikhoabieu] ([MaBH])
GO
CREATE INDEX [MaPhong] ON [thoikhoabieu] ([MaPhong])
GO


ALTER TABLE [damnhiem] ADD CONSTRAINT [damnhiem_ibfk_1] FOREIGN KEY ([MaGV]) REFERENCES [giaovien] ([MaGV]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [damnhiem] ADD CONSTRAINT [damnhiem_ibfk_2] FOREIGN KEY ([MaCV]) REFERENCES [chucvu] ([MaCV]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [giangday] ADD CONSTRAINT [giangday_ibfk_1] FOREIGN KEY ([MaGV]) REFERENCES [giaovien] ([MaGV]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [giangday] ADD CONSTRAINT [giangday_ibfk_2] FOREIGN KEY ([MaNHP]) REFERENCES [nhomhp] ([MaNHP]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [giangday] ADD CONSTRAINT [giangday_ibfk_3] FOREIGN KEY ([MaHK]) REFERENCES [hocky] ([MaHK]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [giaovien] ADD CONSTRAINT [giaovien_ibfk_1] FOREIGN KEY ([MaKhoa]) REFERENCES [khoa] ([MaKhoa]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [giaovien] ADD CONSTRAINT [giaovien_ibfk_2] FOREIGN KEY ([MaHV]) REFERENCES [hocvi] ([MaHV]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [gvcn] ADD CONSTRAINT [gvcn_ibfk_1] FOREIGN KEY ([MaGV]) REFERENCES [giaovien] ([MaGV]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [gvcn] ADD CONSTRAINT [gvcn_ibfk_2] FOREIGN KEY ([MaNL]) REFERENCES [nhomlop] ([MaNL]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [gvcn] ADD CONSTRAINT [gvcn_ibfk_3] FOREIGN KEY ([MaNH]) REFERENCES [namhoc] ([MaNH]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [hocphan] ADD CONSTRAINT [hocphan_ibfk_1] FOREIGN KEY ([MaKHDT]) REFERENCES [khdt] ([MaKHDT]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [khdt] ADD CONSTRAINT [khdt_ibfk_1] FOREIGN KEY ([MaHDT]) REFERENCES [hedt] ([MaHDT]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [khdt] ADD CONSTRAINT [khdt_ibfk_2] FOREIGN KEY ([MaTD]) REFERENCES [tddt] ([MaTD]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [khdt] ADD CONSTRAINT [khdt_ibfk_3] FOREIGN KEY ([MaNganh]) REFERENCES [nganh] ([MaNganh]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [khoilop] ADD CONSTRAINT [khoilop_ibfk_1] FOREIGN KEY ([MaKhoa]) REFERENCES [khoa] ([MaKhoa]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [khoilop] ADD CONSTRAINT [khoilop_ibfk_2] FOREIGN KEY ([MaHDT]) REFERENCES [hedt] ([MaHDT]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [khoilop] ADD CONSTRAINT [khoilop_ibfk_3] FOREIGN KEY ([MaTDDT]) REFERENCES [tddt] ([MaTD]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [nganh] ADD CONSTRAINT [nganh_ibfk_1] FOREIGN KEY ([MaKhoa]) REFERENCES [khoa] ([MaKhoa]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [nhomhp] ADD CONSTRAINT [nhomhp_ibfk_1] FOREIGN KEY ([MaHP]) REFERENCES [hocphan] ([MaHP]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [nhomhp] ADD CONSTRAINT [nhomhp_ibfk_2] FOREIGN KEY ([MaKL]) REFERENCES [khoilop] ([MaKL]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [nhomlop] ADD CONSTRAINT [nhomlop_ibfk_1] FOREIGN KEY ([MaKL]) REFERENCES [khoilop] ([MaKL]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [thoikhoabieu] ADD CONSTRAINT [thoikhoabieu_ibfk_1] FOREIGN KEY ([MaGD]) REFERENCES [giangday] ([MaGD]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [thoikhoabieu] ADD CONSTRAINT [thoikhoabieu_ibfk_2] FOREIGN KEY ([MaBH]) REFERENCES [buoihoc] ([MaBH]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [thoikhoabieu] ADD CONSTRAINT [thoikhoabieu_ibfk_3] FOREIGN KEY ([MaPhong]) REFERENCES [phonghoc] ([MaPhong]) ON DELETE CASCADE ON UPDATE CASCADE
GO

