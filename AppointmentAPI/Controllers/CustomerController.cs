using AppointmentAPI.Models;
using AppointmentAPI.Models.DTO;
using AppointmentAPI.Services.Implementation;
using AppointmentAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppointmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _custService;
        public    CustomerController(ICustomerService custService) {
            _custService = custService;
        }


        // GET: api/<CustomerController>
        [HttpGet]
        public Customer GetCustomerByEmail(string email)
        {
            try
            {
               return _custService.GetCustomerByEmail(email);
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        // POST api/<CustomerController>
        [HttpPost]
        public void CreateCustomer([FromBody] Customer customer)
        {

            try
            {               
                _custService.Insert(CustomerDTO.CustomerDTOMapReverse(customer));
                _custService.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

       
    }
}
