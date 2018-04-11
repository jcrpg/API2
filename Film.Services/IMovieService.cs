using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Film.Models;

namespace Film.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Models.Movie>> GetItemList();

    }
}
