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
        public HttpResponseMessage Get(int id)
        {
            var result = repo.GetDetails(id);

            if (result.Output != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result.Output);
            }

            return Request.CreateResponse(HttpStatusCode.NotFound, result.Message);
           
        }
    }
}
