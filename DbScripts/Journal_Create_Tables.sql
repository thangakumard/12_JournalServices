USE [DairyBook]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](20) NULL,
	[FirstName] [nchar](20) NULL,
	[LastName] [nchar](20) NULL,
	[Password] [nchar](100) NULL,
	[EmailID] [nchar](30) NULL,
	[Mobile] [nchar](20) NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[MoodType](
	[MoodTypeID] [int] NOT NULL,
	[MoodType] [nchar](20) NULL,
	[Description] [nchar](60) NULL,
 CONSTRAINT [PK_MoodType] PRIMARY KEY CLUSTERED 
(
	[MoodTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[EventType](
	[EventTypeID] [int] NOT NULL,
	[EventType] [nchar](20) NULL,
	[Description] [nchar](10) NULL,
 CONSTRAINT [PK_EventType] PRIMARY KEY CLUSTERED 
(
	[EventTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Activity](
	[ActivityID] [int] IDENTITY(1,1) NOT NULL,
	[ActivityName] [nchar](20) NULL,
	[Description] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ActivityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Journal](
	[JournalID] [int] IDENTITY(1,1) NOT NULL,
	[JournalDate] [datetime] NOT NULL,
	[JournalTitle] [nchar](20) NULL,
	[JournalDescription] [nchar](2500) NULL,
PRIMARY KEY CLUSTERED 
(
	[JournalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Journal_Activity](
	[JournalID] [int] NOT NULL,
	[ActivityID] [int] NOT NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[Description] [nchar](500) NULL,
 CONSTRAINT [PK_Journal_Activity] PRIMARY KEY CLUSTERED 
(
	[JournalID] ASC,
	[ActivityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Journal_Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_JournalActivity] FOREIGN KEY([ActivityID])
REFERENCES [dbo].[Activity] ([ActivityID])
GO

ALTER TABLE [dbo].[Journal_Activity] CHECK CONSTRAINT [FK_Activity_JournalActivity]
GO

ALTER TABLE [dbo].[Journal_Activity]  WITH CHECK ADD  CONSTRAINT [FK_Journal_JournalActivity] FOREIGN KEY([JournalID])
REFERENCES [dbo].[Journal] ([JournalID])
GO

ALTER TABLE [dbo].[Journal_Activity] CHECK CONSTRAINT [FK_Journal_JournalActivity]
GO

CREATE TABLE [dbo].[Journal_EventType](
	[JournalID] [int] NOT NULL,
	[EventTypeID] [int] NOT NULL
 CONSTRAINT [PK_Journal_EventType] PRIMARY KEY CLUSTERED 
(
	[JournalID] ASC,
	[EventTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Journal_EventType]  WITH CHECK ADD  CONSTRAINT [FK_EventType_JournalEventType] FOREIGN KEY([EventTypeID])
REFERENCES [dbo].[EventType] ([EventTypeID])
GO

ALTER TABLE [dbo].[Journal_EventType] CHECK CONSTRAINT [FK_EventType_JournalEventType]
GO

ALTER TABLE [dbo].[Journal_EventType]  WITH CHECK ADD  CONSTRAINT [FK_Journal_JournalEventType] FOREIGN KEY([JournalID])
REFERENCES [dbo].[Journal] ([JournalID])
GO

ALTER TABLE [dbo].[Journal_EventType] CHECK CONSTRAINT [FK_Journal_JournalEventType]
GO

CREATE TABLE [dbo].[Journal_MoodType](
	[JournalID] [int] NOT NULL,
	[MoodTypeID] [int] NOT NULL,
 CONSTRAINT [PK_Journal_MoodType] PRIMARY KEY CLUSTERED 
(
	[JournalID] ASC,
	[MoodTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Journal_MoodType]  WITH CHECK ADD  CONSTRAINT [FK_Journal_JournalMoodType] FOREIGN KEY([JournalID])
REFERENCES [dbo].[Journal] ([JournalID])
GO

ALTER TABLE [dbo].[Journal_MoodType] CHECK CONSTRAINT [FK_Journal_JournalMoodType]
GO

ALTER TABLE [dbo].[Journal_MoodType]  WITH CHECK ADD  CONSTRAINT [FK_MoodType_JournalMoodType] FOREIGN KEY([MoodTypeID])
REFERENCES [dbo].[MoodType] ([MoodTypeID])
GO

ALTER TABLE [dbo].[Journal_MoodType] CHECK CONSTRAINT [FK_MoodType_JournalMoodType]
GO










