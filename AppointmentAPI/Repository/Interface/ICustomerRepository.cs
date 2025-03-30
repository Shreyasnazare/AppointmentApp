using AppointmentAPI.DAL.Entity;

namespace AppointmentAPI.Repository.Interface
{
    public interface ICustomerRepository : IRepository<CustomerDetails> 
    {
        CustomerDetails GetCustomerByEmail(string email);
       

    }
}
