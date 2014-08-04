namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Archaeology(ref SecondLevelCriteria archaeology, UnitOfWork uow)
        {
            var item_1 = new ThirdLevelCriteria { Name = "Classical archaeology", Tags = "classical archaeology", SecondLevelCriteria = archaeology };

            var item_2 = new ThirdLevelCriteria { Name = "Egyptology", Tags = "egyptology", SecondLevelCriteria = archaeology };

            /* продолжить */

            uow.ThirdLevelCriteriaRepository.Add(item_1);
            uow.ThirdLevelCriteriaRepository.Add(item_2);

            archaeology.ThirdLevelCriteria.Add(item_1);
            archaeology.ThirdLevelCriteria.Add(item_2);
        }
    }
}