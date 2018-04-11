using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Film.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Helpers;
using Film.Models;
using Film.Services;

namespace Film.Services
{
    public class MovieService:IMovieService
    {
        public async Task<IEnumerable<Models.Movie>> GetItemList()
        {

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.GetAsync("https://alintacodingtest.azurewebsites.net/api/Movies", HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                    if (response.IsSuccessStatusCode)
                    {

                        var movieList = response.Content.ReadAsAsync<List<Models.Movie>>().Result;

                        return movieList;

                    }

                }
            }
            catch (HttpRequestException ex)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            throw new HttpResponseException(HttpStatusCode.NoContent);

        }
    }
}