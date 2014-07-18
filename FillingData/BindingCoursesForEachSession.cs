namespace Testing.FillingData
{
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Testing.CourseraEntity;
    using UOfW = Testing.UnitOfWork;
    using Testing.Helpful;

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
                    var crs = session;

                    // SessionIdFromApi - глобальный идентификатор Сессий (внутренняя идентификация в Coursera API)
                    var findCrs = uow.SessionRepository.Get(x => x.SessionIdFromApi == crs.SessionIdFromApi).FirstOrDefault();
                    if (findCrs != null)
                    {
                        findCrs.Courses = crs.Courses; // присваиваем курсы по соотв.сессии
                        uow.SessionRepository.Update(findCrs);
                    }
                }
                uow.Save();
            }
        }

        /// <summary>
        /// Сокращенная версия класса Session, необходим для связки с курсами
        /// </summary>
        private abstract class SpecialSessionProxy
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
