using AppointmentAPI.DAL.Entity.Customer;

namespace AppointmentAPI.Repository.Interface.Customer
{
    public interface ICustomerRepository : IRepository<CustomerDetails>
    {
        CustomerDetails GetCustomerByEmail(string email);


    }
}
