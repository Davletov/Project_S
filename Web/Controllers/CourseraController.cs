using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Helpers;
using Web.Models;

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
        public async Task<ActionResult> Index(int page = 1)
        {
            Profile user = userManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {                
                var coursesForCurrUser = user.ProfileCriteria.Select(x => x.Criteria).Take(5).SelectMany(x => x.Courses).ToList();
                
                List<IMaterial> result = new List<IMaterial>();

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
                int pageSize = 5;
                
                return View(result.ToPagedList(page, 10));
            }

            return RedirectToAction("Index", "Home"); // заглушка (переделать)
        }
    }
}