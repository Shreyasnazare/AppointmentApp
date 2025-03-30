using AppointmentAPI.DAL.Entity;
using AppointmentAPI.Models;
using AppointmentAPI.Repository.Interface;
using AppointmentAPI.Services.Interface;
using AppointmentAPI.Models.DTO;

namespace AppointmentAPI.Services.Implementation
{
    public class CustomerService : Service<CustomerDetails>,ICustomerService
    {
        ICustomerRepository _repo;
        public CustomerService(ICustomerRepository repo) : base(repo) {
           _repo = repo;

        }

        public Customer GetCustomerByEmail(string email) {
            var custDetails = _repo.GetCustomerByEmail(email);

            if (custDetails != null)
            {
                return CustomerDTO.CustomerDTOMap(custDetails);
            }
            return null;

        }
    }
}
