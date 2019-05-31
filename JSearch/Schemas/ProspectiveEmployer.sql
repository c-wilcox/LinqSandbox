USE [JobSearch]
GO

ALTER TABLE [dbo].[ProspectiveEmployer] DROP CONSTRAINT [FK_ProspectiveEmployer_RecruiterAgent]
GO

/****** Object:  Table [dbo].[ProspectiveEmployer]    Script Date: 5/31/2019 3:45:34 PM ******/
DROP TABLE [dbo].[ProspectiveEmployer]
GO

/****** Object:  Table [dbo].[ProspectiveEmployer]    Script Date: 5/31/2019 3:45:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProspectiveEmployer](
	[pkProspectiveEmployer] [bigint] IDENTITY(1,1) NOT NULL,
	[fkRecruiterAgent] [bigint] NULL,
 CONSTRAINT [PK_ProspectiveEmployer] PRIMARY KEY CLUSTERED 
(
	[pkProspectiveEmployer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ProspectiveEmployer]  WITH CHECK ADD  CONSTRAINT [FK_ProspectiveEmployer_RecruiterAgent] FOREIGN KEY([fkRecruiterAgent])
REFERENCES [dbo].[RecruiterAgent] ([pkRecruiterAgent])
GO

ALTER TABLE [dbo].[ProspectiveEmployer] CHECK CONSTRAINT [FK_ProspectiveEmployer_RecruiterAgent]
GO

