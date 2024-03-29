USE [master]
GO
/****** Object:  Database [FastFood]    Script Date: 2020-01-12 12:09:28 AM ******/
CREATE DATABASE [FastFood]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FastFood', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\FastFood.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FastFood_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\FastFood_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FastFood] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FastFood].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FastFood] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FastFood] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FastFood] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FastFood] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FastFood] SET ARITHABORT OFF 
GO
ALTER DATABASE [FastFood] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FastFood] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FastFood] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FastFood] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FastFood] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FastFood] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FastFood] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FastFood] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FastFood] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FastFood] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FastFood] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FastFood] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FastFood] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FastFood] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FastFood] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FastFood] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FastFood] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FastFood] SET RECOVERY FULL 
GO
ALTER DATABASE [FastFood] SET  MULTI_USER 
GO
ALTER DATABASE [FastFood] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FastFood] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FastFood] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FastFood] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FastFood] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FastFood', N'ON'
GO
USE [FastFood]
GO
/****** Object:  Table [dbo].[tbl_goods]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_goods](
	[goods_id] [int] NOT NULL,
	[kurdish_name] [nvarchar](50) NULL,
	[arabic_name] [nvarchar](50) NULL,
	[english_name] [nvarchar](50) NULL,
	[sort] [int] NULL,
	[print_name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[goods_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_goods_type]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_goods_type](
	[goods_type_id] [int] NOT NULL,
	[kurdish_name] [nvarchar](50) NULL,
	[arabic_name] [nvarchar](50) NULL,
	[english_name] [nvarchar](50) NULL,
	[price] [float] NULL,
	[sort_no] [int] NULL,
	[goods_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[goods_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_invoice]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_invoice](
	[invoice_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[invoice_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_invoice_info]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_invoice_info](
	[info_id] [int] NOT NULL,
	[invoice_id] [int] NULL,
	[date] [date] NULL,
	[total_before_discount] [float] NULL,
	[discount_amount] [float] NULL,
	[discount_ratio] [float] NULL,
	[total_after_discount] [float] NULL,
	[user_id] [int] NULL,
	[mobile_info_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[info_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_mobile_info]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_mobile_info](
	[mobile_info_id] [int] NOT NULL,
	[mobile_number] [nvarchar](50) NULL,
	[address] [nvarchar](80) NULL,
 CONSTRAINT [PK_tbl_mobile_info] PRIMARY KEY CLUSTERED 
(
	[mobile_info_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_note]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_note](
	[order_id] [int] NOT NULL,
	[invoice_id] [int] NULL,
	[goods_type_id] [int] NULL,
	[price] [float] NULL,
	[quantity] [int] NULL,
	[table_id] [int] NULL,
	[note] [bit] NULL,
 CONSTRAINT [PK__tbl_note__4659622927CCBDF6] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_order]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_order](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[invoice_id] [int] NULL,
	[goods_type_id] [int] NULL,
	[price] [float] NULL,
	[quantity] [int] NULL,
	[table_id] [int] NULL,
 CONSTRAINT [PK__tbl_orde__465962290D8A4F45] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_table_info]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_table_info](
	[table_id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[available] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[table_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[user_id] [int] NOT NULL,
	[username] [nvarchar](120) NULL,
	[password] [nvarchar](120) NULL,
	[permission] [nvarchar](50) NULL,
	[favcolor] [nvarchar](120) NULL,
	[favanimal] [nvarchar](120) NULL,
	[full_name] [nvarchar](50) NULL,
	[active] [bit] NULL,
	[is_changed] [bit] NULL,
	[is_still_work] [bit] NULL,
	[email] [nvarchar](80) NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_check]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_check]
AS
SELECT        dbo.tbl_note.goods_type_id, MAX(dbo.tbl_note.invoice_id) AS invoice_id, MAX(dbo.tbl_goods_type.kurdish_name) AS kurdish_name, SUM(dbo.tbl_note.quantity) AS quantity, dbo.tbl_table_info.name AS [table], 
                         dbo.tbl_note.note
FROM            dbo.tbl_note INNER JOIN
                         dbo.tbl_goods_type ON dbo.tbl_note.goods_type_id = dbo.tbl_goods_type.goods_type_id INNER JOIN
                         dbo.tbl_table_info ON dbo.tbl_note.table_id = dbo.tbl_table_info.table_id
GROUP BY dbo.tbl_note.goods_type_id, dbo.tbl_note.note, dbo.tbl_table_info.name

GO
/****** Object:  View [dbo].[View_note]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_note]
AS
SELECT        MAX(dbo.tbl_note.order_id) AS order_id, dbo.tbl_note.goods_type_id, MAX(dbo.tbl_goods_type.kurdish_name) AS kurdish_name, MAX(dbo.tbl_goods_type.price) AS price, SUM(dbo.tbl_note.quantity) AS quantity, 
                         dbo.tbl_note.invoice_id, dbo.tbl_table_info.name, SUM(dbo.tbl_note.quantity) * MAX(dbo.tbl_goods_type.price) AS total
FROM            dbo.tbl_note INNER JOIN
                         dbo.tbl_table_info ON dbo.tbl_note.table_id = dbo.tbl_table_info.table_id INNER JOIN
                         dbo.tbl_goods_type ON dbo.tbl_note.goods_type_id = dbo.tbl_goods_type.goods_type_id
GROUP BY dbo.tbl_note.goods_type_id, dbo.tbl_note.invoice_id, dbo.tbl_table_info.name

GO
INSERT [dbo].[tbl_goods] ([goods_id], [kurdish_name], [arabic_name], [english_name], [sort], [print_name]) VALUES (1, N'erangel', N'azar', N'mad', 5, N'awd')
INSERT [dbo].[tbl_goods] ([goods_id], [kurdish_name], [arabic_name], [english_name], [sort], [print_name]) VALUES (2, N'aaa', N'www', N'ffff', 1, N'aaa')
INSERT [dbo].[tbl_goods] ([goods_id], [kurdish_name], [arabic_name], [english_name], [sort], [print_name]) VALUES (3, N'darawan', N'awd', N'awd', 3, N'asdawd')
INSERT [dbo].[tbl_goods] ([goods_id], [kurdish_name], [arabic_name], [english_name], [sort], [print_name]) VALUES (4, N'dara', N'awdawd', N'wadwda', 2, N'awdwd')
INSERT [dbo].[tbl_goods] ([goods_id], [kurdish_name], [arabic_name], [english_name], [sort], [print_name]) VALUES (5, N'branco', N'ئەلەرم', N'custridge', 1, N'mqabilat')
INSERT [dbo].[tbl_goods] ([goods_id], [kurdish_name], [arabic_name], [english_name], [sort], [print_name]) VALUES (6, N'ساردی توشی لوشی', N'سردی پوشی نوشی', N'frezy drink', 1, N'hello')
INSERT [dbo].[tbl_goods] ([goods_id], [kurdish_name], [arabic_name], [english_name], [sort], [print_name]) VALUES (8, N'خدسا', N'زساسا', N'sassa', 1, N'1')
INSERT [dbo].[tbl_goods] ([goods_id], [kurdish_name], [arabic_name], [english_name], [sort], [print_name]) VALUES (9, N'اسواس', N'ساساسا', N'as', 1, N'1')
INSERT [dbo].[tbl_goods] ([goods_id], [kurdish_name], [arabic_name], [english_name], [sort], [print_name]) VALUES (10, N'a', N'awd', N'as', 2, N'sd')
INSERT [dbo].[tbl_goods_type] ([goods_type_id], [kurdish_name], [arabic_name], [english_name], [price], [sort_no], [goods_id]) VALUES (2, N'www', N'wad', N'awd', 123, 1, 2)
INSERT [dbo].[tbl_goods_type] ([goods_type_id], [kurdish_name], [arabic_name], [english_name], [price], [sort_no], [goods_id]) VALUES (4, N'awed', N'ewfw', N'adwadwad', 123, 12, 2)
INSERT [dbo].[tbl_goods_type] ([goods_type_id], [kurdish_name], [arabic_name], [english_name], [price], [sort_no], [goods_id]) VALUES (5, N'sef', N'bbb', N'awd12', 123213, 321, 4)
INSERT [dbo].[tbl_goods_type] ([goods_type_id], [kurdish_name], [arabic_name], [english_name], [price], [sort_no], [goods_id]) VALUES (9, N'aaa', N'bbb', N'ccc', 333, 444, 3)
INSERT [dbo].[tbl_goods_type] ([goods_type_id], [kurdish_name], [arabic_name], [english_name], [price], [sort_no], [goods_id]) VALUES (10, N'کەلەرمی فەڕەنسی', N'ئەلەرمی فەڕەنسی', N'alarm', 123, 2, 5)
INSERT [dbo].[tbl_goods_type] ([goods_type_id], [kurdish_name], [arabic_name], [english_name], [price], [sort_no], [goods_id]) VALUES (12, N'uyj', N'wsefawd', N'awd', 32445, 4, 5)
INSERT [dbo].[tbl_goods_type] ([goods_type_id], [kurdish_name], [arabic_name], [english_name], [price], [sort_no], [goods_id]) VALUES (13, N'سەوفوە', N'adwq', N'awd', 234324, 3, 5)
INSERT [dbo].[tbl_goods_type] ([goods_type_id], [kurdish_name], [arabic_name], [english_name], [price], [sort_no], [goods_id]) VALUES (14, N'volvano', N'ڤۆلڤۆ', N'volvo', 200, 1, 5)
INSERT [dbo].[tbl_invoice] ([invoice_id]) VALUES (1)
INSERT [dbo].[tbl_invoice] ([invoice_id]) VALUES (2)
INSERT [dbo].[tbl_invoice] ([invoice_id]) VALUES (3)
INSERT [dbo].[tbl_invoice] ([invoice_id]) VALUES (4)
INSERT [dbo].[tbl_invoice] ([invoice_id]) VALUES (5)
INSERT [dbo].[tbl_invoice] ([invoice_id]) VALUES (6)
INSERT [dbo].[tbl_invoice] ([invoice_id]) VALUES (7)
INSERT [dbo].[tbl_invoice] ([invoice_id]) VALUES (8)
INSERT [dbo].[tbl_invoice_info] ([info_id], [invoice_id], [date], [total_before_discount], [discount_amount], [discount_ratio], [total_after_discount], [user_id], [mobile_info_id]) VALUES (1, 1, CAST(N'2020-01-02' AS Date), 246, 0, 0, 246, 0, NULL)
INSERT [dbo].[tbl_invoice_info] ([info_id], [invoice_id], [date], [total_before_discount], [discount_amount], [discount_ratio], [total_after_discount], [user_id], [mobile_info_id]) VALUES (2, 2, CAST(N'2020-01-02' AS Date), 123, 0, 0, 123, 0, NULL)
INSERT [dbo].[tbl_invoice_info] ([info_id], [invoice_id], [date], [total_before_discount], [discount_amount], [discount_ratio], [total_after_discount], [user_id], [mobile_info_id]) VALUES (3, 3, CAST(N'2020-01-02' AS Date), 534394, 0, 0, 534394, 0, NULL)
INSERT [dbo].[tbl_invoice_info] ([info_id], [invoice_id], [date], [total_before_discount], [discount_amount], [discount_ratio], [total_after_discount], [user_id], [mobile_info_id]) VALUES (4, 4, CAST(N'2020-01-06' AS Date), 323, 0, 0, 323, 0, 1)
INSERT [dbo].[tbl_mobile_info] ([mobile_info_id], [mobile_number], [address]) VALUES (1, N'0750 123 1048', N'slemani')
INSERT [dbo].[tbl_mobile_info] ([mobile_info_id], [mobile_number], [address]) VALUES (2, N'234324', N'erfefw')
INSERT [dbo].[tbl_mobile_info] ([mobile_info_id], [mobile_number], [address]) VALUES (3, N'0', N'نیە')
INSERT [dbo].[tbl_note] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id], [note]) VALUES (14, 8, 14, 200, 1, 10, 0)
SET IDENTITY_INSERT [dbo].[tbl_order] ON 

INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (4011, 1, 2, 123, 1, 2)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (4012, 1, 4, 123, 1, 2)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (4013, 2, 4, 123, 1, 2)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (4014, 3, 13, 234324, 1, 1)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (4015, 3, 12, 32445, 1, 1)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (4016, 3, 14, 200, 1, 1)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (4017, 3, 9, 333, 1, 1)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (4018, 3, 14, 200, 1, 1)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (4019, 3, 10, 123, 1, 1)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (4020, 3, 13, 234324, 1, 1)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (4021, 3, 12, 32445, 1, 1)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (5002, 4, 14, 200, 1, 10)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (5003, 4, 10, 123, 1, 10)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (6002, 5, 14, 200, 1, 1)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (6003, 6, 13, 234324, 1, 8)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (6004, 6, 14, 200, 1, 8)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (6005, 6, 10, 123, 1, 8)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (6006, 6, 12, 32445, 1, 8)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (6007, 6, 13, 234324, 1, 8)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (6008, 7, 14, 200, 1, 2)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (6009, 7, 14, 200, 1, 2)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (6010, 7, 10, 123, 1, 2)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (6011, 7, 14, 200, 1, 2)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (6012, 7, 4, 123, 1, 2)
INSERT [dbo].[tbl_order] ([order_id], [invoice_id], [goods_type_id], [price], [quantity], [table_id]) VALUES (6013, 7, 2, 123, 1, 2)
SET IDENTITY_INSERT [dbo].[tbl_order] OFF
INSERT [dbo].[tbl_table_info] ([table_id], [name], [available]) VALUES (1, N'T1', 1)
INSERT [dbo].[tbl_table_info] ([table_id], [name], [available]) VALUES (2, N'T2', 1)
INSERT [dbo].[tbl_table_info] ([table_id], [name], [available]) VALUES (3, N'T3', 1)
INSERT [dbo].[tbl_table_info] ([table_id], [name], [available]) VALUES (8, N'dd', 1)
INSERT [dbo].[tbl_table_info] ([table_id], [name], [available]) VALUES (9, N'T4', 1)
INSERT [dbo].[tbl_table_info] ([table_id], [name], [available]) VALUES (10, N'دیلیڤەری', 1)
INSERT [dbo].[tbl_user] ([user_id], [username], [password], [permission], [favcolor], [favanimal], [full_name], [active], [is_changed], [is_still_work], [email]) VALUES (1, N'qAwi3gkBFVM=', N'1A5hV7722Ik=', N'admin', N'OZ5Zr5X+ocU=', N'TGdSoMvWbVQ=', N'shahram adalat', 1, 1, 1, N'shahramadalat@gmail.com')
SET ANSI_PADDING ON

GO
/****** Object:  Index [unique_name_in_iufo]    Script Date: 2020-01-12 12:09:28 AM ******/
ALTER TABLE [dbo].[tbl_table_info] ADD  CONSTRAINT [unique_name_in_iufo] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [unique_email_user]    Script Date: 2020-01-12 12:09:28 AM ******/
ALTER TABLE [dbo].[tbl_user] ADD  CONSTRAINT [unique_email_user] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [unique_username_in_user]    Script Date: 2020-01-12 12:09:28 AM ******/
ALTER TABLE [dbo].[tbl_user] ADD  CONSTRAINT [unique_username_in_user] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uq_color_animal_user]    Script Date: 2020-01-12 12:09:28 AM ******/
ALTER TABLE [dbo].[tbl_user] ADD  CONSTRAINT [uq_color_animal_user] UNIQUE NONCLUSTERED 
(
	[favcolor] ASC,
	[favanimal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_goods_type]  WITH CHECK ADD FOREIGN KEY([goods_id])
REFERENCES [dbo].[tbl_goods] ([goods_id])
GO
ALTER TABLE [dbo].[tbl_invoice_info]  WITH CHECK ADD FOREIGN KEY([invoice_id])
REFERENCES [dbo].[tbl_invoice] ([invoice_id])
GO
ALTER TABLE [dbo].[tbl_note]  WITH CHECK ADD  CONSTRAINT [FK__tbl_note__goods___239E4DCF] FOREIGN KEY([goods_type_id])
REFERENCES [dbo].[tbl_goods_type] ([goods_type_id])
GO
ALTER TABLE [dbo].[tbl_note] CHECK CONSTRAINT [FK__tbl_note__goods___239E4DCF]
GO
ALTER TABLE [dbo].[tbl_note]  WITH CHECK ADD  CONSTRAINT [FK__tbl_note__invoic__22AA2996] FOREIGN KEY([invoice_id])
REFERENCES [dbo].[tbl_invoice] ([invoice_id])
GO
ALTER TABLE [dbo].[tbl_note] CHECK CONSTRAINT [FK__tbl_note__invoic__22AA2996]
GO
ALTER TABLE [dbo].[tbl_note]  WITH CHECK ADD  CONSTRAINT [FK__tbl_note__table___24927208] FOREIGN KEY([table_id])
REFERENCES [dbo].[tbl_table_info] ([table_id])
GO
ALTER TABLE [dbo].[tbl_note] CHECK CONSTRAINT [FK__tbl_note__table___24927208]
GO
ALTER TABLE [dbo].[tbl_order]  WITH CHECK ADD  CONSTRAINT [FK__tbl_order__goods__1ED998B2] FOREIGN KEY([goods_type_id])
REFERENCES [dbo].[tbl_goods_type] ([goods_type_id])
GO
ALTER TABLE [dbo].[tbl_order] CHECK CONSTRAINT [FK__tbl_order__goods__1ED998B2]
GO
ALTER TABLE [dbo].[tbl_order]  WITH CHECK ADD  CONSTRAINT [FK__tbl_order__invoi__1DE57479] FOREIGN KEY([invoice_id])
REFERENCES [dbo].[tbl_invoice] ([invoice_id])
GO
ALTER TABLE [dbo].[tbl_order] CHECK CONSTRAINT [FK__tbl_order__invoi__1DE57479]
GO
ALTER TABLE [dbo].[tbl_order]  WITH CHECK ADD  CONSTRAINT [FK__tbl_order__table__1FCDBCEB] FOREIGN KEY([table_id])
REFERENCES [dbo].[tbl_table_info] ([table_id])
GO
ALTER TABLE [dbo].[tbl_order] CHECK CONSTRAINT [FK__tbl_order__table__1FCDBCEB]
GO
/****** Object:  StoredProcedure [dbo].[spGet_address]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spGet_address]
@address nvarchar(50)
as
set nocount on;
select * from tbl_mobile_info where address like @address


GO
/****** Object:  StoredProcedure [dbo].[spGet_invoice_info]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGet_invoice_info]
@invoice_id int
as
begin
set nocount on;
select total_before_discount,discount_amount,discount_ratio,total_after_discount,user_id from tbl_invoice_info where invoice_id=@invoice_id 
end
























GO
/****** Object:  StoredProcedure [dbo].[spGet_mobile_number]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGet_mobile_number]
@mobile nvarchar(50)
as
set nocount on;
select * from tbl_mobile_info where mobile_number like @mobile
GO
/****** Object:  StoredProcedure [dbo].[spGoods_get_by_arabic_name]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spGoods_get_by_arabic_name]
@arabic_name nvarchar(50)
as begin
set nocount on;
select * from tbl_goods where arabic_name like @arabic_name
end
GO
/****** Object:  StoredProcedure [dbo].[spGoods_get_by_english_name]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spGoods_get_by_english_name]
@english_name nvarchar(50)
as 
begin
select * from tbl_goods where english_name=@english_name;
end
GO
/****** Object:  StoredProcedure [dbo].[spGoods_get_by_kurdish_name]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spGoods_get_by_kurdish_name]
@kurdish_name nvarchar(50)
as begin
select * from tbl_goods where kurdish_name = @kurdish_name
end
GO
/****** Object:  StoredProcedure [dbo].[spGoods_get_by_printer_name]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spGoods_get_by_printer_name]
@print_name nvarchar(50)
as
begin 
set nocount on;
select * from tbl_goods where print_name like @print_name
end
GO
/****** Object:  StoredProcedure [dbo].[spGoods_type_get_by_arabic]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGoods_type_get_by_arabic]
@arabic nvarchar(50)
as
begin
set nocount on;
select * from tbl_goods_type where arabic_name like @arabic
end
GO
/****** Object:  StoredProcedure [dbo].[spGoods_type_get_by_english]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGoods_type_get_by_english]
@english nvarchar(50)
as
begin
set nocount on;
select * from tbl_goods_type where english_name like @english
end
GO
/****** Object:  StoredProcedure [dbo].[spGoods_type_get_by_kurdish]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGoods_type_get_by_kurdish]
@kurdish nvarchar(50)
as
begin
set nocount on;
select * from tbl_goods_type where kurdish_name like @kurdish
end
GO
/****** Object:  StoredProcedure [dbo].[spPrint]    Script Date: 2020-01-12 12:09:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spPrint]
@table_name nvarchar(50)
as
set nocount on;
select kurdish_name,price,quantity,total,name,invoice_id from View_note where name=@table_name;
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_user', @level2type=N'COLUMN',@level2name=N'username'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_note"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_goods_type"
            Begin Extent = 
               Top = 18
               Left = 327
               Bottom = 148
               Right = 497
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_table_info"
            Begin Extent = 
               Top = 163
               Left = 327
               Bottom = 286
               Right = 497
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_check'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_check'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[39] 4[22] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_note"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 215
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_table_info"
            Begin Extent = 
               Top = 29
               Left = 331
               Bottom = 142
               Right = 501
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_goods_type"
            Begin Extent = 
               Top = 154
               Left = 354
               Bottom = 284
               Right = 540
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_note'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_note'
GO
USE [master]
GO
ALTER DATABASE [FastFood] SET  READ_WRITE 
GO
