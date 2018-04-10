using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Film.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Film.Services
{
    public class WebClientManager
    {
        public static async Task<List<Movie>> GetItemList()
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

                        var movieList = response.Content.ReadAsAsync<List<Movie>>().Result;

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