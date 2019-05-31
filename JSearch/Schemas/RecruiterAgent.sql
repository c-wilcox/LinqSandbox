USE [JobSearch]
GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RecruiterAgent', @level2type=N'CONSTRAINT',@level2name=N'FK_RecruiterAgent_Recruiter'
GO

ALTER TABLE [dbo].[RecruiterAgent] DROP CONSTRAINT [FK_RecruiterAgent_Recruiter]
GO

/****** Object:  Table [dbo].[RecruiterAgent]    Script Date: 5/31/2019 3:46:50 PM ******/
DROP TABLE [dbo].[RecruiterAgent]
GO

/****** Object:  Table [dbo].[RecruiterAgent]    Script Date: 5/31/2019 3:46:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RecruiterAgent](
	[pkRecruiterAgent] [bigint] IDENTITY(1,1) NOT NULL,
	[fkRecruiter] [bigint] NOT NULL,
 CONSTRAINT [PK_RecruiterAgentx] PRIMARY KEY CLUSTERED 
(
	[pkRecruiterAgent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RecruiterAgent]  WITH CHECK ADD  CONSTRAINT [FK_RecruiterAgent_Recruiter] FOREIGN KEY([fkRecruiter])
REFERENCES [dbo].[Recruiter] ([pkRecruiter])
GO

ALTER TABLE [dbo].[RecruiterAgent] CHECK CONSTRAINT [FK_RecruiterAgent_Recruiter]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'FK_FromTable_ToTable' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RecruiterAgent', @level2type=N'CONSTRAINT',@level2name=N'FK_RecruiterAgent_Recruiter'
GO

