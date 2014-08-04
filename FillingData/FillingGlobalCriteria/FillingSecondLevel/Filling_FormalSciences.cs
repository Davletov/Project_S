namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_FormalSciences(ref FirstLevelCriteria formalSciences, UnitOfWork uow)
        {
            var item_1 = new SecondLevelCriteria { Name = "Applied Mathematics", Tags = "applied mathematics", FirstLevelCriteria = formalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>()};
            FillingThirdLevelCriteria.Filling_AppliedMathematics(ref item_1, uow);


            var item_2 = new SecondLevelCriteria { Name = "Computer sciences", Tags = "computer sciences", FirstLevelCriteria = formalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_ComputerSciences(ref item_2, uow);

            /* продолжить */

            uow.SecondLevelCriteriaRepository.Add(item_1);
            uow.SecondLevelCriteriaRepository.Add(item_2);

            formalSciences.SecondLevelCriteria.Add(item_1);
            formalSciences.SecondLevelCriteria.Add(item_2);
        }
    }
}