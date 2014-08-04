namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_HumanitiesSciences(ref FirstLevelCriteria humanitiesSciences, UnitOfWork uow)
        {
            var item_1 = new SecondLevelCriteria { Name = "History", Tags = "history", FirstLevelCriteria = humanitiesSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_History(ref item_1, uow);


            var item_2 = new SecondLevelCriteria { Name = "Linguistics", Tags = "linguistics", FirstLevelCriteria = humanitiesSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Linguistics(ref item_2, uow);

            /* продолжить */
            
            uow.SecondLevelCriteriaRepository.Add(item_1);
            uow.SecondLevelCriteriaRepository.Add(item_2);           

            humanitiesSciences.SecondLevelCriteria.Add(item_1);
            humanitiesSciences.SecondLevelCriteria.Add(item_2);
        }
    }
}