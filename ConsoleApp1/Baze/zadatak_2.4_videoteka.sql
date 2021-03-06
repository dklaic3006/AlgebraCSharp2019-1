USE [master]
GO
/****** Object:  Database [zadatak_2.4_videoteka]    Script Date: 20.3.2019. 10:39:56 ******/
CREATE DATABASE [zadatak_2.4_videoteka]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'zadatak_2.4_videoteka', FILENAME = N'C:\Users\Damir\zadatak_2.4_videoteka.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'zadatak_2.4_videoteka_log', FILENAME = N'C:\Users\Damir\zadatak_2.4_videoteka_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [zadatak_2.4_videoteka].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET ARITHABORT OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET  DISABLE_BROKER 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET  MULTI_USER 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET DB_CHAINING OFF 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET QUERY_STORE = OFF
GO
USE [zadatak_2.4_videoteka]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [zadatak_2.4_videoteka]
GO
/****** Object:  Table [dbo].[cjenik]    Script Date: 20.3.2019. 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cjenik](
	[id_cjenika] [int] IDENTITY(1,1) NOT NULL,
	[kategorija] [nchar](10) NULL,
	[cijena] [smallmoney] NULL,
 CONSTRAINT [PK_cjenik] PRIMARY KEY CLUSTERED 
(
	[id_cjenika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clanovi]    Script Date: 20.3.2019. 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clanovi](
	[id_clana] [int] IDENTITY(1,1) NOT NULL,
	[ime] [nvarchar](50) NOT NULL,
	[prezime] [nvarchar](50) NOT NULL,
	[adresa] [nvarchar](50) NULL,
	[mjesto] [nvarchar](25) NULL,
	[telefon] [char](15) NULL,
	[datum_uclanjenja] [date] NOT NULL,
 CONSTRAINT [PK_clanovi] PRIMARY KEY CLUSTERED 
(
	[id_clana] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[filmovi]    Script Date: 20.3.2019. 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[filmovi](
	[id_filma] [nchar](10) NOT NULL,
	[id_zanra] [nchar](10) NULL,
	[godina_izdanja] [int] NULL,
	[naziv] [nvarchar](50) NOT NULL,
	[ime_rezisera] [nvarchar](50) NULL,
	[prezime_rezisera] [nvarchar](50) NULL,
	[ime_gl_glumca] [nvarchar](50) NULL,
	[prezime_gl_glumca] [nvarchar](50) NULL,
	[DVD_kolicina] [int] NOT NULL,
	[VHS_kolicina] [int] NOT NULL,
	[broj_police] [nchar](10) NULL,
	[naslovnica] [image] NULL,
 CONSTRAINT [PK_filmovi] PRIMARY KEY CLUSTERED 
(
	[id_filma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[posudba]    Script Date: 20.3.2019. 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[posudba](
	[id_clana] [int] NOT NULL,
	[id_filma] [nchar](10) NOT NULL,
	[datum_posudbe] [date] NOT NULL,
	[datum_povratka] [date] NOT NULL,
	[id_cjenika] [int] NULL,
 CONSTRAINT [PK_posudba] PRIMARY KEY CLUSTERED 
(
	[id_clana] ASC,
	[id_filma] ASC,
	[datum_posudbe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[zanrovi]    Script Date: 20.3.2019. 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zanrovi](
	[id_zanra] [nchar](10) NOT NULL,
	[zanr] [nchar](10) NOT NULL,
 CONSTRAINT [PK_zanrovi] PRIMARY KEY CLUSTERED 
(
	[id_zanra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[cjenik] ON 

INSERT [dbo].[cjenik] ([id_cjenika], [kategorija], [cijena]) VALUES (1, N'Hit DVD   ', 15.0000)
INSERT [dbo].[cjenik] ([id_cjenika], [kategorija], [cijena]) VALUES (2, N'DVD       ', 12.0000)
INSERT [dbo].[cjenik] ([id_cjenika], [kategorija], [cijena]) VALUES (3, N'Hit VHS   ', 12.0000)
INSERT [dbo].[cjenik] ([id_cjenika], [kategorija], [cijena]) VALUES (4, N'VHS       ', 10.0000)
SET IDENTITY_INSERT [dbo].[cjenik] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_clanovi]    Script Date: 20.3.2019. 10:40:00 ******/
CREATE NONCLUSTERED INDEX [IX_clanovi] ON [dbo].[clanovi]
(
	[prezime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_filmovi]    Script Date: 20.3.2019. 10:40:00 ******/
CREATE NONCLUSTERED INDEX [IX_filmovi] ON [dbo].[filmovi]
(
	[naziv] ASC,
	[prezime_gl_glumca] ASC,
	[prezime_rezisera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_zanrovi]    Script Date: 20.3.2019. 10:40:00 ******/
CREATE NONCLUSTERED INDEX [IX_zanrovi] ON [dbo].[zanrovi]
(
	[zanr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[filmovi]  WITH CHECK ADD  CONSTRAINT [FK_filmovi_zanrovi] FOREIGN KEY([id_zanra])
REFERENCES [dbo].[zanrovi] ([id_zanra])
GO
ALTER TABLE [dbo].[filmovi] CHECK CONSTRAINT [FK_filmovi_zanrovi]
GO
ALTER TABLE [dbo].[posudba]  WITH CHECK ADD  CONSTRAINT [FK_posudba_cjenik] FOREIGN KEY([id_cjenika])
REFERENCES [dbo].[cjenik] ([id_cjenika])
GO
ALTER TABLE [dbo].[posudba] CHECK CONSTRAINT [FK_posudba_cjenik]
GO
ALTER TABLE [dbo].[posudba]  WITH CHECK ADD  CONSTRAINT [FK_posudba_clanovi] FOREIGN KEY([id_clana])
REFERENCES [dbo].[clanovi] ([id_clana])
GO
ALTER TABLE [dbo].[posudba] CHECK CONSTRAINT [FK_posudba_clanovi]
GO
ALTER TABLE [dbo].[posudba]  WITH CHECK ADD  CONSTRAINT [FK_posudba_filmovi] FOREIGN KEY([id_filma])
REFERENCES [dbo].[filmovi] ([id_filma])
GO
ALTER TABLE [dbo].[posudba] CHECK CONSTRAINT [FK_posudba_filmovi]
GO
ALTER TABLE [dbo].[zanrovi]  WITH CHECK ADD  CONSTRAINT [CK_zanrovi] CHECK  (([id_zanra]>=(1000) AND [id_zanra]<=(9999)))
GO
ALTER TABLE [dbo].[zanrovi] CHECK CONSTRAINT [CK_zanrovi]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_zanra BETWEEN 1000 AND 9999' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zanrovi', @level2type=N'CONSTRAINT',@level2name=N'CK_zanrovi'
GO
USE [master]
GO
ALTER DATABASE [zadatak_2.4_videoteka] SET  READ_WRITE 
GO
