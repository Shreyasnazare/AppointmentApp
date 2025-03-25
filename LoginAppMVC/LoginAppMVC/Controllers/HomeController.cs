using System.Diagnostics;
using System.Security.Claims;
using LoginAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;
using Microsoft.Graph.Admin.Edge.InternetExplorerMode.SiteLists.Item.Publish;
using Microsoft.Identity.Client;

namespace LoginAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var cliams = User.Claims;

            var groupIDs = User.Claims.Select(x => x.Type == "groups").ToList();
            if (groupIDs != null)
            {

            }

            var roles = User.FindAll(ClaimTypes.Role)
                        .Select(r => r.Value)
                        .ToList();
            var userName = User.Identity.Name;// This will give you the logged-in user's name
            return View(model: userName);
        }

        //public async Task<List<string>> GetGroupNames(List<string> objectIDs)
        //{
        //    var graphClient = new GraphServiceClient(
        //    new DelegateAuthenticationProvider(
        //        async (requestMessage) =>
        //        {
        //            requestMessage.Headers.Authorization =
        //                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", result.AccessToken);
        //        }
        //    )
        //);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
