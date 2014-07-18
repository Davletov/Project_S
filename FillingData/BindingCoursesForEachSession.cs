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
        /// Связываем курсы с сессиями
        /// </summary>
        public static void BindingCoursesForEachSession()
        {
            // Url к апи, ктр достает все сессии и связанные с ними курсы
            var url = "https://api.coursera.org/api/catalog.v1/sessions?fields=id,courseId,homeLink,status,active,durationString,startDay,startMonth," +
            "startYear,name,signatureTrackCloseTime,signatureTrackOpenTime,signatureTrackPrice,signatureTrackRegularPrice,eligibleForCertificates" +
                      ",eligibleForSignatureTrack,certificateDescription,certificatesReady&includes=courses";

            var res = GetDataFromSomeUrl2(url); // преобразуем в корректный JSON
            var resultList = JsonConvert.DeserializeObject<List<Session>>(res); // превращаем в объект Session

            using (var uow = new UOfW.UnitOfWork())
            {
                // для каждой сессии
                foreach (var session in resultList)
                {
                    var crs = session;

                    // SessionIdFromApi - глобальный идентификатор Сессий (внутренняя идентификация в Coursera API)
                    var findCrs = uow.SessionRepository.Get(x => x.SessionIdFromApi == crs.SessionIdFromApi).FirstOrDefault();
                    if (findCrs != null)
                    {
                        findCrs.Courses = crs.Courses; // присваиваем курсы по соотв.сессии
                        uow.SessionRepository.Update(findCrs);
                    }
                }
                uow.Save();
            }
        }

    }
}
