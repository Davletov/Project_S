namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_ChemicalEngineering(ref SecondLevelCriteria chemicalEngineering, UnitOfWork uow)
        {
            var item_1 = new ThirdLevelCriteria { Name = "Biochemical Engineering", Tags = "biochemical engineering,bioengineering", SecondLevelCriteria = chemicalEngineering };

            var item_2 = new ThirdLevelCriteria { Name = "Catalysis", Tags = "catalysis", SecondLevelCriteria = chemicalEngineering };

            /* продолжить */

            uow.ThirdLevelCriteriaRepository.Add(item_1);
            uow.ThirdLevelCriteriaRepository.Add(item_2);

            chemicalEngineering.ThirdLevelCriteria.Add(item_1);
            chemicalEngineering.ThirdLevelCriteria.Add(item_2);
        }
    }
}