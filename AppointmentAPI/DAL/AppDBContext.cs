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

        public DbSet<DoctorSlots> DoctorSlots { get; set; }

        public DbSet<TimeSlots> TimeSlots { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DoctorRating>().HasNoKey();
            modelBuilder.Entity<DoctorSpecialisation>().HasNoKey();  // use this when we dont want to register in APP dB context but to use this model for raw queries like stored procedure
        }

    }
}
