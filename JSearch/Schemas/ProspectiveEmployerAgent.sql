USE [JobSearch]
GO

ALTER TABLE [dbo].[ProspectiveEmployerAgent] DROP CONSTRAINT [FK_ProspectiveEmployerAgent_ProspectiveEmployer]
GO

/****** Object:  Table [dbo].[ProspectiveEmployerAgent]    Script Date: 5/31/2019 3:44:49 PM ******/
DROP TABLE [dbo].[ProspectiveEmployerAgent]
GO

/****** Object:  Table [dbo].[ProspectiveEmployerAgent]    Script Date: 5/31/2019 3:44:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProspectiveEmployerAgent](
	[pkProspectiveEmployerAgent] [bigint] IDENTITY(1,1) NOT NULL,
	[fkProspectiveEmployer] [bigint] NOT NULL,
 CONSTRAINT [PK_EmployerAgent_1] PRIMARY KEY CLUSTERED 
(
	[pkProspectiveEmployerAgent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ProspectiveEmployerAgent]  WITH CHECK ADD  CONSTRAINT [FK_ProspectiveEmployerAgent_ProspectiveEmployer] FOREIGN KEY([fkProspectiveEmployer])
REFERENCES [dbo].[ProspectiveEmployer] ([pkProspectiveEmployer])
GO

ALTER TABLE [dbo].[ProspectiveEmployerAgent] CHECK CONSTRAINT [FK_ProspectiveEmployerAgent_ProspectiveEmployer]
GO

