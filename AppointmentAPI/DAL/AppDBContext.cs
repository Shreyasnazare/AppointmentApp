using AppointmentAPI.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace AppointmentAPI.DAL
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        { }

        public DbSet<CustomerDetails> Customer { get; set; }

    }
}
