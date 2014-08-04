using System.Linq;

namespace FiilingData.FillingCourseraData
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Web.Models.CourseraEntity;
    using Web.UnitOfWork;

    /// <summary>
    /// Скрипт для заполнения данными локальной бд о сессиях(сроки курсов) с coursera.org 
    /// </summary>
    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutSessions()
        {
            Console.WriteLine("\nЗагрузка инфы по Сессиям с Coursera Api ...");

            var url = "https://api.coursera.org/api/catalog.v1/sessions?fields=id,courseId,homeLink,status,active,durationString,startDay,startMonth," +
            "startYear,name,signatureTrackCloseTime,signatureTrackOpenTime,signatureTrackPrice,signatureTrackRegularPrice,eligibleForCertificates" +
                      ",eligibleForSignatureTrack,certificateDescription,certificatesReady";

            try
            {
                var res = GetDataFromSomeUrl(url);
                var resultList = JsonConvert.DeserializeObject<List<Session>>(res);
            
                if (resultList.Count > 0)
                {
                    // Если в таблице Session уже есть какие то данные, то удалим их
                    using (var uowDel = new UnitOfWork())
                    {
                        var sessionList = uowDel.SessionRepository.Get().Select(x => x.SessionId).ToList();
                        var countRowsInExistingBase = sessionList.Count;
                        if (countRowsInExistingBase > 0)
                        {
                            foreach (var sessionId in sessionList)
                            {
                                uowDel.SessionRepository.Delete(sessionId);
                            }

                            uowDel.Save();
                        }
                    }

                    // Заполняем таблице Session данным с Coursera Api
                    using (var uowTmp = new UnitOfWork())
                    {
                        foreach (var session in resultList)
                        {
                            uowTmp.SessionRepository.Add(session);
                        }

                        uowTmp.Save();
                    }
                }

                Console.WriteLine("Загрузка инфы по Сессиям с Coursera Api прошла успешно !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some exception: {0}", ex.Message);
                throw;
            }
        }
    }
}