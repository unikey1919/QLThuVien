CREATE DATABASE DoAnLTWIN
GO
USE DoAnLTWIN
GO


CREATE TABLE Account
(
  UserName NVARCHAR(50) PRIMARY KEY,
  PassWord NVARCHAR(50),
  type NVARCHAR(20) DEFAULT N'Sinh Viên', --1:Admin. 0:SV 2:GiaoVien
  MaThe CHAR(5) 
)
GO

INSERT INTO dbo.Account
        ( UserName, PassWord, type, MaThe )
VALUES  ( N'user01', -- UserName - nvarchar(50)
          N'12', -- PassWord - nvarchar(50)
          N'Giáo Viên', -- type - nvarchar(20)
          '2'  -- MaThe - char(5)
          )
SELECT * FROM dbo.SACH
CREATE TABLE SACH
(
	MaSach		CHAR(5) PRIMARY KEY,
	TenSach		NVARCHAR(200) NOT NULL,
	TheLoai		NVARCHAR(50) NOT NULL,
	TinhTrang	NVARCHAR(20),
	SoLuong		INT NOT NULL,
	NXB			NVARCHAR(200)NOT NULL,
	NamXB		NVARCHAR(20) NOT NULL,
	TG			NVARCHAR(200) NOT NULL
	
)
GO
SELECT * FROM dbo.SACHTVMUON
CREATE TABLE SACHTVMUON
(
    MaThe       CHAR(5),
	MaSach		CHAR(5) PRIMARY KEY,
	TenSach		NVARCHAR(200) NOT NULL,
	TheLoai		NVARCHAR(50) NOT NULL,
	TinhTrang	NVARCHAR(20),
	SoLuong		INT NOT NULL,
	NXB			NVARCHAR(200)NOT NULL,
	NamXB		NVARCHAR(20) NOT NULL,
	TG			NVARCHAR(200) NOT NULL
	
)
GO

CREATE TABLE THETHUVIEN
(
	MaThe		CHAR(5)  PRIMARY KEY,
	TenSV		NVARCHAR(100) NOT NULL,
	Gioitinh	NCHAR(10) NOT NULL,
	NgaySinh	DATE,
	DiaChiSV	NVARCHAR(200) NOT NULL,
	DienThoaiSV	NVARCHAR(20),
	NgayTao		DATE NOT NULL,
	NgayHetHan	DATE NOT NULL,
	
)
GO




CREATE TABLE PHIEUNHACTRA
(
	MaPNT		CHAR(5) PRIMARY KEY,
	MaThe		CHAR(5) NOT NULL,	
	NgayLap		DATETIME NOT NULL,
	DonGiaPhat	INT NOT NULL,
	MaSach		CHAR(5) NOT NULL	
) 
GO

CREATE TABLE PHIEUMUON
(
	MaPM		CHAR(5) PRIMARY KEY,
	MaSach		CHAR(5) NOT NULL,
	MaThe		CHAR(5) NOT NULL,
	NgayMuon	DATETIME NOT NULL,
)
GO
CREATE TABLE SACHMUON
(
	MaPM		CHAR(5) PRIMARY KEY,
	MaSach		CHAR(5),
	TinhTrang	NVARCHAR(20),
	SLSachMuon	INT NOT NULL,
	NgayTra		DATETIME NOT NULL,
	
)
GO

CREATE TABLE SACHTRATHANHCONG
(  
    MaPM		CHAR(5),
	MaSach		CHAR(5),
	TinhTrang	NVARCHAR(20),
	SLSachMuon	INT NOT NULL,
	NgayTra		DATETIME NOT NULL DEFAULT GETDATE(),
	NgayHetHan  DATETIME
)
GO

CREATE TABLE TVMUON
( 
  MaThe    CHAR(5),
  TenSach  NVARCHAR(200) NOT NULL,
  SoLuong  INT NOT NULL,
  NgayChoMuon DATE NOT NULL DEFAULT GETDATE()
 )
 GO
 
 SELECT * FROM dbo.TVMUON
 UPDATE dbo.TVMUON SET TenSach=N'Quản lí Ứng Dụng Mới' WHERE TenSach=N'Quản Lí Ứng Dụng'

CREATE TABLE NHOM
 (
   groupid CHAR(5)  PRIMARY KEY,
   name    NVARCHAR(50) NOT NULL DEFAULT N'Khác'
  )
  GO
  
 INSERT INTO dbo.NHOM
         ( groupid, name )
 VALUES  ( '2', -- groupid - char(5)
           N'Giáo Viên'  -- name - char(5)
           )

