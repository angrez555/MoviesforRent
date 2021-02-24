USE [master]
GO
/****** Object:  Database [databaseset]    Script Date: 2/24/2021 4:04:39 PM ******/
CREATE DATABASE [databaseset]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'databaseset', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\databaseset.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'databaseset_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\databaseset_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [databaseset] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [databaseset].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [databaseset] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [databaseset] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [databaseset] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [databaseset] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [databaseset] SET ARITHABORT OFF 
GO
ALTER DATABASE [databaseset] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [databaseset] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [databaseset] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [databaseset] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [databaseset] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [databaseset] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [databaseset] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [databaseset] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [databaseset] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [databaseset] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [databaseset] SET  DISABLE_BROKER 
GO
ALTER DATABASE [databaseset] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [databaseset] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [databaseset] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [databaseset] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [databaseset] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [databaseset] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [databaseset] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [databaseset] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [databaseset] SET  MULTI_USER 
GO
ALTER DATABASE [databaseset] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [databaseset] SET DB_CHAINING OFF 
GO
ALTER DATABASE [databaseset] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [databaseset] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [databaseset]
GO
/****** Object:  Table [dbo].[CUSTABLE]    Script Date: 2/24/2021 4:04:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTABLE](
	[CUSTOId] [int] NOT NULL,
	[FSTNAM] [varchar](50) NULL,
	[SURNAM] [varchar](50) NULL,
	[ADDRES] [varchar](50) NULL,
	[PHON] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CUSTOId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MOVTBL]    Script Date: 2/24/2021 4:04:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MOVTBL](
	[MOVSId] [int] NOT NULL,
	[MOVNAME] [varchar](50) NULL,
	[MOVRAT] [varchar](50) NULL,
	[MOVGEN] [varchar](50) NULL,
	[MOVCPY] [varchar](50) NULL,
	[MOVPLT] [varchar](50) NULL,
	[MOVRNT] [varchar](50) NULL,
	[MOVRELSDT] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MOVSId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RNTBL]    Script Date: 2/24/2021 4:04:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RNTBL](
	[RNTId] [int] NOT NULL,
	[CUSTOID] [int] NULL,
	[MOVSID] [int] NULL,
	[RNTDT] [varchar](50) NULL,
	[RTRNDT] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[RNTId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CUSTABLE] ([CUSTOId], [FSTNAM], [SURNAM], [ADDRES], [PHON]) VALUES (1, N'Vegta', N'Den', N'Garden mart', 374862)
INSERT [dbo].[CUSTABLE] ([CUSTOId], [FSTNAM], [SURNAM], [ADDRES], [PHON]) VALUES (2, N'Gohan', N'Bik', N'42 short Street', 378912)
INSERT [dbo].[CUSTABLE] ([CUSTOId], [FSTNAM], [SURNAM], [ADDRES], [PHON]) VALUES (3, N'Maxsan', N'Val', N'53 Stone Place', 893247)
INSERT [dbo].[CUSTABLE] ([CUSTOId], [FSTNAM], [SURNAM], [ADDRES], [PHON]) VALUES (4, N'Jackson', N'mento', N'84 Walten Way', 876284)
INSERT [dbo].[CUSTABLE] ([CUSTOId], [FSTNAM], [SURNAM], [ADDRES], [PHON]) VALUES (5, N'Roky', N'valt', N'Shrewood park', 983257)
INSERT [dbo].[CUSTABLE] ([CUSTOId], [FSTNAM], [SURNAM], [ADDRES], [PHON]) VALUES (6, N'Alex', N'Pit', N'Martin wal', 528429)
INSERT [dbo].[MOVTBL] ([MOVSId], [MOVNAME], [MOVRAT], [MOVGEN], [MOVCPY], [MOVPLT], [MOVRNT], [MOVRELSDT]) VALUES (1, N'Suicide Squade', N'7', N'Action', N'10', N'Story of women to fight aganst world', N'2', N'13-11-2011')
INSERT [dbo].[MOVTBL] ([MOVSId], [MOVNAME], [MOVRAT], [MOVGEN], [MOVCPY], [MOVPLT], [MOVRNT], [MOVRELSDT]) VALUES (2, N'Tennt', N'9', N'Action', N'18', N'Team of the secrate agent', N'5', N'24-2-2018 ')
INSERT [dbo].[MOVTBL] ([MOVSId], [MOVNAME], [MOVRAT], [MOVGEN], [MOVCPY], [MOVPLT], [MOVRNT], [MOVRELSDT]) VALUES (3, N'Dark Knight', N'8', N'Super Hero', N'16', N'Hero that come in night to save world', N'5', N'29-5-2019 ')
INSERT [dbo].[MOVTBL] ([MOVSId], [MOVNAME], [MOVRAT], [MOVGEN], [MOVCPY], [MOVPLT], [MOVRNT], [MOVRELSDT]) VALUES (4, N'F8', N'6', N'Adventure', N'27', N'Team of action hero go on the adventure', N'2', N'8-11-2014 ')
INSERT [dbo].[MOVTBL] ([MOVSId], [MOVNAME], [MOVRAT], [MOVGEN], [MOVCPY], [MOVPLT], [MOVRNT], [MOVRELSDT]) VALUES (5, N'Alien', N'9', N'Sci-fic', N'7', N'Alien come attack on the earth', N'2', N'22-5-2009 ')
INSERT [dbo].[MOVTBL] ([MOVSId], [MOVNAME], [MOVRAT], [MOVGEN], [MOVCPY], [MOVPLT], [MOVRNT], [MOVRELSDT]) VALUES (6, N'Onward', N'5', N'Story', N'38', N'Story of the two friend ', N'2', N'17-7-2010 ')
INSERT [dbo].[RNTBL] ([RNTId], [CUSTOID], [MOVSID], [RNTDT], [RTRNDT]) VALUES (1, 2, 1, N'19-2-2021', N'20-2-2021')
INSERT [dbo].[RNTBL] ([RNTId], [CUSTOID], [MOVSID], [RNTDT], [RTRNDT]) VALUES (2, 4, 3, N'21-2-2021', N'22-2-2021')
INSERT [dbo].[RNTBL] ([RNTId], [CUSTOID], [MOVSID], [RNTDT], [RTRNDT]) VALUES (3, 1, 5, N'21-2-2021', N'')
INSERT [dbo].[RNTBL] ([RNTId], [CUSTOID], [MOVSID], [RNTDT], [RTRNDT]) VALUES (4, 3, 4, N'22-2-2021', N'')
INSERT [dbo].[RNTBL] ([RNTId], [CUSTOID], [MOVSID], [RNTDT], [RTRNDT]) VALUES (5, 5, 2, N'22-2-2021', N'22-2-2021')
INSERT [dbo].[RNTBL] ([RNTId], [CUSTOID], [MOVSID], [RNTDT], [RTRNDT]) VALUES (6, 4, 6, N'23-2-2021', N'')
ALTER TABLE [dbo].[RNTBL]  WITH CHECK ADD  CONSTRAINT [FK_CUSTOID] FOREIGN KEY([CUSTOID])
REFERENCES [dbo].[CUSTABLE] ([CUSTOId])
GO
ALTER TABLE [dbo].[RNTBL] CHECK CONSTRAINT [FK_CUSTOID]
GO
ALTER TABLE [dbo].[RNTBL]  WITH CHECK ADD  CONSTRAINT [FK_MOVSID] FOREIGN KEY([MOVSID])
REFERENCES [dbo].[MOVTBL] ([MOVSId])
GO
ALTER TABLE [dbo].[RNTBL] CHECK CONSTRAINT [FK_MOVSID]
GO
USE [master]
GO
ALTER DATABASE [databaseset] SET  READ_WRITE 
GO
