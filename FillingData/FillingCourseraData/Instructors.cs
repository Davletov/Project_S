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
    /// Скрипт для заполнения данными локальной бд о инструкторах курсов с coursera.org 
    /// </summary>
    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutInstructors()
        {
            Console.WriteLine("\nЗагрузка инфы по Инструкторам с Coursera Api ...");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var url = "https://api.coursera.org/api/catalog.v1/instructors?fields=id,photo,photo150,bio,prefixName,firstName,middleName,lastName," +
            "suffixName,fullName,title,department,website,websiteTwitter,websiteFacebook,websiteLinkedin,websiteGplus,shortName";

            try
            {
                var res = GetDataFromSomeUrl(url);
                var resultList = JsonConvert.DeserializeObject<List<Instructor>>(res);

                if (resultList.Count > 0)
                {
                    // Если в таблице Instructor уже есть какие то данные, то удалим их
                    using (var uowDel = new UnitOfWork())
                    {
                        var instructorList = uowDel.InstructorRepository.Get().Select(x => x.InstructorId).ToList();
                        var countRowsInExistingBase = instructorList.Count;
                        if (countRowsInExistingBase > 0)
                        {
                            foreach (var instructorId in instructorList)
                            {
                                uowDel.InstructorRepository.Delete(instructorId);
                            }

                            uowDel.Save();
                        }
                    }

                    // Заполняем таблице Instructor данным с Coursera Api
                    using (var uowTmp = new UnitOfWork())
                    {
                        foreach (var instructor in resultList)
                        {
                            uowTmp.InstructorRepository.Add(instructor);
                        }

                        uowTmp.Save();
                    }
                }

                stopWatch.Stop();

                Console.WriteLine("Загрузка инфы по Инструкторам с Coursera Api прошла успешно !");

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