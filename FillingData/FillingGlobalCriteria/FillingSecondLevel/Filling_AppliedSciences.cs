namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_AppliedSciences(ref FirstLevelCriteria appliedSciences, UnitOfWork uow)
        {
            var item_1 = new SecondLevelCriteria { Name = "Agriculture", Tags = "agriculture", FirstLevelCriteria = appliedSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>()};
            FillingThirdLevelCriteria.Filling_Agriculture(ref item_1, uow);


            var item_2 = new SecondLevelCriteria { Name = "Architecture and design", Tags = "architecture,design", FirstLevelCriteria = appliedSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_ArchitectureAndDesign(ref item_2, uow);

            /* продолжить */

            uow.SecondLevelCriteriaRepository.Add(item_1);
            uow.SecondLevelCriteriaRepository.Add(item_2);

            appliedSciences.SecondLevelCriteria.Add(item_1);
            appliedSciences.SecondLevelCriteria.Add(item_2);
        }
    }
}