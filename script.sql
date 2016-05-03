USE [Vehicle]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 5/3/2016 12:38:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehicle](
	[Id] [int] NULL,
	[Year] [int] NULL,
	[Make] [varchar](100) NULL,
	[Model] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