SELECT * FROM dbo.NHOM


SELECT DISTINCT Sex.name,Sex.Nam,Sex.Nu,Tong.Tong
 FROM
(SELECT ChucVu, COUNT(MaThe) AS Tong  FROM dbo.THETHUVIEN GROUP BY ChucVu) AS Tong,
(SELECT  Nam.name,Nam.GT AS Nam,Nu.GT AS Nu
FROM    dbo.THETHUVIEN,  (SELECT name,COUNT(dbo.THETHUVIEN.Gioitinh) AS GT
                      FROM NHOM LEFT JOIN  dbo.THETHUVIEN ON name=ChucVu AND Gioitinh=N'Nam'

                      GROUP BY name) AS Nam,


                     (SELECT name,COUNT(dbo.THETHUVIEN.Gioitinh) AS GT
                      FROM NHOM LEFT JOIN  dbo.THETHUVIEN ON name=ChucVu AND Gioitinh=N'Nữ'

                      GROUP BY name) AS Nu
WHERE Nam.name=Nu.name) AS Sex  
WHERE Sex.name=Tong.ChucVu 


SELECT * FROM dbo.SACH

SELECT SUM(SoLuong) FROM dbo.SACH WHERE TheLoai=N''



SELECT * FROM dbo.Account



ALTER TABLE dbo.SACHMUON ADD PRIMARY KEY(MaPM)


---Tao Rang Buoc khoa ngoai


ALTER TABLE dbo.Account ADD CONSTRAINT FRK_Account_THETHUVIEN FOREIGN KEY(MaThe) REFERENCES dbo.THETHUVIEN(MaThe)
ALTER TABLE dbo.SACHMUON ADD CONSTRAINT FRK_SACHMUON_PHIEUMUON FOREIGN KEY(MaPM) REFERENCES dbo.PHIEUMUON(MaPM)
ALTER TABLE SACHMUON ADD CONSTRAINT FRK_SACHMUON_SACH FOREIGN KEY(MaSach) REFERENCES SACH(MaSach) 

ALTER TABLE PHIEUNHACTRA ADD CONSTRAINT FRK_PHIEUNHACTRA_SACH FOREIGN KEY(MaSach) REFERENCES SACH(MaSach)  
ALTER TABLE PHIEUNHACTRA ADD CONSTRAINT FRK_PHIEUNHACTRA_THETHUVIEN FOREIGN KEY(MaThe) REFERENCES THETHUVIEN(MaThe)


ALTER TABLE PHIEUMUON ADD CONSTRAINT FRK_PHIEUMUON_SACH FOREIGN KEY(MaSach) REFERENCES SACH(MaSach) 
ALTER TABLE PHIEUMUON ADD CONSTRAINT FRK_PHIEUMUON_THETHUVIEN FOREIGN KEY(MaThe) REFERENCES THETHUVIEN(MaThe)

ALTER TABLE dbo.TVMUON WITH CHECK ADD FOREIGN KEY(MaThe) REFERENCES dbo.THETHUVIEN(MaThe)


GO

---Tao rang buoc
ALTER TABLE SACH ADD CONSTRAINT DEF_SACH_SoLuong  CHECK(SoLuong>0)



--PROC Account
CREATE PROC USP_Login
@userName NVARCHAR(100),@passWord NVARCHAR(100)
AS
BEGIN
     SELECT * FROM dbo.Account WHERE UserName=@userName AND PassWord=@passWord
END
GO

SELECT * FROM dbo.THETHUVIEN
--PROC STUDENTUSER
ALTER PROC USP_InsertStudentUser
    @MaThe		CHAR(5),
	@TenSV		NVARCHAR(100),
	@Gioitinh	NCHAR(10),
	@NgaySinh   DATE,
	@DiaChiSV	NVARCHAR(200),
	@DienThoai	NVARCHAR(20),
	@NgayTao	DATE ,
	@NgayHetHan	DATE,
	@ChucVu     NVARCHAR(50),
	@Anh        image
 AS
 BEGIN
	INSERT INTO THETHUVIEN VALUES (@MaThe, @TenSV, @Gioitinh, @NgaySinh, @DiaChiSV, @DienThoai, @NgayTao, @NgayHetHan, @ChucVu, @Anh)
 END
 GO
 SELECT * FROM dbo.THETHUVIEN

