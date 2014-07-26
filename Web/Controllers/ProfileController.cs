using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ProfileController : Controller
    {
        //
        // GET: /Profile/
        public new ActionResult Profile()
        {
            return View();
        }
	}
}