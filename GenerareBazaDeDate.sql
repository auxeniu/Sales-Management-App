USE [master]
GO
ALTER TABLE [dbo].[Utilizatori] DROP CONSTRAINT [CK__Utilizatori__Rol__4EA8A765]
GO
ALTER TABLE [dbo].[Utilizatori] DROP CONSTRAINT [CK__Utilizatori__Rol__36D11DD4]
GO
ALTER TABLE [dbo].[Tranzactii] DROP CONSTRAINT [FK_Tranzactii_Clienti]
GO
ALTER TABLE [dbo].[DetaliiTranzactie] DROP CONSTRAINT [FK_DetaliiTranzactie_Tranzactii]
GO
ALTER TABLE [dbo].[DetaliiTranzactie] DROP CONSTRAINT [FK_DetaliiTranzactie_Produse]
GO
ALTER TABLE [dbo].[Utilizatori] DROP CONSTRAINT [DF__Utilizato__EsteA__3118447E]
GO
/****** Object:  Index [UQ__Utilizat__E85F509DD755B45B]    Script Date: 28-Jun-25 2:11:06 PM ******/
ALTER TABLE [dbo].[Utilizatori] DROP CONSTRAINT [UQ__Utilizat__E85F509DD755B45B]
GO
/****** Object:  Table [dbo].[Utilizatori]    Script Date: 28-Jun-25 2:11:06 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Utilizatori]') AND type in (N'U'))
DROP TABLE [dbo].[Utilizatori]
GO
/****** Object:  Table [dbo].[Tranzactii]    Script Date: 28-Jun-25 2:11:06 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tranzactii]') AND type in (N'U'))
DROP TABLE [dbo].[Tranzactii]
GO
/****** Object:  Table [dbo].[Produse]    Script Date: 28-Jun-25 2:11:06 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Produse]') AND type in (N'U'))
DROP TABLE [dbo].[Produse]
GO
/****** Object:  Table [dbo].[DetaliiTranzactie]    Script Date: 28-Jun-25 2:11:06 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DetaliiTranzactie]') AND type in (N'U'))
DROP TABLE [dbo].[DetaliiTranzactie]
GO
/****** Object:  Table [dbo].[Clienti]    Script Date: 28-Jun-25 2:11:06 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Clienti]') AND type in (N'U'))
DROP TABLE [dbo].[Clienti]
GO
/****** Object:  User [##MS_AgentSigningCertificate##]    Script Date: 28-Jun-25 2:11:06 PM ******/
DROP USER [##MS_AgentSigningCertificate##]
GO
/****** Object:  User [##MS_PolicyEventProcessingLogin##]    Script Date: 28-Jun-25 2:11:06 PM ******/
DROP USER [##MS_PolicyEventProcessingLogin##]
GO
/****** Object:  User [##MS_PolicyEventProcessingLogin##]    Script Date: 28-Jun-25 2:11:06 PM ******/
CREATE USER [##MS_PolicyEventProcessingLogin##] FOR LOGIN [##MS_PolicyEventProcessingLogin##] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [##MS_AgentSigningCertificate##]    Script Date: 28-Jun-25 2:11:06 PM ******/
CREATE USER [##MS_AgentSigningCertificate##] FOR LOGIN [##MS_AgentSigningCertificate##]
GO
/****** Object:  Table [dbo].[Clienti]    Script Date: 28-Jun-25 2:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clienti](
	[IdClient] [int] IDENTITY(1,1) NOT NULL,
	[Nume] [varchar](100) NOT NULL,
	[Prenume] [varchar](100) NULL,
	[Adresa] [varchar](255) NULL,
	[Telefon] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetaliiTranzactie]    Script Date: 28-Jun-25 2:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetaliiTranzactie](
	[IdDetaliiTranzactie] [int] IDENTITY(1,1) NOT NULL,
	[IdTranzactie] [int] NOT NULL,
	[IdProdus] [int] NOT NULL,
	[Cantitate] [int] NOT NULL,
	[PretUnitarLaVanzare] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDetaliiTranzactie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produse]    Script Date: 28-Jun-25 2:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produse](
	[IdProdus] [int] IDENTITY(1,1) NOT NULL,
	[Denumire] [varchar](150) NOT NULL,
	[Pret] [decimal](10, 2) NOT NULL,
	[Stoc] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProdus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tranzactii]    Script Date: 28-Jun-25 2:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tranzactii](
	[IdTranzactie] [int] IDENTITY(1,1) NOT NULL,
	[IdClient] [int] NULL,
	[DataTranzactie] [datetime] NOT NULL,
	[TotalGeneral] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTranzactie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilizatori]    Script Date: 28-Jun-25 2:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilizatori](
	[IdUtilizator] [int] IDENTITY(1,1) NOT NULL,
	[NumeUtilizator] [varchar](50) NOT NULL,
	[ParolaHash] [varchar](256) NOT NULL,
	[NumeComplet] [varchar](100) NULL,
	[Rol] [varchar](50) NOT NULL,
	[EsteActiv] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUtilizator] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clienti] ON 

INSERT [dbo].[Clienti] ([IdClient], [Nume], [Prenume], [Adresa], [Telefon], [Email]) VALUES (0, N'Florescu', N'Elena', N'Aleea Crinilor 3B', N'0765123789', N'elena.f@sample.net')
INSERT [dbo].[Clienti] ([IdClient], [Nume], [Prenume], [Adresa], [Telefon], [Email]) VALUES (1, N'Ionescu', N'Maria', N'Bd. Unirii Nr. 5, Cluj-Napoca', N'0745111222', N'maria.ionescu@email.com')
INSERT [dbo].[Clienti] ([IdClient], [Nume], [Prenume], [Adresa], [Telefon], [Email]) VALUES (2, N'George', N'Vasile', N'Aleea Castanilor Nr. 1, Iasi', N'0766222333', N'vasile.g@email.net')
INSERT [dbo].[Clienti] ([IdClient], [Nume], [Prenume], [Adresa], [Telefon], [Email]) VALUES (3002, N'Dumitrescu', N'George', N'Bd. Libertatii 101', N'0733444555', N'george.d@test.com')
INSERT [dbo].[Clienti] ([IdClient], [Nume], [Prenume], [Adresa], [Telefon], [Email]) VALUES (4002, N'Miclescu', N'Razvan', N'Bucuresti', N'0725383244', N'miclesaux@email.com')
INSERT [dbo].[Clienti] ([IdClient], [Nume], [Prenume], [Adresa], [Telefon], [Email]) VALUES (5001, N'Mircea', N'Ioana', N'Nicolae Grigorescu 23', N'0725324626', N'mirceaioana@email.com')
INSERT [dbo].[Clienti] ([IdClient], [Nume], [Prenume], [Adresa], [Telefon], [Email]) VALUES (5002, N'Popa', N'Ana-Maria', N'Str. Zorilor 7', N'0720111222', N'anamaria.popa@email.dev')
SET IDENTITY_INSERT [dbo].[Clienti] OFF
GO
SET IDENTITY_INSERT [dbo].[DetaliiTranzactie] ON 

INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (0, 0, 0, 1, CAST(4500.99 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (1, 0, 1, 2, CAST(75.50 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (2, 1, 2, 1, CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (3, 1, 3, 1, CAST(1200.00 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (4, 2, 0, 1, CAST(4500.99 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (1001, 1001, 0, 1, CAST(4500.99 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (1002, 1001, 1, 1, CAST(75.50 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (2001, 2001, 4, 2, CAST(450.75 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (3001, 3001, 3, 2, CAST(1200.00 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (3002, 3001, 2, 1, CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (3003, 3001, 1, 1, CAST(75.50 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (3004, 3001, 4, 1, CAST(450.75 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (4001, 4001, 4, 1, CAST(450.75 AS Decimal(10, 2)))
INSERT [dbo].[DetaliiTranzactie] ([IdDetaliiTranzactie], [IdTranzactie], [IdProdus], [Cantitate], [PretUnitarLaVanzare]) VALUES (4002, 4001, 2, 1, CAST(320.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[DetaliiTranzactie] OFF
GO
SET IDENTITY_INSERT [dbo].[Produse] ON 

INSERT [dbo].[Produse] ([IdProdus], [Denumire], [Pret], [Stoc]) VALUES (0, N'Laptop Performant X2000', CAST(4500.99 AS Decimal(10, 2)), 12)
INSERT [dbo].[Produse] ([IdProdus], [Denumire], [Pret], [Stoc]) VALUES (1, N'Mouse Optic Wireless M3', CAST(75.50 AS Decimal(10, 2)), 46)
INSERT [dbo].[Produse] ([IdProdus], [Denumire], [Pret], [Stoc]) VALUES (2, N'Tastatura Mecanica K7', CAST(320.00 AS Decimal(10, 2)), 27)
INSERT [dbo].[Produse] ([IdProdus], [Denumire], [Pret], [Stoc]) VALUES (3, N'Monitor LED 27 inch', CAST(1200.00 AS Decimal(10, 2)), 22)
INSERT [dbo].[Produse] ([IdProdus], [Denumire], [Pret], [Stoc]) VALUES (4, N'SSD Extern 1TB', CAST(450.75 AS Decimal(10, 2)), 36)
INSERT [dbo].[Produse] ([IdProdus], [Denumire], [Pret], [Stoc]) VALUES (1001, N'Camera Foto', CAST(390.99 AS Decimal(10, 2)), 29)
SET IDENTITY_INSERT [dbo].[Produse] OFF
GO
SET IDENTITY_INSERT [dbo].[Tranzactii] ON 

INSERT [dbo].[Tranzactii] ([IdTranzactie], [IdClient], [DataTranzactie], [TotalGeneral]) VALUES (0, 0, CAST(N'2025-05-17T14:39:05.607' AS DateTime), CAST(4651.99 AS Decimal(18, 2)))
INSERT [dbo].[Tranzactii] ([IdTranzactie], [IdClient], [DataTranzactie], [TotalGeneral]) VALUES (1, 1, CAST(N'2025-05-22T14:39:05.643' AS DateTime), CAST(1520.00 AS Decimal(18, 2)))
INSERT [dbo].[Tranzactii] ([IdTranzactie], [IdClient], [DataTranzactie], [TotalGeneral]) VALUES (2, 2, CAST(N'2025-05-27T15:26:55.507' AS DateTime), CAST(4500.99 AS Decimal(18, 2)))
INSERT [dbo].[Tranzactii] ([IdTranzactie], [IdClient], [DataTranzactie], [TotalGeneral]) VALUES (1001, NULL, CAST(N'2025-05-28T14:06:19.627' AS DateTime), CAST(4576.49 AS Decimal(18, 2)))
INSERT [dbo].[Tranzactii] ([IdTranzactie], [IdClient], [DataTranzactie], [TotalGeneral]) VALUES (2001, NULL, CAST(N'2025-05-28T18:47:50.890' AS DateTime), CAST(901.50 AS Decimal(18, 2)))
INSERT [dbo].[Tranzactii] ([IdTranzactie], [IdClient], [DataTranzactie], [TotalGeneral]) VALUES (3001, 1, CAST(N'2025-05-28T20:59:57.043' AS DateTime), CAST(3246.25 AS Decimal(18, 2)))
INSERT [dbo].[Tranzactii] ([IdTranzactie], [IdClient], [DataTranzactie], [TotalGeneral]) VALUES (4001, 2, CAST(N'2025-06-03T07:38:19.133' AS DateTime), CAST(770.75 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Tranzactii] OFF
GO
SET IDENTITY_INSERT [dbo].[Utilizatori] ON 

INSERT [dbo].[Utilizatori] ([IdUtilizator], [NumeUtilizator], [ParolaHash], [NumeComplet], [Rol], [EsteActiv]) VALUES (2001, N'admin', N'ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc0596cad4c6e270', NULL, N'Admin', 1)
INSERT [dbo].[Utilizatori] ([IdUtilizator], [NumeUtilizator], [ParolaHash], [NumeComplet], [Rol], [EsteActiv]) VALUES (2002, N'auxeniu', N'0cd45a0093a4f3f32971e8d7cb47ebd1ef793dea5415a6b515f4c62a92237394', NULL, N'Admin', 1)
INSERT [dbo].[Utilizatori] ([IdUtilizator], [NumeUtilizator], [ParolaHash], [NumeComplet], [Rol], [EsteActiv]) VALUES (3001, N'vizitator', N'811e39fc87aa5087b1a11439316221ccf0e6bca458542755563b230e561ca7b3', NULL, N'Vizitator', 1)
INSERT [dbo].[Utilizatori] ([IdUtilizator], [NumeUtilizator], [ParolaHash], [NumeComplet], [Rol], [EsteActiv]) VALUES (5001, N'operator', N'c51a8b59d33fd4fa3aa83ededa02424f1d769dddc5f42eeee63c3dde6a74ce40', NULL, N'Operator', 1)
SET IDENTITY_INSERT [dbo].[Utilizatori] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Utilizat__E85F509DD755B45B]    Script Date: 28-Jun-25 2:11:06 PM ******/
ALTER TABLE [dbo].[Utilizatori] ADD UNIQUE NONCLUSTERED 
(
	[NumeUtilizator] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Utilizatori] ADD  DEFAULT ((1)) FOR [EsteActiv]
GO
ALTER TABLE [dbo].[DetaliiTranzactie]  WITH CHECK ADD  CONSTRAINT [FK_DetaliiTranzactie_Produse] FOREIGN KEY([IdProdus])
REFERENCES [dbo].[Produse] ([IdProdus])
GO
ALTER TABLE [dbo].[DetaliiTranzactie] CHECK CONSTRAINT [FK_DetaliiTranzactie_Produse]
GO
ALTER TABLE [dbo].[DetaliiTranzactie]  WITH CHECK ADD  CONSTRAINT [FK_DetaliiTranzactie_Tranzactii] FOREIGN KEY([IdTranzactie])
REFERENCES [dbo].[Tranzactii] ([IdTranzactie])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetaliiTranzactie] CHECK CONSTRAINT [FK_DetaliiTranzactie_Tranzactii]
GO
ALTER TABLE [dbo].[Tranzactii]  WITH CHECK ADD  CONSTRAINT [FK_Tranzactii_Clienti] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Clienti] ([IdClient])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Tranzactii] CHECK CONSTRAINT [FK_Tranzactii_Clienti]
GO
ALTER TABLE [dbo].[Utilizatori]  WITH NOCHECK ADD CHECK  (([Rol]='Vizitator' OR [Rol]='Operator' OR [Rol]='Admin'))
GO
ALTER TABLE [dbo].[Utilizatori]  WITH NOCHECK ADD CHECK  (([Rol]='Vizitator' OR [Rol]='Operator' OR [Rol]='Admin'))
GO