CREATE PROC USP_DeleteStudentUSer
@mathe CHAR(5)
AS
BEGIN
    DELETE FROM dbo.THETHUVIEN WHERE MaThe=@mathe
END
GO

ALTER PROC USP_UpdateStudentUser
    @MaThe		CHAR(5),
	@TenSV		NVARCHAR(100),
	@Gioitinh	NCHAR(10),
	@NgaySinh   DATE,
	@DiaChiSV	NVARCHAR(200),
	@DienThoai	NVARCHAR(20),
	@NgayTao	DATE ,
	@NgayHetHan	DATE ,
	@ChucVu     NVARCHAR(50),
	@Anh        image
AS
BEGIN
   UPDATE dbo.THETHUVIEN SET TenSV = @TenSV, Gioitinh = @Gioitinh, NgaySinh = @NgaySinh, DiaChiSV = @DiaChiSV, DienThoaiSV = @DienThoai, NgayTao = @NgayTao, NgayHetHan = @NgayHetHan, ChucVu = @ChucVu, Anh = @Anh WHERE MaThe = @MaThe 
END
GO

SELECT * FROM dbo.THETHUVIEN WHERE MaThe=MaThe
--PROC BOOK
CREATE PROC USP_InsertBook
	@MaSach		CHAR(5) ,
	@TenSach	NVARCHAR(200) ,
	@TheLoai	NVARCHAR(50) ,
	@TinhTrang	NVARCHAR(20),
	@SoLuong    INT ,
	@NXB		NVARCHAR(200),
	@NamXB		NVARCHAR(20),
	@TG			NVARCHAR(200)
	AS
    BEGIN
        INSERT INTO dbo.SACH
                ( MaSach ,
                  TenSach ,
                  TheLoai ,
                  TinhTrang ,
                  SoLuong ,
                  NXB ,
                  NamXB ,
                  TG
                )
        VALUES  ( @MaSach , -- MaSach - int
                  @TenSach , -- TenSach - nvarchar(200)
                  @TheLoai , -- TheLoai - nvarchar(50)
                  @TinhTrang , -- TinhTrang - nvarchar(20)
                  @SoLuong , -- SoLuong - int
                  @NXB , -- NXB - nvarchar(200)
                  @NamXB , -- NamXB - nvarchar(20)
                  @TG  -- TG - nvarchar(200)
                )
    END
	GO

CREATE PROC USP_DeleteBook
@masach CHAR(5)
as
BEGIN
    DELETE FROM dbo.SACH WHERE MaSach=@masach
END
GO

CREATE PROC USP_EditBook
    @MaSach		CHAR(5) ,
	@TenSach	NVARCHAR(200) ,
	@TheLoai	NVARCHAR(50) ,
	@TinhTrang	NVARCHAR(20),
	@SoLuong    INT ,
	@NXB		NVARCHAR(200),
	@NamXB		NVARCHAR(20),
	@TG			NVARCHAR(200)
AS
BEGIN
    UPDATE dbo.SACH SET TenSach=@TenSach, TheLoai=@TheLoai, TinhTrang=@TinhTrang, SoLuong=@SoLuong, NXB=@NXB, NamXB=@NamXB, TG=@TG WHERE  MaSach=@MaSach
END
GO

---PROC PM


CREATE PROC USP_InsertPM
    @MaPM		CHAR(5),
	@MaSach		CHAR(5),
	@MaThe		CHAR(5),
	@NgayMuon	DATETIME
AS
BEGIN
    INSERT INTO dbo.PHIEUMUON
            ( MaPM, MaSach, MaThe, NgayMuon )
    VALUES  ( @MaPM, -- MaPM - char(5)
              @MaSach, -- MaSach - char(5)
              @MaThe, -- MaThe - char(5)
              @NgayMuon  -- NgayMuon - datetime
              )
END
GO

CREATE PROC USP_DeletePM
@MAPM CHAR(5)
AS
BEGIN
    DELETE FROM dbo.PHIEUMUON WHERE MaPM=@MAPM  
END
go

CREATE PROC USP_EditPM
    @MaPM		CHAR(5),
	@MaSach		CHAR(5),
	@MaThe		CHAR(5),
	@NgayMuon	DATETIME
AS
BEGIN
   UPDATE dbo.PHIEUMUON SET MaSach=@MaSach,MaThe=@MaThe,NgayMuon=@NgayMuon WHERE MaPM=@MaPM
    
