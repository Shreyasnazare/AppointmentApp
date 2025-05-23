USE [DoctorAppointment]
GO
/****** Object:  Table [dbo].[PaymentDetails]    Script Date: 5/17/2025 11:58:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentDetails](
	[PaymentID] [bigint] IDENTITY(1,1) NOT NULL,
	[BookingID] [bigint] NULL,
	[ConsultingFees] [bigint] NULL,
	[TotalFees] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
