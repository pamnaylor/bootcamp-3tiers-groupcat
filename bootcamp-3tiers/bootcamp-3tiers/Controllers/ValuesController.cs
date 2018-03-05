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
            new Details { FirstName = "", LastName = "", Age = 1, Nationality = "" }
        };

        public IEnumerable<Details> GetDetails()
        {
            return detailsList;
        }
    }
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }



        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
