using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace bootcamp_3tiers.Controllers
{
    public class Details
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Nationality { get; set; }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public async Task<ActionResult> List()
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
