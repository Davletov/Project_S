using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Testing.CourseraEntity;

namespace Testing.FillingData
{
    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutInstructors()
        {
            var url = "https://api.coursera.org/api/catalog.v1/instructors?fields=id,photo,photo150,bio,prefixName,firstName,middleName,lastName," +
            "suffixName,fullName,title,department,website,websiteTwitter,websiteFacebook,websiteLinkedin,websiteGplus,shortName";

            var res = GetDataFromSomeUrl(url);
            var resultList = JsonConvert.DeserializeObject<List<Instructor>>(res);


            if (resultList.Count > 0)
            {
                using (var uowTmp = new UnitOfWork.UnitOfWork())
                {
                    foreach (var instructor in resultList)
                    {
                        uowTmp.InstructorRepository.Add(instructor);
                    }
                    uowTmp.Save();
                }
            }
        }
    }
}