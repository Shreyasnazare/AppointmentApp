using System.ComponentModel.DataAnnotations;

namespace AppointmentAPI.DAL.Entity
{
    public class CustomerDetails
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public string ActiveYN { get; set; }
    }
}
