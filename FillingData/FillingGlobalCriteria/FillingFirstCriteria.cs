namespace FiilingData.FillingGlobalCriteria
{
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;    
    using System.Diagnostics;
    using FiilingData.FillingGlobalCriteria.FillingFirstLevel;
    using Web.DataAccess.Repository;
    using Web.Models.Criteria;

    public static class FillingFirstCriteria
    {
        public static void FillingGlobalCriteria()
        {
            var stopWatch = new Stopwatch();

            Console.WriteLine("\nЗагрузка критериев ...");
            stopWatch.Start();

            FillingFirstLevelCriteria.Filling_HumanitiesSciences();     // заполнение блока критериев Гумманитарных наук
            FillingFirstLevelCriteria.Filling_SocialSciences();         // заполнение блока критериев Общественных наук
            FillingFirstLevelCriteria.Filling_NaturalSciences();        // заполнение блока критериев Естественных наук
            FillingFirstLevelCriteria.Filling_EngineeringSciences();    // заполнение блока критериев Инженерных наук
            FillingFirstLevelCriteria.Filling_FormalSciences();         // заполнение блока критериев Формальных наук
            FillingFirstLevelCriteria.Filling_AppliedSciences();        // заполнение блока критериев Прикладных наук

            stopWatch.Stop();
            Console.WriteLine("Загрузка критериев прошла успешно !");

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        public static void WriteCriteriaToJson()
        {
            var stopWatch = new Stopwatch();

            Console.WriteLine("\nСохранение критериев в json файл...");
            stopWatch.Start();

            string str;
            using (var uow = new UnitOfWork())
            {
                var listCategory = uow.Repository<FirstLevelCriteria>().Get().ToList();
                str = JsonConvert.SerializeObject(listCategory, Formatting.None, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            }

            str = str.Replace("\"SecondLevelCriteria\"", "\"children\"")
                    .Replace("\"ThirdLevelCriteria\"", "\"children\"")
                    .Replace("Name", "text")
                    .Replace("Id", "id");

            string currentAssemblyPath = Path.GetDirectoryName(typeof(UnitOfWork).Assembly.Location) ?? string.Empty;
            var path = Directory.GetParent(currentAssemblyPath).Parent.Parent.FullName + @"\Web\Scripts\Data";
            string fileName = Path.Combine(path, "jsonData.js");
            File.WriteAllText(fileName, str);


            stopWatch.Stop();
            Console.WriteLine("Сохранение критериев в json файл прошло успешно !");


            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
