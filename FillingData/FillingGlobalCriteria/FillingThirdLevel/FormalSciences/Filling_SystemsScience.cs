using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_SystemsScience(ref Criteria systemsScience, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Complex systems", Tags = "complex systems", Parent = systemsScience },
                new Criteria { Name = "Cybernetics", Tags = "cybernetics", Parent = systemsScience },
                new Criteria { Name = "Control engineering", Tags = "control engineering,control theory", Parent = systemsScience },
                new Criteria { Name = "Control systems", Tags = "control systems,control theory", Parent = systemsScience },
                new Criteria { Name = "Dynamical systems", Tags = "dynamical systems,control theory", Parent = systemsScience },
                new Criteria { Name = "Operations research", Tags = "operations research", Parent = systemsScience },
                new Criteria { Name = "Systems dynamics", Tags = "systems dynamics", Parent = systemsScience },
                new Criteria { Name = "Systems engineering", Tags = "systems engineering", Parent = systemsScience },
                new Criteria { Name = "Systems analysis", Tags = "systems analysis", Parent = systemsScience },
                new Criteria { Name = "Developmental systems theory", Tags = "developmental systems theory,systems theory", Parent = systemsScience },
                new Criteria { Name = "General systems theory", Tags = "general systems theory,systems theory", Parent = systemsScience },
                new Criteria { Name = "Mathematical system theory", Tags = "mathematical system theory,systems theory", Parent = systemsScience },
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                systemsScience.Children.Add(thirdLevelCriteria);
            }
        }
    }
}