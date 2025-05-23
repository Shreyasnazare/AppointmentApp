USE [DoctorAppointment]
GO
/****** Object:  StoredProcedure [dbo].[GetDoctorRating]    Script Date: 5/17/2025 11:59:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: 30-Apr-2025
-- Description:	To get all the doctorDetails along with it's specilisation, avg ratings , timeslots
-- =============================================
Create     PROCEDURE [dbo].[GetDoctorRating] 
	@DoctorID as bigint 
AS
BEGIN
	
	Declare @AvgDoctorRating as nvarchar(10)
	set @AvgDoctorRating = (Select Avg(Rating)  from DoctorRatings where DoctorID = @DoctorID)

	


	Select top 1 Description, Convert(date,Rating_At) as Rating_At , Round(@AvgDoctorRating,1) as AvgRating, Rating  from DoctorRatings
	where DoctorID = @DoctorID order by Rating_at desc


END
GO
