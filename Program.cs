using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Testing.CourseraEntity;
using UOfW = Testing.UnitOfWork;

namespace Testing
{
    using Testing.FillingData;

    class Program
    {

        static void Main(string[] args)
        {
            /* Заполняем данными, скрипты желательно проводить каждый отдельно и по одному разу, иначе будут дупликаты в базе */
            // FillingDataFromCoursera.FillingDataAboutCourses(); // используем Coursera Api для загрузки инфы о всех курсах
            // FillingDataFromCoursera.FillingDataAboutSessions(); // используем Coursera Api для загрузки инфы о всех сессиях курса(сроки)
            // FillingDataFromCoursera.FillingDataAboutInstructors(); // используем Coursera Api для загрузки инфы о всех преподавателях
            // FillingDataFromCoursera.FillingDataAboutUniversities(); // используем Coursera Api для загрузки инфы о всех университетах
            // FillingDataFromCoursera.FillingDataAboutCategories(); // используем Coursera Api для загрузки инфы о всех категориях

            // Устанавливаем связь многие ко многим между сущностями Course and Category
            // Категория (Пр.: математика) -> содержит курсы (Пр.: Мат.методы в экономике, Лин.алгебра и т.д.)
            // Курс (Пр.: Мат.методы в экономике) -> входит в след.категории (Пр.: Математика, Экономика)
            // FillingDataFromCoursera.BindingCoursesForEachCategory();

            // FillingDataFromCoursera.BindingCoursesForEachInstructor();
            // FillingDataFromCoursera.BindingCoursesForEachSession();
            // FillingDataFromCoursera.BindingCoursesForEachUniversity();

            TestGetSomeData();

        }

        private static void TestGetSomeData()
        {
            // Связь многие ко многим работает корректно, удаление отрабатывает, вроде все гуд !
            using (var uow = new UOfW.UnitOfWork())
            {
                var someCategroy = "chemistry";
                var categoryByRequest =
                    uow.CategoryRepository.Get(x => x.Name.Contains(someCategroy) || x.ShortName.Contains(someCategroy))
                        .Select(x => x.CategoryId)
                        .ToList();

                var result = new List<Course>();
                foreach (var category in categoryByRequest)
                {
                    var allCourses =
                        uow.CourseRepository.Get(x => x.Categories.Select(y => y.CategoryId).Contains(category))
                            .ToList();
                    result.AddRange(allCourses);
                }
                var response = 1;
            }
        }


        private static void TestDeleting()
        {
            using (var uow = new UOfW.UnitOfWork())
            {
                var result = uow.CategoryRepository.Get(x => x.CategoryIdFromApi == 17).FirstOrDefault();
                uow.CategoryRepository.Delete(result);
                uow.Save();
            }
            var response = 1;
        }
    }
}
