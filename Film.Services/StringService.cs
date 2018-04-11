using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Film.Services;
using Film.Models;
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
namespace Film.Services
{
    public class StringService
    {
        private readonly IMovieService _movieService;

        public StringService(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public  IEnumerable<Models.Actor> GetAscendingOrder()
        {

            var result = _movieService.GetItemList().Result.ToList();
            var roles = result.SelectMany(s => s.Roles).OrderBy(m => m.Name).OrderBy(o => o.Name).GroupBy(g => g.Actor).Select(s => new Actor() { Name = s.Key, Roles = s.ToList() });

            if (result.Count == 0)
               return null;//roles;

            return roles;
        }
    }
}
