namespace FiilingData.FillingCourseraData
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Web.Models.CourseraEntity;
    using Web.UnitOfWork;

    /// <summary>
    /// Скрипт для заполнения данными локальной бд о курса с coursera.org 
    /// </summary>
    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutCourses()
        {
            Console.WriteLine("\nЗагрузка инфы по Курсам с Coursera Api ...");

            var url = "https://api.coursera.org/api/catalog.v1/courses?fields=id,shortName,name,language,largeIcon,photo,previewLink,shortDescription," +
                "smallIcon,smallIconHover,subtitleLanguagesCsv,isTranslate,universityLogo,universityLogoSt,video,videoId,aboutTheCourse,targetAudience," +
                "faq,courseSyllabus,courseFormat,suggestedReadings,instructor,estimatedClassWorkload,aboutTheInstructor,recommendedBackground";

            try
            {
                var res = GetDataFromSomeUrl(url);
                var resultList = JsonConvert.DeserializeObject<List<Course>>(res);

                if (resultList.Count > 0)
                {
                    using (var uowTmp = new UnitOfWork())
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

                Console.WriteLine("Загрузка инфы по Курсам с Coursera Api прошла успешно !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some exception: {0}", ex.Message);
                throw;
            }
        }
    }
}