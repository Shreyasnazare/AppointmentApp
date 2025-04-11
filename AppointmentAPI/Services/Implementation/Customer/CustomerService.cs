using AppointmentAPI.DAL.Entity.Customer;
using AppointmentAPI.Models.Customer;
using AppointmentAPI.Repository.Interface.Customer;
using AppointmentAPI.Services.Interface.Customer;
using AppointmentAPI.Models.Customer.Customer.DTO;


namespace AppointmentAPI.Services.Implementation.Customer
{
    public class CustomerService : Service<CustomerDetails>, ICustomerService
    {
        ICustomerRepository _repo;
        public CustomerService(ICustomerRepository repo) : base(repo)
        {
            _repo = repo;
            
        }

        public CustomerModel GetCustomerByEmail(string email)
        {
            var custDetails = _repo.GetCustomerByEmail(email);

            if (custDetails != null)
            {
                return AppointmentAPI.Models.Customer.Customer.DTO.CustomerDTO.CustomerDTOMap(custDetails);
            }
            return null;

        }
    }
}
