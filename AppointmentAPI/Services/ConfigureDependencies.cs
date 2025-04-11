using AppointmentAPI.DAL;
using AppointmentAPI.DAL.Entity.Customer;
using AppointmentAPI.DAL.Entity.Doctor;
using AppointmentAPI.Repository.Implementation;
using AppointmentAPI.Repository.Implementation.Customer;
using AppointmentAPI.Repository.Implementation.Doctor;
using AppointmentAPI.Repository.Interface;
using AppointmentAPI.Repository.Interface.Customer;
using AppointmentAPI.Repository.Interface.Doctor;
using AppointmentAPI.Services.Implementation.Customer;
using AppointmentAPI.Services.Implementation.Doctor;
using AppointmentAPI.Services.Interface.Customer;
using AppointmentAPI.Services.Interface.Doctor;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace AppointmentAPI.Services
{
    public static class ConfigureDependencies
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {

            //DB
            services.AddDbContext<AppDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            });

            //Repository
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        
            services.AddScoped<IRepository<CustomerDetails>, Repository<CustomerDetails>>();

            services.AddScoped<IDoctorRepository, DoctorRepository>();

            services.AddScoped<IRepository<DoctorDetails>, Repository<DoctorDetails>>();



            //Services
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IDoctorService, DoctorService>();


        }
    }
}
