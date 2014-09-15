namespace Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using System.Collections.Generic;
    using Microsoft.AspNet.Identity;
    using Web.Models.Location;
    
    /// <summary>
    /// Контроллер для обработки Страны и города в профайле пользователя
    /// </summary>
    public class LocationController : Controller
    {
        /// <summary>
        /// Список всех стран
        /// </summary>
        /// <returns></returns>
        public static List<Country> GetCountries()
        {
            List<Country> countryList;
            using (var uow = new UnitOfWork.UnitOfWork())
            {
                countryList = uow.CountryRepository.Get().ToList();
            }
            return countryList;
        }

        /// <summary>
        /// Список всех городов выбранной страны
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Cities(int countryId)
        {
            var cities = new List<CityProxy>();
            var currentUserId = User.Identity.GetUserId();
            int cityId = 0;
            using (var uow = new UnitOfWork.UnitOfWork())
            {
                cities = uow.CityRepository.Get(x => x.Country.CountryId == countryId)
                    .Select(x =>
                        new CityProxy
                        {
                            CityId = x.CityId,
                            Name = x.Name,
                        })
                        .ToList();

                if (currentUserId != null)
                {
                    cityId = uow.ProfileRepository.GetById(currentUserId).City;
                }
            }

            var data = new SelectList(cities, "CityId", "Name");

            return Json(new { data, cityId });
        }

        private class CityProxy
        {
            public int CityId { get; set; }
            public string Name { get; set; }
        }
    }
}