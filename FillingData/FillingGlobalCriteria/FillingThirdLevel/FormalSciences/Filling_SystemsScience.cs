using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_SystemsScience(ref SecondLevelCriteria systemsScience, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Complex systems", Tags = "complex systems", SecondLevelCriteria = systemsScience },
                new ThirdLevelCriteria { Name = "Cybernetics", Tags = "cybernetics", SecondLevelCriteria = systemsScience },
                new ThirdLevelCriteria { Name = "Control engineering", Tags = "control engineering,control theory", SecondLevelCriteria = systemsScience },
                new ThirdLevelCriteria { Name = "Control systems", Tags = "control systems,control theory", SecondLevelCriteria = systemsScience },
                new ThirdLevelCriteria { Name = "Dynamical systems", Tags = "dynamical systems,control theory", SecondLevelCriteria = systemsScience },
                new ThirdLevelCriteria { Name = "Operations research", Tags = "operations research", SecondLevelCriteria = systemsScience },
                new ThirdLevelCriteria { Name = "Systems dynamics", Tags = "systems dynamics", SecondLevelCriteria = systemsScience },
                new ThirdLevelCriteria { Name = "Systems engineering", Tags = "systems engineering", SecondLevelCriteria = systemsScience },
                new ThirdLevelCriteria { Name = "Systems analysis", Tags = "systems analysis", SecondLevelCriteria = systemsScience },
                new ThirdLevelCriteria { Name = "Developmental systems theory", Tags = "developmental systems theory,systems theory", SecondLevelCriteria = systemsScience },
                new ThirdLevelCriteria { Name = "General systems theory", Tags = "general systems theory,systems theory", SecondLevelCriteria = systemsScience },
                new ThirdLevelCriteria { Name = "Mathematical system theory", Tags = "mathematical system theory,systems theory", SecondLevelCriteria = systemsScience },
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                systemsScience.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}