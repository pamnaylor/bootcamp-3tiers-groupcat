using System;
using System.Collections.Generic;
using System.Web.Http;

namespace bootcamp_3tiers.Controllers
{
    public class Details
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Nationality { get; set; }
    }

    public class DetailsRepository
    {
        private List<Details> detailsList = new List<Details>
        {
            new Details { FirstName = "Pam", LastName = "Naylor", Age = 29, Nationality = "British" },
            new Details { FirstName = "James", LastName = "Whiteley", Age = 21, Nationality = "British" },
            new Details { FirstName = "Moh Moh", LastName = "Oo", Age = 33, Nationality = "Burmese" }
        };

        public IEnumerable<Details> GetDetails()
        {
            return detailsList;
        }
    }
    public class ValuesController : ApiController
    {
        private DetailsRepository repo = new DetailsRepository();
        public ValuesController()
        {

        }
            // GET api/values
        public IEnumerable<Details> Get()
        {
            return repo.GetDetails();
        }



        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
