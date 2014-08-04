namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_NaturalSciences(ref FirstLevelCriteria naturalSciences, UnitOfWork uow)
        {
            var item_1 = new SecondLevelCriteria { Name = "Physics and Space sciences", Tags = "physics sciences,space sciences", FirstLevelCriteria = naturalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>()};
            FillingThirdLevelCriteria.Filling_PhysicsSpaceSciences(ref item_1, uow);


            var item_2 = new SecondLevelCriteria { Name = "Earth sciences", Tags = "earth sciences", FirstLevelCriteria = naturalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Earth(ref item_2, uow);

            /* продолжить */

            uow.SecondLevelCriteriaRepository.Add(item_1);
            uow.SecondLevelCriteriaRepository.Add(item_2);

            naturalSciences.SecondLevelCriteria.Add(item_1);
            naturalSciences.SecondLevelCriteria.Add(item_2);
        }
    }
}