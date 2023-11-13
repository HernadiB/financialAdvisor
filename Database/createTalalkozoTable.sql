USE [tanacsado]
GO

/****** Object:  Table [dbo].[talalkozo]    Script Date: 2023. 11. 13. 16:39:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[talalkozo](
	[talalkozo_id] [int] IDENTITY(1,1) NOT NULL,
	[tanacsado_id] [int] NULL,
	[ugyfel_id] [int] NULL,
	[datum] [date] NULL,
	[idopont] [time](7) NULL,
	[idotartam] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[talalkozo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[talalkozo]  WITH CHECK ADD  CONSTRAINT [FK_talalkozo_tanacsado] FOREIGN KEY([tanacsado_id])
REFERENCES [dbo].[tanacsado] ([tanacsado_id])
GO

ALTER TABLE [dbo].[talalkozo] CHECK CONSTRAINT [FK_talalkozo_tanacsado]
GO

ALTER TABLE [dbo].[talalkozo]  WITH CHECK ADD  CONSTRAINT [FK_talalkozo_ugyfel] FOREIGN KEY([ugyfel_id])
REFERENCES [dbo].[ugyfel] ([ugyfel_id])
GO

ALTER TABLE [dbo].[talalkozo] CHECK CONSTRAINT [FK_talalkozo_ugyfel]
GO

