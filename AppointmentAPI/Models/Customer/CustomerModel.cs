using System.ComponentModel.DataAnnotations;

namespace AppointmentAPI.Models.Customer
{
    public class CustomerModel
    {


        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? DOB { get; set; }

        [Required]
        public string? Contact { get; set; }
    }
}
