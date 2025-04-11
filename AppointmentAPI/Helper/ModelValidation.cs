using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using AppointmentAPI.Models.Response;


namespace AppointmentAPI.Helper
{




    public class ManualModelValidationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errorMessages = context.ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                string combinedErrors = string.Join(" | ", errorMessages);

                var response = new Response
                {
                    success = false,
                    message = combinedErrors
                };
                context.Result = new BadRequestObjectResult(response);
            }






        }
    }

}
