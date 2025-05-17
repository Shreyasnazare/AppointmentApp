using System.ComponentModel.DataAnnotations;

namespace AppointmentAPI.DAL.Entity.Doctor
{
    public class TimeSlots
    {
        [Key]
        public long TimeSlotID { get; set; }
        public string? SlotStart { get; set; }
        public string? SlotEnd { get; set; }
        public string? SlotSequence { get; set; }
        public string? ActiveYN { get; set; }
    }
}
