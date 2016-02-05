using Business.Impl;
using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModel;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Ajax/
        public ActionResult Index()
        {
            var viewModel = new LocationViewModel();
            viewModel.Countries = new List<Country>() {
                new Country() { Id=1,Name="Turkey"},
                new Country() { Id=2,Name="Russia"},
                new Country() { Id=3,Name="Sweden"},

            };
            viewModel.Cities = new  List<City>();
            return View(viewModel);
        }


        public async Task<JsonResult> GetCities(string countryId)
        {
            return await Task.Run(() => GetCitiesInternal(countryId));
        }

        private JsonResult GetCitiesInternal(string countryId)
        {
            var result = new CityBusiness().GetCitiesByCountryId(int.Parse(countryId));
            if (result == null)
            {
                result = new List<City>();
            } 
            else
                result.Insert(0, new City() { Id = 0, Name = "Select" });
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}