namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Linguistics(ref SecondLevelCriteria linguistics, UnitOfWork uow)
        {
            var item_1 = new ThirdLevelCriteria { Name = "Business English", Tags = "business english", SecondLevelCriteria = linguistics };

            var item_2 = new ThirdLevelCriteria { Name = "Classical language", Tags = "classical language", SecondLevelCriteria = linguistics };

            /* продолжить */

            uow.ThirdLevelCriteriaRepository.Add(item_1);
            uow.ThirdLevelCriteriaRepository.Add(item_2);

            linguistics.ThirdLevelCriteria.Add(item_1);
            linguistics.ThirdLevelCriteria.Add(item_2);
        }
    }
}