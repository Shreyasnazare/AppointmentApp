USE [DoctorAppointment]
GO
/****** Object:  User [IIS APPPOOL\AppointmentAPI]    Script Date: 5/17/2025 11:58:08 AM ******/
CREATE USER [IIS APPPOOL\AppointmentAPI] FOR LOGIN [IIS APPPOOL\AppointmentAPI] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [IIS APPPOOL\AppointmentAPI]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [IIS APPPOOL\AppointmentAPI]
GO
