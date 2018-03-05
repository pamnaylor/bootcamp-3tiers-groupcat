using Api.Models;
using Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
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
