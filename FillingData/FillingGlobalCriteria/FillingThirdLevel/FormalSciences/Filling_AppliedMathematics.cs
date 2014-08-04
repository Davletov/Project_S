namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_AppliedMathematics(ref SecondLevelCriteria appliedMathematics, UnitOfWork uow)
        {
            var item_1 = new ThirdLevelCriteria { Name = "Mathematical statistics", Tags = "mathematical statistics,statistics",  SecondLevelCriteria = appliedMathematics };

            var item_2 = new ThirdLevelCriteria { Name = "Econometrics", Tags = "econometrics,statistics", SecondLevelCriteria = appliedMathematics };

            /* продолжить */

            uow.ThirdLevelCriteriaRepository.Add(item_1);
            uow.ThirdLevelCriteriaRepository.Add(item_2);

            appliedMathematics.ThirdLevelCriteria.Add(item_1);
            appliedMathematics.ThirdLevelCriteria.Add(item_2);
        }
    }
}