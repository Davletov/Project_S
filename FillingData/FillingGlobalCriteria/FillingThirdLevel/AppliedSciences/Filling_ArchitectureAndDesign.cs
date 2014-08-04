namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_ArchitectureAndDesign(ref SecondLevelCriteria architectureAndDesign, UnitOfWork uow)
        {
            var item_1 = new ThirdLevelCriteria { Name = "Architecture", Tags = "Architecture,related design", SecondLevelCriteria = architectureAndDesign };

            var item_2 = new ThirdLevelCriteria { Name = "Urban planning", Tags = "urban design,related design", SecondLevelCriteria = architectureAndDesign };

            /* продолжить */

            uow.ThirdLevelCriteriaRepository.Add(item_1);
            uow.ThirdLevelCriteriaRepository.Add(item_2);

            architectureAndDesign.ThirdLevelCriteria.Add(item_1);
            architectureAndDesign.ThirdLevelCriteria.Add(item_2);
        }
    }
}