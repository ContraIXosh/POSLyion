USE [master]
GO
/****** Object:  Database [POSLyion]    Script Date: 9/26/2024 12:38:57 PM ******/
CREATE DATABASE [POSLyion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'POSLyion', FILENAME = N'E:\Programas\SQL Server 2022 Developer Edition\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\POSLyion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'POSLyion_log', FILENAME = N'E:\Programas\SQL Server 2022 Developer Edition\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\POSLyion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [POSLyion] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POSLyion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POSLyion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [POSLyion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [POSLyion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [POSLyion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [POSLyion] SET ARITHABORT OFF 
GO
ALTER DATABASE [POSLyion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [POSLyion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [POSLyion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [POSLyion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [POSLyion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [POSLyion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [POSLyion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [POSLyion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [POSLyion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [POSLyion] SET  ENABLE_BROKER 
GO
ALTER DATABASE [POSLyion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [POSLyion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [POSLyion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [POSLyion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [POSLyion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [POSLyion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [POSLyion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [POSLyion] SET RECOVERY FULL 
GO
ALTER DATABASE [POSLyion] SET  MULTI_USER 
GO
ALTER DATABASE [POSLyion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [POSLyion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [POSLyion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [POSLyion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [POSLyion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [POSLyion] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'POSLyion', N'ON'
GO
ALTER DATABASE [POSLyion] SET QUERY_STORE = ON
GO
ALTER DATABASE [POSLyion] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [POSLyion]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](40) NULL,
	[full_name] [varchar](100) NOT NULL,
	[email] [varchar](155) NULL,
	[phone] [varchar](60) NULL,
	[state] [bit] NOT NULL,
	[create_date] [datetime] NOT NULL,
	[modify_date] [datetime] NULL,
 CONSTRAINT [PK_customer_id] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissions](
	[permission_id] [int] IDENTITY(1,1) NOT NULL,
	[role_id] [int] NOT NULL,
	[menu_name] [varchar](100) NOT NULL,
	[create_date] [datetime] NOT NULL,
 CONSTRAINT [PK_permission_id] PRIMARY KEY CLUSTERED 
(
	[permission_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategories]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategories](
	[product_category_id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](60) NOT NULL,
	[state] [bit] NOT NULL,
	[create_date] [datetime] NOT NULL,
	[modify_date] [datetime] NULL,
 CONSTRAINT [PK_product_category_id] PRIMARY KEY CLUSTERED 
(
	[product_category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[bar_code] [varchar](60) NOT NULL,
	[description] [varchar](60) NOT NULL,
	[product_category_id] [int] NOT NULL,
	[cost_price] [decimal](9, 2) NOT NULL,
	[sale_price] [decimal](9, 2) NOT NULL,
	[current_stock] [int] NOT NULL,
	[minimum_stock] [int] NOT NULL,
	[state] [bit] NOT NULL,
	[create_date] [datetime] NOT NULL,
	[modify_date] [datetime] NULL,
 CONSTRAINT [PK_product_id] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrderDetails]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrderDetails](
	[purchase_order_detail_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[price] [decimal](9, 2) NOT NULL,
	[quantity] [int] NOT NULL,
	[subtotal] [decimal](12, 2) NOT NULL,
 CONSTRAINT [PK_order_detail_id] PRIMARY KEY CLUSTERED 
(
	[purchase_order_detail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrders]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrders](
	[purchase_order_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[vendor_id] [int] NULL,
	[total] [decimal](12, 2) NOT NULL,
	[document_type] [varchar](20) NOT NULL,
	[document_number] [varchar](50) NULL,
	[create_date] [datetime] NOT NULL,
 CONSTRAINT [PK_order_id] PRIMARY KEY CLUSTERED 
(
	[purchase_order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[role_id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](60) NOT NULL,
	[create_date] [datetime] NOT NULL,
	[modify_date] [datetime] NULL,
 CONSTRAINT [PK_rol_id] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleDetails]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleDetails](
	[sale_detail_id] [int] IDENTITY(1,1) NOT NULL,
	[sale_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[price] [decimal](12, 2) NOT NULL,
	[quantity] [int] NOT NULL,
	[subtotal] [decimal](12, 2) NOT NULL,
 CONSTRAINT [PK_sale_detail_id] PRIMARY KEY CLUSTERED 
(
	[sale_detail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[sale_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[customer_id] [int] NULL,
	[total] [decimal](12, 2) NOT NULL,
	[change] [decimal](6, 2) NOT NULL,
	[create_date] [datetime] NOT NULL,
	[modify_date] [datetime] NULL,
 CONSTRAINT [PK_sale_id] PRIMARY KEY CLUSTERED 
(
	[sale_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](30) NULL,
	[full_name] [varchar](100) NOT NULL,
	[email] [varchar](155) NULL,
	[username] [varchar](30) NOT NULL,
	[password] [varchar](155) NOT NULL,
	[role_id] [int] NOT NULL,
	[state] [bit] NOT NULL,
	[create_date] [datetime] NOT NULL,
	[modify_date] [datetime] NULL,
	[phone] [varchar](60) NULL,
 CONSTRAINT [PK_user_id] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendors]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendors](
	[vendor_id] [int] IDENTITY(1,1) NOT NULL,
	[cuit] [varchar](40) NULL,
	[company_name] [varchar](100) NOT NULL,
	[email] [varchar](155) NULL,
	[phone] [varchar](60) NULL,
	[state] [bit] NOT NULL,
	[create_date] [datetime] NOT NULL,
	[modify_date] [datetime] NULL,
 CONSTRAINT [PK_provider_id] PRIMARY KEY CLUSTERED 
(
	[vendor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Permissions] ON 

INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (1, 1, N'ventasToolStripMenuItem', CAST(N'2024-08-31T19:47:22.127' AS DateTime))
INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (2, 1, N'comprasToolStripMenuItem', CAST(N'2024-08-31T19:47:22.127' AS DateTime))
INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (3, 1, N'productosToolStripMenuItem', CAST(N'2024-08-31T19:47:22.127' AS DateTime))
INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (4, 1, N'usuariosToolStripMenuItem', CAST(N'2024-08-31T19:47:22.127' AS DateTime))
INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (5, 1, N'clientesToolStripMenuItem', CAST(N'2024-08-31T19:47:22.127' AS DateTime))
INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (6, 1, N'proveedoresToolStripMenuItem', CAST(N'2024-08-31T19:47:22.127' AS DateTime))
INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (7, 1, N'reportesToolStripMenuItem', CAST(N'2024-08-31T19:47:22.127' AS DateTime))
INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (8, 1, N'configuraciónToolStripMenuItem', CAST(N'2024-08-31T19:47:22.127' AS DateTime))
INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (11, 3, N'comprasToolStripMenuItem', CAST(N'2024-08-31T19:47:22.150' AS DateTime))
INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (12, 3, N'productosToolStripMenuItem', CAST(N'2024-08-31T19:47:22.150' AS DateTime))
INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (13, 4, N'ventasToolStripMenuItem', CAST(N'2024-08-31T19:47:22.150' AS DateTime))
INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (14, 4, N'reportesToolStripMenuItem', CAST(N'2024-08-31T19:47:22.150' AS DateTime))
INSERT [dbo].[Permissions] ([permission_id], [role_id], [menu_name], [create_date]) VALUES (15, 4, N'clientesToolStripMenuItem', CAST(N'2024-08-31T19:47:22.150' AS DateTime))
SET IDENTITY_INSERT [dbo].[Permissions] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([role_id], [description], [create_date], [modify_date]) VALUES (1, N'Usuario', CAST(N'2024-08-31T19:47:22.000' AS DateTime), NULL)
INSERT [dbo].[Roles] ([role_id], [description], [create_date], [modify_date]) VALUES (3, N'Gestor de negocio', CAST(N'2024-08-31T19:47:22.030' AS DateTime), NULL)
INSERT [dbo].[Roles] ([role_id], [description], [create_date], [modify_date]) VALUES (4, N'Administrador', CAST(N'2024-08-31T19:47:22.043' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([user_id], [dni], [full_name], [email], [username], [password], [role_id], [state], [create_date], [modify_date], [phone]) VALUES (1, N'43108399', N'Lucas Matias Prado', N'llluuuukkkkks@gmail.com', N'hexatec9', N'123', 1, 1, CAST(N'2024-08-31T19:47:22.093' AS DateTime), CAST(N'2024-09-25T16:53:18.000' AS DateTime), N'3794111111')
INSERT [dbo].[Users] ([user_id], [dni], [full_name], [email], [username], [password], [role_id], [state], [create_date], [modify_date], [phone]) VALUES (2, N'43274483', N'Mauricio', N'contraixosh@hotmail.com', N'contraixoshh', N'123', 1, 0, CAST(N'2024-08-31T19:47:22.093' AS DateTime), CAST(N'2024-08-31T20:45:37.667' AS DateTime), N'3794222222')
INSERT [dbo].[Users] ([user_id], [dni], [full_name], [email], [username], [password], [role_id], [state], [create_date], [modify_date], [phone]) VALUES (3, N'43108398', N'Mauricio Emmanuel Villalba', N'contraixosh@hotmail.com', N'hexatec8', N'123', 1, 1, CAST(N'2024-08-31T20:05:17.033' AS DateTime), CAST(N'2024-09-26T11:14:03.267' AS DateTime), N'3794333333')
INSERT [dbo].[Users] ([user_id], [dni], [full_name], [email], [username], [password], [role_id], [state], [create_date], [modify_date], [phone]) VALUES (1002, N'43274481', N'full_name_prueba_crud', N'emailprueba@hotmail.com', N'prueba_crud', N'123', 3, 0, CAST(N'2024-09-25T15:49:03.317' AS DateTime), CAST(N'2024-09-25T16:24:02.240' AS DateTime), N'3794902111')
INSERT [dbo].[Users] ([user_id], [dni], [full_name], [email], [username], [password], [role_id], [state], [create_date], [modify_date], [phone]) VALUES (1003, N'43274401', N'crud_create_user_exito', N'prueba_crud@outlook.com', N'diz', N'123', 4, 1, CAST(N'2024-09-25T16:29:28.943' AS DateTime), CAST(N'2024-09-26T12:37:11.733' AS DateTime), N'379110000')
INSERT [dbo].[Users] ([user_id], [dni], [full_name], [email], [username], [password], [role_id], [state], [create_date], [modify_date], [phone]) VALUES (1004, N'', N'prueba_incompleto_crud', N'', N'prueba_incompleto', N'123', 1, 0, CAST(N'2024-09-25T16:32:46.083' AS DateTime), CAST(N'2024-09-25T16:46:04.430' AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_Dni]    Script Date: 9/26/2024 12:38:58 PM ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [UC_Dni] UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_Username]    Script Date: 9/26/2024 12:38:58 PM ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [UC_Username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT (getdate()) FOR [create_date]
GO
ALTER TABLE [dbo].[Permissions] ADD  DEFAULT (getdate()) FOR [create_date]
GO
ALTER TABLE [dbo].[ProductCategories] ADD  DEFAULT (getdate()) FOR [create_date]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0)) FOR [cost_price]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0)) FOR [sale_price]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0)) FOR [current_stock]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0)) FOR [minimum_stock]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT (getdate()) FOR [create_date]
GO
ALTER TABLE [dbo].[PurchaseOrderDetails] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[PurchaseOrders] ADD  DEFAULT (getdate()) FOR [create_date]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (getdate()) FOR [create_date]
GO
ALTER TABLE [dbo].[Sales] ADD  DEFAULT (getdate()) FOR [create_date]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [create_date]
GO
ALTER TABLE [dbo].[Vendors] ADD  DEFAULT (getdate()) FOR [create_date]
GO
ALTER TABLE [dbo].[Permissions]  WITH CHECK ADD  CONSTRAINT [FK_Permissions_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([role_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Permissions] CHECK CONSTRAINT [FK_Permissions_Roles]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductCategories] FOREIGN KEY([product_category_id])
REFERENCES [dbo].[ProductCategories] ([product_category_id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductCategories]
GO
ALTER TABLE [dbo].[PurchaseOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrderDetails_Products] FOREIGN KEY([product_id])
REFERENCES [dbo].[Products] ([product_id])
GO
ALTER TABLE [dbo].[PurchaseOrderDetails] CHECK CONSTRAINT [FK_PurchaseOrderDetails_Products]
GO
ALTER TABLE [dbo].[PurchaseOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrderDetails_PurchaseOrders] FOREIGN KEY([order_id])
REFERENCES [dbo].[PurchaseOrders] ([purchase_order_id])
GO
ALTER TABLE [dbo].[PurchaseOrderDetails] CHECK CONSTRAINT [FK_PurchaseOrderDetails_PurchaseOrders]
GO
ALTER TABLE [dbo].[PurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[PurchaseOrders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[PurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_Vendors_PurchaseOrders] FOREIGN KEY([vendor_id])
REFERENCES [dbo].[Vendors] ([vendor_id])
GO
ALTER TABLE [dbo].[PurchaseOrders] CHECK CONSTRAINT [FK_Vendors_PurchaseOrders]
GO
ALTER TABLE [dbo].[SaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_SaleDetails_Products] FOREIGN KEY([product_id])
REFERENCES [dbo].[Products] ([product_id])
GO
ALTER TABLE [dbo].[SaleDetails] CHECK CONSTRAINT [FK_SaleDetails_Products]
GO
ALTER TABLE [dbo].[SaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_SaleDetails_Sales] FOREIGN KEY([sale_id])
REFERENCES [dbo].[Sales] ([sale_id])
GO
ALTER TABLE [dbo].[SaleDetails] CHECK CONSTRAINT [FK_SaleDetails_Sales]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customers] ([customer_id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Customers]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([role_id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
/****** Object:  StoredProcedure [dbo].[SP_CREATE_USER]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CREATE_USER]
@dni VARCHAR(30),
@full_name VARCHAR(100),
@email VARCHAR(155),
@username VARCHAR(30),
@password VARCHAR(155),
@role_id INT,
@phone VARCHAR(60),
@state BIT,
@message VARCHAR(360) OUTPUT,
@created_user_id INT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @created_user_id = 0
	IF NOT EXISTS (SELECT dni, username FROM Users WHERE dni = @dni OR username = @username)
	BEGIN
		INSERT INTO Users (dni, full_name, email, username, password, role_id, phone, state)
		VALUES (@dni, @full_name, @email, @username, @password, @role_id, @phone, @state)
		SET @created_user_id = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @message = 'Ya existe un usuario con el mismo DNI o nombre de usuario. Por favor, verificar nuevamente.'
		SET @created_user_id = 0
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_USER]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DELETE_USER]
@user_id INT,
@message VARCHAR(360) OUTPUT,
@result BIT OUTPUT
AS
BEGIN
	IF EXISTS (SELECT user_id FROM Users WHERE user_id = @user_id)
	BEGIN
		UPDATE Users
		SET state = 0
		WHERE user_id = @user_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'No se encuentra el usuario solicitado'
		SET @result = 0
	END
END	
GO
/****** Object:  StoredProcedure [dbo].[SP_RESTORE_USER]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_RESTORE_USER]
@user_id INT,
@message VARCHAR(360) OUTPUT,
@result INT OUTPUT
AS
BEGIN
	SET @message = ''
	IF EXISTS(SELECT user_id FROM Users WHERE user_id = @user_id)
	BEGIN
		UPDATE Users
		SET state = 1
		WHERE user_id = @user_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'No se encuentra el usuario solicitado'
		SET @result = 0
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_USER]    Script Date: 9/26/2024 12:38:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATE_USER]
@user_id INT,
@dni VARCHAR(30),
@full_name VARCHAR(100),
@email VARCHAR(155),
@username VARCHAR(30),
@password VARCHAR(155),
@role_id INT,
@phone VARCHAR(60),
@state BIT,
@message VARCHAR(360) OUTPUT,
@result BIT OUTPUT
AS
BEGIN
	IF NOT EXISTS (SELECT user_id, dni, username FROM Users WHERE user_id != @user_id AND (dni = @dni OR username = @username))
	BEGIN
		UPDATE Users SET
		dni = @dni,
		full_name = @full_name,
		email = @email,
		username = @username,
		password = @password,
		role_id = @role_id,
		phone = @phone,
		state = @state,
		modify_date = GETDATE()
		WHERE user_id = @user_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'Ya existe un usuario con el mismo DNI o nombre de usuario. Por favor, verificar nuevamente.'
		SET @result = 0
	END
END
GO
USE [master]
GO
ALTER DATABASE [POSLyion] SET  READ_WRITE 
GO
