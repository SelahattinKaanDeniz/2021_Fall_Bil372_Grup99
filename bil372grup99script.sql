USE [master]
GO
/****** Object:  Database [Bil372]    Script Date: 11/30/2021 9:52:28 AM ******/
CREATE DATABASE [Bil372]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bil372', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Bil372.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bil372_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Bil372_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Bil372] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bil372].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bil372] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bil372] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bil372] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bil372] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bil372] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bil372] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bil372] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bil372] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bil372] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bil372] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bil372] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bil372] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bil372] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bil372] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bil372] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bil372] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bil372] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bil372] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bil372] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bil372] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bil372] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bil372] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bil372] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Bil372] SET  MULTI_USER 
GO
ALTER DATABASE [Bil372] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bil372] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bil372] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bil372] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bil372] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bil372] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Bil372] SET QUERY_STORE = OFF
GO
USE [Bil372]
GO
/****** Object:  Table [dbo].[GenelBakim]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GenelBakim](
	[PersonelID] [varchar](11) NOT NULL,
	[ServisID] [varchar](11) NOT NULL,
	[UcakID] [varchar](11) NOT NULL,
	[BakimTuru] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GenelBakimTeknisyeni]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GenelBakimTeknisyeni](
	[ServisPersoneliID] [varchar](11) NOT NULL,
	[PersonelID] [varchar](11) NOT NULL,
	[TeknisyenDerecesi] [varchar](11) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KabinMemuru]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KabinMemuru](
	[MurettebatID] [varchar](11) NOT NULL,
	[UcakID] [varchar](11) NOT NULL,
	[PersonelID] [varchar](11) NOT NULL,
	[MedeniDurumu] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[KullaniciAdi] [varchar](30) NOT NULL,
	[Sifre] [varchar](256) NOT NULL,
	[KullaniciTipi] [varchar](50) NOT NULL,
	[PersonelID] [varchar](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Murettebat]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Murettebat](
	[MurettebatID] [varchar](11) NOT NULL,
	[UcakID] [varchar](11) NOT NULL,
	[PersonelID] [varchar](11) NOT NULL,
	[YabanciDil] [varchar](80) NOT NULL,
	[UcusSuresi] [varchar](20) NOT NULL,
	[MurettebatTipi] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MurettebatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[PersonelID] [varchar](11) NOT NULL,
	[Cinsiyet] [varchar](12) NOT NULL,
	[Maas] [varchar](9) NOT NULL,
	[DogumTarihi] [date] NOT NULL,
	[Ad] [varchar](30) NOT NULL,
	[Soyad] [varchar](30) NOT NULL,
	[Egitim] [varchar](80) NOT NULL,
	[TCNO] [varchar](11) NOT NULL,
	[SGN] [varchar](11) NOT NULL,
	[IseAlimTarihi] [date] NOT NULL,
	[TelefonNO] [varchar](13) NOT NULL,
	[Adres] [varchar](200) NOT NULL,
	[Eposta] [varchar](50) NOT NULL,
	[PersonelTipi] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pilot]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pilot](
	[MurettebatID] [varchar](11) NOT NULL,
	[UcakID] [varchar](11) NOT NULL,
	[PersonelID] [varchar](11) NOT NULL,
	[LisansTuru] [varchar](20) NOT NULL,
	[PilotRolu] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sefer]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sefer](
	[SeferID] [varchar](11) NOT NULL,
	[UcakID] [varchar](11) NOT NULL,
	[UcusSuresi] [varchar](20) NOT NULL,
	[SeferTarihi] [date] NOT NULL,
	[VarisZamani] [varchar](10) NOT NULL,
	[KalkisZamani] [varchar](10) NOT NULL,
	[VarisYeri] [varchar](100) NOT NULL,
	[KalkisYeri] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SeferID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servis]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servis](
	[ServisID] [varchar](11) NOT NULL,
	[UcakID] [varchar](11) NOT NULL,
	[BaslangicTarihi] [date] NOT NULL,
	[BitisTarihi] [date] NOT NULL,
	[ServisTipi] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ServisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServisPersoneli]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServisPersoneli](
	[ServisPersoneliID] [varchar](11) NOT NULL,
	[ServisPersonelTipi] [varchar](20) NOT NULL,
	[PersonelID] [varchar](11) NOT NULL,
	[CalistigiHavalimani] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ServisPersoneliID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tamir]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tamir](
	[PersonelID] [varchar](11) NOT NULL,
	[ServisID] [varchar](11) NOT NULL,
	[UcakID] [varchar](11) NOT NULL,
	[KazaTarihi] [date] NOT NULL,
	[KazaSebebi] [varchar](100) NOT NULL,
	[TamirSonucu] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TamirPersoneli]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TamirPersoneli](
	[ServisPersoneliID] [varchar](11) NOT NULL,
	[PersonelID] [varchar](11) NOT NULL,
	[Uzmanlik] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ucak]    Script Date: 11/30/2021 9:52:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ucak](
	[UcakID] [varchar](11) NOT NULL,
	[Model] [varchar](50) NOT NULL,
	[YolcuKapasitesi] [varchar](10) NOT NULL,
	[Agirlik] [varchar](10) NOT NULL,
	[UreticiFirma] [varchar](50) NOT NULL,
	[UretimYili] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UcakID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GenelBakim]  WITH CHECK ADD FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personel] ([PersonelID])
GO
ALTER TABLE [dbo].[GenelBakim]  WITH CHECK ADD FOREIGN KEY([ServisID])
REFERENCES [dbo].[Servis] ([ServisID])
GO
ALTER TABLE [dbo].[GenelBakim]  WITH CHECK ADD FOREIGN KEY([UcakID])
REFERENCES [dbo].[Ucak] ([UcakID])
GO
ALTER TABLE [dbo].[GenelBakimTeknisyeni]  WITH CHECK ADD FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personel] ([PersonelID])
GO
ALTER TABLE [dbo].[GenelBakimTeknisyeni]  WITH CHECK ADD FOREIGN KEY([ServisPersoneliID])
REFERENCES [dbo].[ServisPersoneli] ([ServisPersoneliID])
GO
ALTER TABLE [dbo].[KabinMemuru]  WITH CHECK ADD FOREIGN KEY([MurettebatID])
REFERENCES [dbo].[Murettebat] ([MurettebatID])
GO
ALTER TABLE [dbo].[KabinMemuru]  WITH CHECK ADD FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personel] ([PersonelID])
GO
ALTER TABLE [dbo].[KabinMemuru]  WITH CHECK ADD FOREIGN KEY([UcakID])
REFERENCES [dbo].[Ucak] ([UcakID])
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personel] ([PersonelID])
GO
ALTER TABLE [dbo].[Murettebat]  WITH CHECK ADD FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personel] ([PersonelID])
GO
ALTER TABLE [dbo].[Murettebat]  WITH CHECK ADD FOREIGN KEY([UcakID])
REFERENCES [dbo].[Ucak] ([UcakID])
GO
ALTER TABLE [dbo].[Pilot]  WITH CHECK ADD FOREIGN KEY([MurettebatID])
REFERENCES [dbo].[Murettebat] ([MurettebatID])
GO
ALTER TABLE [dbo].[Pilot]  WITH CHECK ADD FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personel] ([PersonelID])
GO
ALTER TABLE [dbo].[Pilot]  WITH CHECK ADD FOREIGN KEY([UcakID])
REFERENCES [dbo].[Ucak] ([UcakID])
GO
ALTER TABLE [dbo].[Sefer]  WITH CHECK ADD FOREIGN KEY([UcakID])
REFERENCES [dbo].[Ucak] ([UcakID])
GO
ALTER TABLE [dbo].[Servis]  WITH CHECK ADD FOREIGN KEY([UcakID])
REFERENCES [dbo].[Ucak] ([UcakID])
GO
ALTER TABLE [dbo].[ServisPersoneli]  WITH CHECK ADD FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personel] ([PersonelID])
GO
ALTER TABLE [dbo].[Tamir]  WITH CHECK ADD FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personel] ([PersonelID])
GO
ALTER TABLE [dbo].[Tamir]  WITH CHECK ADD FOREIGN KEY([ServisID])
REFERENCES [dbo].[Servis] ([ServisID])
GO
ALTER TABLE [dbo].[Tamir]  WITH CHECK ADD FOREIGN KEY([UcakID])
REFERENCES [dbo].[Ucak] ([UcakID])
GO
ALTER TABLE [dbo].[TamirPersoneli]  WITH CHECK ADD FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personel] ([PersonelID])
GO
ALTER TABLE [dbo].[TamirPersoneli]  WITH CHECK ADD FOREIGN KEY([ServisPersoneliID])
REFERENCES [dbo].[ServisPersoneli] ([ServisPersoneliID])
GO
USE [master]
GO
ALTER DATABASE [Bil372] SET  READ_WRITE 
GO
