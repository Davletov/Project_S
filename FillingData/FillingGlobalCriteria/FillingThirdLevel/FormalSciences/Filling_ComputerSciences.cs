namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_ComputerSciences(ref SecondLevelCriteria computerSciences, UnitOfWork uow)
        {
            var item_1 = new ThirdLevelCriteria { Name = "Automata theory", Tags = "automata theory,formal languages,theory of computation", SecondLevelCriteria = computerSciences };

            var item_2 = new ThirdLevelCriteria { Name = "Computability theory", Tags = "computability theory,theory of computation", SecondLevelCriteria = computerSciences };

            /* продолжить */

            uow.ThirdLevelCriteriaRepository.Add(item_1);
            uow.ThirdLevelCriteriaRepository.Add(item_2);

            computerSciences.ThirdLevelCriteria.Add(item_1);
            computerSciences.ThirdLevelCriteria.Add(item_2);
        }
    }
}