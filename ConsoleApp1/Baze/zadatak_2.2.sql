USE [master]
GO
/****** Object:  Database [zadatak_2.2]    Script Date: 20.3.2019. 0:32:45 ******/
CREATE DATABASE [zadatak_2.2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'zadatak_2.2', FILENAME = N'C:\Users\Damir\zadatak_2.2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'zadatak_2.2_log', FILENAME = N'C:\Users\Damir\zadatak_2.2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [zadatak_2.2] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [zadatak_2.2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [zadatak_2.2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [zadatak_2.2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [zadatak_2.2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [zadatak_2.2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [zadatak_2.2] SET ARITHABORT OFF 
GO
ALTER DATABASE [zadatak_2.2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [zadatak_2.2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [zadatak_2.2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [zadatak_2.2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [zadatak_2.2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [zadatak_2.2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [zadatak_2.2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [zadatak_2.2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [zadatak_2.2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [zadatak_2.2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [zadatak_2.2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [zadatak_2.2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [zadatak_2.2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [zadatak_2.2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [zadatak_2.2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [zadatak_2.2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [zadatak_2.2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [zadatak_2.2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [zadatak_2.2] SET  MULTI_USER 
GO
ALTER DATABASE [zadatak_2.2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [zadatak_2.2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [zadatak_2.2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [zadatak_2.2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [zadatak_2.2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [zadatak_2.2] SET QUERY_STORE = OFF
GO
USE [zadatak_2.2]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [zadatak_2.2]
GO
/****** Object:  Table [dbo].[odjeli]    Script Date: 20.3.2019. 0:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[odjeli](
	[id_odjela] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [nvarchar](50) NOT NULL,
	[lokacija] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__odjeli__AC670D52902C0428] PRIMARY KEY CLUSTERED 
(
	[id_odjela] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[radnici]    Script Date: 20.3.2019. 0:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[radnici](
	[id_radnika] [int] IDENTITY(1,1) NOT NULL,
	[ime] [nvarchar](50) NOT NULL,
	[prezime] [nvarchar](50) NOT NULL,
	[id_odjela] [int] NOT NULL,
 CONSTRAINT [PK__radnici__FBAF864B06D92069] PRIMARY KEY CLUSTERED 
(
	[id_radnika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[voditelji]    Script Date: 20.3.2019. 0:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[voditelji](
	[id_radnika] [int] NOT NULL,
	[id_odjela] [int] NOT NULL,
 CONSTRAINT [PK_id] PRIMARY KEY CLUSTERED 
(
	[id_radnika] ASC,
	[id_odjela] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[odjeli] ON 

INSERT [dbo].[odjeli] ([id_odjela], [naziv], [lokacija]) VALUES (1, N'Prodaja', N'Zagreb')
INSERT [dbo].[odjeli] ([id_odjela], [naziv], [lokacija]) VALUES (2, N'Nabava', N'Zagreb')
INSERT [dbo].[odjeli] ([id_odjela], [naziv], [lokacija]) VALUES (4, N'Transport', N'Požega')
INSERT [dbo].[odjeli] ([id_odjela], [naziv], [lokacija]) VALUES (5, N'Proizvodnja', N'Osijek')
SET IDENTITY_INSERT [dbo].[odjeli] OFF
SET IDENTITY_INSERT [dbo].[radnici] ON 

INSERT [dbo].[radnici] ([id_radnika], [ime], [prezime], [id_odjela]) VALUES (1, N'Tomislav', N'Lauš', 1)
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezime], [id_odjela]) VALUES (2, N'Marija', N'Cvek', 5)
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezime], [id_odjela]) VALUES (4, N'Lucija', N'Trenk', 2)
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezime], [id_odjela]) VALUES (5, N'Ivan', N'Jović', 1)
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezime], [id_odjela]) VALUES (6, N'Luka', N'Pervan', 3)
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezime], [id_odjela]) VALUES (7, N'Dubravko', N'Ham', 4)
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezime], [id_odjela]) VALUES (8, N'Alen', N'Nekić', 2)
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezime], [id_odjela]) VALUES (9, N'Nevia', N'Neven', 5)
INSERT [dbo].[radnici] ([id_radnika], [ime], [prezime], [id_odjela]) VALUES (11, N'Egon', N'Kroo', 4)
SET IDENTITY_INSERT [dbo].[radnici] OFF
INSERT [dbo].[voditelji] ([id_radnika], [id_odjela]) VALUES (1, 1)
INSERT [dbo].[voditelji] ([id_radnika], [id_odjela]) VALUES (4, 2)
INSERT [dbo].[voditelji] ([id_radnika], [id_odjela]) VALUES (9, 5)
INSERT [dbo].[voditelji] ([id_radnika], [id_odjela]) VALUES (11, 4)
ALTER TABLE [dbo].[voditelji]  WITH CHECK ADD  CONSTRAINT [FK__voditelji__id_od__2B3F6F97] FOREIGN KEY([id_odjela])
REFERENCES [dbo].[odjeli] ([id_odjela])
GO
ALTER TABLE [dbo].[voditelji] CHECK CONSTRAINT [FK__voditelji__id_od__2B3F6F97]
GO
ALTER TABLE [dbo].[voditelji]  WITH CHECK ADD  CONSTRAINT [FK__voditelji__id_za__2A4B4B5E] FOREIGN KEY([id_radnika])
REFERENCES [dbo].[radnici] ([id_radnika])
GO
ALTER TABLE [dbo].[voditelji] CHECK CONSTRAINT [FK__voditelji__id_za__2A4B4B5E]
GO
ALTER TABLE [dbo].[voditelji]  WITH CHECK ADD  CONSTRAINT [FK_voditelji_radnici] FOREIGN KEY([id_odjela])
REFERENCES [dbo].[radnici] ([id_radnika])
GO
ALTER TABLE [dbo].[voditelji] CHECK CONSTRAINT [FK_voditelji_radnici]
GO
USE [master]
GO
ALTER DATABASE [zadatak_2.2] SET  READ_WRITE 
GO
