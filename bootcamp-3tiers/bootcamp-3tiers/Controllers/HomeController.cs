using bootcamp_3tiers.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace bootcamp_3tiers.Controllers
{
    public class HomeController : Controller
    {
        private string apiUrl;
        public HomeController()
        {
            apiUrl = ConfigurationManager.AppSettings.Get("ApiUrl");
        }
        public async Task<ActionResult> Index()
        {
            var userDetails = await GetDetails();
            return View(userDetails);
        }

        public async Task<ActionResult> Details(int id)
        {
            var userDetails = await GetDetails(id);
            return View(userDetails);
        }

        private async Task<IEnumerable<Details>> GetDetails()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{apiUrl}api/values");
            return await response.Content.ReadAsAsync<IEnumerable<Details>>();
        }

        private async Task<Details> GetDetails(int id)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{apiUrl}api/values/{id}");
            return await response.Content.ReadAsAsync<Details>();
        }

    }
}
