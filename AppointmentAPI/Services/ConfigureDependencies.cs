using AppointmentAPI.DAL;
using AppointmentAPI.DAL.Entity;
using AppointmentAPI.Repository.Implementation;
using AppointmentAPI.Repository.Interface;
using AppointmentAPI.Services.Implementation;
using AppointmentAPI.Services.Interface;
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
         


            //Services
            services.AddScoped<ICustomerService, CustomerService>();
         
           
        }
    }
}
