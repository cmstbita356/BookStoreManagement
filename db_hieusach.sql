USE [master]
GO
/****** Object:  Database [db_hieusach]    Script Date: 11/12/2022 10:44:35 PM ******/
CREATE DATABASE [db_hieusach]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_hieusach', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_hieusach.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_hieusach_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_hieusach_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_hieusach] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_hieusach].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_hieusach] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_hieusach] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_hieusach] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_hieusach] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_hieusach] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_hieusach] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_hieusach] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_hieusach] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_hieusach] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_hieusach] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_hieusach] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_hieusach] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_hieusach] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_hieusach] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_hieusach] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_hieusach] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_hieusach] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_hieusach] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_hieusach] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_hieusach] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_hieusach] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_hieusach] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_hieusach] SET RECOVERY FULL 
GO
ALTER DATABASE [db_hieusach] SET  MULTI_USER 
GO
ALTER DATABASE [db_hieusach] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_hieusach] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_hieusach] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_hieusach] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_hieusach] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_hieusach] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_hieusach', N'ON'
GO
ALTER DATABASE [db_hieusach] SET QUERY_STORE = OFF
GO
USE [db_hieusach]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookId] [varchar](15) NOT NULL,
	[BookName] [nvarchar](255) NULL,
	[BookType] [varchar](15) NULL,
	[BookAuthor] [nvarchar](255) NULL,
	[BookPublisher] [varchar](255) NULL,
	[BookPrice] [int] NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookType]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookType](
	[TypeId] [varchar](15) NOT NULL,
	[TypeName] [nvarchar](255) NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [varchar](15) NOT NULL,
	[CustomerName] [nvarchar](255) NULL,
	[CustomerPhone] [varchar](20) NULL,
	[CustomerEmail] [varchar](255) NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DamagedBook]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DamagedBook](
	[BookId] [varchar](15) NOT NULL,
	[DamagedQuantity] [int] NULL,
	[DamagedTotal] [int] NULL,
	[Liquidated] [int] NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Degree]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Degree](
	[DegId] [varchar](15) NOT NULL,
	[DegName] [nvarchar](255) NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DegId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmplId] [varchar](15) NOT NULL,
	[EmplName] [nvarchar](255) NULL,
	[EmplDegree] [varchar](15) NULL,
	[EmplPosition] [varchar](15) NULL,
	[EmplAddress] [nvarchar](255) NULL,
	[EmplPhone] [varchar](20) NULL,
	[EmplUsername] [varchar](255) NULL,
	[EmplPassword] [varchar](255) NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmplId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Import]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Import](
	[ImportId] [varchar](15) NOT NULL,
	[EmplId] [varchar](15) NULL,
	[VendorId] [varchar](15) NOT NULL,
	[ImportDate] [varchar](20) NULL,
	[ImportTotal] [int] NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ImportId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportDetail]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportDetail](
	[ImportId] [varchar](15) NOT NULL,
	[BookId] [varchar](15) NOT NULL,
	[BookQuantity] [int] NULL,
	[UnitCost] [int] NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ImportId] ASC,
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[PtnId] [varchar](15) NOT NULL,
	[PtnName] [nvarchar](255) NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PtnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipt](
	[ReceiptId] [varchar](15) NOT NULL,
	[SaleEmployeeId] [varchar](15) NULL,
	[CustomerId] [varchar](15) NULL,
	[SaleDate] [varchar](20) NULL,
	[ReceiptTotal] [int] NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReceiptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceiptDetail]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiptDetail](
	[ReceiptId] [varchar](15) NOT NULL,
	[BookId] [varchar](15) NOT NULL,
	[Quantity] [int] NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReceiptId] ASC,
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[BookId] [varchar](15) NOT NULL,
	[BookQuantity] [int] NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendor]    Script Date: 11/12/2022 10:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendor](
	[VendorId] [varchar](15) NOT NULL,
	[VendorName] [nvarchar](255) NULL,
	[VendorPhone] [varchar](20) NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VendorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Book] ([BookId], [BookName], [BookType], [BookAuthor], [BookPublisher], [BookPrice], [Status]) VALUES (N'B001', N'Book1', N'T01', N'Author1', N'Pub01', 1000, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [BookType], [BookAuthor], [BookPublisher], [BookPrice], [Status]) VALUES (N'B002', N'Book2', N'T02', N'Author2', N'Pub02', 2000, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [BookType], [BookAuthor], [BookPublisher], [BookPrice], [Status]) VALUES (N'B003', N'Book3', N'T03', N'Author3', N'Pub03', 3000, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [BookType], [BookAuthor], [BookPublisher], [BookPrice], [Status]) VALUES (N'B004', N'Book4', N'T04', N'Author4', N'Pub01', 4000, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [BookType], [BookAuthor], [BookPublisher], [BookPrice], [Status]) VALUES (N'B005', N'Book5', N'T01', N'Author5', N'Pub01', 5000, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [BookType], [BookAuthor], [BookPublisher], [BookPrice], [Status]) VALUES (N'B006', N'Book6', N'T01', N'Author6', N'Pub02', 6000, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [BookType], [BookAuthor], [BookPublisher], [BookPrice], [Status]) VALUES (N'B007', N'Book7', N'T03', N'Author7', N'Pub03', 7000, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [BookType], [BookAuthor], [BookPublisher], [BookPrice], [Status]) VALUES (N'B008', N'Book8', N'T02', N'Author8', N'Pub02', 8000, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [BookType], [BookAuthor], [BookPublisher], [BookPrice], [Status]) VALUES (N'B009', N'Book9', N'T04', N'Author9', N'Pub01', 9000, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [BookType], [BookAuthor], [BookPublisher], [BookPrice], [Status]) VALUES (N'B010', N'Book10', N'T04', N'Author10', N'Pub03', 10000, 1)
