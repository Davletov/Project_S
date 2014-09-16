namespace FiilingData
{
    using System;
    using FiilingData.FillingCourseraData;
    using FiilingData.FillingGlobalCriteria;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Заполнение данными с Coursera");
            Console.WriteLine("2. Заполнение глобальных критериев");
            Console.WriteLine("3. Связывание глобальных критериев и критериев Coursera");
            Console.WriteLine("4. Заполнение стран и городов");

            Console.WriteLine("\n\nНажмите цифру соот.пункту меню или любую другую клавишу для выхода ... ");
            var ans = Console.ReadLine();
            int choice;
            if (int.TryParse(ans, out choice))
            {
                switch (choice)
                {
                    case 1:
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
                        break;
                    case 2:
                        // Заполняем глобальные критерии
                        FillingFirstCriteria.FillingGlobalCriteria();
                        FillingFirstCriteria.WriteCriteriaToJson();
                        break;
                    case 3:
                        // Связывание глобальных критериев и критериев Coursera
                        FillingDataFromCoursera.BindingGlobalCriteriasWithCourseraCriterias();
                        break;
                    case 4:
                        // Заполнение стран и городов
                        FillingCountryAndCity.FillingCountriesWithCities();
                        break;
                    default:
                        Console.WriteLine("Не выбрали ни одну из операций, нажмите любую клавишу для выхода ...");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}


