namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_MechanicalEngineering(ref SecondLevelCriteria mechanicalEngineering, UnitOfWork uow)
        {
            var item_1 = new ThirdLevelCriteria { Name = "Aeronautics Engineering", Tags = "aeronautics engineering,aerospace engineering", SecondLevelCriteria = mechanicalEngineering };

            var item_2 = new ThirdLevelCriteria { Name = "Astronautics Engineering", Tags = "astronautics engineering,aerospace engineering", SecondLevelCriteria = mechanicalEngineering };

            /* продолжить */

            uow.ThirdLevelCriteriaRepository.Add(item_1);
            uow.ThirdLevelCriteriaRepository.Add(item_2);

            mechanicalEngineering.ThirdLevelCriteria.Add(item_1);
            mechanicalEngineering.ThirdLevelCriteria.Add(item_2);
        }
    }
}