USE [tanacsado]
GO

/****** Object:  Table [dbo].[tanacsado]    Script Date: 2023. 11. 13. 16:39:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tanacsado](
	[tanacsado_id] [int] IDENTITY(1,1) NOT NULL,
	[nev] [varchar](30) NULL,
	[szakterulet_id] [int] NULL,
	[oradij] [int] NULL,
	[telefon] [varchar](14) NULL,
	[email] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[tanacsado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tanacsado]  WITH CHECK ADD  CONSTRAINT [FK_tanacsado_szakterulet] FOREIGN KEY([szakterulet_id])
REFERENCES [dbo].[szakterulet] ([szakterulet_id])
GO

ALTER TABLE [dbo].[tanacsado] CHECK CONSTRAINT [FK_tanacsado_szakterulet]
GO

