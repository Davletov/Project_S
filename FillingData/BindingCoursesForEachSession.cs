namespace Testing.FillingData
{
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Testing.CourseraEntity;
    using UOfW = Testing.UnitOfWork;
    using Testing.Helpful;
    using System.Collections.ObjectModel;

    public static partial class FillingDataFromCoursera
    {
        /// <summary>
        /// Связываем курсы с сессиями
        /// </summary>
        public static void BindingCoursesForEachSession()
        {
            // Url к апи, ктр достает все сессии и связанные с ними курсы
            // (вытаскиваем только необходимые данные: SessionIdFromApi и список курсов)
            var url = "https://api.coursera.org/api/catalog.v1/sessions?fields=id&includes=courses";

            var res = GetDataFromSomeUrl2(url); // преобразуем в корректный JSON
            var resultList = JsonConvert.DeserializeObject<List<SpecialSessionProxy>>(res); // превращаем в объект SpecialSessionProxy

            using (var uow = new UOfW.UnitOfWork())
            {
                // для каждой сессии
                foreach (var session in resultList)
                {
                    var sessn = session; // сессия со списком курсов

                    // SessionIdFromApi - глобальный идентификатор Сессий (внутренняя идентификация в Coursera API)
                    // Находим в нашей базе сессию по идентификатору SessionIdFromApi (в нем список курсов пока Null)
                    var findSessn = uow.SessionRepository.Get(x => x.SessionIdFromApi == sessn.SessionIdFromApi).FirstOrDefault();
                    if (findSessn != null && sessn.Courses != null)
                    {
                        var listToCopy = sessn.Courses;
                        findSessn.Courses = new Collection<Course>();

                        foreach (var course in listToCopy)
                        {
                            // находим в нашей базе соотв.курс
                            var addCourse = uow.CourseRepository.Get(x => x.CourseIdFromApi == course.CourseIdFromApi).FirstOrDefault();

                            // и добавляем его в список Courses в сущности Сессия
                            if (addCourse != null)
                            {
                                findSessn.Courses.Add(addCourse);
                            }
                        }
                        uow.SessionRepository.Update(findSessn);
                    }
                }
                uow.Save();
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
