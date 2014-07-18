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
        /// Связываем курсы с инструкторами
        /// </summary>
        public static void BindingCoursesForEachInstructor()
        {
            // Url к апи, ктр достает всех инструкторов и связанные с ними курсы
            // (вытаскиваем только необходимые данные: InstructorIdFromApi и список курсов)
            var url = "https://api.coursera.org/api/catalog.v1/instructors?fields=id&includes=courses";

            var res = GetDataFromSomeUrl2(url); // преобразуем в корректный JSON
            var resultList = JsonConvert.DeserializeObject<List<SpecialInstructorProxy>>(res); // превращаем в объект SpecialInstructorProxy

            using (var uow = new UOfW.UnitOfWork())
            {
                // для каждого инструктора
                foreach (var instructor in resultList)
                {
                    var crs = instructor;

                    // InstructorIdFromApi - глобальный идентификатор Инструкторов (внутрення идентификация в Coursera API)
                    var findCrs = uow.InstructorRepository.Get(x => x.InstructorIdFromApi == crs.InstructorIdFromApi).FirstOrDefault();
                    if (findCrs != null)
                    {
                        findCrs.Courses = crs.Courses; // присваиваем курсы по соотв.инструкторам
                        uow.InstructorRepository.Update(findCrs);
                    }
                }
                uow.Save();
            }
        }

        /// <summary>
        /// Сокращенная версия класса Instructor, необходим для связки с курсами
        /// </summary>
        private abstract class SpecialInstructorProxy
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
            [JsonConverter(typeof(ConvertToCourse))]
            public ICollection<Course> Courses { get; set; }
        }

    }
}
