namespace FiilingData.FillingCourseraData
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Web.Models.CourseraEntity;
    using Web.UnitOfWork;

    /// <summary>
    /// Скрипт для заполнения данными локальной бд о универах курсов с coursera.org 
    /// </summary>
    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutUniversities()
        {
            Console.WriteLine("\nЗагрузка инфы по Университетам с Coursera Api ...");
            var url = "https://api.coursera.org/api/catalog.v1/universities?fields=id,name,shortName,description,banner,homeLink,location,locationCity," +
            "locationState,locationCountry,locationLat,locationLng,classLogo,website,websiteTwitter" +
                      ",websiteFacebook,websiteYoutube,logo,squareLogo,landingPageBanner";

            try
            {
                var res = GetDataFromSomeUrl(url);
                var resultList = JsonConvert.DeserializeObject<List<University>>(res);
            
                if (resultList.Count > 0)
                {
                    using (var uowTmp = new UnitOfWork())
                    {
                        foreach (var university in resultList)
                        {
                            uowTmp.UniversityRepository.Add(university);
                        }

                        uowTmp.Save();
                    }
                }

                Console.WriteLine("Загрузка инфы по Университетам с Coursera Api прошла успешно !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some exception: {0}", ex.Message);
                throw;
            }
        }
    }
}