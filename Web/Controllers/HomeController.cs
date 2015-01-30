using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using PagedList;
using Web.Helpers;
using Web.Models;
using Web.Models.CourseraEntity;
using Web.Models.Profile;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;  

namespace Web.Controllers
{
  
    [RequireHttps]
    public class HomeController : Controller
    {
        private readonly UserManager<Profile> userManager = new UserManager<Profile>(new UserStore<Profile>(new BdContext()));

        public async Task<ActionResult> Index(int page = 1)
        {
            Profile user = userManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                var coursesForCurrUser = user.ProfileCriteria.Select(x => x.Criteria).Take(5).SelectMany(x => x.Courses).ToList();

                var result = new List<IMaterial>();

                var courseMaterials = coursesForCurrUser.Select(course => new CourseraMaterial
                {
                    Name = course.Name,
                    Description = course.ShortDescription,
                    AboutTheCourse = course.AboutTheCourse,
                    LargeIcon = course.LargeIcon,
                    SmallIcon = course.SmallIcon
                }).ToList();


                var yotubeMaterials = await YoutubeHelper.GetMaterials(User);

                result.AddRange(courseMaterials);
                result.AddRange(yotubeMaterials);

                return View(result.ToPagedList(page, 20));
            }

            return RedirectToAction("Login", "Account"); 
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