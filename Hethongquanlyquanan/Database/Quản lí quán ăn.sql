USE [master]
GO
/****** Object:  Database [QLQA]    Script Date: 10/15/2017 20:21:20 ******/
CREATE DATABASE [QLQA] ON  PRIMARY 
( NAME = N'QLQA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QLQA.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLQA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QLQA_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLQA] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLQA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLQA] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLQA] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLQA] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLQA] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLQA] SET ARITHABORT OFF
GO
ALTER DATABASE [QLQA] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QLQA] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLQA] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLQA] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLQA] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLQA] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLQA] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLQA] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLQA] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLQA] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLQA] SET  DISABLE_BROKER
GO
ALTER DATABASE [QLQA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLQA] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLQA] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLQA] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLQA] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLQA] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLQA] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLQA] SET  READ_WRITE
GO
ALTER DATABASE [QLQA] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLQA] SET  MULTI_USER
GO
ALTER DATABASE [QLQA] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLQA] SET DB_CHAINING OFF
GO
USE [QLQA]
GO
/****** Object:  Table [dbo].[HT_NhanVien]    Script Date: 10/15/2017 20:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HT_NhanVien](
	[maNhanVien] [varchar](10) NOT NULL,
	[tenNV] [nvarchar](30) NULL,
	[ngaySinh] [datetime] NULL,
	[gioiTinh] [char](10) NULL,
	[diaChi] [nvarchar](100) NULL,
	[dienThoai] [char](15) NULL,
	[hesoLuong] [int] NULL,
	[matKhau] [nvarchar](30) NULL,
 CONSTRAINT [NV_PK] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HT_MonAn]    Script Date: 10/15/2017 20:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HT_MonAn](
	[maMonAn] [varchar](10) NOT NULL,
	[tenMonAn] [nvarchar](100) NULL,
	[donGia] [int] NULL,
 CONSTRAINT [MA_PK] PRIMARY KEY CLUSTERED 
(
	[maMonAn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HT_KhachHang]    Script Date: 10/15/2017 20:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HT_KhachHang](
	[maKhachHang] [varchar](10) NOT NULL,
	[tenKH] [nvarchar](30) NULL,
	[ngaySinh] [datetime] NULL,
	[gioiTinh] [char](10) NULL,
	[diaChi] [nvarchar](100) NULL,
	[ngayGiaNhap] [date] NULL,
	[diem] [int] NULL,
 CONSTRAINT [KH_PK] PRIMARY KEY CLUSTERED 
(
	[maKhachHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HT_ChiNhanh]    Script Date: 10/15/2017 20:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HT_ChiNhanh](
	[maChiNhanh] [varchar](10) NOT NULL,
	[tenChiNhanh] [nvarchar](100) NULL,
	[soDienThoai] [nvarchar](20) NULL,
	[diaChi] [nvarchar](100) NULL,
	[soLuongBanAn] [int] NULL,
	[ngayThanhLap] [date] NULL,
	[nhanVienQuanLi] [varchar](10) NULL,
 CONSTRAINT [CN_PK] PRIMARY KEY CLUSTERED 
(
	[maChiNhanh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HT_ThongTinBanAn]    Script Date: 10/15/2017 20:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HT_ThongTinBanAn](
	[maChiNhanh] [varchar](10) NOT NULL,
	[maBan] [varchar](10) NOT NULL,
	[tinhTrang] [nvarchar](30) NULL,
 CONSTRAINT [TTBA_PK] PRIMARY KEY CLUSTERED 
(
	[maChiNhanh] ASC,
	[maBan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HT_HoaDon]    Script Date: 10/15/2017 20:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HT_HoaDon](
	[maHoaDon] [varchar](10) NOT NULL,
	[maKhachHang] [varchar](10) NULL,
	[ngayLap] [datetime] NULL,
	[maNhanVien] [varchar](10) NULL,
	[maChiNhanh] [varchar](10) NULL,
 CONSTRAINT [HD_PK] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HT_DonHang]    Script Date: 10/15/2017 20:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HT_DonHang](
	[maDonHang] [varchar](10) NOT NULL,
	[maChiNhanh] [varchar](10) NULL,
	[maKhachHang] [varchar](10) NULL,
	[tongtien] [int] NULL,
	[ngayGiaoHang] [datetime] NULL,
	[soDienThoai] [varchar](11) NULL,
	[diaChi] [nvarchar](100) NULL,
	[nhanVienLapDon] [varchar](10) NULL,
	[gioGiaoHang] [time](7) NULL,
 CONSTRAINT [HTDH_PK] PRIMARY KEY CLUSTERED 
(
	[maDonHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[maKhachHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[maChiNhanh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HT_DanhMucMonAn]    Script Date: 10/15/2017 20:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HT_DanhMucMonAn](
	[maChiNhanh] [varchar](10) NOT NULL,
	[maMonAn] [varchar](10) NOT NULL,
	[donGia] [int] NULL,
 CONSTRAINT [DMMA_PK] PRIMARY KEY CLUSTERED 
(
	[maChiNhanh] ASC,
	[maMonAn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HT_ChiTietHoaDon]    Script Date: 10/15/2017 20:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HT_ChiTietHoaDon](
	[maHoaDon] [varchar](10) NOT NULL,
	[maMonAn] [varchar](10) NOT NULL,
	[donGia] [int] NULL,
	[soLuong] [int] NULL,
 CONSTRAINT [CTHD_PK] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC,
	[maMonAn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HT_ChiTietDonHang]    Script Date: 10/15/2017 20:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HT_ChiTietDonHang](
	[maDonHang] [varchar](10) NOT NULL,
	[maMonAn] [varchar](10) NULL,
	[soluong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [HTCTDH_PK] PRIMARY KEY CLUSTERED 
(
	[maDonHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Check [NV_GT_CHECK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_NhanVien]  WITH CHECK ADD  CONSTRAINT [NV_GT_CHECK] CHECK  (([gioiTinh]='N?' OR [gioiTinh]='Nam'))
GO
ALTER TABLE [dbo].[HT_NhanVien] CHECK CONSTRAINT [NV_GT_CHECK]
GO
/****** Object:  Check [KH_GT_CHECK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_KhachHang]  WITH CHECK ADD  CONSTRAINT [KH_GT_CHECK] CHECK  (([gioiTinh]='N?' OR [gioiTinh]='Nam'))
GO
ALTER TABLE [dbo].[HT_KhachHang] CHECK CONSTRAINT [KH_GT_CHECK]
GO
/****** Object:  Check [TTBA_check]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_ThongTinBanAn]  WITH CHECK ADD  CONSTRAINT [TTBA_check] CHECK  (([tinhTrang]='Ðã d?t' OR [tinhTrang]='Ðang dùng' OR [tinhTrang]='Chua dùng'))
GO
ALTER TABLE [dbo].[HT_ThongTinBanAn] CHECK CONSTRAINT [TTBA_check]
GO
/****** Object:  ForeignKey [HTCN_NVQL_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_ChiNhanh]  WITH CHECK ADD  CONSTRAINT [HTCN_NVQL_FK] FOREIGN KEY([nhanVienQuanLi])
REFERENCES [dbo].[HT_NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[HT_ChiNhanh] CHECK CONSTRAINT [HTCN_NVQL_FK]
GO
/****** Object:  ForeignKey [TTBA_CN_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_ThongTinBanAn]  WITH CHECK ADD  CONSTRAINT [TTBA_CN_FK] FOREIGN KEY([maChiNhanh])
REFERENCES [dbo].[HT_ChiNhanh] ([maChiNhanh])
GO
ALTER TABLE [dbo].[HT_ThongTinBanAn] CHECK CONSTRAINT [TTBA_CN_FK]
GO
/****** Object:  ForeignKey [HD_CN_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_HoaDon]  WITH CHECK ADD  CONSTRAINT [HD_CN_FK] FOREIGN KEY([maChiNhanh])
REFERENCES [dbo].[HT_ChiNhanh] ([maChiNhanh])
GO
ALTER TABLE [dbo].[HT_HoaDon] CHECK CONSTRAINT [HD_CN_FK]
GO
/****** Object:  ForeignKey [HD_KH_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_HoaDon]  WITH CHECK ADD  CONSTRAINT [HD_KH_FK] FOREIGN KEY([maKhachHang])
REFERENCES [dbo].[HT_KhachHang] ([maKhachHang])
GO
ALTER TABLE [dbo].[HT_HoaDon] CHECK CONSTRAINT [HD_KH_FK]
GO
/****** Object:  ForeignKey [HD_NV_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_HoaDon]  WITH CHECK ADD  CONSTRAINT [HD_NV_FK] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[HT_NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[HT_HoaDon] CHECK CONSTRAINT [HD_NV_FK]
GO
/****** Object:  ForeignKey [HTDH_MCN_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_DonHang]  WITH CHECK ADD  CONSTRAINT [HTDH_MCN_FK] FOREIGN KEY([maChiNhanh])
REFERENCES [dbo].[HT_ChiNhanh] ([maChiNhanh])
GO
ALTER TABLE [dbo].[HT_DonHang] CHECK CONSTRAINT [HTDH_MCN_FK]
GO
/****** Object:  ForeignKey [HTDH_MKH_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_DonHang]  WITH CHECK ADD  CONSTRAINT [HTDH_MKH_FK] FOREIGN KEY([maKhachHang])
REFERENCES [dbo].[HT_KhachHang] ([maKhachHang])
GO
ALTER TABLE [dbo].[HT_DonHang] CHECK CONSTRAINT [HTDH_MKH_FK]
GO
/****** Object:  ForeignKey [HTDH_NVLD_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_DonHang]  WITH CHECK ADD  CONSTRAINT [HTDH_NVLD_FK] FOREIGN KEY([nhanVienLapDon])
REFERENCES [dbo].[HT_NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[HT_DonHang] CHECK CONSTRAINT [HTDH_NVLD_FK]
GO
/****** Object:  ForeignKey [DMMA_CN_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_DanhMucMonAn]  WITH CHECK ADD  CONSTRAINT [DMMA_CN_FK] FOREIGN KEY([maChiNhanh])
REFERENCES [dbo].[HT_ChiNhanh] ([maChiNhanh])
GO
ALTER TABLE [dbo].[HT_DanhMucMonAn] CHECK CONSTRAINT [DMMA_CN_FK]
GO
/****** Object:  ForeignKey [DMMA_MA_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_DanhMucMonAn]  WITH CHECK ADD  CONSTRAINT [DMMA_MA_FK] FOREIGN KEY([maMonAn])
REFERENCES [dbo].[HT_MonAn] ([maMonAn])
GO
ALTER TABLE [dbo].[HT_DanhMucMonAn] CHECK CONSTRAINT [DMMA_MA_FK]
GO
/****** Object:  ForeignKey [CTHD_HD_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [CTHD_HD_FK] FOREIGN KEY([maHoaDon])
REFERENCES [dbo].[HT_HoaDon] ([maHoaDon])
GO
ALTER TABLE [dbo].[HT_ChiTietHoaDon] CHECK CONSTRAINT [CTHD_HD_FK]
GO
/****** Object:  ForeignKey [CTHD_MA_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [CTHD_MA_FK] FOREIGN KEY([maMonAn])
REFERENCES [dbo].[HT_MonAn] ([maMonAn])
GO
ALTER TABLE [dbo].[HT_ChiTietHoaDon] CHECK CONSTRAINT [CTHD_MA_FK]
GO
/****** Object:  ForeignKey [HTCTDH_MDH_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [HTCTDH_MDH_FK] FOREIGN KEY([maDonHang])
REFERENCES [dbo].[HT_DonHang] ([maDonHang])
GO
ALTER TABLE [dbo].[HT_ChiTietDonHang] CHECK CONSTRAINT [HTCTDH_MDH_FK]
GO
/****** Object:  ForeignKey [HTCTDH_MMA_FK]    Script Date: 10/15/2017 20:21:21 ******/
ALTER TABLE [dbo].[HT_ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [HTCTDH_MMA_FK] FOREIGN KEY([maMonAn])
REFERENCES [dbo].[HT_MonAn] ([maMonAn])
GO
ALTER TABLE [dbo].[HT_ChiTietDonHang] CHECK CONSTRAINT [HTCTDH_MMA_FK]
GO
