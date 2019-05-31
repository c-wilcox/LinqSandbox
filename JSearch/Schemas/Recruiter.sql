USE [JobSearch]
GO

/****** Object:  Table [dbo].[Recruiter]    Script Date: 5/31/2019 3:46:33 PM ******/
DROP TABLE [dbo].[Recruiter]
GO

/****** Object:  Table [dbo].[Recruiter]    Script Date: 5/31/2019 3:46:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Recruiter](
	[pkRecruiter] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](400) NOT NULL,
 CONSTRAINT [PK_Recruiter] PRIMARY KEY CLUSTERED 
(
	[pkRecruiter] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

