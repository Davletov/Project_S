using System.Diagnostics;
using System.Linq;

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

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var url = "https://api.coursera.org/api/catalog.v1/categories?fields=id,name,shortName,description";

            try
            {
                var res = GetDataFromSomeUrl(url);
                var resultList = JsonConvert.DeserializeObject<List<Category>>(res);
            
                if (resultList.Count > 0)
                {
                    // Если в таблице Category уже есть какие то данные, то удалим их
                    using (var uowDel = new UnitOfWork())
                    {
                        var categoryList = uowDel.CategoryRepository.Get().Select(x => x.CategoryId).ToList();
                        var countRowsInExistingBase = categoryList.Count;
                        if (countRowsInExistingBase > 0)
                        {
                            foreach (var categoryId in categoryList)
                            {
                                uowDel.CategoryRepository.Delete(categoryId);
                            }

                            uowDel.Save();
                        }
                    }

                    // Заполняем таблице Category данным с Coursera Api
                    using (var uowTmp = new UnitOfWork())
                    {
                        foreach (var category in resultList)
                        {
                            uowTmp.CategoryRepository.Add(category);
                        }

                        uowTmp.Save();
                    }
                }

                stopWatch.Stop();

                Console.WriteLine("Загрузка инфы по Категориям с Coursera Api прошла успешно !");

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
    }
}