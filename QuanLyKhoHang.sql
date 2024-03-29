USE [master]
GO
/****** Object:  Database [QUAN_LY_KHO]    Script Date: 6/2/2019 11:06:31 PM ******/
CREATE DATABASE [QUAN_LY_KHO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUAN_LY_KHO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\QUAN_LY_KHO.mdf' , SIZE = 3328KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUAN_LY_KHO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\QUAN_LY_KHO_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUAN_LY_KHO] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUAN_LY_KHO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUAN_LY_KHO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QUAN_LY_KHO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUAN_LY_KHO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUAN_LY_KHO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUAN_LY_KHO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUAN_LY_KHO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUAN_LY_KHO] SET  MULTI_USER 
GO
ALTER DATABASE [QUAN_LY_KHO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUAN_LY_KHO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUAN_LY_KHO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUAN_LY_KHO] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QUAN_LY_KHO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUAN_LY_KHO] SET QUERY_STORE = OFF
GO
USE [QUAN_LY_KHO]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonBanHang]    Script Date: 6/2/2019 11:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonBanHang](
	[maHoaDon] [int] NOT NULL,
	[maHangHoa] [int] NOT NULL,
	[GiaBanHang] [float] NULL,
	[soLuong] [int] NULL,
	[thanhTien] [float] NULL,
 CONSTRAINT [PK_ChiTietHoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC,
	[maHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 6/2/2019 11:06:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhap](
	[maHangHoa] [int] NOT NULL,
	[maHoaDonNhap] [int] NOT NULL,
	[soLuong] [int] NULL,
	[thanhTien] [int] NULL,
 CONSTRAINT [MHH_MHDN_PK] PRIMARY KEY CLUSTERED 
(
	[maHangHoa] ASC,
	[maHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 6/2/2019 11:06:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangHoa](
	[maHangHoa] [int] NOT NULL,
	[tenHangHoa] [nvarchar](50) NULL,
	[ngaySanXuat] [date] NULL,
	[soLuong] [int] NULL,
	[GiaHang] [float] NULL,
	[DVT] [char](30) NULL,
	[maLoaiHang] [int] NULL,
	[moTa] [nvarchar](50) NULL,
 CONSTRAINT [PK__HangHoa__3A3BE7058311B7AF] PRIMARY KEY CLUSTERED 
(
	[maHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 6/2/2019 11:06:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[maHoaDon] [int] NOT NULL,
	[ngayThang] [date] NULL,
	[maKhachHang] [int] NULL,
	[tongTien] [float] NULL,
	[maNV] [int] NULL,
 CONSTRAINT [PK__HoaDonBa__026B4D9A75D6F48A] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 6/2/2019 11:06:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[maHoaDonNhap] [int] NOT NULL,
	[ngayThang] [date] NULL,
	[tongTien] [int] NULL,
	[maNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/2/2019 11:06:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[maKhachHang] [int] NOT NULL,
	[hoTen] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK__KhachHan__0CCB3D49550FA875] PRIMARY KEY CLUSTERED 
(
	[maKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 6/2/2019 11:06:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[maLoaiHang] [int] NOT NULL,
	[tenLoaiHang] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 6/2/2019 11:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [int] NOT NULL,
	[maHangHoa] [int] NULL,
	[TenNhaCungCap] [nvarchar](50) NULL,
	[DiaChiNCC] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/2/2019 11:06:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNV] [int] NOT NULL,
	[tenNV] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[queQuan] [nvarchar](50) NULL,
	[sDT] [nvarchar](50) NULL,
	[Matkhau] [nvarchar](50) NULL,
	[maKhoHang] [int] NULL,
 CONSTRAINT [PK__NhanVien__7A3EC7D5CFDFFC5C] PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (3, 3, 3, 222, 666)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (3, 5, 1, 400, 400)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (3, 7, 3, 34455, 103365)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (15, 6, 200, 3, 600)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (15, 7, 34455, 2, 68910)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (23, 4, 123, 2, 246)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (23, 7, 34455, 23, 792465)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (34, 3, 222, 3, 666)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (34, 5, 400, 2, 800)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (34, 7, 34455, 6, 206730)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (231, 3, 222, 4, 888)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (231, 4, 123, 3, 369)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (456, 3, 222, 2, 444)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (456, 5, 400, 3, 1200)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (2321, 3, 222, 4, 888)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (2321, 6, 200, 3, 600)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (3243, 3, 222, 2, 444)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (3243, 4, 123, 2, 246)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (3321, 1, 300, 4, 1200)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (3321, 6, 200, 2, 400)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (4561, 4, 123, 2, 246)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (4561, 6, 200, 5, 1000)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (4567, 3, 222, 2, 444)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (4567, 5, 400, 3, 1200)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (4567, 6, 200, 2, 400)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (12311, 1, 300, 4, 1200)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (12311, 5, 400, 2, 800)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (12344, 4, 123, 3, 369)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (12344, 6, 200, 2, 400)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (23642, 5, 400, 10, 4000)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (33333, 4, 123, 33, 4059)
INSERT [dbo].[ChiTietHoaDonBanHang] ([maHoaDon], [maHangHoa], [GiaBanHang], [soLuong], [thanhTien]) VALUES (33333, 5, 400, 4, 1600)
INSERT [dbo].[ChiTietHoaDonNhap] ([maHangHoa], [maHoaDonNhap], [soLuong], [thanhTien]) VALUES (1, 1, 3, 21000000)
INSERT [dbo].[ChiTietHoaDonNhap] ([maHangHoa], [maHoaDonNhap], [soLuong], [thanhTien]) VALUES (4, 4, 10, 300000)
INSERT [dbo].[ChiTietHoaDonNhap] ([maHangHoa], [maHoaDonNhap], [soLuong], [thanhTien]) VALUES (4, 5, 5, 150000)
INSERT [dbo].[HangHoa] ([maHangHoa], [tenHangHoa], [ngaySanXuat], [soLuong], [GiaHang], [DVT], [maLoaiHang], [moTa]) VALUES (1, N'Ti Vi', CAST(N'2019-02-02' AS Date), 4, 300, N'chiec                         ', 1, N'FPT')
INSERT [dbo].[HangHoa] ([maHangHoa], [tenHangHoa], [ngaySanXuat], [soLuong], [GiaHang], [DVT], [maLoaiHang], [moTa]) VALUES (3, N'Lap Top', CAST(N'2019-02-02' AS Date), 4, 222, N'chiec                         ', 2, N'tot')
INSERT [dbo].[HangHoa] ([maHangHoa], [tenHangHoa], [ngaySanXuat], [soLuong], [GiaHang], [DVT], [maLoaiHang], [moTa]) VALUES (4, N'Tủ Lạnh', CAST(N'2019-02-02' AS Date), 9, 123, N'chiec                         ', 1, N'FPT')
INSERT [dbo].[HangHoa] ([maHangHoa], [tenHangHoa], [ngaySanXuat], [soLuong], [GiaHang], [DVT], [maLoaiHang], [moTa]) VALUES (5, N'Máy Tính', CAST(N'2019-02-02' AS Date), 4, 400, N'chiec                         ', 1, N'FPT')
INSERT [dbo].[HangHoa] ([maHangHoa], [tenHangHoa], [ngaySanXuat], [soLuong], [GiaHang], [DVT], [maLoaiHang], [moTa]) VALUES (6, N'Bóng Đèn', CAST(N'2019-02-02' AS Date), 4, 200, N'chiec                         ', 2, N'tot')
INSERT [dbo].[HangHoa] ([maHangHoa], [tenHangHoa], [ngaySanXuat], [soLuong], [GiaHang], [DVT], [maLoaiHang], [moTa]) VALUES (7, N'Điều Hòa', CAST(N'2019-02-02' AS Date), 7, 34455, N'chiec                         ', 1, N'Panasonic')
INSERT [dbo].[HangHoa] ([maHangHoa], [tenHangHoa], [ngaySanXuat], [soLuong], [GiaHang], [DVT], [maLoaiHang], [moTa]) VALUES (9, N'Quạt', CAST(N'2019-02-02' AS Date), 4, 1300, N'chiec                         ', 2, N'tot')
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (1, CAST(N'2019-05-20' AS Date), 2, 0, 3)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (2, CAST(N'2019-05-17' AS Date), 1, 0, 1)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (3, CAST(N'2019-05-17' AS Date), 1, 0, 1)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (15, CAST(N'2019-06-01' AS Date), 1, 69510, 2)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (23, CAST(N'2019-06-02' AS Date), 1, 0, 1)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (34, CAST(N'2019-05-21' AS Date), 2, 208196, 2)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (231, CAST(N'2019-05-20' AS Date), 2, 1257, 3)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (322, CAST(N'2019-05-18' AS Date), 1, 0, 1)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (456, CAST(N'2019-05-19' AS Date), 1, 1644, 1)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (2321, CAST(N'2019-05-05' AS Date), 1, 1488, 1)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (3243, CAST(N'2019-05-18' AS Date), 1, 690, 1)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (3321, CAST(N'2019-05-18' AS Date), 1, 0, 1)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (4561, CAST(N'2019-05-18' AS Date), 1, 0, 1)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (4567, CAST(N'2019-05-19' AS Date), 1, 2044, 1)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (12311, CAST(N'2019-06-02' AS Date), 2, 2000, 1)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (12344, CAST(N'2019-05-20' AS Date), 2, 769, 2)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (23642, CAST(N'2019-05-20' AS Date), 1, 4000, 1)
INSERT [dbo].[HoaDonBanHang] ([maHoaDon], [ngayThang], [maKhachHang], [tongTien], [maNV]) VALUES (33333, CAST(N'2019-05-20' AS Date), 1, 5659, 1)
INSERT [dbo].[HoaDonNhap] ([maHoaDonNhap], [ngayThang], [tongTien], [maNV]) VALUES (1, CAST(N'2019-01-02' AS Date), 39000000, 1)
INSERT [dbo].[HoaDonNhap] ([maHoaDonNhap], [ngayThang], [tongTien], [maNV]) VALUES (2, CAST(N'2019-01-02' AS Date), 24000000, 1)
INSERT [dbo].[HoaDonNhap] ([maHoaDonNhap], [ngayThang], [tongTien], [maNV]) VALUES (3, CAST(N'2019-02-02' AS Date), 56000000, 1)
INSERT [dbo].[HoaDonNhap] ([maHoaDonNhap], [ngayThang], [tongTien], [maNV]) VALUES (4, CAST(N'2019-03-02' AS Date), 700000, 2)
INSERT [dbo].[HoaDonNhap] ([maHoaDonNhap], [ngayThang], [tongTien], [maNV]) VALUES (5, CAST(N'2019-03-02' AS Date), 750000, 2)
INSERT [dbo].[HoaDonNhap] ([maHoaDonNhap], [ngayThang], [tongTien], [maNV]) VALUES (6, CAST(N'2019-03-02' AS Date), 140000, 3)
INSERT [dbo].[KhachHang] ([maKhachHang], [hoTen], [ngaySinh], [gioiTinh], [diaChi], [sdt]) VALUES (1, N'Doãn Linh Chi', CAST(N'2019-05-06' AS Date), N'N?', N'Nam Định', N'232454')
INSERT [dbo].[KhachHang] ([maKhachHang], [hoTen], [ngaySinh], [gioiTinh], [diaChi], [sdt]) VALUES (2, N'Doãn Thị Kim Liên', CAST(N'2019-05-17' AS Date), N'N?', N'Nam Ddinh', N'33445332')
INSERT [dbo].[LoaiHang] ([maLoaiHang], [tenLoaiHang]) VALUES (1, N'Kho thiet bi dien tu')
INSERT [dbo].[LoaiHang] ([maLoaiHang], [tenLoaiHang]) VALUES (2, N'Kho thuc pham')
INSERT [dbo].[LoaiHang] ([maLoaiHang], [tenLoaiHang]) VALUES (3, N'Kho vat lieu xay dung')
INSERT [dbo].[NhanVien] ([maNV], [tenNV], [ngaySinh], [GioiTinh], [queQuan], [sDT], [Matkhau], [maKhoHang]) VALUES (1, N'Nguyen Van A', CAST(N'1994-01-02' AS Date), N'Nữ', N'Thai Binh', N'16780764  ', N'123', 1)
INSERT [dbo].[NhanVien] ([maNV], [tenNV], [ngaySinh], [GioiTinh], [queQuan], [sDT], [Matkhau], [maKhoHang]) VALUES (2, N'Nguyen Van B', CAST(N'1990-05-06' AS Date), N'Nam', N'Hà Nội', N'18723764  ', N'1234', 2)
INSERT [dbo].[NhanVien] ([maNV], [tenNV], [ngaySinh], [GioiTinh], [queQuan], [sDT], [Matkhau], [maKhoHang]) VALUES (3, N'Nguyen Van ddd', CAST(N'1995-07-12' AS Date), N'Nam', N'Bac Ninh', N'13789974  ', N'', 1)
INSERT [dbo].[NhanVien] ([maNV], [tenNV], [ngaySinh], [GioiTinh], [queQuan], [sDT], [Matkhau], [maKhoHang]) VALUES (223, N'ssss', CAST(N'2019-05-20' AS Date), N'nu', N'sádd', N'hgghx', N'', 1)
ALTER TABLE [dbo].[ChiTietHoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [CTHDBH_MHDBH_FK] FOREIGN KEY([maHoaDon])
REFERENCES [dbo].[HoaDonBanHang] ([maHoaDon])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang] CHECK CONSTRAINT [CTHDBH_MHDBH_FK]
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [CTHDBH_MHH_FK] FOREIGN KEY([maHangHoa])
REFERENCES [dbo].[HangHoa] ([maHangHoa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang] CHECK CONSTRAINT [CTHDBH_MHH_FK]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [CTHDN_HDN_FK] FOREIGN KEY([maHoaDonNhap])
REFERENCES [dbo].[HoaDonNhap] ([maHoaDonNhap])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [CTHDN_HDN_FK]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [CTHDN_MHH_FK] FOREIGN KEY([maHangHoa])
REFERENCES [dbo].[HangHoa] ([maHangHoa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [CTHDN_MHH_FK]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK__HangHoa__maKhoHa__2B3F6F97] FOREIGN KEY([maLoaiHang])
REFERENCES [dbo].[LoaiHang] ([maLoaiHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK__HangHoa__maKhoHa__2B3F6F97]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK__HoaDonBanH__maNV__19AACF41] FOREIGN KEY([maNV])
REFERENCES [dbo].[NhanVien] ([maNV])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK__HoaDonBanH__maNV__19AACF41]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_KhachHang] FOREIGN KEY([maKhachHang])
REFERENCES [dbo].[KhachHang] ([maKhachHang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK__HoaDonNhap__maNV__30F848ED] FOREIGN KEY([maNV])
REFERENCES [dbo].[NhanVien] ([maNV])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK__HoaDonNhap__maNV__30F848ED]
GO
ALTER TABLE [dbo].[NhaCungCap]  WITH CHECK ADD FOREIGN KEY([maHangHoa])
REFERENCES [dbo].[HangHoa] ([maHangHoa])
GO
/****** Object:  StoredProcedure [dbo].[ThemKhachHang]    Script Date: 6/2/2019 11:06:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create  procedure [dbo].[ThemKhachHang]
@id int, @name nvarchar(50),@ngaysinh date, @gioitinh nchar(10),
@quequan nvarchar(50), @SDT nchar(10) 
as
begin
	insert into KhachHang(maKhachHang,hoTen,ngaySinh,gioiTinh,diaChi,sdt) values (@id,@name,@ngaysinh,@gioitinh,@quequan,@SDT)
end
GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 6/2/2019 11:06:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemNhanVien]
@id int, @name nvarchar(50), @ngaySinh date, @diachi nvarchar(50),@quequan nvarchar(50), @SDT char(10), @maKho int
as
begin
	insert into NhanVien(maNV,tenNV,ngaySinh ,diaChi,queQuan,sDT, maKhoHang) values (@id,@name,@ngaySinh,@diachi,@quequan,@SDT,@maKho)
end
GO
/****** Object:  StoredProcedure [dbo].[UpdatekhachHang]    Script Date: 6/2/2019 11:06:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdatekhachHang]
@id int , @ten nvarchar(50) ,@namsinh date, @gioitinh nchar(10),
@quequan nvarchar(50) , @SDT nchar(10)
as
begin
	update KhachHang set HoTen=@ten, GioiTinh=@gioitinh , diaChi=@quequan , SDT=@SDT
	where maKhachHang=@id 
end
GO
USE [master]
GO
ALTER DATABASE [QUAN_LY_KHO] SET  READ_WRITE 
GO
