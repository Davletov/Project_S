namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_SocialSciences(ref FirstLevelCriteria socialSciences, UnitOfWork uow)
        {
            var item_1 = new SecondLevelCriteria { Name = "Anthropology", Tags = "anthropology", FirstLevelCriteria = socialSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>()};
            FillingThirdLevelCriteria.Filling_Anthropology(ref item_1, uow);


            var item_2 = new SecondLevelCriteria { Name = "Archaeology", Tags = "archaeology", FirstLevelCriteria = socialSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Archaeology(ref item_2, uow);

            /* продолжить */

            uow.SecondLevelCriteriaRepository.Add(item_1);
            uow.SecondLevelCriteriaRepository.Add(item_2);

            socialSciences.SecondLevelCriteria.Add(item_1);
            socialSciences.SecondLevelCriteria.Add(item_2);
        }
    }
}