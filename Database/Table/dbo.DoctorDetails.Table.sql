USE [DoctorAppointment]
GO
/****** Object:  Table [dbo].[DoctorDetails]    Script Date: 5/17/2025 11:58:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorDetails](
	[DoctorID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NULL,
	[Qualification] [nvarchar](500) NULL,
	[Address] [nvarchar](200) NULL,
	[DOB] [date] NULL,
	[Contact] [nvarchar](20) NULL,
	[ActiveYN] [varchar](1) NULL,
	[CareerStart] [date] NULL,
	[Image] [nvarchar](max) NULL,
	[Hospital] [nvarchar](100) NULL,
	[ConsultingFees] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
