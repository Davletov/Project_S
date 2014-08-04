﻿using System.Linq;

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
                    // Если в таблице University уже есть какие то данные, то удалим их
                    using (var uowDel = new UnitOfWork())
                    {
                        var universityList = uowDel.UniversityRepository.Get().Select(x => x.UniversityId).ToList();
                        var countRowsInExistingBase = universityList.Count;
                        if (countRowsInExistingBase > 0)
                        {
                            foreach (var universityId in universityList)
                            {
                                uowDel.SessionRepository.Delete(universityId);
                            }

                            uowDel.Save();
                        }
                    }

                    // Заполняем таблице University данным с Coursera Api
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