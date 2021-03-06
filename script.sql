USE [master]
GO
/****** Object:  Database [Project291]    Script Date: 2018-06-11 8:17:08 PM ******/
CREATE DATABASE [Project291]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project291', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Project291.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Project291_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Project291_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Project291] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project291].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project291] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project291] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project291] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project291] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project291] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project291] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Project291] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project291] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project291] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project291] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project291] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project291] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project291] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project291] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project291] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Project291] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project291] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project291] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project291] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project291] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project291] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project291] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project291] SET RECOVERY FULL 
GO
ALTER DATABASE [Project291] SET  MULTI_USER 
GO
ALTER DATABASE [Project291] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project291] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project291] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project291] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Project291] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Project291', N'ON'
GO
USE [Project291]
GO
/****** Object:  Table [dbo].[Branch]    Script Date: 2018-06-11 8:17:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branch](
	[BID] [int] NOT NULL,
	[location] [nchar](16) NULL,
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[BID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Car]    Script Date: 2018-06-11 8:17:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[VID] [int] NOT NULL,
	[Type_ID] [int] NULL,
	[BID] [int] NULL,
	[Miles] [int] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[VID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CarType]    Script Date: 2018-06-11 8:17:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarType](
	[Type_ID] [int] NOT NULL,
	[car_type_name] [nchar](20) NULL,
	[monthly_price] [int] NULL,
	[weekly_price] [int] NULL,
	[daily_price] [int] NULL,
 CONSTRAINT [PK_CarType] PRIMARY KEY CLUSTERED 
(
	[Type_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2018-06-11 8:17:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [nchar](50) NULL,
	[LName] [nchar](50) NULL,
	[City] [nchar](50) NULL,
	[Street] [nchar](50) NULL,
	[Postal_Code] [nchar](50) NULL,
	[Credit_Card] [nchar](50) NULL,
	[Goldstar] [int] NULL,
	[phone_number] [nchar](50) NULL,
	[email] [nchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2018-06-11 8:17:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EID] [int] NOT NULL,
	[FName] [nchar](50) NULL,
	[LName] [nchar](50) NULL,
	[City] [nchar](50) NULL,
	[start_date] [nchar](50) NULL,
	[email] [nchar](50) NULL,
	[BID] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RentalHistory]    Script Date: 2018-06-11 8:17:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalHistory](
	[Transaction_ID] [int] IDENTITY(1,1) NOT NULL,
	[CID] [int] NULL,
	[EID_process_pickup] [int] NULL,
	[from_BID] [int] NULL,
	[delivered_to_BID] [int] NULL,
	[scheduled_pickup_date] [nchar](25) NULL,
	[rental_duration] [nchar](25) NULL,
	[late_fee] [int] NULL,
	[scheduled_return_date] [nchar](25) NULL,
	[picked_up] [int] NULL,
	[real_return_date] [nchar](25) NULL,
	[VID] [int] NULL,
	[EID_process_return] [int] NULL,
	[date_booking_made] [nchar](25) NULL,
 CONSTRAINT [PK_RentalHistory] PRIMARY KEY CLUSTERED 
(
	[Transaction_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Branch] ([BID], [location]) VALUES (1, N'Calgary         ')
INSERT [dbo].[Branch] ([BID], [location]) VALUES (2, N'Edmonton        ')
INSERT [dbo].[Branch] ([BID], [location]) VALUES (3, N'Vancouver       ')
INSERT [dbo].[Branch] ([BID], [location]) VALUES (4, N'Dallas          ')
INSERT [dbo].[Branch] ([BID], [location]) VALUES (5, N'Seattle         ')
INSERT [dbo].[Branch] ([BID], [location]) VALUES (6, N'Red Deer        ')
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (11, 1, 1, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (12, 1, 2, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (13, 1, 3, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (14, 2, 4, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (15, 2, 5, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (16, 2, 6, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (17, 3, 1, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (18, 3, 2, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (19, 3, 3, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (20, 4, 4, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (21, 4, 5, 10000)
INSERT [dbo].[Car] ([VID], [Type_ID], [BID], [Miles]) VALUES (22, 4, 6, 10000)
INSERT [dbo].[CarType] ([Type_ID], [car_type_name], [monthly_price], [weekly_price], [daily_price]) VALUES (1, N'Plain Car           ', 500, 100, 25)
INSERT [dbo].[CarType] ([Type_ID], [car_type_name], [monthly_price], [weekly_price], [daily_price]) VALUES (2, N'SUV                 ', 600, 200, 50)
INSERT [dbo].[CarType] ([Type_ID], [car_type_name], [monthly_price], [weekly_price], [daily_price]) VALUES (3, N'Truck               ', 700, 300, 75)
INSERT [dbo].[CarType] ([Type_ID], [car_type_name], [monthly_price], [weekly_price], [daily_price]) VALUES (4, N'Sports Car          ', 800, 400, 100)
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CID], [FName], [LName], [City], [Street], [Postal_Code], [Credit_Card], [Goldstar], [phone_number], [email]) VALUES (77782, N'John                                              ', N'Smith                                             ', N'Calgary                                           ', N'123 Fake Street                                   ', N'T1S 1A6                                           ', N'1234-1234-1234-1234                               ', 0, N'7805140453                                        ', N'jsmith@email.com                                  ')
INSERT [dbo].[Customer] ([CID], [FName], [LName], [City], [Street], [Postal_Code], [Credit_Card], [Goldstar], [phone_number], [email]) VALUES (77783, N'Sam                                               ', N'Pools                                             ', N'Edmonton                                          ', N'7905 67 Street                                    ', N'T0E 1K0                                           ', N'1230-1230-1230-1230                               ', 0, N'7805140001                                        ', N'spools@email.com                                  ')
INSERT [dbo].[Customer] ([CID], [FName], [LName], [City], [Street], [Postal_Code], [Credit_Card], [Goldstar], [phone_number], [email]) VALUES (77784, N'Joe                                               ', N'Combs                                             ', N'Calgary                                           ', N'8776 120 Street                                   ', N'T0E 1K9                                           ', N'9234-9234-9234-9234                               ', 0, N'7805140002                                        ', N'jcombs@email.com                                  ')
INSERT [dbo].[Customer] ([CID], [FName], [LName], [City], [Street], [Postal_Code], [Credit_Card], [Goldstar], [phone_number], [email]) VALUES (77788, N't                                                 ', N't                                                 ', N't                                                 ', N't                                                 ', N't                                                 ', N'123                                               ', 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Customer] OFF
INSERT [dbo].[Employee] ([EID], [FName], [LName], [City], [start_date], [email], [BID]) VALUES (8888, N'Mark                                              ', N'Roberts                                           ', N'Calgary                                           ', N'2009                                              ', N'mroberts@company.com                              ', 1)
INSERT [dbo].[Employee] ([EID], [FName], [LName], [City], [start_date], [email], [BID]) VALUES (8889, N'Fred                                              ', N'Holder                                            ', N'Edmonton                                          ', N'2013                                              ', N'fholder@company.com                               ', 2)
SET IDENTITY_INSERT [dbo].[RentalHistory] ON 

INSERT [dbo].[RentalHistory] ([Transaction_ID], [CID], [EID_process_pickup], [from_BID], [delivered_to_BID], [scheduled_pickup_date], [rental_duration], [late_fee], [scheduled_return_date], [picked_up], [real_return_date], [VID], [EID_process_return], [date_booking_made]) VALUES (35666, 77783, 7, 1, 1, N'2018-05-01               ', N'week                     ', 1, N'2018-05-07               ', 0, NULL, 11, 1, N'1-5-2018                 ')
SET IDENTITY_INSERT [dbo].[RentalHistory] OFF
USE [master]
GO
ALTER DATABASE [Project291] SET  READ_WRITE 
GO
