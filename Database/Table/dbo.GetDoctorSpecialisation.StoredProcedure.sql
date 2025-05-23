USE [DoctorAppointment]
GO
/****** Object:  StoredProcedure [dbo].[GetDoctorSpecialisation]    Script Date: 5/17/2025 11:58:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: 30-Apr-2025
-- Description:	To get all the doctorDetails along with it's specilisation, avg ratings , timeslots
-- =============================================
CREATE   PROCEDURE [dbo].[GetDoctorSpecialisation] 
	@DoctorID as bigint 
AS
BEGIN
	
	Select S.Code, S.Description from DoctorSpecialisation DS 
	join Specialisation s on DS.SpecialisationID = S.ID
	where DS.DoctorID = @DoctorID


END
GO