END
GO
---PROC SACHTV MUON
CREATE PROC USP_InsertSACHCHOMUON
    @MaThe CHAR(5),
	@MaSach		CHAR(5) ,
	@TenSach	NVARCHAR(200) ,
	@TheLoai	NVARCHAR(50) ,
	@TinhTrang	NVARCHAR(20),
	@SoLuong    INT ,
	@NXB		NVARCHAR(200),
	@NamXB		NVARCHAR(20),
	@TG			NVARCHAR(200)
	AS
    BEGIN
        INSERT INTO dbo.SACHTVMUON
                ( MaThe ,
                  MaSach ,
                  TenSach ,
                  TheLoai ,
                  TinhTrang ,
                  SoLuong ,
                  NXB ,
                  NamXB ,
                  TG
                )
        VALUES  ( @MaThe , -- MaThe - char(5)
                  @MaSach , -- MaSach - char(5)
                  @TenSach , -- TenSach - nvarchar(200)
                  @TheLoai , -- TheLoai - nvarchar(50)
                  @TinhTrang , -- TinhTrang - nvarchar(20)
                  @SoLuong , -- SoLuong - int
                  @NXB , -- NXB - nvarchar(200)
                  @NamXB , -- NamXB - nvarchar(20)
                  @TG  -- TG - nvarchar(200)
                )
    END
	GO

CREATE PROC USP_DeleteChoMuonSach
@MaThe CHAR(5),
@MaSach CHAR(5)
as
BEGIN
    DELETE FROM dbo.SACHTVMUON WHERE MaThe=@mathe AND MaSach=@masach
END
GO

CREATE PROC USP_EditChoMuonSach
@MaThe         CHAR(5),
    @MaSach		CHAR(5) ,
	@TenSach	NVARCHAR(200) ,
	@TheLoai	NVARCHAR(50) ,
	@TinhTrang	NVARCHAR(20),
	@SoLuong    INT ,
	@NXB		NVARCHAR(200),
	@NamXB		NVARCHAR(20),
	@TG			NVARCHAR(200)
AS
BEGIN
    UPDATE dbo.SACHTVMUON SET TenSach=@TenSach, TheLoai=@TheLoai, TinhTrang=@TinhTrang, SoLuong=@SoLuong, NXB=@NXB, NamXB=@NamXB, TG=@TG WHERE  MaSach=@MaSach AND MaThe=@MaThe
END
GO



---PROC SACH MUON

CREATE PROC InsertSM
    @MaPM		CHAR(5),
	@MaSach		CHAR(5),
	@SLSachMuon	INT,
	@TinhTrang	NVARCHAR(20),
	@NgayTra    DATETIME
AS
BEGIN
    INSERT INTO  dbo.SACHMUON
            ( MaPM ,
              MaSach ,
              TinhTrang ,
              SLSachMuon ,
              NgayTra
            )
    VALUES  ( @MaPM , -- MaPM - char(5)
              @MaSach , -- MaSach - char(5)
              @TinhTrang , -- TinhTrang - nvarchar(20)
              @SLSachMuon, -- SLSachMuon - int
              @NgayTra  -- NgayTra - datetime
            )
END
GO

CREATE PROC EditSM
    @MaPM		CHAR(5),
	@MaSach		CHAR(5),
	@TinhTrang	NVARCHAR(20),
	@SLSachMuon	INT,
	@NgayTra    DATETIME
AS
BEGIN
    UPDATE dbo.SACHMUON SET TinhTrang=@TinhTrang,SLSachMuon=@SLSachMuon,NgayTra=@NgayTra WHERE MaSach=@MaSach AND MaPM=@MaPM
END
GO

CREATE PROC DeleteSM
@MAPM CHAR(5),
@MASACH CHAR(5)
AS
BEGIN
    DELETE FROM dbo.SACHMUON WHERE MaSach=@MASACH AND MaPM=@MAPM
END
GO

CREATE PROC USP_InsertSACHTRA
   @MaPM		CHAR(5),
	@MaSach		CHAR(5),
	@TinhTrang	NVARCHAR(20),
	@SLSachMuon	INT ,
	@NgayTra    DATETIME,
	@NgayHetHan  DATETIME,
	@Mathe      CHAR(5)
	
AS
BEGIN
    INSERT INTO dbo.SACHTRATHANHCONG
            ( MaPM ,
              MaSach ,
              TinhTrang ,
              SLSachMuon ,
              NgayTra ,
              NgayHetHan,
			  MaThe
            )
    VALUES  ( @MaPM , -- MaPM - char(5)
              @MaSach , -- MaSach - char(5)
              @TinhTrang , -- TinhTrang - nvarchar(20)
              @SLSachMuon , -- SLSachMuon - int
              GETDATE() , -- NgayTra - datetime
              @NgayHetHan,
			  @Mathe
		 
            )
