using AppointmentAPI.DAL.Entity.Customer;
using AppointmentAPI.Models.Customer;
using AppointmentAPI.Repository.Interface.Customer;
using AppointmentAPI.Services.Interface.Customer;
using AppointmentAPI.Models.Customer.Customer.DTO;
using AppointmentAPI.Models.Response;
using Microsoft.EntityFrameworkCore;


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


        public Response UpdateCustomer(CustomerModel req)
        {
            var custDetails = _repo.GetCustomerByEmail(req.Email);
            var customerID = custDetails.CustomerID;
            if (custDetails != null)
            {
         
                custDetails = Models.Customer.Customer.DTO.CustomerDTO.CustomerDTOMapReverse(req, custDetails);
                custDetails.CustomerID = customerID;
                _repo.Update(custDetails);
                _repo.SaveChanges();
                return new Response
                {
                    message = "Customer updated successfully.",
                    success = true
                };

            }
            return new Response
            {
                message = "Customer does not exists.",
                success = false
            };

        }
    }
}
