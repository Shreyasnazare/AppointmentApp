using AppointmentAPI.DAL.Entity.Doctor;

namespace AppointmentAPI.Models.Doctor
{
    public class DoctorSlotsTiming
    {
        public string? DoctorID { get; set; }
        public string? TimeSlotID { get; set; }
        public string? SlotCapacity { get; set; }
        public string? SlotFilled { get; set; }
        public string? SlotStart { get; set; }
        public string? SlotEnd { get; set; }
        
            

    }




    //public static class DoctorSlotsDTO
    //{

    //    public static DoctorModelSlots DoctorSlotsToModel(DoctorSlots req, DoctorModelSlots res = null)
    //    {
    //        if(res == null)
    //        res = new DoctorModelSlots();


    //        res.DoctorID = req.DoctorID.ToString();
    //        res.SlotCapacity = req.SlotCapacity.ToString();
    //        res.SlotFilled = req.SlotFilled.ToString();
    //        res.TimeSlotID = req.TimeSlotID.ToString();


    //       return res;

    //    }

    //}


}
