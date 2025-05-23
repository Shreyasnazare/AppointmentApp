USE [DoctorAppointment]
GO
/****** Object:  Table [dbo].[DoctorSlots]    Script Date: 5/17/2025 11:58:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorSlots](
	[DoctorSlotsID] [bigint] IDENTITY(1,1) NOT NULL,
	[DoctorID] [bigint] NULL,
	[TimeSlotID] [bigint] NULL,
	[SlotCapacity] [bigint] NULL,
	[SlotFilled] [bigint] NULL
) ON [PRIMARY]
GO
