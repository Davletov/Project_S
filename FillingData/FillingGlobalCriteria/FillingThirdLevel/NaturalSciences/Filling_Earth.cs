namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Earth(ref SecondLevelCriteria earth, UnitOfWork uow)
        {
            var item_1 = new ThirdLevelCriteria { Name = "Edaphology", Tags = "edaphology", SecondLevelCriteria = earth };

            var item_2 = new ThirdLevelCriteria { Name = "Environmental science", Tags = "environmental science", SecondLevelCriteria = earth };

            /* продолжить */

            uow.ThirdLevelCriteriaRepository.Add(item_1);
            uow.ThirdLevelCriteriaRepository.Add(item_2);

            earth.ThirdLevelCriteria.Add(item_1);
            earth.ThirdLevelCriteria.Add(item_2);
        }
    }
}