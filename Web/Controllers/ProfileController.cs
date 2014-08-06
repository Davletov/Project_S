using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class ProfileController : Controller
    {
        //
        // GET: /Profile/
        public new ActionResult Profile()
        {
            var countryList = new List<Country>();
            using (var uow = new UnitOfWork.UnitOfWork())
            {
                countryList = uow.CountryRepository.Get().ToList();
            }

            ViewData["countryList"] = countryList;

            return View();
        }
	}
}