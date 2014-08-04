namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_PhysicsSpaceSciences(ref SecondLevelCriteria physicsSpaceSciences, UnitOfWork uow)
        {
            var item_1 = new ThirdLevelCriteria { Name = "Acoustics", Tags = "acoustics", SecondLevelCriteria = physicsSpaceSciences };

            var item_2 = new ThirdLevelCriteria { Name = "Applied Physics", Tags = "applied physics", SecondLevelCriteria = physicsSpaceSciences };

            /* продолжить */

            uow.ThirdLevelCriteriaRepository.Add(item_1);
            uow.ThirdLevelCriteriaRepository.Add(item_2);
            
            physicsSpaceSciences.ThirdLevelCriteria.Add(item_1);
            physicsSpaceSciences.ThirdLevelCriteria.Add(item_2);
        }
    }
}