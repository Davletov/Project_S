using System.Diagnostics;
using Web.DataAccess.Repository;
using Web.Helpful;

namespace FiilingData.FillingCourseraData
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Newtonsoft.Json;    
    using Web.Models.CourseraEntity;    

    public static partial class FillingDataFromCoursera
    {
        /// <summary>
        /// Связываем курсы с сессиями
        /// </summary>
        public static void BindingCoursesForEachSession()
        {
            Console.WriteLine("\nСвязывание курсов с сессиями ...");

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            // Url к апи, ктр достает все сессии и связанные с ними курсы
            // (вытаскиваем только необходимые данные: SessionIdFromApi и список курсов)
            var url = "https://api.coursera.org/api/catalog.v1/sessions?fields=id&includes=courses";

            try
            {
                var res = GetDataFromSomeUrl2(url); // преобразуем в корректный JSON
                var resultList = JsonConvert.DeserializeObject<List<SpecialSessionProxy>>(res); // превращаем в объект SpecialSessionProxy

                using (var uow = new UnitOfWork())
                {
                    // для каждой сессии
                    foreach (var session in resultList)
                    {
                        var sessn = session; // сессия со списком курсов

                        // SessionIdFromApi - глобальный идентификатор Сессий (внутренняя идентификация в Coursera API)
                        // Находим в нашей базе сессию по идентификатору SessionIdFromApi (в нем список курсов пока Null)
                        var findSessn =
                            uow.Repository<Session>().Get(x => x.SessionIdFromApi == sessn.SessionIdFromApi)
                                .FirstOrDefault();
                        if (findSessn != null && sessn.Courses != null)
                        {
                            var listToCopy = sessn.Courses;
                            findSessn.Courses = new Collection<Course>();

                            foreach (var course in listToCopy)
                            {
                                // находим в нашей базе соотв.курс
                                var addCourse =
                                    uow.Repository<Course>().Get(x => x.CourseIdFromApi == course.CourseIdFromApi)
                                        .FirstOrDefault();

                                // и добавляем его в список Courses в сущности Сессия
                                if (addCourse != null)
                                {
                                    findSessn.Courses.Add(addCourse);
                                }
                            }

                            uow.Repository<Session>().Update(findSessn);
                        }
                    }

                    uow.Commit();
                }

                stopWatch.Stop();

                Console.WriteLine("Связывание курсов с сессиями прошло успешно !");

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

        /// <summary>
        /// Сокращенная версия класса Session, необходим для связки с курсами
        /// </summary>
        private class SpecialSessionProxy
        {
            /// <summary>
            /// Session Id (public Id for identity with Session Id from Coursera API
            /// </summary>
            [JsonProperty("id")]
            public int SessionIdFromApi { get; set; }

            /// <summary>
            /// Связка многие ко многим (Категория <-> Курсы)
            /// Каждая категория (Пр.: математика) может иметь несколько курсов
            /// Каждый курс (Пр.: Математические методы в экономике) может относится к нескольких категориям 
            /// </summary>
            [JsonProperty("courses")]
            [JsonConverter(typeof(ConvertToCourse))]
            public ICollection<Course> Courses { get; set; }
        }

    }
}
