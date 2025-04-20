using AppointmentAPI.DAL.Entity.Customer;
using AppointmentAPI.Models.Customer;
using AppointmentAPI.Models.Response;

namespace AppointmentAPI.Services.Interface.Customer
{
    public interface ICustomerService : IService<CustomerDetails>
    {

        CustomerModel GetCustomerByEmail(string email);
         Response UpdateCustomer(CustomerModel req);

    }
}
