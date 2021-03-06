USE [master]
GO
/****** Object:  Database [KantarDb]    Script Date: 1.02.2021 00:20:21 ******/
CREATE DATABASE [KantarDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KantarDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\KantarDbmaden.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KantarDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\KantarDbmaden_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KantarDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KantarDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KantarDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KantarDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KantarDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KantarDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [KantarDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KantarDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KantarDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KantarDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KantarDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KantarDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KantarDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KantarDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KantarDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KantarDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KantarDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KantarDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KantarDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KantarDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KantarDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KantarDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KantarDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KantarDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KantarDb] SET  MULTI_USER 
GO
ALTER DATABASE [KantarDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KantarDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KantarDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KantarDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KantarDb] SET DELAYED_DURABILITY = DISABLED 
GO
USE [KantarDb]
GO
/****** Object:  Table [dbo].[Arac]    Script Date: 1.02.2021 00:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arac](
	[AracId] [int] IDENTITY(1,1) NOT NULL,
	[AracPlaka] [varchar](50) NULL,
	[AracDorsePlaka] [varchar](50) NULL,
	[AracDaraAgirlik] [float] NULL,
	[AracTip] [bit] NULL,
	[AracMarkaModel] [nvarchar](max) NULL,
	[Arsiv] [bit] NULL,
 CONSTRAINT [PK_Arac] PRIMARY KEY CLUSTERED 
(
	[AracId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CariUnvan_Firma]    Script Date: 1.02.2021 00:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CariUnvan_Firma](
	[CariUnvan_FirmaId] [int] IDENTITY(1,1) NOT NULL,
	[CariUnvan_FirmaAd] [varchar](255) NULL,
	[CariUnvan_FirmaTelefon] [nvarchar](50) NULL,
	[CariUnvan_FirmaAdres] [nvarchar](max) NULL,
	[CariUnvan_FirmaEmail] [nvarchar](max) NULL,
	[CariUnvan_FirmaVergiDairesi] [nvarchar](max) NULL,
	[CariUnvan_FirmaVergiNo] [varchar](100) NULL,
	[CariUnvan_FirmaMarsisNo] [nvarchar](max) NULL,
	[CariUnvan_SahisAdSoyad] [nvarchar](max) NULL,
	[CariUnvan_SahisAd] [nvarchar](max) NULL,
	[CariUnvan_SahisSoyad] [nvarchar](max) NULL,
	[CariUnvan_FirmaTC] [nvarchar](11) NULL,
	[CariUnvan_FirmaGonderici] [bit] NULL,
	[CariUnvan_FirmaTip] [int] NULL,
	[Il] [nvarchar](max) NULL,
	[Ilce] [nvarchar](max) NULL,
	[Arsiv] [bit] NULL,
 CONSTRAINT [PK_CariUnvan_Firma] PRIMARY KEY CLUSTERED 
(
	[CariUnvan_FirmaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Malzeme]    Script Date: 1.02.2021 00:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Malzeme](
	[MalzemeId] [int] IDENTITY(1,1) NOT NULL,
	[MalzemeAd] [nvarchar](max) NULL,
	[MalzemeAciklama] [nvarchar](max) NULL,
	[MalzemeBirimFiyat] [float] NULL,
	[Arsiv] [bit] NULL,
 CONSTRAINT [PK_Malzeme] PRIMARY KEY CLUSTERED 
(
	[MalzemeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SevkYeri]    Script Date: 1.02.2021 00:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SevkYeri](
	[SevkYeriId] [int] IDENTITY(1,1) NOT NULL,
	[SevkYeriAdres] [nvarchar](max) NULL,
	[SevkYeriAciklama] [nvarchar](max) NULL,
	[Arsiv] [bit] NULL,
 CONSTRAINT [PK_SevkYeri] PRIMARY KEY CLUSTERED 
(
	[SevkYeriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sofor]    Script Date: 1.02.2021 00:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sofor](
	[SoforId] [int] IDENTITY(1,1) NOT NULL,
	[SoforAd] [nvarchar](max) NULL,
	[SoforSoyad] [nvarchar](max) NULL,
	[SoforAdSoyad] [nvarchar](max) NULL,
	[SoforTC] [nvarchar](max) NULL,
	[SoforTelefon] [nvarchar](max) NULL,
	[Arsiv] [bit] NULL,
 CONSTRAINT [PK_Sofor] PRIMARY KEY CLUSTERED 
(
	[SoforId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tartim]    Script Date: 1.02.2021 00:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tartim](
	[TartimId] [int] IDENTITY(1,1) NOT NULL,
	[AracId] [int] NULL,
	[IslemSirasi] [int] NULL,
	[OlcumTarihi] [datetime] NULL,
	[CariUnvan_FirmaAliciId] [int] NULL,
	[MalzemeId] [int] NULL,
	[SevkYeriId] [int] NULL,
	[SoforId] [int] NULL,
	[BrutAgirlik] [float] NULL,
	[AracAgirlik] [float] NULL,
	[NetAgirlik] [float] NULL,
	[Ucret] [float] NULL,
	[CariUnvan_FirmaNakliyeciId] [int] NULL,
	[CariUnvan_FirmaGondericiId] [int] NULL,
	[YetkiliId] [int] NULL,
 CONSTRAINT [PK_Tartim] PRIMARY KEY CLUSTERED 
(
	[TartimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yetkili]    Script Date: 1.02.2021 00:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetkili](
	[YetkiliId] [int] IDENTITY(1,1) NOT NULL,
	[YetkiliKullaniciAd] [nvarchar](max) NULL,
	[YetkiliSifre] [nvarchar](max) NULL,
	[Admin] [bit] NULL,
	[Arsiv] [bit] NULL,
 CONSTRAINT [PK_Yetkili] PRIMARY KEY CLUSTERED 
(
	[YetkiliId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tartim]  WITH CHECK ADD  CONSTRAINT [FK_Tartim_Arac] FOREIGN KEY([AracId])
REFERENCES [dbo].[Arac] ([AracId])
GO
ALTER TABLE [dbo].[Tartim] CHECK CONSTRAINT [FK_Tartim_Arac]
GO
ALTER TABLE [dbo].[Tartim]  WITH CHECK ADD  CONSTRAINT [FK_Tartim_CariUnvan_Firma] FOREIGN KEY([CariUnvan_FirmaAliciId])
REFERENCES [dbo].[CariUnvan_Firma] ([CariUnvan_FirmaId])
GO
ALTER TABLE [dbo].[Tartim] CHECK CONSTRAINT [FK_Tartim_CariUnvan_Firma]
GO
ALTER TABLE [dbo].[Tartim]  WITH CHECK ADD  CONSTRAINT [FK_Tartim_CariUnvan_Firma1] FOREIGN KEY([CariUnvan_FirmaNakliyeciId])
REFERENCES [dbo].[CariUnvan_Firma] ([CariUnvan_FirmaId])
GO
ALTER TABLE [dbo].[Tartim] CHECK CONSTRAINT [FK_Tartim_CariUnvan_Firma1]
GO
ALTER TABLE [dbo].[Tartim]  WITH CHECK ADD  CONSTRAINT [FK_Tartim_CariUnvan_Firma3] FOREIGN KEY([CariUnvan_FirmaGondericiId])
REFERENCES [dbo].[CariUnvan_Firma] ([CariUnvan_FirmaId])
GO
ALTER TABLE [dbo].[Tartim] CHECK CONSTRAINT [FK_Tartim_CariUnvan_Firma3]
GO
ALTER TABLE [dbo].[Tartim]  WITH CHECK ADD  CONSTRAINT [FK_Tartim_Malzeme] FOREIGN KEY([MalzemeId])
REFERENCES [dbo].[Malzeme] ([MalzemeId])
GO
ALTER TABLE [dbo].[Tartim] CHECK CONSTRAINT [FK_Tartim_Malzeme]
GO
ALTER TABLE [dbo].[Tartim]  WITH CHECK ADD  CONSTRAINT [FK_Tartim_SevkYeri] FOREIGN KEY([SevkYeriId])
REFERENCES [dbo].[SevkYeri] ([SevkYeriId])
GO
ALTER TABLE [dbo].[Tartim] CHECK CONSTRAINT [FK_Tartim_SevkYeri]
GO
ALTER TABLE [dbo].[Tartim]  WITH CHECK ADD  CONSTRAINT [FK_Tartim_Sofor] FOREIGN KEY([SoforId])
REFERENCES [dbo].[Sofor] ([SoforId])
GO
ALTER TABLE [dbo].[Tartim] CHECK CONSTRAINT [FK_Tartim_Sofor]
GO
ALTER TABLE [dbo].[Tartim]  WITH CHECK ADD  CONSTRAINT [FK_Tartim_Yetkili] FOREIGN KEY([YetkiliId])
REFERENCES [dbo].[Yetkili] ([YetkiliId])
GO
ALTER TABLE [dbo].[Tartim] CHECK CONSTRAINT [FK_Tartim_Yetkili]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'true= gönderici firma' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CariUnvan_Firma', @level2type=N'COLUMN',@level2name=N'CariUnvan_FirmaGonderici'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0=Şahıs 1=diğer' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CariUnvan_Firma', @level2type=N'COLUMN',@level2name=N'CariUnvan_FirmaTip'
GO
USE [master]
GO
ALTER DATABASE [KantarDb] SET  READ_WRITE 
GO
