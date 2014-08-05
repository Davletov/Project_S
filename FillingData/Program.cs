using FiilingData.FillingGlobalCriteria;
using FiilingData.FillingGlobalCriteria.FillingFirstLevel;

namespace FiilingData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Web.Models.CourseraEntity;
    using Web.UnitOfWork;
    using FiilingData.FillingCourseraData;

    class Program
    {
        /* Заполняем данными, скрипты желательно проводить каждый отдельно и по одному разу, иначе будут дупликаты в базе */
        /* Идея по доработке скрипта заполнения данных :
         * За 2 недели на курсере появилось 2 новых курса, так что возможно данный скрипт надо будет запускать и обновлять данные раз в неделю или две
         * Полный скрипт отрабатывает около 5 минут на локальной машине.
         * Перед выполнением скрипта надо будет добавить метод, ктр полностью очистит все таблицы. 
         * Либо надо вытаскивать тока изменненые курсы или новые и обновлять базу (сложный вариант).*/
        static void Main(string[] args)
        {
            /*Console.Write("Начать заполнение БД данными с Coursera ? \nВнимание, если хоть одна таблица в базе уже заполнена,\n" +
                          "то повторная процедура заполнения приведет к дупликатам в таблицах!\n" +
                          "Press y(yes) or n(no): ");
            var answ = Console.ReadLine();
            if (answ != null && answ.ToLower() == "y")
            {

                 FillingDataFromCoursera.FillingDataAboutCourses(); // инфа о всех курсах
                 FillingDataFromCoursera.FillingDataAboutSessions(); // инфа о всех сессиях курса(сроки)
                 FillingDataFromCoursera.FillingDataAboutInstructors(); // инфа о всех преподавателях
                 FillingDataFromCoursera.FillingDataAboutUniversities(); // инфа о всех университетах
                 FillingDataFromCoursera.FillingDataAboutCategories(); // инфа о всех категориях

                 // Устанавливаем связь многие ко многим между сущностями Course and Category and etc
                 FillingDataFromCoursera.BindingCoursesForEachCategory();
                 FillingDataFromCoursera.BindingCoursesForEachInstructor();
                 FillingDataFromCoursera.BindingCoursesForEachSession();
                 FillingDataFromCoursera.BindingCoursesForEachUniversity();

            }
            Console.WriteLine("Нажмите любую клавиу для закрытия приложения ...");*/


            // Заполняем глобальные критерии
            //FillingFirstCriteria.FillingGlobalCriteria();

            FillingCountryAndCity.FillingCountriesWithCities();

            Console.ReadKey();

            //TestGetSomeData();
        }

        private static void TestGetSomeData()
        {
            // Связь многие ко многим работает корректно, удаление отрабатывает, вроде все гуд !
            using (var uow = new UnitOfWork())
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
            using (var uow = new UnitOfWork())
            {
                var result = uow.CategoryRepository.Get(x => x.CategoryIdFromApi == 17).FirstOrDefault();
                uow.CategoryRepository.Delete(result);
                uow.Save();
            }
            var response = 1;
        }
    }
}


