namespace Testing.FillingData
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Testing.CourseraEntity;
    using UOfW = Testing.UnitOfWork;

    /// <summary>
    /// Скрипты, для заполнения данными локальной бд о курса с coursera.org 
    /// </summary>
    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutCourses()
        {
            var url = "https://api.coursera.org/api/catalog.v1/courses?fields=id,shortName,name,language,largeIcon,photo,previewLink,shortDescription," +
          "smallIcon,smallIconHover,subtitleLanguagesCsv,isTranslate,universityLogo,universityLogoSt,video,videoId,aboutTheCourse,targetAudience," +
          "faq,courseSyllabus,courseFormat,suggestedReadings,instructor,estimatedClassWorkload,aboutTheInstructor,recommendedBackground";
            
            var res = GetDataFromSomeUrl(url);
            var resultList = JsonConvert.DeserializeObject<List<Course>>(res);

            if (resultList.Count > 0)
            {
                using (var uowTmp = new UOfW.UnitOfWork())
                {
                    foreach (var course in resultList)
                    {
                        if (course != null)
                        {
                            uowTmp.CourseRepository.Add(course);
                        }
                    }
                    uowTmp.Save();
                }
            }
        }
    }
}