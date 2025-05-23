USE [DoctorAppointment]
GO
/****** Object:  Table [dbo].[DoctorRatings]    Script Date: 5/17/2025 11:58:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorRatings](
	[RatingID] [bigint] IDENTITY(1,1) NOT NULL,
	[DoctorID] [bigint] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Rating] [float] NOT NULL,
	[Rating_At] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
