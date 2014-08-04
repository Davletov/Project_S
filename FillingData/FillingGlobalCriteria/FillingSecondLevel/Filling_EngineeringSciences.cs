namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_EngineeringSciences(ref FirstLevelCriteria engineeringSciences, UnitOfWork uow)
        {
            var item_1 = new SecondLevelCriteria { Name = "Mechanical Engineering", Tags = "mechanical engineering", FirstLevelCriteria = engineeringSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>()};
            FillingThirdLevelCriteria.Filling_MechanicalEngineering(ref item_1, uow);


            var item_2 = new SecondLevelCriteria { Name = "Chemical Engineering", Tags = "chemical engineering", FirstLevelCriteria = engineeringSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_ChemicalEngineering(ref item_2, uow);

            /* продолжить */

            uow.SecondLevelCriteriaRepository.Add(item_1);
            uow.SecondLevelCriteriaRepository.Add(item_2);

            engineeringSciences.SecondLevelCriteria.Add(item_1);
            engineeringSciences.SecondLevelCriteria.Add(item_2);
        }
    }
}