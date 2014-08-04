namespace FiilingData.FillingGlobalCriteria
{
    using System;
    using FiilingData.FillingGlobalCriteria.FillingFirstLevel;

    public static class FillingFirstCriteria
    {
        public static void FillingGlobalCriteria()
        {
            Console.WriteLine("\nЗагрузка критериев ...");

            FillingFirstLevelCriteria.Filling_HumanitiesSciences();     // заполнение блока критериев Гумманитарных наук
            FillingFirstLevelCriteria.Filling_SocialSciences();         // заполнение блока критериев Общественных наук
            FillingFirstLevelCriteria.Filling_NaturalSciences();        // заполнение блока критериев Естественных наук
            FillingFirstLevelCriteria.Filling_EngineeringSciences();    // заполнение блока критериев Инженерных наук
            FillingFirstLevelCriteria.Filling_FormalSciences();         // заполнение блока критериев Формальных наук
            FillingFirstLevelCriteria.Filling_AppliedSciences();        // заполнение блока критериев Прикладных наук

            Console.WriteLine("Загрузка критериев прошла успешно !");
        }
    }
}
