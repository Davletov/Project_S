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
        /// Связываем курсы с категориями
        /// </summary>
        public static void BindingCoursesForEachCategory()
        {
            // Url к апи, ктр достает все категории и связанные с ними курсы
            // (вытаскиваем только необходимые данные: CategoryIdFromApi и список курсов)
            var url = "https://api.coursera.org/api/catalog.v1/categories?ids=19&fields=id&includes=courses";

            var res = GetDataFromSomeUrl2(url); // преобразуем в корректный JSON
            var resultList = JsonConvert.DeserializeObject<List<SpecialCategoryProxy>>(res); // превращаем в объект SpecialCategoryProxy

            using (var uow = new UOfW.UnitOfWork())
            {
                // для каждой категории
                foreach (var category in resultList)
                {
                    var crs = category;

                    // CategoryIdFromApi - глобальный идентификатор Категорий (внутрення идентификация в Coursera API)
                    var findCrs = uow.CategoryRepository.Get(x => x.CategoryIdFromApi == crs.CategoryIdFromApi).FirstOrDefault();
                    if (findCrs != null)
                    {
                        findCrs.Courses = crs.Courses; // присваиваем курсы по соотв.категории
                        //uow.CategoryRepository.Update(findCrs);
                    }
                }
                //uow.Save();
            }
        }

        /// <summary>
        /// Сокращенная версия класса Category, необходим для связки с курсами
        /// </summary>
        private abstract class SpecialCategoryProxy
        {
            /// <summary>
            /// Category Id (public Id for identity with Category Id from Coursera API
            /// </summary>
            [JsonProperty("id")]
            public int CategoryIdFromApi { get; set; }

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
