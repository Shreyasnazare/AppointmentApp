USE [DoctorAppointment]
GO
/****** Object:  Table [dbo].[DoctorSpecialisation]    Script Date: 5/17/2025 11:58:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorSpecialisation](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[DoctorID] [bigint] NOT NULL,
	[SpecialisationID] [bigint] NOT NULL
) ON [PRIMARY]
GO
