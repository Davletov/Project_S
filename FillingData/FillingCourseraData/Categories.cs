namespace FiilingData.FillingCourseraData
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Web.Models.CourseraEntity;
    using Web.UnitOfWork;

    /// <summary>
    /// Скрипт для заполнения данными локальной бд о категориях курсов с coursera.org 
    /// </summary>
    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutCategories()
        {
            Console.WriteLine("\nЗагрузка инфы по Категориям с Coursera Api ...");

            var url = "https://api.coursera.org/api/catalog.v1/categories?fields=id,name,shortName,description";

            try
            {
                var res = GetDataFromSomeUrl(url);
                var resultList = JsonConvert.DeserializeObject<List<Category>>(res);
            
                if (resultList.Count > 0)
                {
                    using (var uowTmp = new UnitOfWork())
                    {
                        foreach (var category in resultList)
                        {
                            uowTmp.CategoryRepository.Add(category);
                        }

                        uowTmp.Save();
                    }
                }

                Console.WriteLine("Загрузка инфы по Категориям с Coursera Api прошла успешно !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some exception: {0}", ex.Message);
                throw;
            }

        }
    }
}