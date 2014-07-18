namespace Testing.FillingData
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Testing.CourseraEntity;

    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutUniversities()
        {
            var url = "https://api.coursera.org/api/catalog.v1/universities?fields=id,name,shortName,description,banner,homeLink,location,locationCity," +
            "locationState,locationCountry,locationLat,locationLng,classLogo,website,websiteTwitter" +
                      ",websiteFacebook,websiteYoutube,logo,squareLogo,landingPageBanner";

            var res = GetDataFromSomeUrl(url);
            var resultList = JsonConvert.DeserializeObject<List<University>>(res);


            if (resultList.Count > 0)
            {
                using (var uowTmp = new UnitOfWork.UnitOfWork())
                {
                    foreach (var university in resultList)
                    {
                        uowTmp.UniversityRepository.Add(university);
                    }
                    uowTmp.Save();
                }
            }
        }
    }
}