USE [master]
GO

/****** Object:  Database [Ballastlane]  ******/
CREATE DATABASE [Ballastlane];
GO

USE [Ballastlane]
GO

/****** Object:  Table [dbo].[ProfileData]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfileData](
	[ProfileId] [uniqueidentifier] NOT NULL,
	[Email] [varchar](256) NOT NULL,
	[Alias] [varchar](50) NOT NULL,
	[Birthday] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProfileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[UserData]    Script Date: 29/01/2024 01:03:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserData](
	[Email] [varchar](256) NOT NULL,
	[Password] [varchar](500) NOT NULL,
	[IsActivated] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserData] ADD  DEFAULT ((1)) FOR [IsActivated]
GO

ALTER TABLE [dbo].[ProfileData]  WITH CHECK ADD  CONSTRAINT [FK_ProfileData_UserData] FOREIGN KEY([Email])
REFERENCES [dbo].[UserData] ([Email])

GO
ALTER TABLE [dbo].[ProfileData] CHECK CONSTRAINT [FK_ProfileData_UserData]
GO


USE [master]
GO

ALTER DATABASE [Ballastlane] SET  READ_WRITE 
GO
