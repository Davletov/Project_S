using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using Newtonsoft.Json;
using Testing.CourseraEntity;
using UOfW = Testing.UnitOfWork;

namespace Testing.FillingData
{
    public static partial class FillingDataFromCoursera
    {
        public static void Testing()
        {
            var url =
                "https://api.coursera.org/api/catalog.v1/courses?ids=2&fields=id,shortName,name,language,largeIcon,photo,previewLink,shortDescription," +
                "smallIcon,smallIconHover,subtitleLanguagesCsv,isTranslate,universityLogo,universityLogoSt,video,videoId,aboutTheCourse,targetAudience," +
                "faq,courseSyllabus,courseFormat,suggestedReadings,instructor,estimatedClassWorkload,aboutTheInstructor,recommendedBackground&includes=categories";

            var res = GetDataFromSomeUrl2(url);
            var resultList = JsonConvert.DeserializeObject<List<Course>>(res);

            var tmp2 = new Course();
            using (var uow = new UOfW.UnitOfWork())
            {
                foreach (var course in resultList)
                {
                    var crs = course;
                    var findCrs =
                        uow.CourseRepository.Get(x => x.CourseIdFromApi == crs.CourseIdFromApi).FirstOrDefault();
                    if (findCrs != null)
                    {
                        findCrs.Categories = crs.Categories;
                        uow.CourseRepository.Update(findCrs);
                    }
                    tmp2 = findCrs;
                }
                uow.Save();
            }
            var tmp = res;
        }

        public static void GetCoursesForEachCategory()
        {
            var url = "https://api.coursera.org/api/catalog.v1/categories?ids=17&fields=id,name,shortName,description&includes=courses";

            var res = GetDataFromSomeUrl2(url);
            var resultList = JsonConvert.DeserializeObject<List<Category>>(res);

            var tmp2 = new Category();
            using (var uow = new UOfW.UnitOfWork())
            {
                foreach (var category in resultList)
                {
                    var crs = category;
                    var findCrs =
                        uow.CategoryRepository.Get(x => x.CategoryIdFromApi == crs.CategoryIdFromApi).FirstOrDefault();
                    if (findCrs != null)
                    {
                        findCrs.Courses = crs.Courses;
                        uow.CategoryRepository.Update(findCrs);
                    }
                    tmp2 = findCrs;
                }
                uow.Save();
            }
            var tmp = res;
        }

    }
}
