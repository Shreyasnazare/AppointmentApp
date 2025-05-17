using Microsoft.AspNetCore.Mvc;
using AppointmentAPI.Models.Response;
using AppointmentAPI.Services.Interface.Customer;
using AppointmentAPI.Repository.Interface.Doctor;
using AppointmentAPI.Services.Interface.Doctor;
using AppointmentAPI.Models.Doctor;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using AppointmentAPI.Models.Customer;
using AppointmentAPI.Helper;
using AppointmentAPI.DAL.Entity.Doctor;
namespace AppointmentAPI.Controllers
{
    /*[ApiController]  // Commented this because the 
    attributre auto generates the
    400 bad request whenever a required ,
    mandatory or email formatted type is incorrect or blank field is sent as blank */
    [Route("api/Doctor")]

    public class DoctorController : BaseController
    {


        IDoctorService _drService;
        IDoctorSlotService _drSlotService;
        public DoctorController(IDoctorService drService,IDoctorSlotService drSlotService)
        {
            _drService = drService;
            _drSlotService = drSlotService;
        }

        [HttpPost("CreateDoctor")]
        [ManualModelValidation] // 👈 disables auto-400 validation and use customer Model Validation here
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AppointmentAPI.Models.Response.Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateDoctor([FromForm] DoctorModelReq req)
        {
            try
            {

                return Ok(await _drService.InsertDoctorDetail(req));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An unexpected error occurred at CreateDoctor.", error = ex.Message });
            }
        }


        [HttpPost("UpdateDoctor")]
        [ManualModelValidation] // 👈 disables auto-400 validation and use customer Model Validation here
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AppointmentAPI.Models.Response.Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateDoctor([FromForm] DoctorModelReq req)
        {
            try
            {
                return Ok(await _drService.UpdateDoctorDetail(req));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An unexpected error occurred at UpdateDoctor.", error = ex.Message });
            }
        }


        [HttpGet("GetAllDoctor")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResponseV2<List<DoctorModelRes>>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAllDoctor()
        {
            try
            {

                return Ok(_drService.GetAllDoctor());


            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An unexpected error occurred at GetAllDoctor.", error = ex.Message });
            }
        }




        [HttpGet("GetDoctorByEmail/{email}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResponseV2<DoctorModelRes>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetDoctorByEmail([FromRoute] string email)
        {
            try
            {
                return Ok(_drService.GetDoctorByEmail(email));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An unexpected error occurred at GetDoctorByEmail.", error = ex.Message });
            }
        }

        [HttpGet("GetDoctorDetails/{doctorID}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResponseV2<DoctorModelRes>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetDoctorDetails([FromRoute] string doctorID)
        {
            try
            {
                return Ok(_drService.Get(long.Parse(doctorID)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An unexpected error occurred at GetDoctorDetails.", error = ex.Message });
            }
        }


        [HttpGet("GetDoctorSlots/{doctorID}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DoctorSlotsTiming))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetDoctorSlots([FromRoute] string doctorID)
        {
            try
            {
                return Ok(_drSlotService.GetDoctorSlots(doctorID));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An unexpected error occurred at GetDoctorSlots.", error = ex.Message });
            }
        }


        [HttpGet("GetDoctorRatings/{doctorID}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DoctorRating))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetDoctorRatings([FromRoute] string doctorID)
        {
            try
            {
                return Ok(_drService.GetDoctorRatings(doctorID));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An unexpected error occurred at GetDoctorRatings.", error = ex.Message });
            }
        }


        [HttpGet("GetDoctorSpecialisation/{doctorID}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DoctorSpecialisation))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetDoctorSpecialisation([FromRoute] string doctorID)
        {
            try
            {
                return Ok(_drService.GetDoctorSpecialisation(doctorID));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An unexpected error occurred at GetDoctorSpecialisation.", error = ex.Message });
            }
        }

    }
}
