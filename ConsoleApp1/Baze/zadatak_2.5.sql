USE [master]
GO
/****** Object:  Database [zadatak_2.3]    Script Date: 20.3.2019. 12:13:59 ******/
CREATE DATABASE [zadatak_2.3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'zadatak_2.3', FILENAME = N'C:\Users\Damir\zadatak_2.3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'zadatak_2.3_log', FILENAME = N'C:\Users\Damir\zadatak_2.3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [zadatak_2.3] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [zadatak_2.3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [zadatak_2.3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [zadatak_2.3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [zadatak_2.3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [zadatak_2.3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [zadatak_2.3] SET ARITHABORT OFF 
GO
ALTER DATABASE [zadatak_2.3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [zadatak_2.3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [zadatak_2.3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [zadatak_2.3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [zadatak_2.3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [zadatak_2.3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [zadatak_2.3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [zadatak_2.3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [zadatak_2.3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [zadatak_2.3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [zadatak_2.3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [zadatak_2.3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [zadatak_2.3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [zadatak_2.3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [zadatak_2.3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [zadatak_2.3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [zadatak_2.3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [zadatak_2.3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [zadatak_2.3] SET  MULTI_USER 
GO
ALTER DATABASE [zadatak_2.3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [zadatak_2.3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [zadatak_2.3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [zadatak_2.3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [zadatak_2.3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [zadatak_2.3] SET QUERY_STORE = OFF
GO
USE [zadatak_2.3]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [zadatak_2.3]
GO
/****** Object:  Table [dbo].[proizvod]    Script Date: 20.3.2019. 12:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proizvod](
	[id_prizvoda] [nchar](10) NOT NULL,
	[naziv] [nvarchar](50) NOT NULL,
	[id_skladista] [nchar](10) NOT NULL,
 CONSTRAINT [PK_proizvod] PRIMARY KEY CLUSTERED 
(
	[id_prizvoda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[radnici]    Script Date: 20.3.2019. 12:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[radnici](
	[id_radnika] [int] IDENTITY(1,1) NOT NULL,
	[ime] [nvarchar](50) NOT NULL,
	[prezine] [nvarchar](50) NULL,
	[id_skladista] [nchar](10) NULL,
 CONSTRAINT [PK_radnici] PRIMARY KEY CLUSTERED 
(
	[id_radnika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[skladiste]    Script Date: 20.3.2019. 12:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[skladiste](
	[id_skladista] [nchar](10) NOT NULL,
	[naziv] [nvarchar](50) NOT NULL,
	[lokacija_skladista] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_skladište] PRIMARY KEY CLUSTERED 
(
	[id_skladista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[voditelji]    Script Date: 20.3.2019. 12:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[voditelji](
	[id_radnika] [int] NOT NULL,
	[id_skladista] [nchar](10) NOT NULL,
 CONSTRAINT [PK_voditelji] PRIMARY KEY CLUSTERED 
(
	[id_radnika] ASC,
	[id_skladista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[proizvod] ([id_prizvoda], [naziv], [id_skladista]) VALUES (N'p1        ', N'stol', N's1        ')
INSERT [dbo].[proizvod] ([id_prizvoda], [naziv], [id_skladista]) VALUES (N'p2        ', N'stolica', N's1        ')
INSERT [dbo].[proizvod] ([id_prizvoda], [naziv], [id_skladista]) VALUES (N'p3        ', N'krevet', N's1        ')
INSERT [dbo].[proizvod] ([id_prizvoda], [naziv], [id_skladista]) VALUES (N'p4        ', N'spužva', N's2        ')
INSERT [dbo].[proizvod] ([id_prizvoda], [naziv], [id_skladista]) VALUES (N'p5        ', N'tekstil', N's2        ')
INSERT [dbo].[proizvod] ([id_prizvoda], [naziv], [id_skladista]) VALUES (N'p6        ', N'konac', N's2        ')
INSERT [dbo].[proizvod] ([id_prizvoda], [naziv], [id_skladista]) VALUES (N'p7        ', N'čokolada', N's3        ')
INSERT [dbo].[proizvod] ([id_prizvoda], [naziv], [id_skladista]) VALUES (N'p8        ', N'keks', N's3        ')
SET IDENTITY_INSERT [dbo].[radnici] ON 

INSERT [dbo].[radnici] ([id_radnika], [ime], [prezine], [id_skladista]) VALUES (1, N'Ivan', N'Prvi', N's1        ')
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezine], [id_skladista]) VALUES (2, N'Marko', N'Drugi', N's1        ')
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezine], [id_skladista]) VALUES (3, N'Darko', N'Treći', N's2        ')
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezine], [id_skladista]) VALUES (4, N'Franjo', N'Šest', N's2        ')
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezine], [id_skladista]) VALUES (8, N'Anica', N'Max', N's3        ')
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezine], [id_skladista]) VALUES (9, N'Marica', N'Ivić', N's3        ')
SET IDENTITY_INSERT [dbo].[radnici] OFF
INSERT [dbo].[skladiste] ([id_skladista], [naziv], [lokacija_skladista]) VALUES (N's1        ', N'skladište1', N'Osijek')
INSERT [dbo].[skladiste] ([id_skladista], [naziv], [lokacija_skladista]) VALUES (N's2        ', N'skladište2', N'Vinkovci')
INSERT [dbo].[skladiste] ([id_skladista], [naziv], [lokacija_skladista]) VALUES (N's3        ', N'skladište3', N'Vukovar')
INSERT [dbo].[voditelji] ([id_radnika], [id_skladista]) VALUES (1, N's1        ')
INSERT [dbo].[voditelji] ([id_radnika], [id_skladista]) VALUES (3, N's2        ')
INSERT [dbo].[voditelji] ([id_radnika], [id_skladista]) VALUES (9, N's3        ')
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_skladiste]    Script Date: 20.3.2019. 12:14:03 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_skladiste] ON [dbo].[skladiste]
(
	[id_skladista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[proizvod]  WITH CHECK ADD  CONSTRAINT [FK_proizvod_skladiste] FOREIGN KEY([id_skladista])
REFERENCES [dbo].[skladiste] ([id_skladista])
GO
ALTER TABLE [dbo].[proizvod] CHECK CONSTRAINT [FK_proizvod_skladiste]
GO
ALTER TABLE [dbo].[radnici]  WITH CHECK ADD  CONSTRAINT [FK_radnici_skladište] FOREIGN KEY([id_skladista])
REFERENCES [dbo].[skladiste] ([id_skladista])
GO
ALTER TABLE [dbo].[radnici] CHECK CONSTRAINT [FK_radnici_skladište]
GO
ALTER TABLE [dbo].[voditelji]  WITH CHECK ADD  CONSTRAINT [FK_voditelji_radnici] FOREIGN KEY([id_radnika])
REFERENCES [dbo].[radnici] ([id_radnika])
GO
ALTER TABLE [dbo].[voditelji] CHECK CONSTRAINT [FK_voditelji_radnici]
GO
ALTER TABLE [dbo].[voditelji]  WITH CHECK ADD  CONSTRAINT [FK_voditelji_skladište] FOREIGN KEY([id_skladista])
REFERENCES [dbo].[skladiste] ([id_skladista])
GO
ALTER TABLE [dbo].[voditelji] CHECK CONSTRAINT [FK_voditelji_skladište]
GO
ALTER TABLE [dbo].[skladiste]  WITH CHECK ADD  CONSTRAINT [CK_skladiste] CHECK  (([lokacija_skladista]='Osijek' OR [lokacija_skladista]='Vinkovci' OR [lokacija_skladista]='Vukovar'))
GO
ALTER TABLE [dbo].[skladiste] CHECK CONSTRAINT [CK_skladiste]
GO
USE [master]
GO
ALTER DATABASE [zadatak_2.3] SET  READ_WRITE 
GO
