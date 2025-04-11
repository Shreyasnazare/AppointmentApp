using AppointmentAPI.DAL.Entity.Customer;
using AppointmentAPI.DAL.Entity.Doctor;
using Microsoft.EntityFrameworkCore;

namespace AppointmentAPI.DAL
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        { }

        public DbSet<CustomerDetails> Customer { get; set; }

        public DbSet<DoctorDetails> DoctorDetails { get; set; }

    }
}
