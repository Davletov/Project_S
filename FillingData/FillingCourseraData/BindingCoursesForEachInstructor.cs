using System.Diagnostics;
using Web.DataAccess.Repository;

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
        /// Связываем курсы с инструкторами
        /// </summary>
        public static void BindingCoursesForEachInstructor()
        {
            Console.WriteLine("\nСвязывание курсов с инструкторами ...");

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            // Url к апи, ктр достает всех инструкторов и связанные с ними курсы
            // (вытаскиваем только необходимые данные: InstructorIdFromApi и список курсов)
            var url = "https://api.coursera.org/api/catalog.v1/instructors?fields=id&includes=courses";

            try
            {
                var res = GetDataFromSomeUrl2(url); // преобразуем в корректный JSON
                var resultList = JsonConvert.DeserializeObject<List<SpecialInstructorProxy>>(res); // превращаем в объект SpecialInstructorProxy

                using (var uow = new UnitOfWork())
                {
                    // для каждого инструктора
                    foreach (var instructor in resultList)
                    {
                        var instr = instructor; // инструктор со списком курсов

                        // InstructorIdFromApi - глобальный идентификатор Инструкторов (внутрення идентификация в Coursera API)
                        // Находим в нашей базе инструктора по идентификатору InstructorIdFromApi (в нем список курсов пока Null)
                        var findinstr =
                            uow.Repository<Instructor>().Get(x => x.InstructorIdFromApi == instr.InstructorIdFromApi)
                                .FirstOrDefault();
                        if (findinstr != null && instr.Courses != null)
                        {
                            var listToCopy = instr.Courses;
                            findinstr.Courses = new Collection<Course>();

                            foreach (var course in listToCopy)
                            {
                                // находим в нашей базе соотв.курс
                                var addCourse =
                                    uow.Repository<Course>().Get(x => x.CourseIdFromApi == course.CourseIdFromApi)
                                        .FirstOrDefault();

                                // и добавляем его в список Courses в сущности Инструктор
                                if (addCourse != null)
                                {
                                    findinstr.Courses.Add(addCourse);
                                }
                            }

                            uow.Repository<Instructor>().Update(findinstr);
                        }
                    }

                    uow.Commit();
                }

                stopWatch.Stop();
                Console.WriteLine("Связывание курсов с инструкторами прошло успешно !");

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
        /// Сокращенная версия класса Instructor, необходим для связки с курсами
        /// </summary>
        private class SpecialInstructorProxy
        {
            /// <summary>
            /// Instructor Id (public Id for identity with Instructor Id from Coursera API
            /// </summary>
            [JsonProperty("id")]
            public int InstructorIdFromApi { get; set; }

            /// <summary>
            /// Связка многие ко многим (Категория <-> Курсы)
            /// Каждая категория (Пр.: математика) может иметь несколько курсов
            /// Каждый курс (Пр.: Математические методы в экономике) может относится к нескольких категориям 
            /// </summary>
            [JsonProperty("courses")]
            //[JsonConverter(typeof(ConvertToCourse))]
            public ICollection<Course> Courses { get; set; }
        }

    }
}
