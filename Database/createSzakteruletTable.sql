USE [tanacsado]
GO

/****** Object:  Table [dbo].[szakterulet]    Script Date: 2023. 11. 13. 16:38:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[szakterulet](
	[szakterulet_id] [int] IDENTITY(1,1) NOT NULL,
	[megnevezes] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[szakterulet_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

