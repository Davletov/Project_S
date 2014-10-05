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
    /// Скрипт для заполнения данными локальной бд о сессиях(сроки курсов) с coursera.org 
    /// </summary>
    public static partial class FillingDataFromCoursera
    {
        public static void FillingDataAboutSessions()
        {
            Console.WriteLine("\nЗагрузка инфы по Сессиям с Coursera Api ...");

            var stopWatch = new Stopwatch();
            stopWatch.Start();

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
                        var sessionList = uowDel.Repository<Session>().Get().Select(x => x.SessionId).ToList();
                        var countRowsInExistingBase = sessionList.Count;
                        if (countRowsInExistingBase > 0)
                        {
                            foreach (var sessionId in sessionList)
                            {
                                uowDel.Repository<Session>().Delete(sessionId);
                            }

                            uowDel.Commit();
                        }
                    }

                    // Заполняем таблице Session данным с Coursera Api
                    using (var uowTmp = new UnitOfWork())
                    {
                        foreach (var session in resultList)
                        {
                            uowTmp.Repository<Session>().Add(session);
                        }

                        uowTmp.Commit();
                    }
                }

                stopWatch.Stop();

                Console.WriteLine("Загрузка инфы по Сессиям с Coursera Api прошла успешно !");

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