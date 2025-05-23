USE [DoctorAppointment]
GO
/****** Object:  Table [dbo].[TimeSlots]    Script Date: 5/17/2025 11:58:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeSlots](
	[TimeSlotID] [bigint] IDENTITY(1,1) NOT NULL,
	[SlotStart] [nvarchar](5) NOT NULL,
	[SlotEnd] [nvarchar](5) NOT NULL,
	[SlotSequence] [nvarchar](100) NULL,
	[ActiveYN] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[TimeSlotID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
