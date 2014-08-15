using System.Diagnostics;

namespace FiilingData.FillingCourseraData
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Newtonsoft.Json;
    using Web.Helpful;
    using Web.Models.CourseraEntity;
    using Web.UnitOfWork;

    public static partial class FillingDataFromCoursera
    {
        /// <summary>
        /// Связываем курсы с университетами
        /// </summary>
        public static void BindingCoursesForEachUniversity()
        {
            Console.WriteLine("\nСвязывание курсов с университетами ...");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Url к апи, ктр достает все университеты и связанные с ними курсы
            // (вытаскиваем только необходимые данные: UniversityIdFromApi и список курсов)
            var url = "https://api.coursera.org/api/catalog.v1/universities?fields=id&includes=courses";

            var res = GetDataFromSomeUrl2(url); // преобразуем в корректный JSON
            var resultList = JsonConvert.DeserializeObject<List<SpecialUniversityProxy>>(res); // превращаем в объект SpecialUniversityProxy

            try
            {
                using (var uow = new UnitOfWork())
                {
                    // для каждого универа
                    foreach (var university in resultList)
                    {
                        var univer = university; // универ со списком курсов

                        // UniversityIdFromApi - глобальный идентификатор Университетов (внутрення идентификация в Coursera API)
                        // Находим в нашей базе университет по идентификатору UniversityIdFromApi (в нем список курсов пока Null)
                        var findUniver =
                            uow.UniversityRepository.Get(x => x.UniversityIdFromApi == univer.UniversityIdFromApi)
                                .FirstOrDefault();
                        if (findUniver != null && univer.Courses != null)
                        {
                            var listToCopy = univer.Courses;
                            findUniver.Courses = new Collection<Course>();

                            foreach (var course in listToCopy)
                            {
                                // находим в нашей базе соотв.курс
                                var addCourse =
                                    uow.CourseRepository.Get(x => x.CourseIdFromApi == course.CourseIdFromApi)
                                        .FirstOrDefault();

                                // и добавляем его в список Courses в сущности Университет
                                if (addCourse != null)
                                {
                                    findUniver.Courses.Add(addCourse);
                                }
                            }

                            uow.UniversityRepository.Update(findUniver);
                        }
                    }

                    uow.Save();
                }

                stopWatch.Stop();

                Console.WriteLine("Связывание курсов с университетами прошло успешно !");

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
        /// Сокращенная версия класса University, необходим для связки с курсами
        /// </summary>
        private class SpecialUniversityProxy
        {
            /// <summary>
            /// University Id (public Id for identity with University Id from Coursera API
            /// </summary>
            [JsonProperty("id")]
            public int UniversityIdFromApi { get; set; }

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