END
GO

---PROC CHO MUON

CREATE PROC USP_InsertChoMuonSach
@MaThe CHAR(5),
@TenSach NVARCHAR(200),
@SoLuong INT,
@NgayChoMuon DATE 

AS
BEGIN
    INSERT INTO dbo.TVMUON
            ( MaThe ,
              TenSach ,
              SoLuong ,
              NgayChoMuon
            )
    VALUES  ( @MaThe , -- MaThe - char(5)
              @TenSach , -- TenSach - nvarchar(200)
              @SoLuong , -- SoLuong - int
              GETDATE()  -- NgayChoMuon - date
            )  
END
GO

CREATE PROC USP_DeleteGVchoMuon
@MaThe CHAR(5),
@TenSach NVARCHAR(200)
AS
BEGIN
   DELETE FROM dbo.TVMUON WHERE MaThe=@MaThe AND TenSach=@TenSach 
END
GO

CREATE PROC USP_UpdateGVchoMuon
@MaThe CHAR(5),
@TenSach NVARCHAR(200),
@SoLuong INT,
@NgayChoMuon DATE 
AS
BEGIN
    UPDATE dbo.TVMUON SET TenSach=@TenSach, SoLuong=@SoLuong WHERE TenSach=@TenSach AND MaThe=@MaThe
END
GO



---PROC Thong Ke

CREATE PROC USP_ChucVu
AS
 BEGIN
     SELECT DISTINCT Sex.name,Sex.Nam,Sex.Nu,Tong.Tong
 FROM
(SELECT ChucVu, COUNT(MaThe) AS Tong  FROM dbo.THETHUVIEN GROUP BY ChucVu) AS Tong,
(SELECT  Nam.name,Nam.GT AS Nam,Nu.GT AS Nu
FROM    dbo.THETHUVIEN,  (SELECT name,COUNT(dbo.THETHUVIEN.Gioitinh) AS GT
                      FROM NHOM LEFT JOIN  dbo.THETHUVIEN ON name=ChucVu AND Gioitinh=N'Nam'

                      GROUP BY name) AS Nam,


                     (SELECT name,COUNT(dbo.THETHUVIEN.Gioitinh) AS GT
                      FROM NHOM LEFT JOIN  dbo.THETHUVIEN ON name=ChucVu AND Gioitinh=N'Nữ'

                      GROUP BY name) AS Nu
WHERE Nam.name=Nu.name) AS Sex  
WHERE Sex.name=Tong.ChucVu 
 END

GO
---PROC Account
CREATE PROC USP_UpdateAccount
@username NVARCHAR(50), @chucvu NVARCHAR(50), @password NVARCHAR(100), @newpass NVARCHAR(50)
AS
BEGIN
    DECLARE @isRightPass INT =0
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE UserName=@username AND PassWord=@password

	IF(@isRightPass =1)
	BEGIN
	    IF(@newpass = NULL OR @newpass='')
		BEGIN
		    UPDATE dbo.Account SET type=@chucvu WHERE UserName=@username
		END
		ELSE
		    UPDATE dbo.Account SET type=@chucvu, PassWord=@newpass WHERE UserName=@username
	END
END
GO



INSERT INTO dbo.Account
        ( UserName, PassWord, type, MaThe )
VALUES  ( N'thang1', -- UserName - nvarchar(50)
          N'123', -- PassWord - nvarchar(50)
          N'Admin', -- type - nvarchar(20)
          ''  -- MaThe - char(5)
          )

SELECT * FROM dbo.PHIEUMUON
SELECT * FROM dbo.SACH
SELECT * FROM dbo.SACHTVMUON
SELECT * FROM dbo.TVMUON
SELECT * FROM dbo.THETHUVIEN
SELECT * FROM dbo.Account

SELECT * FROM dbo.PHIEUMUON WHERE CONCAT(MaPM,MaSach) LIKE N'%PM262%'

SELECT MAX(MaSach),MIN(MaSach) FROM dbo.PHIEUMUON 

SELECT * FROM dbo.SACH WHERE CONCAT(MaSach,TenSach,TheLoai,NamXB,NXB,TG) LIKE N'%" + txtFind.Text + "%'

SELECT * FROM dbo.PHIEUMUON where