using System.Collections.Generic;
using Business.Interface;
using Entity;

namespace Business.Impl
{
    public class CityBusiness : ICityBusiness
    {
        public List<City> GetCitiesByCountryId(int countryId)
        {
            var cityList = new List<City>();
            switch (countryId)
            {
                case 1:
                    {
                        cityList.Add(new City() { Id = 1, CountryId=countryId,Name="İstanbul"});
                        cityList.Add(new City() { Id = 2, CountryId = countryId, Name = "Ankara" });
                        cityList.Add(new City() { Id = 3, CountryId = countryId, Name = "İzmir" });
                        break;
                    }
                case 2:
                    {
                        cityList.Add(new City() { Id = 1, CountryId = countryId, Name = "Moscow" });
                        cityList.Add(new City() { Id = 2, CountryId = countryId, Name = "Saint Petersburg" });
                        cityList.Add(new City() { Id = 3, CountryId = countryId, Name = "Murmansk" });
                        break;
                    }
                case 3:
                    {
                        cityList.Add(new City() { Id = 1, CountryId = countryId, Name = "Stockholm" });
                        cityList.Add(new City() { Id = 2, CountryId = countryId, Name = "Malmo" }); 
                        break;
                    }
            }
            return cityList;
        }
    }
}
