using System.Diagnostics;
using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingCourseraData
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Web.Models.CourseraEntity;    

    /// <summary>
    /// Скрипт для заполнения данными локальной бд о категориях курсов с coursera.org 
    /// </summary>
    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutCategories()
        {
            Console.WriteLine("\nЗагрузка инфы по Категориям с Coursera Api ...");

            var stopWatch = new Stopwatch();
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
                        var categoryList = uowDel.Repository<Category>().Get().Select(x => x.CategoryId).ToList();
                        var countRowsInExistingBase = categoryList.Count;
                        if (countRowsInExistingBase > 0)
                        {
                            foreach (var categoryId in categoryList)
                            {
                                uowDel.Repository<Category>().Delete(categoryId);
                            }

                            uowDel.Commit();
                        }
                    }

                    // Заполняем таблице Category данным с Coursera Api
                    using (var uowTmp = new UnitOfWork())
                    {
                        foreach (var category in resultList)
                        {
                            uowTmp.Repository<Category>().Add(category);
                        }

                        uowTmp.Commit();
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