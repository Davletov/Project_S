using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;    
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_FormalSciences(ref FirstLevelCriteria formalSciences, UnitOfWork uow)
        {
            var tmpSecondCritList = new List<SecondLevelCriteria>();
            var item_1 = new SecondLevelCriteria { Name = "Applied Mathematics", Tags = "applied mathematics", FirstLevelCriteria = formalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>()};
            FillingThirdLevelCriteria.Filling_AppliedMathematics(ref item_1, uow);
            tmpSecondCritList.Add(item_1);

            var item_2 = new SecondLevelCriteria { Name = "Computer sciences", Tags = "computer sciences", FirstLevelCriteria = formalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_ComputerSciences(ref item_2, uow);
            tmpSecondCritList.Add(item_2);

            var item_3 = new SecondLevelCriteria { Name = "Logic", Tags = "logic", FirstLevelCriteria = formalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Logic(ref item_3, uow);
            tmpSecondCritList.Add(item_3);

            var item_4 = new SecondLevelCriteria { Name = "Pure Mathematics", Tags = "pure mathematics", FirstLevelCriteria = formalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_PureMathematics(ref item_4, uow);
            tmpSecondCritList.Add(item_4);

            var item_5 = new SecondLevelCriteria { Name = "Statistics", Tags = "statistics", FirstLevelCriteria = formalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Statistics(ref item_5, uow);
            tmpSecondCritList.Add(item_5);

            var item_6 = new SecondLevelCriteria { Name = "Systems science", Tags = "systems science", FirstLevelCriteria = formalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_SystemsScience(ref item_6, uow);
            tmpSecondCritList.Add(item_6);


            foreach (var secondLevelCriteria in tmpSecondCritList)
            {
                uow.Repository<SecondLevelCriteria>().Add(secondLevelCriteria);
                formalSciences.SecondLevelCriteria.Add(secondLevelCriteria);
            }
        }
    }
}