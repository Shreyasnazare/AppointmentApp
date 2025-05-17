using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace AppointmentAPI.Models.Doctor
{
    public class DoctorModelReq
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string? Email { get; set; }

        [Required]
        public string? Qualification { get; set; }
        [Required]
        public DateOnly? DOB { get; set; }
        [Required]
        public string? Contact { get; set; }
        [Required]
        public DateOnly? CareerStart { get; set; }
        [Required]
        public double? ConsultingFees { get; set; }
        [Required]

        public string? Hospital { get; set; }

        
        public IFormFile? ImageFile { get; set; }
    }


    public class DoctorModelRes
    {

        
        public string? DoctorID { get; set; }

        
        public string? FirstName { get; set; }

        
        public string? LastName { get; set; }

       
        public string? Email { get; set; }

      
        public string? Qualification { get; set; }
        
        public DateOnly? DOB { get; set; }
        
        public string? Contact { get; set; }
        
        public DateOnly? CareerStart { get; set; }
       
        public double? ConsultingFees { get; set; }
     

        public string? Hospital { get; set; }

       
        public string? Image { get; set; }
    }

}
