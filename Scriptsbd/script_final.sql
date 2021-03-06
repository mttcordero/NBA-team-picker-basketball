USE [master]
GO
/****** Object:  Database [PSIM1619I_MatteoCordero_2219132]    Script Date: 18/06/2021 12:16:06 ******/
CREATE DATABASE [PSIM1619I_MatteoCordero_2219132]
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET ARITHABORT OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET RECOVERY FULL 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET  MULTI_USER 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PSIM1619I_MatteoCordero_2219132', N'ON'
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET QUERY_STORE = OFF
GO
USE [PSIM1619I_MatteoCordero_2219132]
GO
/****** Object:  Table [dbo].[Divisoes]    Script Date: 18/06/2021 12:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Divisoes](
	[ID] [int] NOT NULL,
	[NomeDivisao] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipas]    Script Date: 18/06/2021 12:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipas](
	[ID] [int] NOT NULL,
	[NomeEquipa] [varchar](50) NOT NULL,
	[DivisaoID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquipasJogadores]    Script Date: 18/06/2021 12:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquipasJogadores](
	[ID] [int] NOT NULL,
	[JogadorID] [int] NOT NULL,
	[EquipaID] [int] NOT NULL,
	[NumeroCamisola] [int] NOT NULL,
	[Posicao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EquipasJogadores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jogadores]    Script Date: 18/06/2021 12:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jogadores](
	[id] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Universidade] [varchar](50) NULL,
	[altura] [varchar](50) NULL,
	[peso] [varchar](50) NULL,
 CONSTRAINT [PK__Jogadore__3213E83F97CB74D0] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[novos_utilizadores]    Script Date: 18/06/2021 12:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[novos_utilizadores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[idade] [varchar](50) NOT NULL,
 CONSTRAINT [PK_novos_utilizadores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilizadores]    Script Date: 18/06/2021 12:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilizadores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[nomeUser] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Divisoes] ([ID], [NomeDivisao]) VALUES (1, N'atlantico')
INSERT [dbo].[Divisoes] ([ID], [NomeDivisao]) VALUES (2, N'central')
INSERT [dbo].[Divisoes] ([ID], [NomeDivisao]) VALUES (3, N'sudeste')
INSERT [dbo].[Divisoes] ([ID], [NomeDivisao]) VALUES (4, N'noroeste')
INSERT [dbo].[Divisoes] ([ID], [NomeDivisao]) VALUES (5, N'pacifico')
INSERT [dbo].[Divisoes] ([ID], [NomeDivisao]) VALUES (6, N'sudoeste')
GO
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (1, N'Boston Celtics', 1)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (2, N'Brooklyn Netss', 1)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (3, N'New York Knicks', 1)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (4, N'Philadelphia 76ers', 1)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (5, N'Toronto Raptors', 1)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (6, N'Chicago Bulls', 2)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (7, N'Cleveland Cavaliers', 2)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (8, N'Detroit Pistons', 2)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (9, N'Indiana Pacers', 2)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (10, N'Milwaukee Bucks', 2)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (11, N'Atlanta Hawks', 3)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (12, N'Charlotte Hornets', 3)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (13, N'Miami Heat', 3)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (14, N'Orlando Magic', 3)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (15, N'Washington Wizards', 3)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (16, N'Denver Nuggets', 4)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (17, N'Minnesota Timberwolves', 4)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (18, N'Oklahoma City Thunder', 4)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (19, N'Portland Trail Blazers', 4)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (20, N'Utah Jazz', 4)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (21, N'Golden State Warriors', 5)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (22, N'LA Clippers', 5)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (23, N'Los Angeles Lakers', 5)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (24, N'Phoenix Suns', 5)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (25, N'Sacramento Kings', 5)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (26, N'Dallas Mavericks', 6)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (27, N'Houston Rockets', 6)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (28, N'Memphis Grizzlies', 6)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (29, N'New Orleans Pelicans', 6)
INSERT [dbo].[Equipas] ([ID], [NomeEquipa], [DivisaoID]) VALUES (30, N'San Antonio Spurs', 6)
GO
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (1, 1, 1, 7, N'Al-AR')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (2, 2, 1, 4, N'Ar')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (3, 3, 1, 99, N'P')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (4, 4, 2, 13, N'Ar')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (5, 5, 3, 39, N'Pg')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (6, 6, 4, 24, N'P')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (7, 7, 5, 7, N'PG')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (8, 8, 6, 6, N'A')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (9, 9, 7, 31, N'C')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (10, 10, 8, 3, N'C')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (11, 11, 9, 22, N'SG')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (12, 12, 10, 34, N'PF')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (13, 13, 11, 34, N'PF')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (14, 14, 12, 2, N'PG')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (15, 15, 13, 8, N'SF')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (16, 16, 14, 5, N'C')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (17, 17, 15, 4, N'PG')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (18, 18, 16, 88, N'SF')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (19, 19, 17, 6, N'C')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (20, 20, 18, 7, N'A')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (21, 21, 19, 11, N'PF')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (22, 22, 20, 4, N'PG')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (23, 23, 21, 7, N'PG')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (24, 24, 22, 9, N'C')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (25, 25, 23, 55, N'A')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (26, 26, 24, 11, N'C')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (27, 27, 25, 4, N'SG')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (28, 28, 26, 7, N'PG')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (29, 29, 27, 9, N'C')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (30, 30, 28, 55, N'A')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (31, 31, 29, 11, N'C')
INSERT [dbo].[EquipasJogadores] ([ID], [JogadorID], [EquipaID], [NumeroCamisola], [Posicao]) VALUES (32, 32, 30, 4, N'SG')
GO
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (1, N'Jaylen Brown', N'California', N'1.98 m', N'101.2 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (2, N'Carsen Edwards', N'Purdue', N'1.80 m', N'101.2 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (3, N'Tacko Fall', N'UCF', N'2.26 m', N'141 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (4, N'James Harden', N'Arizona State', N'1.96 m', N'99.8 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (5, N'Derrick Rose', N'Memphis', N'1.88 m', N'91 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (6, N'Dwight Howard', N'', N'2.08 m', N'120 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (7, N'Kyle Lowry', N'Villanova', N'1.83 m', N'88 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (8, N'Troy Brown Jr', N'Oregon', N'1.98 m', N'97 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (9, N'	Jarrett Allen', N'Texas', N'2.11 m', N'110 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (10, N'Hamidou Diallo', N'Kentucky', N'1.96 m', N'91 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (11, N'Caris LeVert', N'Michigan', N'1.98 m', N'92 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (12, N'Giannis Antetokounmpo', N'', N'2.11 m', N'109 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (13, N'Kevin Huerter', N'Maryland', N'2.11 m', N'109 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (14, N'LaMelo Ball', N'', N'1.98 m', N'81 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (15, N'Trevor Ariza', N'UCLA', N'2.03 m', N'97 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (16, N'Mo Bamba', N'Texas', N'2.13 m', N'104 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (17, N'Russell Westbrook', N'UCLA', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (18, N'Will Barton', N'UCLA', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (19, N'Ed Davis', N'UCLA', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (20, N'Charlie Brown Jr.', N'UCLA', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (21, N'Carmelo Anthony', N'UCLA', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (22, N'Mike Conley', N'UCLA', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (23, N'Stephen Curry', N'Davidson', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (24, N'Nicolas Batum', N'', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (25, N'Kostas Antetokounmpo', N'Dayton', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (26, N'Deandre Ayton', N'UCLA', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (27, N'Kyle Guy', N'UCLA', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (28, N'Tyler Bey', N'Davidson', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (29, N'D.J. Augustin', N'', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (30, N'Grayson Allen', N'Dayton', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (31, N'Lonzo Ball', N'UCLA', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (32, N'Gorgui Dieng', N'UCLA', N'1.91 m', N'90 kg')
INSERT [dbo].[Jogadores] ([id], [Nome], [Universidade], [altura], [peso]) VALUES (33, N'Matteo Cordero', N'', N'3.22', N'25')
GO
SET IDENTITY_INSERT [dbo].[novos_utilizadores] ON 

INSERT [dbo].[novos_utilizadores] ([id], [nome], [email], [idade]) VALUES (1, N'matteo', N'18', N'ferbe')
INSERT [dbo].[novos_utilizadores] ([id], [nome], [email], [idade]) VALUES (2, N'matteo', N'18', N'dddddddd')
INSERT [dbo].[novos_utilizadores] ([id], [nome], [email], [idade]) VALUES (3, N'matteo', N'18', N'fdffffff')
SET IDENTITY_INSERT [dbo].[novos_utilizadores] OFF
GO
SET IDENTITY_INSERT [dbo].[Utilizadores] ON 

INSERT [dbo].[Utilizadores] ([id], [password], [nomeUser]) VALUES (1, N'1234', N'admin')
INSERT [dbo].[Utilizadores] ([id], [password], [nomeUser]) VALUES (2, N'1234', N'mttcordero')
SET IDENTITY_INSERT [dbo].[Utilizadores] OFF
GO
ALTER TABLE [dbo].[Equipas]  WITH CHECK ADD  CONSTRAINT [FK_Equipas_Divisoes] FOREIGN KEY([DivisaoID])
REFERENCES [dbo].[Divisoes] ([ID])
GO
ALTER TABLE [dbo].[Equipas] CHECK CONSTRAINT [FK_Equipas_Divisoes]
GO
ALTER TABLE [dbo].[EquipasJogadores]  WITH CHECK ADD  CONSTRAINT [FK_EquipasJogadores_Equipas] FOREIGN KEY([EquipaID])
REFERENCES [dbo].[Equipas] ([ID])
GO
ALTER TABLE [dbo].[EquipasJogadores] CHECK CONSTRAINT [FK_EquipasJogadores_Equipas]
GO
ALTER TABLE [dbo].[EquipasJogadores]  WITH CHECK ADD  CONSTRAINT [FK_EquipasJogadores_Jogadores] FOREIGN KEY([JogadorID])
REFERENCES [dbo].[Jogadores] ([id])
GO
ALTER TABLE [dbo].[EquipasJogadores] CHECK CONSTRAINT [FK_EquipasJogadores_Jogadores]
GO
USE [master]
GO
ALTER DATABASE [PSIM1619I_MatteoCordero_2219132] SET  READ_WRITE 
GO
