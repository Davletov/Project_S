using System.Collections.Generic;
using Newtonsoft.Json;
using Testing.CourseraEntity;

namespace Testing.FillingData
{
    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutCategories()
        {
            var url = "https://api.coursera.org/api/catalog.v1/categories?fields=id,name,shortName,description";

            var res = GetDataFromSomeUrl(url);
            var resultList = JsonConvert.DeserializeObject<List<Category>>(res);


            if (resultList.Count > 0)
            {
                using (var uowTmp = new UnitOfWork.UnitOfWork())
                {
                    foreach (var category in resultList)
                    {
                        uowTmp.CategoryRepository.Add(category);
                    }
                    uowTmp.Save();
                }
            }

        }
    }
}