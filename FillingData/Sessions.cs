namespace Testing.FillingData
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Testing.CourseraEntity;

    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutSessions()
        {
            var url = "https://api.coursera.org/api/catalog.v1/sessions?fields=id,courseId,homeLink,status,active,durationString,startDay,startMonth," +
            "startYear,name,signatureTrackCloseTime,signatureTrackOpenTime,signatureTrackPrice,signatureTrackRegularPrice,eligibleForCertificates" +
                      ",eligibleForSignatureTrack,certificateDescription,certificatesReady";

            var res = GetDataFromSomeUrl(url);
            var resultList = JsonConvert.DeserializeObject<List<Session>>(res);
            

            if (resultList.Count > 0)
            {
                using (var uowTmp = new UnitOfWork.UnitOfWork())
                {
                    foreach (var session in resultList)
                    {
                        uowTmp.SessionRepository.Add(session);
                    }
                    uowTmp.Save();
                }
            }
        }
    }
}