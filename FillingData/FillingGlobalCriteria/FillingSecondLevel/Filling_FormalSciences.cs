using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;    
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_FormalSciences(ref Criteria formalSciences, UnitOfWork uow)
        {
            var tmpSecondCritList = new List<Criteria>();
            var item_1 = new Criteria { Name = "Applied Mathematics", Tags = "applied mathematics", Parent = formalSciences, Children = new Collection<Criteria>()};
            FillingThirdLevelCriteria.Filling_AppliedMathematics(ref item_1, uow);
            tmpSecondCritList.Add(item_1);

            var item_2 = new Criteria { Name = "Computer sciences", Tags = "computer sciences", Parent = formalSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_ComputerSciences(ref item_2, uow);
            tmpSecondCritList.Add(item_2);

            var item_3 = new Criteria { Name = "Logic", Tags = "logic", Parent = formalSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Logic(ref item_3, uow);
            tmpSecondCritList.Add(item_3);

            var item_4 = new Criteria { Name = "Pure Mathematics", Tags = "pure mathematics", Parent = formalSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_PureMathematics(ref item_4, uow);
            tmpSecondCritList.Add(item_4);

            var item_5 = new Criteria { Name = "Statistics", Tags = "statistics", Parent = formalSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Statistics(ref item_5, uow);
            tmpSecondCritList.Add(item_5);

            var item_6 = new Criteria { Name = "Systems science", Tags = "systems science", Parent = formalSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_SystemsScience(ref item_6, uow);
            tmpSecondCritList.Add(item_6);


            foreach (var secondLevelCriteria in tmpSecondCritList)
            {
                uow.Repository<Criteria>().Add(secondLevelCriteria);
                formalSciences.Children.Add(secondLevelCriteria);
            }
        }
    }
}