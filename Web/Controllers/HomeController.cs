using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Web.Models.CourseraEntity;

namespace Web.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Для тестового вывода всех курсов на главную страничку из категории 'химия'
            var chemistryCourses = new List<Course>();
            using (var uow = new UnitOfWork.UnitOfWork())
            {
                chemistryCourses = uow.CourseRepository.Get(x => x.ShortName.Contains("chemistry") || x.Name.Contains("chemistry")).ToList();
            }

            ViewData["chemistryCourses"] = chemistryCourses;

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