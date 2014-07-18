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
        /// Связываем курсы с университетами
        /// </summary>
        public static void BindingCoursesForEachUniversity()
        {
            // Url к апи, ктр достает все университеты и связанные с ними курсы
            var url = "https://api.coursera.org/api/catalog.v1/universities?fields=id,name,shortName,description,banner,homeLink,location,locationCity," +
                      "locationState,locationCountry,locationLat,locationLng,classLogo,website,websiteTwitter" +
                      ",websiteFacebook,websiteYoutube,logo,squareLogo,landingPageBanner&includes=courses";

            var res = GetDataFromSomeUrl2(url); // преобразуем в корректный JSON
            var resultList = JsonConvert.DeserializeObject<List<University>>(res); // превращаем в объект University

            using (var uow = new UOfW.UnitOfWork())
            {
                // для каждого универа
                foreach (var university in resultList)
                {
                    var crs = university;

                    // InstructorIdFromApi - глобальный идентификатор Университетов (внутрення идентификация в Coursera API)
                    var findCrs = uow.UniversityRepository.Get(x => x.UniversityIdFromApi == crs.UniversityIdFromApi).FirstOrDefault();
                    if (findCrs != null)
                    {
                        findCrs.Courses = crs.Courses; // присваиваем курсы по соотв.университетам
                        uow.UniversityRepository.Update(findCrs);
                    }
                }
                uow.Save();
            }
        }

    }
}
