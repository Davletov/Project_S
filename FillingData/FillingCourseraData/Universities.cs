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
    /// Скрипт для заполнения данными локальной бд о универах курсов с coursera.org 
    /// </summary>
    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutUniversities()
        {
            Console.WriteLine("\nЗагрузка инфы по Университетам с Coursera Api ...");

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var url = "https://api.coursera.org/api/catalog.v1/universities?fields=id,name,shortName,description,banner,homeLink,location,locationCity," +
            "locationState,locationCountry,locationLat,locationLng,classLogo,website,websiteTwitter" +
                      ",websiteFacebook,websiteYoutube,logo,squareLogo,landingPageBanner";

            try
            {
                var res = GetDataFromSomeUrl(url);
                var resultList = JsonConvert.DeserializeObject<List<University>>(res);
            
                if (resultList.Count > 0)
                {
                    // Если в таблице University уже есть какие то данные, то удалим их
                    using (var uowDel = new UnitOfWork())
                    {
                        var universityList = uowDel.Repository<University>().Get().Select(x => x.UniversityId).ToList();
                        var countRowsInExistingBase = universityList.Count;
                        if (countRowsInExistingBase > 0)
                        {
                            foreach (var universityId in universityList)
                            {
                                uowDel.Repository<Session>().Delete(universityId);
                            }

                            uowDel.Commit();
                        }
                    }

                    // Заполняем таблице University данным с Coursera Api
                    using (var uowTmp = new UnitOfWork())
                    {
                        foreach (var university in resultList)
                        {
                            uowTmp.Repository<University>().Add(university);
                        }

                        uowTmp.Commit();
                    }
                }

                stopWatch.Stop();

                Console.WriteLine("Загрузка инфы по Университетам с Coursera Api прошла успешно !");

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