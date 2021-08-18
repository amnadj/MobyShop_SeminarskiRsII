USE [master]
GO
/****** Object:  Database [RS2_Seminarski_IB150114]    Script Date: 8/18/2021 5:46:32 PM ******/
CREATE DATABASE [RS2_Seminarski_IB150114]
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RS2_Seminarski_IB150114].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET ARITHABORT OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET RECOVERY FULL 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET  MULTI_USER 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'RS2_Seminarski_IB150114', N'ON'
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET QUERY_STORE = OFF
GO
USE [RS2_Seminarski_IB150114]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Artikli]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artikli](
	[ArtikalId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[Sifra] [nvarchar](max) NOT NULL,
	[Cijena] [decimal](18, 2) NOT NULL,
	[Slika] [varbinary](max) NULL,
	[SlikaThumb] [varbinary](max) NULL,
	[Status] [bit] NOT NULL,
	[KarakteristikeId] [int] NOT NULL,
	[ProizvodjacId] [int] NOT NULL,
	[ModelId] [int] NOT NULL,
 CONSTRAINT [PK_Artikli] PRIMARY KEY CLUSTERED 
(
	[ArtikalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dobavljaci]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dobavljaci](
	[DobavljacId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](max) NULL,
	[KontaktOsoba] [nvarchar](max) NULL,
	[Adresa] [nvarchar](max) NULL,
	[Telefon] [nvarchar](max) NULL,
	[Fax] [nvarchar](max) NULL,
	[Web] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[ZiroRacuni] [nvarchar](max) NULL,
	[Napomena] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Dobavljaci] PRIMARY KEY CLUSTERED 
(
	[DobavljacId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Karakteristike]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Karakteristike](
	[KarakteristikeId] [int] IDENTITY(1,1) NOT NULL,
	[Novo] [bit] NOT NULL,
	[OperativniSistem] [nvarchar](50) NOT NULL,
	[Kamera] [decimal](18, 2) NOT NULL,
	[Ram] [decimal](18, 2) NOT NULL,
	[Memorija] [decimal](18, 2) NOT NULL,
	[Procesor] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Karakteristike] PRIMARY KEY CLUSTERED 
(
	[KarakteristikeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Klijenti]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klijenti](
	[KlijentId] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[DatumRegistracije] [datetime2](7) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Telefon] [nvarchar](max) NULL,
	[KorisnickoIme] [nvarchar](50) NOT NULL,
	[LozinkaHash] [nvarchar](max) NOT NULL,
	[LozinkaSalt] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Klijenti] PRIMARY KEY CLUSTERED 
(
	[KlijentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnici]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnici](
	[KorisnikId] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Telefon] [nvarchar](max) NULL,
	[KorisnickoIme] [nvarchar](50) NOT NULL,
	[LozinkaHash] [nvarchar](max) NOT NULL,
	[LozinkaSalt] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Korisnici] PRIMARY KEY CLUSTERED 
(
	[KorisnikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KorisniciUloge]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KorisniciUloge](
	[KorisnikUlogaId] [int] IDENTITY(1,1) NOT NULL,
	[KorisnikId] [int] NOT NULL,
	[UlogaId] [int] NOT NULL,
	[DatumIzmjene] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_KorisniciUloge] PRIMARY KEY CLUSTERED 
