namespace Testing.FillingData
{
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Testing.CourseraEntity;
    using UOfW = Testing.UnitOfWork;

    public static partial class FillingDataFromCoursera
    {
        /// <summary>
        /// Связываем курсы с категориями
        /// </summary>
        public static void BindingCoursesForEachCategory()
        {
            // Url к апи, ктр достает все категории и связанные с ними курсы
            var url = "https://api.coursera.org/api/catalog.v1/categories?fields=id,name,shortName,description&includes=courses";

            var res = GetDataFromSomeUrl2(url); // преобразуем в корректный JSON
            var resultList = JsonConvert.DeserializeObject<List<Category>>(res); // превращаем в объект Category

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
                        uow.CategoryRepository.Update(findCrs);
                    }
                }
                uow.Save();
            }
        }

    }
}
