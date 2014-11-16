namespace Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using PagedList;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Web.Models.CourseraEntity;
    using Web.Models.Profile;

    public class CourseraController : Controller
    {
        private readonly UserManager<Profile> userManager = new UserManager<Profile>(new UserStore<Profile>(new BdContext()));

        // GET: Coursera
        public ActionResult Index(int page = 1)
        {
            Profile user = userManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {                
                var coursesForCurrUser = user.ProfileCriteria.Where(x => x.Criteria.Parent == null).Select(x => x.Criteria).SelectMany(x => x.Courses).ToList();

                var courseMaterials = coursesForCurrUser.Select(course => new CourseraMaterial
                {
                    Name = course.Name,
                    Description = course.ShortDescription,
                    AboutTheCourse = course.AboutTheCourse,
                    LargeIcon = course.LargeIcon,
                    SmallIcon = course.SmallIcon
                }).ToList();

                int pageSize = 5;
                return View(courseMaterials.ToPagedList(page, pageSize));

            }

            return RedirectToAction("Index", "Home"); // заглушка (переделать)
        }
    }
}