USE [JobSearch]
GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RecruiterAgentInteraction', @level2type=N'CONSTRAINT',@level2name=N'FK_RecruiterAgentInteraction_RecruiterAgent'
GO

ALTER TABLE [dbo].[RecruiterAgentInteraction] DROP CONSTRAINT [FK_RecruiterAgentInteraction_RecruiterAgent]
GO

/****** Object:  Table [dbo].[RecruiterAgentInteraction]    Script Date: 5/31/2019 3:47:44 PM ******/
DROP TABLE [dbo].[RecruiterAgentInteraction]
GO

/****** Object:  Table [dbo].[RecruiterAgentInteraction]    Script Date: 5/31/2019 3:47:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RecruiterAgentInteraction](
	[pkRecruiterAgentInteraction] [bigint] IDENTITY(1,1) NOT NULL,
	[fkRecruiterAgent] [bigint] NOT NULL,
 CONSTRAINT [PK_RecruiterAgentInteraction] PRIMARY KEY CLUSTERED 
(
	[pkRecruiterAgentInteraction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RecruiterAgentInteraction]  WITH CHECK ADD  CONSTRAINT [FK_RecruiterAgentInteraction_RecruiterAgent] FOREIGN KEY([fkRecruiterAgent])
REFERENCES [dbo].[RecruiterAgent] ([pkRecruiterAgent])
GO

ALTER TABLE [dbo].[RecruiterAgentInteraction] CHECK CONSTRAINT [FK_RecruiterAgentInteraction_RecruiterAgent]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'FK_FromTable_ToTable' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RecruiterAgentInteraction', @level2type=N'CONSTRAINT',@level2name=N'FK_RecruiterAgentInteraction_RecruiterAgent'
GO

