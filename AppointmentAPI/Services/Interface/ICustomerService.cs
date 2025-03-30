using AppointmentAPI.DAL.Entity;
using AppointmentAPI.Models;

namespace AppointmentAPI.Services.Interface
{
    public interface ICustomerService : IService<CustomerDetails>
    {

        Customer GetCustomerByEmail(string email);

    }
}
