using System.ComponentModel.DataAnnotations;

namespace AppointmentAPI.DAL.Entity.Customer
{
    public class CustomerDetails
    {
        [Key]
        public long CustomerID { get; set; }


        public string? FirstName { get; set; }


        public string? LastName { get; set; }


        public string? Email { get; set; }


        public string? Address { get; set; }


        public DateTime? DOB { get; set; }


        public string? Contact { get; set; }


        public string? ActiveYN { get; set; }
    }
}
