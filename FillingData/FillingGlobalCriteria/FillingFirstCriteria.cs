namespace FiilingData.FillingGlobalCriteria
{
    using System;
    using System.Diagnostics;
    using FiilingData.FillingGlobalCriteria.FillingFirstLevel;

    public static class FillingFirstCriteria
    {
        public static void FillingGlobalCriteria()
        {
            Stopwatch stopWatch = new Stopwatch();

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
    }
}
