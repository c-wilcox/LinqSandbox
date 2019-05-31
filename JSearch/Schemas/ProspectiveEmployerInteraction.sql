USE [JobSearch]
GO

ALTER TABLE [dbo].[ProspectiveEmployerInteraction] DROP CONSTRAINT [FK_ProspectiveEmployerInteraction_ProspectiveEmployer]
GO

/****** Object:  Table [dbo].[ProspectiveEmployerInteraction]    Script Date: 5/31/2019 3:46:09 PM ******/
DROP TABLE [dbo].[ProspectiveEmployerInteraction]
GO

/****** Object:  Table [dbo].[ProspectiveEmployerInteraction]    Script Date: 5/31/2019 3:46:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProspectiveEmployerInteraction](
	[pkProspectiveEmployerInteraction] [bigint] IDENTITY(1,1) NOT NULL,
	[fkProspectiveEmployer] [bigint] NOT NULL,
 CONSTRAINT [PK_ProspectiveEmployerInteraction] PRIMARY KEY CLUSTERED 
(
	[pkProspectiveEmployerInteraction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ProspectiveEmployerInteraction]  WITH CHECK ADD  CONSTRAINT [FK_ProspectiveEmployerInteraction_ProspectiveEmployer] FOREIGN KEY([fkProspectiveEmployer])
REFERENCES [dbo].[ProspectiveEmployer] ([pkProspectiveEmployer])
GO

ALTER TABLE [dbo].[ProspectiveEmployerInteraction] CHECK CONSTRAINT [FK_ProspectiveEmployerInteraction_ProspectiveEmployer]
GO

