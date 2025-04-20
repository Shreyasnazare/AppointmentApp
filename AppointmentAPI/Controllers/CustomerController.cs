using AppointmentAPI.DAL.Entity;
using AppointmentAPI.Models.Customer;
using AppointmentAPI.Models.Customer.Customer.DTO;
using AppointmentAPI.Models.Response;
using AppointmentAPI.Services.Implementation;
using AppointmentAPI.Services.Interface.Customer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppointmentAPI.Controllers
{
    [ApiController]
    [Route("api/Customer")]
    
    public class CustomerController : BaseController
    {
        ICustomerService _custService;
        public    CustomerController(ICustomerService custService) {
            _custService = custService;
        }


        // GET: api/<CustomerController>
        
        [HttpGet("GetCustomerByEmail/{email}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResponseV2<CustomerModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetCustomerByEmail(string email)
        {
            try
            {
                var user = _custService.GetCustomerByEmail(email);
                if (user == null)
                {
                    return Ok(new ResponseV2<CustomerModel>
                    {
                        message = "Customer does not exists.",                       
                        success = false,
                        Data = null
                    });
                }
                return Ok(new ResponseV2<CustomerModel>
                {
                    message = "Customer details fetched successfully.",                       
                    success = true,
                    Data = user
                });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { message = "An unexpected error occurred at GetCustomerByEmail.", error = ex.Message });
            }
        }

       

        // POST api/<CustomerController>
        [HttpPost("CreateCustomer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult CreateCustomer([FromBody] CustomerModel customer)
        {

            try
            {
                var cust = _custService.GetCustomerByEmail(customer.Email);
                if (cust == null)
                {
                    var customerDBDetails = Models.Customer.Customer.DTO.CustomerDTO.CustomerDTOMapReverse(customer);
                    customerDBDetails.ActiveYN = "Y";
                    _custService.Insert(customerDBDetails);
                    _custService.SaveChanges();
                    return Ok(new Response
                    {
                        message = "Customer created successfully."    ,                       
                        success = true
                    }); 
                }
                else
                {
                    return Ok(new Response
                    {
                        message = "Customer already exists.",                       
                        success = false
                    });
                }
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An unexpected error occurred at CreateCustomer.", error = ex.Message });
            }

        }



        [HttpPost("UpdateCustomer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult UpdateCustomer([FromBody] CustomerModel customer)
        {

            try
            {
               
                    
                 var res =  _custService.UpdateCustomer(customer);
                return Ok(res);
                

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An unexpected error occurred at UpdateCustomer.", error = ex.Message });
            }

        }


    }
}
