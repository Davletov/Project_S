namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Anthropology(ref SecondLevelCriteria anthropology, UnitOfWork uow)
        {
            var item_1 = new ThirdLevelCriteria { Name = "Forensic anthropology", Tags = "forensic anthropology,biological anthropology", SecondLevelCriteria = anthropology };

            var item_2 = new ThirdLevelCriteria { Name = "Gene-culture coevolution", Tags = "Gene-culture coevolution,biological anthropology", SecondLevelCriteria = anthropology };

            /* продолжить */

            uow.ThirdLevelCriteriaRepository.Add(item_1);
            uow.ThirdLevelCriteriaRepository.Add(item_2);

            anthropology.ThirdLevelCriteria.Add(item_1);
            anthropology.ThirdLevelCriteria.Add(item_2);
        }
    }
}