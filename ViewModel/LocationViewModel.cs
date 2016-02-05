using Entity;
using System.Collections.Generic;

namespace ViewModel
{
    public class LocationViewModel
    {

        public int? Country { get; set; }
        public int? City { get; set; }
        public List<Country> Countries { get; set; }

        public List<City> Cities { get; set; }
    }
}
