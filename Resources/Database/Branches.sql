USE [Project]
GO

/****** Object:  Table [dbo].[Branches]    Script Date: 12/7/2022 9:56:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Branches](
	[Branch Number] [int] NOT NULL,
	[Branch Country Address] [varchar](50) NOT NULL,
	[Branch City Address] [varchar](50) NOT NULL,
	[Branch District Address] [varchar](50) NOT NULL,
	[Branch E-mail] [varchar](50) NOT NULL,
	[Branch Phone Number] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[Branch Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

