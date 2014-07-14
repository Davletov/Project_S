using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UOfW = Testing.UnitOfWork;

namespace Testing
{
    using Testing.FillingData;

    class Program
    {

        static void Main(string[] args)
        {
            /* Заполняем данными, скрипты желательно проводить каждый отдельно */
            // FillingDataFromCoursera.FillingDataAboutCourses(); // используем Coursera Api для загрузки инфы о всех курсах
            // FillingDataFromCoursera.FillingDataAboutSessions(); // используем Coursera Api для загрузки инфы о всех сессиях курса(сроки)
            // FillingDataFromCoursera.FillingDataAboutInstructors(); // используем Coursera Api для загрузки инфы о всех преподавателях
            // FillingDataFromCoursera.FillingDataAboutUniversities(); // используем Coursera Api для загрузки инфы о всех университетах
            // FillingDataFromCoursera.FillingDataAboutCategories(); // используем Coursera Api для загрузки инфы о всех категориях

            //FillingDataFromCoursera.Testing();

            
            // Косяк в реализации репозитория либо неправильное использование EF !!!!
            using (var uow = new UOfW.UnitOfWork())
            {
                // через репозиторий EF возвращает null
                var result = uow.CourseRepository.Get(x => x.CourseIdFromApi == 2).Select(x => x.Categories).FirstOrDefault();
            }
            using (var db = new BdContext())
            {
                // если обратиться напрямую к контексту EF то получим данные
                var tmp = db.Courses.Where(x => x.CourseId == 304).Select(x => x.Categories).FirstOrDefault();
                
            }
        }
    }
}
