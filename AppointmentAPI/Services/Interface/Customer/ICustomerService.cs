using AppointmentAPI.DAL.Entity.Customer;
using AppointmentAPI.Models.Customer;

namespace AppointmentAPI.Services.Interface.Customer
{
    public interface ICustomerService : IService<CustomerDetails>
    {

        CustomerModel GetCustomerByEmail(string email);

    }
}
