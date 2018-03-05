using System.Linq;
using System.Web.Mvc;

namespace bootcamp_3tiers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult List()
        {
            DetailsRepository details = new DetailsRepository();
            var userDetails = details.GetDetails();
            return View(userDetails);
        }
    }
}
