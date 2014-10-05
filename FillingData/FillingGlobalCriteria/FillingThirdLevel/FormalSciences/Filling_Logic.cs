using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;   

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Logic(ref SecondLevelCriteria logic, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Set theory", Tags = "set theory,mathematical logic", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Proof theory", Tags = "proof theory,mathematical logic", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Model theory", Tags = "model theory,mathematical logic", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Recursion theory", Tags = "recursion theory,mathematical logic", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Modal logic", Tags = "modal logic,mathematical logic", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Intuitionistic logic", Tags = "intuitionistic logic,mathematical logic", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Logical reasoning", Tags = "logical reasoning,philosophical logic", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Modal logic", Tags = "modal logic,philosophical logic", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Deontic logic", Tags = "deontic logic,philosophical logic", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Doxastic logic", Tags = "doxastic logic,philosophical logic", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Programming language semantics", Tags = "programming language semantics,logic in computer science", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Formal methods", Tags = "formal methods,logic in computer science", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Type theory", Tags = "type theory,logic in computer science", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Logic programming", Tags = "logic programming,logic in computer science", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Multi-valued logic", Tags = "multi-valued logic,logic in computer science", SecondLevelCriteria = logic },
                new ThirdLevelCriteria { Name = "Fuzzy logic", Tags = "fuzzy logic,logic in computer science", SecondLevelCriteria = logic }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                logic.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}