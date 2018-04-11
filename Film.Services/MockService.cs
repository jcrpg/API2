using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Film.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Film.Services
{
    public class MockService : IMovieService
    {
        public Task<IEnumerable<Models.Movie>> GetItemList()
        {
            //or a list of movie List<Movie>
            var jsonString = "[{ 'name':'Beverly Hills Cop','roles':[{'name':'Axel Foley','actor':'Eddie Murphy'},{'name':'Billy Rosewood','actor':'Judge Reinhold'},{'name':'Sgt. Taggart','actor':'John Ashton'},{'name':'Jenny Summers','actor':'Lisa Eilbacher'},{'name':'Mikey Tandino','actor':''}]},{'name':'Stand By Me','roles':[{'name':'Gorgie Lachance','actor':'Wil Wheaton'},{'name':'Chris Chambers','actor':'River Phoenix'},{'name':'Teddy Duchamp','actor':'Corey Feldman'},{'name':'Ace Merrill','actor':'Keifer Sutherland'},{'name':'The Writer','actor':'Richard Dreyfuss'}]},{'name':'Star Trek','roles':[{'name':'Romulan','actor':'Wil Wheaton'},{'name':'Kirk','actor':'Chris Pine'},{'name':'Nero','actor':'Eric Bana'},{'name':'Spock','actor':'Leonard Nimoy'},{'name':'Scotty','actor':'Simon Pegg'},{'name':'Amanda Grayson','actor':'Winona Ryder'}]},{'name':'Family Guy','roles':[{'name':'Meg Griffin','actor':'Mila Kunis'},{'name':'Meg Griffin','actor':'Mila Kunis'},{'name':'Chris Griffin','actor':'Seth Green'},{'name':'Luke Skywalker','actor':'Seth Green'},{'name':'Joe Swanson'},{'name':'Lois Griffin','actor':'Alex Borstein'}]}]";

             IEnumerable<Models.Movie> movieData = JsonConvert.DeserializeObject<IEnumerable<Models.Movie>>(jsonString);

            //"[{""name"":""MovieA"",""roles"":[{""name"":""Axel Foley"",""actor"":""Eddie Murphy""},{""name"":""Gorgie Lachance"",""actor"":""Judge Reinhold""},{""name"":""Jenny Summers"",""actor"":""Lisa Eilbacher""},{""name"":""Mikey Tandino"",""actor"":""}]},{""name"":""MovieB"",""roles"":[{""name"":""Billy Rosewood"",""actor"":""Judge Reinhold""},{""name"":""Chris Chambers"",""actor"":""River Phoenix""},{""name"":""Teddy Duchamp"",""actor"":""Corey Feldman""},{""name"":""Ace Merrill"",""actor"":""Keifer Sutherland""},{""name"":""The Writer"",""actor"":""Richard Dreyfuss""}]}]";
            return Task.FromResult<IEnumerable<Models.Movie>>(movieData);
        }
    }
}
