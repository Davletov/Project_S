using System.Diagnostics;
using System.Linq;

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

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var url = "https://api.coursera.org/api/catalog.v1/courses?fields=id,shortName,name,language,largeIcon,photo,previewLink,shortDescription," +
                "smallIcon,smallIconHover,subtitleLanguagesCsv,isTranslate,universityLogo,universityLogoSt,video,videoId,aboutTheCourse,targetAudience," +
                "faq,courseSyllabus,courseFormat,suggestedReadings,instructor,estimatedClassWorkload,aboutTheInstructor,recommendedBackground";

            try
            {
                var res = GetDataFromSomeUrl(url);
                var resultList = JsonConvert.DeserializeObject<List<Course>>(res);

                if (resultList.Count > 0)
                {
                    // Если в таблице Course уже есть какие то данные, то удалим их
                    using (var uowDel = new UnitOfWork())
                    {
                        var courseList = uowDel.CourseRepository.Get().Select(x => x.CourseId).ToList();
                        var countRowsInExistingBase = courseList.Count;
                        if (countRowsInExistingBase > 0)
                        {
                            foreach (var courseId in courseList)
                            {
                                uowDel.CourseRepository.Delete(courseId);
                            }

                            uowDel.Save();
                        }
                    }

                    // Заполняем таблице Course данным с Coursera Api
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

                stopWatch.Stop();

                Console.WriteLine("Загрузка инфы по Курсам с Coursera Api прошла успешно !");

                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;
                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("RunTime " + elapsedTime);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some exception: {0}", ex.Message);
                throw;
            }
        }
    }
}