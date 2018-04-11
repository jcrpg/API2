using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public  IEnumerable<Actor> GetAscendingOrder()
        {

            var result = _movieService.GetItemList().Result.ToList();
            var roles = result.SelectMany(s => s.Roles).OrderBy(m => m.Name).OrderBy(o => o.Name).GroupBy(g => g.Actor).Select(s => new Actor() { Name = s.Key, Roles = s.ToList() });

            if (result.Count == 0)
               return null;;

            return roles;
        }

    }
}
