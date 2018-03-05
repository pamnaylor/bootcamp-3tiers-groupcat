using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repositories
{
    public class DetailsRepository
    {
        private List<Details> detailsList = new List<Details>
        {
            new Details { Id = 1, FirstName = "Pam", LastName = "Naylor", Age = 29, Nationality = "British" },
            new Details { Id = 2, FirstName = "James", LastName = "Whiteley", Age = 21, Nationality = "British" },
            new Details { Id = 3, FirstName = "Moh Moh", LastName = "Oo", Age = 33, Nationality = "Burmese" }
        };

        public IEnumerable<Details> GetDetails()
        {
            return detailsList;
        }
    }
}