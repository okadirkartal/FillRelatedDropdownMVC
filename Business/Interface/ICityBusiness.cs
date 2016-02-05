using Entity;
using System.Collections.Generic;

namespace Business.Interface
{
    public interface ICityBusiness
    {
         List<City>  GetCitiesByCountryId(int countryId);
    }
}