(
	[KorisnikUlogaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modeli]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modeli](
	[ModelId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Modeli] PRIMARY KEY CLUSTERED 
(
	[ModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nabavka]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nabavka](
	[NabavkaId] [int] IDENTITY(1,1) NOT NULL,
	[BrojNabavke] [nvarchar](50) NOT NULL,
	[Datum] [datetime2](7) NOT NULL,
	[IznosRacuna] [decimal](18, 2) NOT NULL,
	[Pdv] [decimal](18, 2) NOT NULL,
	[Napomena] [nvarchar](max) NULL,
	[SkladisteId] [int] NOT NULL,
	[KorisnikId] [int] NOT NULL,
	[DobavljacId] [int] NOT NULL,
 CONSTRAINT [PK_Nabavka] PRIMARY KEY CLUSTERED 
(
	[NabavkaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NabavkaStavke]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NabavkaStavke](
	[NabavkaStavkeId] [int] IDENTITY(1,1) NOT NULL,
	[NabavkaId] [int] NOT NULL,
	[ArtikalId] [int] NOT NULL,
	[Kolicina] [int] NOT NULL,
	[Cijena] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_NabavkaStavke] PRIMARY KEY CLUSTERED 
(
	[NabavkaStavkeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Narudzba]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Narudzba](
	[NarudzbaId] [int] IDENTITY(1,1) NOT NULL,
	[BrojNarudzbe] [nvarchar](50) NOT NULL,
	[KlijentId] [int] NOT NULL,
	[Datum] [datetime2](7) NOT NULL,
	[Status] [bit] NOT NULL,
	[Otkazano] [bit] NOT NULL,
	[IznosBezPdv] [decimal](18, 2) NOT NULL,
	[IznosSaPdv] [decimal](18, 2) NOT NULL,
	[SkladisteId] [int] NOT NULL,
	[KorisnikId] [int] NOT NULL,
 CONSTRAINT [PK_Narudzba] PRIMARY KEY CLUSTERED 
(
	[NarudzbaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NarudzbaStavke]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NarudzbaStavke](
	[NarudzbaStavkaId] [int] IDENTITY(1,1) NOT NULL,
	[NarudzbaId] [int] NOT NULL,
	[Kolicina] [int] NOT NULL,
	[Cijena] [decimal](18, 2) NOT NULL,
	[Popust] [decimal](18, 2) NULL,
	[ArtikalId] [int] NOT NULL,
 CONSTRAINT [PK_NarudzbaStavke] PRIMARY KEY CLUSTERED 
(
	[NarudzbaStavkaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obavijesti]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obavijesti](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naslov] [nvarchar](max) NULL,
	[Text] [nvarchar](max) NULL,
	[Slika] [varbinary](max) NULL,
	[KorisnikId] [int] NOT NULL,
 CONSTRAINT [PK_Obavijesti] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ocjene]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ocjene](
	[OcjenaId] [int] IDENTITY(1,1) NOT NULL,
	[ArtikalId] [int] NOT NULL,
	[KlijentId] [int] NOT NULL,
	[Datum] [datetime2](7) NOT NULL,
	[Ocjena] [int] NOT NULL,
 CONSTRAINT [PK_Ocjene] PRIMARY KEY CLUSTERED 
(
	[OcjenaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PoslanaNarudzba]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PoslanaNarudzba](
	[PoslanaNarudzbaId] [int] IDENTITY(1,1) NOT NULL,
	[KlijentId] [int] NOT NULL,
	[KorisnikId] [int] NOT NULL,
	[Datum] [datetime2](7) NOT NULL,
	[Poslano] [bit] NOT NULL,
	[NarudzbaId] [int] NOT NULL,
 CONSTRAINT [PK_PoslanaNarudzba] PRIMARY KEY CLUSTERED 
(
	[PoslanaNarudzbaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proizvodjaci]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvodjaci](
	[ProizvodjacId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Proizvodjaci] PRIMARY KEY CLUSTERED 
(
	[ProizvodjacId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skladista]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skladista](
	[SkladisteId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[Adresa] [nvarchar](50) NOT NULL,
	[Opis] [nvarchar](50) NULL,
 CONSTRAINT [PK_Skladista] PRIMARY KEY CLUSTERED 
(
	[SkladisteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uloge]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uloge](
	[UlogaId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](25) NOT NULL,
	[Opis] [nvarchar](50) NULL,
 CONSTRAINT [PK_Uloge] PRIMARY KEY CLUSTERED 
(
	[UlogaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zahtjevi]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zahtjevi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DatumZahtjeva] [datetime2](7) NOT NULL,
	[Naslov] [nvarchar](max) NULL,
	[Opis] [nvarchar](max) NULL,
	[KlijentId] [int] NOT NULL,
 CONSTRAINT [PK_Zahtjevi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZahtjeviStavke]    Script Date: 8/18/2021 5:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZahtjeviStavke](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Odgovor] [nvarchar](max) NULL,
	[ZahtjevId] [int] NOT NULL,
	[KorisnikId] [int] NOT NULL,
 CONSTRAINT [PK_ZahtjeviStavke] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210628144707_init', N'2.1.2-rtm-30932')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210711102401_migracija', N'2.1.2-rtm-30932')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210711105557_baza2', N'2.1.2-rtm-30932')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210711123504_podaci', N'2.1.2-rtm-30932')
GO
SET IDENTITY_INSERT [dbo].[Artikli] ON 

INSERT [dbo].[Artikli] ([ArtikalId], [Naziv], [Sifra], [Cijena], [Slika], [SlikaThumb], [Status], [KarakteristikeId], [ProizvodjacId], [ModelId]) VALUES (1, N'Samsung Galaxy S20+', N'12345', CAST(1200.00 AS Decimal(18, 2)), NULL, NULL, 1, 1, 1, 1)
INSERT [dbo].[Artikli] ([ArtikalId], [Naziv], [Sifra], [Cijena], [Slika], [SlikaThumb], [Status], [KarakteristikeId], [ProizvodjacId], [ModelId]) VALUES (2, N'Iphone 12', N'12346', CAST(1800.00 AS Decimal(18, 2)), NULL, NULL, 1, 3, 3, 3)
INSERT [dbo].[Artikli] ([ArtikalId], [Naziv], [Sifra], [Cijena], [Slika], [SlikaThumb], [Status], [KarakteristikeId], [ProizvodjacId], [ModelId]) VALUES (3, N'Samsung Galaxy S10+', N'2456', CAST(900.00 AS Decimal(18, 2)), NULL, NULL, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Artikli] OFF
GO
SET IDENTITY_INSERT [dbo].[Dobavljaci] ON 

INSERT [dbo].[Dobavljaci] ([DobavljacId], [Naziv], [KontaktOsoba], [Adresa], [Telefon], [Fax], [Web], [Email], [ZiroRacuni], [Napomena], [Status]) VALUES (1, N'DobavljacMoby d.o.o', N'Selma', N'Muje Pasica 7', N'062612612', N'030234342', N'www.dobavljac1.com', N'dobavljac1@mail.com', N'123456789', N'Napomena 1', 1)
INSERT [dbo].[Dobavljaci] ([DobavljacId], [Naziv], [KontaktOsoba], [Adresa], [Telefon], [Fax], [Web], [Email], [ZiroRacuni], [Napomena], [Status]) VALUES (2, N'Test', N'Test', N'Adresa Test', N'062123123', N'030235352', N'www.dobavljac2.com', N'dobavljac2@mail.com', N'123456546', N'Napomena 2', 1)
INSERT [dbo].[Dobavljaci] ([DobavljacId], [Naziv], [KontaktOsoba], [Adresa], [Telefon], [Fax], [Web], [Email], [ZiroRacuni], [Napomena], [Status]) VALUES (3, N'Dobavljac 3', N'Elma', N'Adresa 3', N'062612632', N'030234344', N'www.dobavljac3.com', N'dobavljac3@mail.com', N'123456779', N'Napomena 3', 0)
SET IDENTITY_INSERT [dbo].[Dobavljaci] OFF
GO
SET IDENTITY_INSERT [dbo].[Karakteristike] ON 

INSERT [dbo].[Karakteristike] ([KarakteristikeId], [Novo], [OperativniSistem], [Kamera], [Ram], [Memorija], [Procesor]) VALUES (1, 1, N'Android', CAST(48.00 AS Decimal(18, 2)), CAST(8.00 AS Decimal(18, 2)), CAST(256.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[Karakteristike] ([KarakteristikeId], [Novo], [OperativniSistem], [Kamera], [Ram], [Memorija], [Procesor]) VALUES (2, 1, N'Android', CAST(32.00 AS Decimal(18, 2)), CAST(6.00 AS Decimal(18, 2)), CAST(128.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[Karakteristike] ([KarakteristikeId], [Novo], [OperativniSistem], [Kamera], [Ram], [Memorija], [Procesor]) VALUES (3, 0, N'IOS', CAST(12.00 AS Decimal(18, 2)), CAST(4.00 AS Decimal(18, 2)), CAST(128.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[Karakteristike] ([KarakteristikeId], [Novo], [OperativniSistem], [Kamera], [Ram], [Memorija], [Procesor]) VALUES (4, 1, N'Android', CAST(20.00 AS Decimal(18, 2)), CAST(4.00 AS Decimal(18, 2)), CAST(128.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Karakteristike] OFF
GO
SET IDENTITY_INSERT [dbo].[Klijenti] ON 

INSERT [dbo].[Klijenti] ([KlijentId], [Ime], [Prezime], [DatumRegistracije], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (1, N'Admin', N'Admin', CAST(N'2021-07-11T14:35:02.7840000' AS DateTime2), N'admin@mail.com', N'063232213', N'admin', N'msRqfae6n9ecynIZo++mdsRXI9A=', N'qC8CByThGQN5qApaADFb1Q==')
INSERT [dbo].[Klijenti] ([KlijentId], [Ime], [Prezime], [DatumRegistracije], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (2, N'User', N'User', CAST(N'2021-07-11T14:35:02.7970000' AS DateTime2), N'user@mail.com', N'063132233', N'user', N'msRqfae6n9ecynIZo++mdsRXI9A=', N'IEn1ZDxWcQy4qoDhzxDN0A==')
INSERT [dbo].[Klijenti] ([KlijentId], [Ime], [Prezime], [DatumRegistracije], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (3, N'Amna', N'Dj', CAST(N'2021-07-11T14:35:02.7970000' AS DateTime2), N'amna@mail.com', N'063232245', N'amna123', N'OZ0LPK3MjSQi6XkQy6lyH7sKeEo=', N'XqhynIqes3RnrOiVRT3iLA==')
SET IDENTITY_INSERT [dbo].[Klijenti] OFF
GO
SET IDENTITY_INSERT [dbo].[Korisnici] ON 

INSERT [dbo].[Korisnici] ([KorisnikId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (1, N'Admin', N'Admin', N'admin@mail.com', N'063232983', N'admin', N'msRqfae6n9ecynIZo++mdsRXI9A=', N'qC8CByThGQN5qApaADFb1Q==')
INSERT [dbo].[Korisnici] ([KorisnikId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (2, N'Prodavac', N'Prodavac', N'prodavac@mail.com', N'063235785', N'prodavac', N'poYyNLHCprwOCfDqkiH2ItkdfQQ=', N'IEn1ZDxWcQy4qoDhzxDN0A==')
INSERT [dbo].[Korisnici] ([KorisnikId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (3, N'User', N'User', N'user@mail.com', N'063132233', N'user', N'8+rE1Ksrmut7v5h7jMKdOaOqp7M=', N'XqhynIqes3RnrOiVRT3iLA==')
INSERT [dbo].[Korisnici] ([KorisnikId], [Ime], [Prezime], [Email], [Telefon], [KorisnickoIme], [LozinkaHash], [LozinkaSalt]) VALUES (4, N'Amna', N'Dj', N'amna@mail.com', N'063132233', N'amna136', N'ltlk/W/nvtI0kYhLDJ9qq7D6vwE=', N'tW3ic7sBR8UsRlydwRCKXg==')
SET IDENTITY_INSERT [dbo].[Korisnici] OFF
GO
SET IDENTITY_INSERT [dbo].[KorisniciUloge] ON 

INSERT [dbo].[KorisniciUloge] ([KorisnikUlogaId], [KorisnikId], [UlogaId], [DatumIzmjene]) VALUES (1, 1, 1, CAST(N'2021-07-11T14:35:02.7990000' AS DateTime2))
INSERT [dbo].[KorisniciUloge] ([KorisnikUlogaId], [KorisnikId], [UlogaId], [DatumIzmjene]) VALUES (2, 2, 2, CAST(N'2021-07-11T14:35:02.7990000' AS DateTime2))
INSERT [dbo].[KorisniciUloge] ([KorisnikUlogaId], [KorisnikId], [UlogaId], [DatumIzmjene]) VALUES (3, 3, 2, CAST(N'2021-07-11T14:35:02.7990000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[KorisniciUloge] OFF
GO
SET IDENTITY_INSERT [dbo].[Modeli] ON 

INSERT [dbo].[Modeli] ([ModelId], [Naziv]) VALUES (1, N'Samsung')
INSERT [dbo].[Modeli] ([ModelId], [Naziv]) VALUES (2, N'Huawei')
INSERT [dbo].[Modeli] ([ModelId], [Naziv]) VALUES (3, N'Iphone')
INSERT [dbo].[Modeli] ([ModelId], [Naziv]) VALUES (4, N'Alcatel')
SET IDENTITY_INSERT [dbo].[Modeli] OFF
GO
SET IDENTITY_INSERT [dbo].[Nabavka] ON 

INSERT [dbo].[Nabavka] ([NabavkaId], [BrojNabavke], [Datum], [IznosRacuna], [Pdv], [Napomena], [SkladisteId], [KorisnikId], [DobavljacId]) VALUES (1, N'1', CAST(N'2021-07-11T14:35:02.7990000' AS DateTime2), CAST(1500.00 AS Decimal(18, 2)), CAST(17.00 AS Decimal(18, 2)), N'Prva nabavka', 1, 1, 1)
INSERT [dbo].[Nabavka] ([NabavkaId], [BrojNabavke], [Datum], [IznosRacuna], [Pdv], [Napomena], [SkladisteId], [KorisnikId], [DobavljacId]) VALUES (2, N'2', CAST(N'2021-07-11T14:35:02.8000000' AS DateTime2), CAST(1000.00 AS Decimal(18, 2)), CAST(17.00 AS Decimal(18, 2)), N'Druga nabavka', 1, 1, 2)
INSERT [dbo].[Nabavka] ([NabavkaId], [BrojNabavke], [Datum], [IznosRacuna], [Pdv], [Napomena], [SkladisteId], [KorisnikId], [DobavljacId]) VALUES (3, N'3', CAST(N'2021-07-11T14:35:02.8000000' AS DateTime2), CAST(1404.00 AS Decimal(18, 2)), CAST(17.00 AS Decimal(18, 2)), N'Treca nabavka', 1, 2, 2)
SET IDENTITY_INSERT [dbo].[Nabavka] OFF
GO
SET IDENTITY_INSERT [dbo].[NabavkaStavke] ON 

INSERT [dbo].[NabavkaStavke] ([NabavkaStavkeId], [NabavkaId], [ArtikalId], [Kolicina], [Cijena]) VALUES (1, 1, 1, 1, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[NabavkaStavke] ([NabavkaStavkeId], [NabavkaId], [ArtikalId], [Kolicina], [Cijena]) VALUES (2, 2, 2, 1, CAST(1200.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[NabavkaStavke] OFF
GO
SET IDENTITY_INSERT [dbo].[Narudzba] ON 

INSERT [dbo].[Narudzba] ([NarudzbaId], [BrojNarudzbe], [KlijentId], [Datum], [Status], [Otkazano], [IznosBezPdv], [IznosSaPdv], [SkladisteId], [KorisnikId]) VALUES (1, N'1', 1, CAST(N'2021-07-11T14:35:02.8000000' AS DateTime2), 1, 0, CAST(1000.00 AS Decimal(18, 2)), CAST(1170.00 AS Decimal(18, 2)), 1, 1)
INSERT [dbo].[Narudzba] ([NarudzbaId], [BrojNarudzbe], [KlijentId], [Datum], [Status], [Otkazano], [IznosBezPdv], [IznosSaPdv], [SkladisteId], [KorisnikId]) VALUES (2, N'2', 1, CAST(N'2021-07-11T14:35:02.8010000' AS DateTime2), 1, 0, CAST(900.00 AS Decimal(18, 2)), CAST(1053.00 AS Decimal(18, 2)), 2, 3)
SET IDENTITY_INSERT [dbo].[Narudzba] OFF
GO
SET IDENTITY_INSERT [dbo].[NarudzbaStavke] ON 

INSERT [dbo].[NarudzbaStavke] ([NarudzbaStavkaId], [NarudzbaId], [Kolicina], [Cijena], [Popust], [ArtikalId]) VALUES (1, 1, 1, CAST(1200.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[NarudzbaStavke] ([NarudzbaStavkaId], [NarudzbaId], [Kolicina], [Cijena], [Popust], [ArtikalId]) VALUES (2, 2, 1, CAST(900.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[NarudzbaStavke] ([NarudzbaStavkaId], [NarudzbaId], [Kolicina], [Cijena], [Popust], [ArtikalId]) VALUES (3, 2, 1, CAST(1800.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 3)
SET IDENTITY_INSERT [dbo].[NarudzbaStavke] OFF
GO
SET IDENTITY_INSERT [dbo].[Ocjene] ON 

INSERT [dbo].[Ocjene] ([OcjenaId], [ArtikalId], [KlijentId], [Datum], [Ocjena]) VALUES (1, 2, 1, CAST(N'2021-07-11T14:35:02.8010000' AS DateTime2), 5)
INSERT [dbo].[Ocjene] ([OcjenaId], [ArtikalId], [KlijentId], [Datum], [Ocjena]) VALUES (2, 1, 1, CAST(N'2021-07-11T14:35:02.8010000' AS DateTime2), 5)
SET IDENTITY_INSERT [dbo].[Ocjene] OFF
GO
SET IDENTITY_INSERT [dbo].[Proizvodjaci] ON 

INSERT [dbo].[Proizvodjaci] ([ProizvodjacId], [Naziv]) VALUES (1, N'Samsung')
INSERT [dbo].[Proizvodjaci] ([ProizvodjacId], [Naziv]) VALUES (2, N'Huawei')
INSERT [dbo].[Proizvodjaci] ([ProizvodjacId], [Naziv]) VALUES (3, N'Apple')
INSERT [dbo].[Proizvodjaci] ([ProizvodjacId], [Naziv]) VALUES (4, N'Alcatel')
SET IDENTITY_INSERT [dbo].[Proizvodjaci] OFF
GO
SET IDENTITY_INSERT [dbo].[Skladista] ON 

INSERT [dbo].[Skladista] ([SkladisteId], [Naziv], [Adresa], [Opis]) VALUES (1, N'Skladiste 1', N'Adresa 1', N'Glavno skladiste')
INSERT [dbo].[Skladista] ([SkladisteId], [Naziv], [Adresa], [Opis]) VALUES (2, N'Skladiste 2', N'Adresa 2', N'Sporedno skladiste')
INSERT [dbo].[Skladista] ([SkladisteId], [Naziv], [Adresa], [Opis]) VALUES (3, N'Skladiste 3', N'Adresa 3', N'skladiste')
SET IDENTITY_INSERT [dbo].[Skladista] OFF
GO
SET IDENTITY_INSERT [dbo].[Uloge] ON 

INSERT [dbo].[Uloge] ([UlogaId], [Naziv], [Opis]) VALUES (1, N'Admin', N'Upravljanje sistemom')
INSERT [dbo].[Uloge] ([UlogaId], [Naziv], [Opis]) VALUES (2, N'Prodavac', N'Rad na sistemu')
INSERT [dbo].[Uloge] ([UlogaId], [Naziv], [Opis]) VALUES (3, N'Skladistar', N'Upravljanje robom')
SET IDENTITY_INSERT [dbo].[Uloge] OFF
GO
/****** Object:  Index [IX_Artikli_KarakteristikeId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Artikli_KarakteristikeId] ON [dbo].[Artikli]
(
	[KarakteristikeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Artikli_ModelId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Artikli_ModelId] ON [dbo].[Artikli]
(
	[ModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Artikli_ProizvodjacId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Artikli_ProizvodjacId] ON [dbo].[Artikli]
(
	[ProizvodjacId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_KorisniciUloge_KorisnikId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_KorisniciUloge_KorisnikId] ON [dbo].[KorisniciUloge]
(
	[KorisnikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_KorisniciUloge_UlogaId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_KorisniciUloge_UlogaId] ON [dbo].[KorisniciUloge]
(
	[UlogaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Nabavka_DobavljacId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Nabavka_DobavljacId] ON [dbo].[Nabavka]
(
	[DobavljacId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Nabavka_KorisnikId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Nabavka_KorisnikId] ON [dbo].[Nabavka]
(
	[KorisnikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Nabavka_SkladisteId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Nabavka_SkladisteId] ON [dbo].[Nabavka]
(
	[SkladisteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NabavkaStavke_ArtikalId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_NabavkaStavke_ArtikalId] ON [dbo].[NabavkaStavke]
(
	[ArtikalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NabavkaStavke_NabavkaId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_NabavkaStavke_NabavkaId] ON [dbo].[NabavkaStavke]
(
	[NabavkaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Narudzba_KlijentId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Narudzba_KlijentId] ON [dbo].[Narudzba]
(
	[KlijentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Narudzba_KorisnikId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Narudzba_KorisnikId] ON [dbo].[Narudzba]
(
	[KorisnikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Narudzba_SkladisteId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Narudzba_SkladisteId] ON [dbo].[Narudzba]
(
	[SkladisteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NarudzbaStavke_ArtikalId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_NarudzbaStavke_ArtikalId] ON [dbo].[NarudzbaStavke]
(
	[ArtikalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NarudzbaStavke_NarudzbaId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_NarudzbaStavke_NarudzbaId] ON [dbo].[NarudzbaStavke]
(
	[NarudzbaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Obavijesti_KorisnikId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Obavijesti_KorisnikId] ON [dbo].[Obavijesti]
(
	[KorisnikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Ocjene_ArtikalId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Ocjene_ArtikalId] ON [dbo].[Ocjene]
(
	[ArtikalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Ocjene_KlijentId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Ocjene_KlijentId] ON [dbo].[Ocjene]
(
	[KlijentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PoslanaNarudzba_KlijentId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_PoslanaNarudzba_KlijentId] ON [dbo].[PoslanaNarudzba]
(
	[KlijentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PoslanaNarudzba_KorisnikId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_PoslanaNarudzba_KorisnikId] ON [dbo].[PoslanaNarudzba]
(
	[KorisnikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PoslanaNarudzba_NarudzbaId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_PoslanaNarudzba_NarudzbaId] ON [dbo].[PoslanaNarudzba]
(
	[NarudzbaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Zahtjevi_KlijentId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_Zahtjevi_KlijentId] ON [dbo].[Zahtjevi]
(
	[KlijentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ZahtjeviStavke_KorisnikId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_ZahtjeviStavke_KorisnikId] ON [dbo].[ZahtjeviStavke]
(
	[KorisnikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ZahtjeviStavke_ZahtjevId]    Script Date: 8/18/2021 5:46:34 PM ******/
CREATE NONCLUSTERED INDEX [IX_ZahtjeviStavke_ZahtjevId] ON [dbo].[ZahtjeviStavke]
(
	[ZahtjevId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Artikli]  WITH CHECK ADD  CONSTRAINT [FK__KarakteristikeArtikli__KarakteristikaId__267ABA7A] FOREIGN KEY([KarakteristikeId])
REFERENCES [dbo].[Karakteristike] ([KarakteristikeId])
GO
ALTER TABLE [dbo].[Artikli] CHECK CONSTRAINT [FK__KarakteristikeArtikli__KarakteristikaId__267ABA7A]
GO
ALTER TABLE [dbo].[Artikli]  WITH CHECK ADD  CONSTRAINT [FK__ModeliArtikli__ModelId__267ABA7A] FOREIGN KEY([ModelId])
REFERENCES [dbo].[Modeli] ([ModelId])
GO
ALTER TABLE [dbo].[Artikli] CHECK CONSTRAINT [FK__ModeliArtikli__ModelId__267ABA7A]
GO
ALTER TABLE [dbo].[Artikli]  WITH CHECK ADD  CONSTRAINT [FK__ProizvodjaciArtikli__ProizvodjacId__267ABA7A] FOREIGN KEY([ProizvodjacId])
REFERENCES [dbo].[Proizvodjaci] ([ProizvodjacId])
GO
ALTER TABLE [dbo].[Artikli] CHECK CONSTRAINT [FK__ProizvodjaciArtikli__ProizvodjacId__267ABA7A]
GO
ALTER TABLE [dbo].[KorisniciUloge]  WITH CHECK ADD  CONSTRAINT [FK__KorisnikUloga_KorisnikId__267ABA7A] FOREIGN KEY([KorisnikId])
REFERENCES [dbo].[Korisnici] ([KorisnikId])
GO
ALTER TABLE [dbo].[KorisniciUloge] CHECK CONSTRAINT [FK__KorisnikUloga_KorisnikId__267ABA7A]
GO
ALTER TABLE [dbo].[KorisniciUloge]  WITH CHECK ADD  CONSTRAINT [FK__KorisnikUloga_UlogaId__267ABA7A] FOREIGN KEY([UlogaId])
REFERENCES [dbo].[Uloge] ([UlogaId])
GO
ALTER TABLE [dbo].[KorisniciUloge] CHECK CONSTRAINT [FK__KorisnikUloga_UlogaId__267ABA7A]
GO
ALTER TABLE [dbo].[Nabavka]  WITH CHECK ADD  CONSTRAINT [FK__NabavkaDobavljaci_DobavljacId__267ABA7A] FOREIGN KEY([DobavljacId])
REFERENCES [dbo].[Dobavljaci] ([DobavljacId])
GO
ALTER TABLE [dbo].[Nabavka] CHECK CONSTRAINT [FK__NabavkaDobavljaci_DobavljacId__267ABA7A]
GO
ALTER TABLE [dbo].[Nabavka]  WITH CHECK ADD  CONSTRAINT [FK__NabavkaKorisnik_KorisnikId__267ABA7A] FOREIGN KEY([KorisnikId])
REFERENCES [dbo].[Korisnici] ([KorisnikId])
GO
ALTER TABLE [dbo].[Nabavka] CHECK CONSTRAINT [FK__NabavkaKorisnik_KorisnikId__267ABA7A]
GO
ALTER TABLE [dbo].[Nabavka]  WITH CHECK ADD  CONSTRAINT [FK_Nabavka_Skladista_SkladisteId] FOREIGN KEY([SkladisteId])
REFERENCES [dbo].[Skladista] ([SkladisteId])
GO
ALTER TABLE [dbo].[Nabavka] CHECK CONSTRAINT [FK_Nabavka_Skladista_SkladisteId]
GO
ALTER TABLE [dbo].[NabavkaStavke]  WITH CHECK ADD  CONSTRAINT [FK__NabavkaStavke__NabavkaId__267ABA7A] FOREIGN KEY([NabavkaId])
REFERENCES [dbo].[Nabavka] ([NabavkaId])
GO
ALTER TABLE [dbo].[NabavkaStavke] CHECK CONSTRAINT [FK__NabavkaStavke__NabavkaId__267ABA7A]
GO
ALTER TABLE [dbo].[NabavkaStavke]  WITH CHECK ADD  CONSTRAINT [FK__NabavkaStavkeArtikal__ArtikalId__267ABA7A] FOREIGN KEY([ArtikalId])
REFERENCES [dbo].[Artikli] ([ArtikalId])
GO
ALTER TABLE [dbo].[NabavkaStavke] CHECK CONSTRAINT [FK__NabavkaStavkeArtikal__ArtikalId__267ABA7A]
GO
ALTER TABLE [dbo].[Narudzba]  WITH CHECK ADD  CONSTRAINT [FK__KlijentiNarudzbe_KlijentId__267ABA7A] FOREIGN KEY([KlijentId])
REFERENCES [dbo].[Klijenti] ([KlijentId])
GO
ALTER TABLE [dbo].[Narudzba] CHECK CONSTRAINT [FK__KlijentiNarudzbe_KlijentId__267ABA7A]
GO
ALTER TABLE [dbo].[Narudzba]  WITH CHECK ADD  CONSTRAINT [FK__KorisnikNarudzbe_KorisnikId__267ABA7A] FOREIGN KEY([KorisnikId])
REFERENCES [dbo].[Korisnici] ([KorisnikId])
GO
ALTER TABLE [dbo].[Narudzba] CHECK CONSTRAINT [FK__KorisnikNarudzbe_KorisnikId__267ABA7A]
GO
ALTER TABLE [dbo].[Narudzba]  WITH CHECK ADD  CONSTRAINT [FK_Narudzba_Skladista_SkladisteId] FOREIGN KEY([SkladisteId])
REFERENCES [dbo].[Skladista] ([SkladisteId])
GO
ALTER TABLE [dbo].[Narudzba] CHECK CONSTRAINT [FK_Narudzba_Skladista_SkladisteId]
GO
ALTER TABLE [dbo].[NarudzbaStavke]  WITH CHECK ADD  CONSTRAINT [FK__NarudzbaStavke__NarudzbaId__267ABA7A] FOREIGN KEY([NarudzbaId])
REFERENCES [dbo].[Narudzba] ([NarudzbaId])
GO
ALTER TABLE [dbo].[NarudzbaStavke] CHECK CONSTRAINT [FK__NarudzbaStavke__NarudzbaId__267ABA7A]
GO
ALTER TABLE [dbo].[NarudzbaStavke]  WITH CHECK ADD  CONSTRAINT [FK__NarudzbaStavkeArtikal__ArtikaId__267ABA7A] FOREIGN KEY([ArtikalId])
REFERENCES [dbo].[Artikli] ([ArtikalId])
GO
ALTER TABLE [dbo].[NarudzbaStavke] CHECK CONSTRAINT [FK__NarudzbaStavkeArtikal__ArtikaId__267ABA7A]
GO
ALTER TABLE [dbo].[Obavijesti]  WITH CHECK ADD  CONSTRAINT [FK_Obavijesti_Korisnici_KorisnikId] FOREIGN KEY([KorisnikId])
REFERENCES [dbo].[Korisnici] ([KorisnikId])
GO
ALTER TABLE [dbo].[Obavijesti] CHECK CONSTRAINT [FK_Obavijesti_Korisnici_KorisnikId]
GO
ALTER TABLE [dbo].[Ocjene]  WITH CHECK ADD  CONSTRAINT [FK__OcjeneArtikli_ArtikalId__267ABA7A] FOREIGN KEY([ArtikalId])
REFERENCES [dbo].[Artikli] ([ArtikalId])
GO
ALTER TABLE [dbo].[Ocjene] CHECK CONSTRAINT [FK__OcjeneArtikli_ArtikalId__267ABA7A]
GO
ALTER TABLE [dbo].[Ocjene]  WITH CHECK ADD  CONSTRAINT [FK__OcjeneKlijent_KlijentId__267ABA7A] FOREIGN KEY([KlijentId])
REFERENCES [dbo].[Klijenti] ([KlijentId])
GO
ALTER TABLE [dbo].[Ocjene] CHECK CONSTRAINT [FK__OcjeneKlijent_KlijentId__267ABA7A]
GO
ALTER TABLE [dbo].[PoslanaNarudzba]  WITH CHECK ADD  CONSTRAINT [FK__KlijentiPoslanaNarudzba_KlijentId__267ABA7A] FOREIGN KEY([KlijentId])
REFERENCES [dbo].[Klijenti] ([KlijentId])
GO
ALTER TABLE [dbo].[PoslanaNarudzba] CHECK CONSTRAINT [FK__KlijentiPoslanaNarudzba_KlijentId__267ABA7A]
GO
ALTER TABLE [dbo].[PoslanaNarudzba]  WITH CHECK ADD  CONSTRAINT [FK__KorisniciPoslanaNarudzba_KorisnikId__267ABA7A] FOREIGN KEY([KorisnikId])
REFERENCES [dbo].[Korisnici] ([KorisnikId])
GO
ALTER TABLE [dbo].[PoslanaNarudzba] CHECK CONSTRAINT [FK__KorisniciPoslanaNarudzba_KorisnikId__267ABA7A]
GO
ALTER TABLE [dbo].[PoslanaNarudzba]  WITH CHECK ADD  CONSTRAINT [FK__PoslanaNarudzba_NarudzbaId__267ABA7A] FOREIGN KEY([NarudzbaId])
REFERENCES [dbo].[Narudzba] ([NarudzbaId])
GO
ALTER TABLE [dbo].[PoslanaNarudzba] CHECK CONSTRAINT [FK__PoslanaNarudzba_NarudzbaId__267ABA7A]
GO
ALTER TABLE [dbo].[Zahtjevi]  WITH CHECK ADD  CONSTRAINT [FK_Zahtjevi_Klijenti_KlijentId] FOREIGN KEY([KlijentId])
REFERENCES [dbo].[Klijenti] ([KlijentId])
GO
ALTER TABLE [dbo].[Zahtjevi] CHECK CONSTRAINT [FK_Zahtjevi_Klijenti_KlijentId]
GO
ALTER TABLE [dbo].[ZahtjeviStavke]  WITH CHECK ADD  CONSTRAINT [FK_ZahtjeviStavke_Korisnici_KorisnikId] FOREIGN KEY([KorisnikId])
REFERENCES [dbo].[Korisnici] ([KorisnikId])
GO
ALTER TABLE [dbo].[ZahtjeviStavke] CHECK CONSTRAINT [FK_ZahtjeviStavke_Korisnici_KorisnikId]
GO
ALTER TABLE [dbo].[ZahtjeviStavke]  WITH CHECK ADD  CONSTRAINT [FK_ZahtjeviStavke_Zahtjevi_ZahtjevId] FOREIGN KEY([ZahtjevId])
REFERENCES [dbo].[Zahtjevi] ([Id])
GO
ALTER TABLE [dbo].[ZahtjeviStavke] CHECK CONSTRAINT [FK_ZahtjeviStavke_Zahtjevi_ZahtjevId]
GO
USE [master]
GO
ALTER DATABASE [RS2_Seminarski_IB150114] SET  READ_WRITE 
GO
