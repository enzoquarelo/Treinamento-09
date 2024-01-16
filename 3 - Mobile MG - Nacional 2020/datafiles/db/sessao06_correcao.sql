USE master
GO
DROP DATABASE [SessaoMobile]
GO
CREATE DATABASE [SessaoMobile]
GO
USE [SessaoMobile]
GO
/****** Object:  Table [dbo].[Funcao]    Script Date: 07/08/2020 16:07:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcao](
	[id] [int] NOT NULL IDENTITY,
	[funcao] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Funcao] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Relatos]    Script Date: 07/08/2020 16:07:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relatos](
	[id] [int] NOT NULL IDENTITY,
	[relato] [nvarchar](255) NOT NULL,
	[imagem] [nvarchar](255) NOT NULL,
	[latitude] [decimal](18, 8) NOT NULL,
	[longitude] [decimal](18, 8) NOT NULL,
	[usuarioid] [int] NULL,
 CONSTRAINT [PK_Relatos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/08/2020 16:07:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] NOT NULL IDENTITY,
	[nome] [nvarchar](50) NOT NULL,
	[email] [nvarchar](255) NOT NULL,
	[senha] [nvarchar](50) NOT NULL,
	[telefone] [nvarchar](13) NOT NULL,
	[funcaoid] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Relatos]  WITH CHECK ADD  CONSTRAINT [FK_Relatos_Usuario] FOREIGN KEY([usuarioid])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Relatos] CHECK CONSTRAINT [FK_Relatos_Usuario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Funcao] FOREIGN KEY([funcaoid])
REFERENCES [dbo].[Funcao] ([id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Funcao]
GO

SET IDENTITY_INSERT [dbo].[Funcao] ON 
GO
INSERT INTO [dbo].[Funcao] ([id], [funcao]) VALUES (1, 'Administrador')
INSERT INTO [dbo].[Funcao] ([id], [funcao]) VALUES (2, 'Usuario')
GO
SET IDENTITY_INSERT [dbo].[Funcao] OFF 
GO

SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO

INSERT [dbo].[Usuario] ([id], [nome], [email], [senha], [telefone], [funcaoid]) VALUES (1, N'Dayana  França', N'Daianaclf@hotmail.com', N'321654', N'954462214', 1)
GO
INSERT [dbo].[Usuario] ([id], [nome], [email], [senha], [telefone], [funcaoid]) VALUES (2, N'Juliane Reis dos Santos ', N'juliane2009@gmail.com ', N'6654', N'923736785', 2)
GO
INSERT [dbo].[Usuario] ([id], [nome], [email], [senha], [telefone], [funcaoid]) VALUES (3, N'David Juan', N'david.entrega@hotmail.com', N'123554', N'955526845', 2)
GO
INSERT [dbo].[Usuario] ([id], [nome], [email], [senha], [telefone], [funcaoid]) VALUES (4, N'Jonathas Ramos Costa', N'Jota.rc1@hotmail.com', N'65885', N'924585758', 1)
GO
INSERT [dbo].[Usuario] ([id], [nome], [email], [senha], [telefone], [funcaoid]) VALUES (5, N'Ronaldo Costa Soares', N'Jrcsoares@Yahoo.com.br', N'1455', N'925656123', 2)
GO
INSERT [dbo].[Usuario] ([id], [nome], [email], [senha], [telefone], [funcaoid]) VALUES (6, N'Geraldo Silva', N'geraldosilva@hotmail.com', N'gs55fs5', N'999653214', 2)
GO
INSERT [dbo].[Usuario] ([id], [nome], [email], [senha], [telefone], [funcaoid]) VALUES (7, N'Lívia Queiroz', N'liviasilvaq@gmail.com', N'li58785', N'988665321', 2)
GO
INSERT [dbo].[Usuario] ([id], [nome], [email], [senha], [telefone], [funcaoid]) VALUES (8, N'Graziela de Araujo', N'graziela.a.s@hotmail.com', N'graz41741', N'936534875', 2)
GO
INSERT [dbo].[Usuario] ([id], [nome], [email], [senha], [telefone], [funcaoid]) VALUES (9, N'Marlos Prado', N'marlosprado@hotmail.com', N'853658dsa', N'995653214', 2)
GO
INSERT [dbo].[Usuario] ([id], [nome], [email], [senha], [telefone], [funcaoid]) VALUES (10, N'Daiane Leal', N'daianefalcao.biz@gmail.com', N'5468hnn', N'933568875', 1)
GO

SET IDENTITY_INSERT [dbo].[Usuario] OFF 
GO

SET IDENTITY_INSERT [dbo].[Relatos] ON 
GO

INSERT [dbo].[Relatos] ([id], [relato], [imagem], [latitude], [longitude], [usuarioid]) VALUES (1, 'Após show de sertajeno na praça pública lixo não é recolhido.', '120220201750.jgp', -7.123053, -51.489655, null)
GO
INSERT [dbo].[Relatos] ([id], [relato], [imagem], [latitude], [longitude], [usuarioid]) VALUES (2, 'Maus tratos com animais domésticos.', '020220200935.jgp', -10.512484, -47.151101, 3)
GO
INSERT [dbo].[Relatos] ([id], [relato], [imagem], [latitude], [longitude], [usuarioid]) VALUES (3, 'Praias da rendodezas imundas após festa de ano novo.', '151020202233.jgp', -24.840988, -51.295736, 7)
GO
INSERT [dbo].[Relatos] ([id], [relato], [imagem], [latitude], [longitude], [usuarioid]) VALUES (4, 'Incêndio na reserva de mata atlântica.', '030120201555.jgp', -17.516768, -42.867943, 2)
GO
INSERT [dbo].[Relatos] ([id], [relato], [imagem], [latitude], [longitude], [usuarioid]) VALUES (5, 'Queimas de pneu poluindo o ar do bairro.', '101220201225.jgp', -18.375968, -40.288539, 6)
GO
INSERT [dbo].[Relatos] ([id], [relato], [imagem], [latitude], [longitude], [usuarioid]) VALUES (6, 'Esgoto a céu aberto e sem previsão para o saneamento básico chega.', '070820201753.jgp', -25.330345, -51.902408, 9)
GO
INSERT [dbo].[Relatos] ([id], [relato], [imagem], [latitude], [longitude], [usuarioid]) VALUES (7, 'Derramamento de petróleo no mar após tentativa de exploração.', '080820201836.jgp', -24.006896, -48.348788, 5)
GO
INSERT [dbo].[Relatos] ([id], [relato], [imagem], [latitude], [longitude], [usuarioid]) VALUES (8, 'Poluição do solo em terreno cercado.', '090820201655.jgp', -24.602168, -47.381982, 8)
GO
INSERT [dbo].[Relatos] ([id], [relato], [imagem], [latitude], [longitude], [usuarioid]) VALUES (9, 'Caça ilegal de animais.', '100820201233.jgp', -12.039293, -37.860136, null)
GO
INSERT [dbo].[Relatos] ([id], [relato], [imagem], [latitude], [longitude], [usuarioid]) VALUES (10, 'Após o carnval as ruas estão lotada de lixo.', '220220200932.jgp', -9.869251, -35.912583, null)
GO

SET IDENTITY_INSERT [dbo].[Relatos] OFF 
GO