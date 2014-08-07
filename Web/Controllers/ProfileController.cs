namespace Web.Controllers
{
    using System.Web.Mvc;

    public class ProfileController : Controller
    {
        //
        // GET: /Profile/
        public new ActionResult Profile()
        {
            ViewData["countryList"] = LocationController.GetCountries();

            return View();
        }
	}
}