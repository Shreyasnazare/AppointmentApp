using System.ComponentModel.DataAnnotations;

namespace AppointmentAPI.DAL.Entity.Doctor
{
    public class DoctorDetails
    {
        [Key]
        public long DoctorID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }       
        public string? Email { get; set; }
        public string? Qualification { get; set; }
        public DateOnly? DOB { get; set; }
        public string? Contact { get; set; }
        public string? ActiveYN { get; set; }

        public DateOnly? CareerStart { get; set; }
        public string? ImagePath { get; set; }
        public double? ConsultingFees { get; set; }

        public string? Hospital { get; set; }


    }
    
}
