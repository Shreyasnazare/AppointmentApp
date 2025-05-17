using System.ComponentModel.DataAnnotations;

namespace AppointmentAPI.DAL.Entity.Doctor
{
    public class DoctorSlots
    {
        [Key]
        public long DoctorSlotsID { get; set; }

        public long DoctorID { get; set; }

        public long TimeSlotID { get; set; }

        public long SlotCapacity { get; set; }

        public long SlotFilled { get; set; }
    }
}
