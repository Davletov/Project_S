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
        /// Связываем курсы с категориями
        /// </summary>
        public static void BindingCoursesForEachCategory()
        {
            // Url к апи, ктр достает все категории и связанные с ними курсы
            // (вытаскиваем только необходимые данные: CategoryIdFromApi и список курсов)
            var url = "https://api.coursera.org/api/catalog.v1/categories?fields=id&includes=courses";

            var res = GetDataFromSomeUrl2(url); // преобразуем в корректный JSON
            var resultList = JsonConvert.DeserializeObject<List<SpecialCategoryProxy>>(res); // превращаем в объект SpecialCategoryProxy

            using (var uow = new UOfW.UnitOfWork())
            {
                // для каждой категории
                foreach (var category in resultList)
                {
                    var categ = category; // категория со списком курсов

                    // CategoryIdFromApi - глобальный идентификатор Категорий (внутренняя идентификация в Coursera API)
                    // Находим в нашей базе категорию по идентификатору CategoryIdFromApi (в ней список курсов пока Null)
                    var findCategory = uow.CategoryRepository.Get(x => x.CategoryIdFromApi == categ.CategoryIdFromApi).FirstOrDefault();
                    if (findCategory != null && categ.Courses != null)
                    {
                        var listToCopy = categ.Courses;
                        findCategory.Courses = new Collection<Course>();
                        foreach (var course in listToCopy)
                        {
                            // находим в нашей базе соотв.курс
                            var addCourse = uow.CourseRepository.Get(x => x.CourseIdFromApi == course.CourseIdFromApi).FirstOrDefault();

                            // и добавляем его в список Courses в сущности Категория
                            if (addCourse != null)
                            {
                                findCategory.Courses.Add(addCourse);
                            }
                        }
                        uow.CategoryRepository.Update(findCategory);
                    }
                }
                uow.Save();
            }
        }

        /// <summary>
        /// Сокращенная версия класса Category, необходим для связки с курсами
        /// </summary>
        private class SpecialCategoryProxy
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
