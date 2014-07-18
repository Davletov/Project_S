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
        /// Связываем курсы с инструкторами
        /// </summary>
        public static void BindingCoursesForEachInstructor()
        {
            // Url к апи, ктр достает всех инструкторов и связанные с ними курсы
            var url = "https://api.coursera.org/api/catalog.v1/instructors?fields=id,photo,photo150,bio,prefixName,firstName,middleName,lastName," +
            "suffixName,fullName,title,department,website,websiteTwitter,websiteFacebook,websiteLinkedin,websiteGplus,shortName&includes=courses";

            var res = GetDataFromSomeUrl2(url); // преобразуем в корректный JSON
            var resultList = JsonConvert.DeserializeObject<List<Instructor>>(res); // превращаем в объект Instructor

            using (var uow = new UOfW.UnitOfWork())
            {
                // для каждого инструктора
                foreach (var instructor in resultList)
                {
                    var crs = instructor;

                    // InstructorIdFromApi - глобальный идентификатор Инструкторов (внутрення идентификация в Coursera API)
                    var findCrs = uow.InstructorRepository.Get(x => x.InstructorIdFromApi == crs.InstructorIdFromApi).FirstOrDefault();
                    if (findCrs != null)
                    {
                        findCrs.Courses = crs.Courses; // присваиваем курсы по соотв.инструкторам
                        uow.InstructorRepository.Update(findCrs);
                    }
                }
                uow.Save();
            }
        }

    }
}
