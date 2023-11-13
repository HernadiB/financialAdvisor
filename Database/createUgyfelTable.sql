USE [tanacsado]
GO

/****** Object:  Table [dbo].[ugyfel]    Script Date: 2023. 11. 13. 16:39:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ugyfel](
	[ugyfel_id] [int] IDENTITY(1,1) NOT NULL,
	[nev] [varchar](30) NULL,
	[telefon] [varchar](14) NULL,
	[email] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[ugyfel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ugyfel]  WITH CHECK ADD  CONSTRAINT [FK_ugyfel_ugyfel] FOREIGN KEY([ugyfel_id])
REFERENCES [dbo].[ugyfel] ([ugyfel_id])
GO

ALTER TABLE [dbo].[ugyfel] CHECK CONSTRAINT [FK_ugyfel_ugyfel]
GO

