namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_History(ref SecondLevelCriteria history, UnitOfWork uow)
        {
            var item_1 = new ThirdLevelCriteria { Name = "African history", Tags = "african history,africa,history", SecondLevelCriteria = history};

            var item_2 = new ThirdLevelCriteria { Name = "American history", Tags = "american history,america,history", SecondLevelCriteria = history };

            /* продолжить */

            history.ThirdLevelCriteria.Add(item_1);
            history.ThirdLevelCriteria.Add(item_2);

            uow.ThirdLevelCriteriaRepository.Add(item_1);
            uow.ThirdLevelCriteriaRepository.Add(item_2);

        }
    }
}