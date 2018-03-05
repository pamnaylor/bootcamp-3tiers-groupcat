using bootcamp_3tiers.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace bootcamp_3tiers.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var userDetails = await GetDetailsList();
            return View(userDetails);
        }

        private async Task<IEnumerable<Details>> GetDetailsList()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("http://localhost:50824/api/values");
            return await response.Content.ReadAsAsync<IEnumerable<Details>>();
        }
    }
}
