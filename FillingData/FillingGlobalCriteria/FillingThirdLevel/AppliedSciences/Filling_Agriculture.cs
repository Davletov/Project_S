namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Agriculture(ref SecondLevelCriteria agriculture, UnitOfWork uow)
        {
            var item_1 = new ThirdLevelCriteria { Name = "Agroecology", Tags = "agroecology", SecondLevelCriteria = agriculture };

            var item_2 = new ThirdLevelCriteria { Name = "Agronomy", Tags = "agronomy", SecondLevelCriteria = agriculture };

            /* продолжить */

            uow.ThirdLevelCriteriaRepository.Add(item_1);
            uow.ThirdLevelCriteriaRepository.Add(item_2);

            agriculture.ThirdLevelCriteria.Add(item_1);
            agriculture.ThirdLevelCriteria.Add(item_2);
        }
    }
}