using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Film.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public List<Role> Roles { get; set; }
    }

    public class Role
    {
        public string Name { get; set; }
        public string Actor { get; set; }
    }
}