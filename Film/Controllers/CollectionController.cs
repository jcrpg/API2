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

            //var result = await new MovieService().GetItemList();
            //var restut  = new StringService(new MobieService());
            //result.GetAscendingOrder
            //var roles = result.SelectMany(s => s.Roles).OrderBy(m=> m.Name).OrderBy(o => o.Name).GroupBy(g=> g.Actor).Select(s=> new Actor(){ Name = s.Key, Roles = s.ToList() });

            return output;

        }
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

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