GO
INSERT [dbo].[BookType] ([TypeId], [TypeName], [Status]) VALUES (N'T01', N'Sách tham khảo', 1)
INSERT [dbo].[BookType] ([TypeId], [TypeName], [Status]) VALUES (N'T02', N'Truyện tranh', 1)
INSERT [dbo].[BookType] ([TypeId], [TypeName], [Status]) VALUES (N'T03', N'Tiểu thuyết', 1)
INSERT [dbo].[BookType] ([TypeId], [TypeName], [Status]) VALUES (N'T04', N'Sách giáo khoa', 1)
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone], [CustomerEmail], [Status]) VALUES (N'C01', N'CusName2', N'CusPhoneNum2', N'CusEmail2', 1)
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone], [CustomerEmail], [Status]) VALUES (N'C02', N'CusName3', N'CusPhoneNum3', N'CusEmail3', 1)
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone], [CustomerEmail], [Status]) VALUES (N'C03', N'CusName4', N'CusPhoneNum4', N'CusEmail4', 1)
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone], [CustomerEmail], [Status]) VALUES (N'C04', N'CusName5', N'CusPhoneNum5', N'CusEmail5', 1)
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone], [CustomerEmail], [Status]) VALUES (N'C05', N'CusName6', N'CusPhoneNum6', N'CusEmail6', 1)
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone], [CustomerEmail], [Status]) VALUES (N'OneTime', N'Khách hàng vãng lai', N'null', N'null', 1)
GO
INSERT [dbo].[DamagedBook] ([BookId], [DamagedQuantity], [DamagedTotal], [Liquidated], [Status]) VALUES (N'B001', 0, 0, 0, 1)
INSERT [dbo].[DamagedBook] ([BookId], [DamagedQuantity], [DamagedTotal], [Liquidated], [Status]) VALUES (N'B002', 0, 0, 0, 1)
INSERT [dbo].[DamagedBook] ([BookId], [DamagedQuantity], [DamagedTotal], [Liquidated], [Status]) VALUES (N'B003', 4, 12000, 0, 1)
INSERT [dbo].[DamagedBook] ([BookId], [DamagedQuantity], [DamagedTotal], [Liquidated], [Status]) VALUES (N'B004', 0, 0, 0, 1)
INSERT [dbo].[DamagedBook] ([BookId], [DamagedQuantity], [DamagedTotal], [Liquidated], [Status]) VALUES (N'B005', 5, 25000, 0, 1)
INSERT [dbo].[DamagedBook] ([BookId], [DamagedQuantity], [DamagedTotal], [Liquidated], [Status]) VALUES (N'B006', 0, 0, 0, 1)
INSERT [dbo].[DamagedBook] ([BookId], [DamagedQuantity], [DamagedTotal], [Liquidated], [Status]) VALUES (N'B007', 0, 0, 0, 1)
INSERT [dbo].[DamagedBook] ([BookId], [DamagedQuantity], [DamagedTotal], [Liquidated], [Status]) VALUES (N'B008', 0, 0, 0, 1)
INSERT [dbo].[DamagedBook] ([BookId], [DamagedQuantity], [DamagedTotal], [Liquidated], [Status]) VALUES (N'B009', 0, 0, 0, 1)
INSERT [dbo].[DamagedBook] ([BookId], [DamagedQuantity], [DamagedTotal], [Liquidated], [Status]) VALUES (N'B010', 0, 0, 0, 1)
GO
INSERT [dbo].[Degree] ([DegId], [DegName], [Status]) VALUES (N'CD', N'Cao đẳng', 1)
INSERT [dbo].[Degree] ([DegId], [DegName], [Status]) VALUES (N'DH', N'Đại học', 1)
INSERT [dbo].[Degree] ([DegId], [DegName], [Status]) VALUES (N'TC', N'Trung cấp', 1)
INSERT [dbo].[Degree] ([DegId], [DegName], [Status]) VALUES (N'THPT', N'Tốt nghiệp trung học phổ thông', 1)
INSERT [dbo].[Degree] ([DegId], [DegName], [Status]) VALUES (N'ThS', N'Thạc sĩ', 1)
INSERT [dbo].[Degree] ([DegId], [DegName], [Status]) VALUES (N'TS', N'Tiến sĩ', 1)
GO
INSERT [dbo].[Employee] ([EmplId], [EmplName], [EmplDegree], [EmplPosition], [EmplAddress], [EmplPhone], [EmplUsername], [EmplPassword], [Status]) VALUES (N'N01', N'Quách Lê Nhật Quang', N'THPT', N'QL', N'Add1', N'0901480516', N'nhatquang', N'5a6b7d09fb1d6b64e6838f244a56e937', 1)
INSERT [dbo].[Employee] ([EmplId], [EmplName], [EmplDegree], [EmplPosition], [EmplAddress], [EmplPhone], [EmplUsername], [EmplPassword], [Status]) VALUES (N'N02', N'Nông Thảo Hiền', N'THPT', N'QL', N'Add2', N'0000000001', N'thaohien', N'99eee5de85591811196da49b931e92a6', 1)
INSERT [dbo].[Employee] ([EmplId], [EmplName], [EmplDegree], [EmplPosition], [EmplAddress], [EmplPhone], [EmplUsername], [EmplPassword], [Status]) VALUES (N'N03', N'Trần Quốc Trung', N'THPT', N'QL', N'Add3', N'0000000002', N'quoctrung', N'c73fe718090ae3ed58c8ff30cfe1994a', 1)
INSERT [dbo].[Employee] ([EmplId], [EmplName], [EmplDegree], [EmplPosition], [EmplAddress], [EmplPhone], [EmplUsername], [EmplPassword], [Status]) VALUES (N'N04', N'Đỗ Thị Phương Anh', N'THPT', N'NV', N'Add4', N'0000000003', N'phuonganh', N'8c80bbac5c4df6e9a85af6940ba1c3f3', 1)
INSERT [dbo].[Employee] ([EmplId], [EmplName], [EmplDegree], [EmplPosition], [EmplAddress], [EmplPhone], [EmplUsername], [EmplPassword], [Status]) VALUES (N'N05', N'Nguyễn Văn A', N'THPT', N'NV', N'Add5', N'0000000004', N'vana', N'bf8c8478a0c4be8fca706e63931733b1', 1)
INSERT [dbo].[Employee] ([EmplId], [EmplName], [EmplDegree], [EmplPosition], [EmplAddress], [EmplPhone], [EmplUsername], [EmplPassword], [Status]) VALUES (N'N06', N'Nguyễn Văn B', N'THPT', N'NV', N'Add6', N'0000000005', N'vanb', N'ac4865660909c5ba7cf872c28dd9d754', 1)
GO
INSERT [dbo].[Import] ([ImportId], [EmplId], [VendorId], [ImportDate], [ImportTotal], [Status]) VALUES (N'Imp001', N'N01', N'V01', N'11/10/2022', 90000, 1)
INSERT [dbo].[Import] ([ImportId], [EmplId], [VendorId], [ImportDate], [ImportTotal], [Status]) VALUES (N'Imp002', N'N02', N'V02', N'11/10/2022', 362000, 1)
INSERT [dbo].[Import] ([ImportId], [EmplId], [VendorId], [ImportDate], [ImportTotal], [Status]) VALUES (N'Imp003', N'N03', N'V03', N'11/10/2022', 675000, 1)
INSERT [dbo].[Import] ([ImportId], [EmplId], [VendorId], [ImportDate], [ImportTotal], [Status]) VALUES (N'Imp004', N'N04', N'V01', N'11/10/2022', 275000, 1)
INSERT [dbo].[Import] ([ImportId], [EmplId], [VendorId], [ImportDate], [ImportTotal], [Status]) VALUES (N'Imp005', N'N01', N'V02', N'11/10/2022', 442000, 1)
INSERT [dbo].[Import] ([ImportId], [EmplId], [VendorId], [ImportDate], [ImportTotal], [Status]) VALUES (N'Imp006', N'N02', N'V02', N'11/10/2022', 666000, 1)
INSERT [dbo].[Import] ([ImportId], [EmplId], [VendorId], [ImportDate], [ImportTotal], [Status]) VALUES (N'Imp007', N'N04', N'V03', N'11/10/2022', 1770000, 1)
GO
INSERT [dbo].[ImportDetail] ([ImportId], [BookId], [BookQuantity], [UnitCost], [Status]) VALUES (N'Imp001', N'B001', 100, 900, 1)
INSERT [dbo].[ImportDetail] ([ImportId], [BookId], [BookQuantity], [UnitCost], [Status]) VALUES (N'Imp002', N'B002', 90, 1800, 1)
INSERT [dbo].[ImportDetail] ([ImportId], [BookId], [BookQuantity], [UnitCost], [Status]) VALUES (N'Imp002', N'B003', 80, 2500, 1)
INSERT [dbo].[ImportDetail] ([ImportId], [BookId], [BookQuantity], [UnitCost], [Status]) VALUES (N'Imp003', N'B004', 100, 3600, 1)
INSERT [dbo].[ImportDetail] ([ImportId], [BookId], [BookQuantity], [UnitCost], [Status]) VALUES (N'Imp003', N'B005', 70, 4500, 1)
INSERT [dbo].[ImportDetail] ([ImportId], [BookId], [BookQuantity], [UnitCost], [Status]) VALUES (N'Imp004', N'B006', 50, 5500, 1)
INSERT [dbo].[ImportDetail] ([ImportId], [BookId], [BookQuantity], [UnitCost], [Status]) VALUES (N'Imp005', N'B007', 65, 6800, 1)
INSERT [dbo].[ImportDetail] ([ImportId], [BookId], [BookQuantity], [UnitCost], [Status]) VALUES (N'Imp006', N'B008', 90, 7400, 1)
INSERT [dbo].[ImportDetail] ([ImportId], [BookId], [BookQuantity], [UnitCost], [Status]) VALUES (N'Imp007', N'B009', 100, 8200, 1)
INSERT [dbo].[ImportDetail] ([ImportId], [BookId], [BookQuantity], [UnitCost], [Status]) VALUES (N'Imp007', N'B010', 100, 9500, 1)
GO
INSERT [dbo].[Position] ([PtnId], [PtnName], [Status]) VALUES (N'NV', N'Nhân viên', 1)
INSERT [dbo].[Position] ([PtnId], [PtnName], [Status]) VALUES (N'QL', N'Quản lý', 1)
GO
INSERT [dbo].[Receipt] ([ReceiptId], [SaleEmployeeId], [CustomerId], [SaleDate], [ReceiptTotal], [Status]) VALUES (N'R001', N'N04', N'C04', N'11/11/2022', 90000, 1)
INSERT [dbo].[Receipt] ([ReceiptId], [SaleEmployeeId], [CustomerId], [SaleDate], [ReceiptTotal], [Status]) VALUES (N'R002', N'N06', N'C03', N'11/11/2022', 50000, 1)
INSERT [dbo].[Receipt] ([ReceiptId], [SaleEmployeeId], [CustomerId], [SaleDate], [ReceiptTotal], [Status]) VALUES (N'R003', N'N05', N'OneTime', N'11/11/2022', 6000, 1)
GO
INSERT [dbo].[ReceiptDetail] ([ReceiptId], [BookId], [Quantity], [Status]) VALUES (N'R001', N'B001', 20, 1)
INSERT [dbo].[ReceiptDetail] ([ReceiptId], [BookId], [Quantity], [Status]) VALUES (N'R001', N'B002', 30, 1)
INSERT [dbo].[ReceiptDetail] ([ReceiptId], [BookId], [Quantity], [Status]) VALUES (N'R002', N'B005', 10, 1)
INSERT [dbo].[ReceiptDetail] ([ReceiptId], [BookId], [Quantity], [Status]) VALUES (N'R003', N'B006', 1, 1)
GO
INSERT [dbo].[Stock] ([BookId], [BookQuantity], [Status]) VALUES (N'B001', 80, 1)
INSERT [dbo].[Stock] ([BookId], [BookQuantity], [Status]) VALUES (N'B002', 60, 1)
INSERT [dbo].[Stock] ([BookId], [BookQuantity], [Status]) VALUES (N'B003', 76, 1)
INSERT [dbo].[Stock] ([BookId], [BookQuantity], [Status]) VALUES (N'B004', 100, 1)
INSERT [dbo].[Stock] ([BookId], [BookQuantity], [Status]) VALUES (N'B005', 55, 1)
INSERT [dbo].[Stock] ([BookId], [BookQuantity], [Status]) VALUES (N'B006', 49, 1)
INSERT [dbo].[Stock] ([BookId], [BookQuantity], [Status]) VALUES (N'B007', 65, 1)
INSERT [dbo].[Stock] ([BookId], [BookQuantity], [Status]) VALUES (N'B008', 90, 1)
INSERT [dbo].[Stock] ([BookId], [BookQuantity], [Status]) VALUES (N'B009', 100, 1)
INSERT [dbo].[Stock] ([BookId], [BookQuantity], [Status]) VALUES (N'B010', 100, 1)
GO
INSERT [dbo].[Vendor] ([VendorId], [VendorName], [VendorPhone], [Status]) VALUES (N'V01', N'Công ty trách nhiệm hữu hạn ABC', N'Phone1', 1)
INSERT [dbo].[Vendor] ([VendorId], [VendorName], [VendorPhone], [Status]) VALUES (N'V02', N'Công ty tư nhân 123', N'Phone2', 1)
INSERT [dbo].[Vendor] ([VendorId], [VendorName], [VendorPhone], [Status]) VALUES (N'V03', N'Công ty cổ phần DFG', N'Phone3', 1)
GO
ALTER TABLE [dbo].[BookType] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[DamagedBook] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Degree] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Import] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[ImportDetail] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Position] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Receipt] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[ReceiptDetail] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Stock] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Vendor] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_BookType] FOREIGN KEY([BookType])
REFERENCES [dbo].[BookType] ([TypeId])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_BookType]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Degree] FOREIGN KEY([EmplDegree])
REFERENCES [dbo].[Degree] ([DegId])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Degree]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Position] FOREIGN KEY([EmplPosition])
REFERENCES [dbo].[Position] ([PtnId])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Position]
GO
ALTER TABLE [dbo].[Import]  WITH CHECK ADD  CONSTRAINT [FK_Import_Vendor] FOREIGN KEY([VendorId])
REFERENCES [dbo].[Vendor] ([VendorId])
GO
ALTER TABLE [dbo].[Import] CHECK CONSTRAINT [FK_Import_Vendor]
GO
ALTER TABLE [dbo].[ImportDetail]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetail_Book] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
GO
ALTER TABLE [dbo].[ImportDetail] CHECK CONSTRAINT [FK_ImportDetail_Book]
GO
ALTER TABLE [dbo].[ImportDetail]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetail_Import] FOREIGN KEY([ImportId])
REFERENCES [dbo].[Import] ([ImportId])
GO
ALTER TABLE [dbo].[ImportDetail] CHECK CONSTRAINT [FK_ImportDetail_Import]
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_Customer]
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Employee] FOREIGN KEY([SaleEmployeeId])
REFERENCES [dbo].[Employee] ([EmplId])
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_Employee]
GO
ALTER TABLE [dbo].[ReceiptDetail]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptDetail_Book] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
GO
ALTER TABLE [dbo].[ReceiptDetail] CHECK CONSTRAINT [FK_ReceiptDetail_Book]
GO
ALTER TABLE [dbo].[ReceiptDetail]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptDetail_Receipt] FOREIGN KEY([ReceiptId])
REFERENCES [dbo].[Receipt] ([ReceiptId])
GO
ALTER TABLE [dbo].[ReceiptDetail] CHECK CONSTRAINT [FK_ReceiptDetail_Receipt]
GO
USE [master]
GO
ALTER DATABASE [db_hieusach] SET  READ_WRITE 
GO
