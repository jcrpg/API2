using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Film.Models;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Film.Services;
using Film.Models;

namespace Film.Controllers
{
    public class CollectionController : ApiController
    {
        // GET api/<controller>

        public async Task<IEnumerable<Models.Actor>> GetMovies()
        {
            var service = new StringService(new MovieService());
            var output = service.GetAscendingOrder();

            return output;

        }


        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}