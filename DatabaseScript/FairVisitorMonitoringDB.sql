USE [master]
GO
/****** Object:  Database [FairVisitorMonitoringBD]    Script Date: 5/28/2015 11:21:06 AM ******/
CREATE DATABASE [FairVisitorMonitoringBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FairVisitorMonitoringBD', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\FairVisitorMonitoringBD.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FairVisitorMonitoringBD_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\FairVisitorMonitoringBD_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FairVisitorMonitoringBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET  MULTI_USER 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FairVisitorMonitoringBD]
GO
/****** Object:  Table [dbo].[VisitorTable]    Script Date: 5/28/2015 11:21:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VisitorTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[ContactNumber] [varchar](50) NOT NULL,
 CONSTRAINT [PK_VisitorTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VisitorZoneTable]    Script Date: 5/28/2015 11:21:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitorZoneTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VisitorID] [int] NOT NULL,
	[ZoneId] [int] NOT NULL,
 CONSTRAINT [PK_VisitorZoneTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ZoneTable]    Script Date: 5/28/2015 11:21:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ZoneTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ZoneName] [varchar](max) NOT NULL,
 CONSTRAINT [PK_ZoneTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[VisitorDetailView]    Script Date: 5/28/2015 11:21:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VisitorDetailView]
AS

SELECT v.ID,v.Name,v.Email,v.ContactNumber,z.ID AS ZoneID,z.ZoneName FROM VisitorTable AS v LEFT OUTER JOIN VisitorZoneTable AS vz ON v.ID = vz.VisitorID LEFT OUTER JOIN ZoneTable AS z ON vz.ZoneId = z.ID

GO
SET IDENTITY_INSERT [dbo].[VisitorTable] ON 

INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (1, N'Sajib', N'sajib49@gmail.com', N'+8801676260176')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (2, N'Adil', N'adilhasan62@yahoo.com', N'+880192000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (3, N'Shourov', N'shourov149@yahoo.com', N'+880167000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (4, N'Kajol', N'kajol@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (5, N'Kajol', N'kajol@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (6, N'Kajol', N'kajol@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (7, N'Kajol', N'kajol@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (8, N'Kajol', N'kajol@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (9, N'Kajol', N'kajol@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (10, N'Kajol', N'kajol@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (11, N'Kajol', N'kajol@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (12, N'Kajol', N'kajol@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (13, N'Kajol', N'kajol@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (14, N'Kajol', N'kajol@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (15, N'Kajol', N'kajol@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (16, N'ggg', N'gg', N'ggg')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (17, N'Mithila', N'mithi@gmail.com', N'01913000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (18, N'Sabuj', N'sabuj.ict@yahoo.com', N'01710000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (19, N'Ohona', N'ohona@gmail.com', N'01555555555')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (20, N'Mim', N'mim@yahoo.com', N'01755555555')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (1002, N'Jamal', N'jamal@yahoo.com', N'01670000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (1003, N'Bappa', N'bappa@yahoo.com', N'0167000000')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (1004, N'Tarek', N'tarek69@gmail.com', N'01913496489')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (2002, N'Sumon', N'sumon420@gmail.com', N'01914563990')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (2003, N'Rashed', N'rashed.khokon@yahoo.com', N'017198770034')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (2004, N'Manik', N'studentmanik@gmail.com', N'01555555555')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (2005, N'Ratul', N'ratul.bs-14@gmail.com', N'01766699999')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (2006, N'jhytr', N'gtrfe', N'rvcef')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (2007, N'dwq', N'dsa', N'dasd')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (2008, N'raegv', N'fasg', N'gfad')
INSERT [dbo].[VisitorTable] ([ID], [Name], [Email], [ContactNumber]) VALUES (2009, N'Mizan', N'mizan.bitm@gmail.com', N'0176666666')
SET IDENTITY_INSERT [dbo].[VisitorTable] OFF
SET IDENTITY_INSERT [dbo].[VisitorZoneTable] ON 

INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1, 17, 1)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2, 17, 2)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (3, 17, 4)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (4, 18, 9)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (5, 18, 1002)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (6, 19, 1)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (7, 19, 2)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (8, 19, 3)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (9, 20, 1)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (10, 20, 2)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (11, 20, 7)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (12, 20, 9)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1002, 1002, 1)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1003, 1002, 2)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1004, 1002, 3)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1005, 1002, 4)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1006, 1002, 5)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1007, 1002, 7)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1008, 1002, 9)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1009, 1002, 1002)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1010, 1003, 3)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1011, 1003, 4)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1012, 1003, 5)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1013, 1003, 7)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1014, 1003, 1002)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1015, 1004, 1)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1016, 1004, 3)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1017, 1004, 5)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (1018, 1004, 7)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2002, 2002, 1)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2003, 2002, 2)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2004, 2002, 3)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2005, 2002, 4)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2006, 2002, 5)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2007, 2002, 7)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2008, 2002, 9)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2009, 2002, 1002)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2010, 2004, 1)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2011, 2004, 2)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2012, 2004, 3)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2013, 2004, 4)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2014, 2004, 5)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2015, 2004, 7)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2016, 2004, 9)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2017, 2004, 1002)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2018, 2009, 1)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2019, 2009, 2)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2020, 2009, 3)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2021, 2009, 4)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2022, 2009, 5)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2023, 2009, 7)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2024, 2009, 9)
INSERT [dbo].[VisitorZoneTable] ([ID], [VisitorID], [ZoneId]) VALUES (2025, 2009, 1002)
SET IDENTITY_INSERT [dbo].[VisitorZoneTable] OFF
SET IDENTITY_INSERT [dbo].[ZoneTable] ON 

INSERT [dbo].[ZoneTable] ([ID], [ZoneName]) VALUES (1, N'Web Design & Develop')
INSERT [dbo].[ZoneTable] ([ID], [ZoneName]) VALUES (2, N'Mobile App Zone')
INSERT [dbo].[ZoneTable] ([ID], [ZoneName]) VALUES (3, N'Games & Multimedia Zone')
INSERT [dbo].[ZoneTable] ([ID], [ZoneName]) VALUES (4, N'Enterprise Application Zone')
INSERT [dbo].[ZoneTable] ([ID], [ZoneName]) VALUES (5, N'Telecom Software Zone')
INSERT [dbo].[ZoneTable] ([ID], [ZoneName]) VALUES (7, N'Digital Bangladesh Zone')
INSERT [dbo].[ZoneTable] ([ID], [ZoneName]) VALUES (9, N'Android App')
INSERT [dbo].[ZoneTable] ([ID], [ZoneName]) VALUES (1002, N'Laptop & Hardware Zone')
SET IDENTITY_INSERT [dbo].[ZoneTable] OFF
ALTER TABLE [dbo].[VisitorZoneTable]  WITH CHECK ADD  CONSTRAINT [FK_VisitorZoneTable_VisitorTable] FOREIGN KEY([VisitorID])
REFERENCES [dbo].[VisitorTable] ([ID])
GO
ALTER TABLE [dbo].[VisitorZoneTable] CHECK CONSTRAINT [FK_VisitorZoneTable_VisitorTable]
GO
ALTER TABLE [dbo].[VisitorZoneTable]  WITH CHECK ADD  CONSTRAINT [FK_VisitorZoneTable_ZoneTable] FOREIGN KEY([ZoneId])
REFERENCES [dbo].[ZoneTable] ([ID])
GO
ALTER TABLE [dbo].[VisitorZoneTable] CHECK CONSTRAINT [FK_VisitorZoneTable_ZoneTable]
GO
USE [master]
GO
ALTER DATABASE [FairVisitorMonitoringBD] SET  READ_WRITE 
GO
