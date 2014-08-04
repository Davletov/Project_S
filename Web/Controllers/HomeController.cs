using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Web.Models;
using Web.Models.CourseraEntity;

namespace Web.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Для тестового вывода всех курсов на главную страничку из категории 'химия'
            var resultCourses = new List<Course>();
            string userId = User.Identity.GetUserId();
            Profile currentProfile;
            using (var uow = new UnitOfWork.UnitOfWork())
            {
                currentProfile = uow.ProfileRepository.Get(x => x.UserId == userId).FirstOrDefault();
            }

            using (var uow = new UnitOfWork.UnitOfWork())
            {
                //var criterias = currentProfile.UserCriterias.Select(x => x.Name).ToList();

                /*foreach (var criteria in criterias)
                {
                    var tmp = uow.CourseRepository.Get(x => x.ShortName.Contains(criteria) || x.Name.Contains(criteria)).ToList();
                    resultCourses.AddRange(tmp);
                }*/
            }

            ViewData["chemistryCourses"] = resultCourses;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Blog page";

            return View();
        }

        public ActionResult Support()
        {
            ViewBag.Message = "Support page";

            return View();
        }
    }
}