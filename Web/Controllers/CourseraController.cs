namespace Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Web.Models.CourseraEntity;
    using Web.Models.Profile;

    public class CourseraController : Controller
    {
        private readonly UserManager<Profile> userManager = new UserManager<Profile>(new UserStore<Profile>(new BdContext()));

        // GET: Coursera
        public ActionResult Index()
        {
            Profile user = userManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                var secondLevCourses =
                    user.SecondLevelCriteria.Select(x => x.Criteria).SelectMany(x => x.Courses).ToList();
                var thirdLevCourses =
                    user.ThirdLevelCriteria.Select(x => x.Criteria).SelectMany(x => x.Courses).ToList();
                var coursesForCurrUser = secondLevCourses.Union(thirdLevCourses).ToList();

                var courseMaterials = coursesForCurrUser.Select(course => new CourseraMaterial
                {
                    Name = course.Name,
                    Description = course.ShortDescription,
                    AboutTheCourse = course.AboutTheCourse,
                    LargeIcon = course.LargeIcon
                }).ToList();

                return View(courseMaterials);

            }

            return RedirectToAction("Index", "Home"); // заглушка (переделать)
        }
    }
}