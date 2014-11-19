using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Logic(ref Criteria logic, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Set theory", Tags = "set theory,mathematical logic", Parent =logic },
                new Criteria { Name = "Proof theory", Tags = "proof theory,mathematical logic", Parent =logic },
                new Criteria { Name = "Model theory", Tags = "model theory,mathematical logic", Parent =logic },
                new Criteria { Name = "Recursion theory", Tags = "recursion theory,mathematical logic", Parent =logic },
                new Criteria { Name = "Modal logic", Tags = "modal logic,mathematical logic", Parent =logic },
                new Criteria { Name = "Intuitionistic logic", Tags = "intuitionistic logic,mathematical logic", Parent =logic },
                new Criteria { Name = "Logical reasoning", Tags = "logical reasoning,philosophical logic", Parent =logic },
                new Criteria { Name = "Modal logic", Tags = "modal logic,philosophical logic", Parent =logic },
                new Criteria { Name = "Deontic logic", Tags = "deontic logic,philosophical logic", Parent =logic },
                new Criteria { Name = "Doxastic logic", Tags = "doxastic logic,philosophical logic", Parent =logic },
                new Criteria { Name = "Programming language semantics", Tags = "programming language semantics,logic in computer science", Parent =logic },
                new Criteria { Name = "Formal methods", Tags = "formal methods,logic in computer science", Parent =logic },
                new Criteria { Name = "Type theory", Tags = "type theory,logic in computer science", Parent =logic },
                new Criteria { Name = "Logic programming", Tags = "logic programming,logic in computer science", Parent =logic },
                new Criteria { Name = "Multi-valued logic", Tags = "multi-valued logic,logic in computer science", Parent =logic },
                new Criteria { Name = "Fuzzy logic", Tags = "fuzzy logic,logic in computer science", Parent =logic }
            };

            foreach (var criteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(criteria);
                logic.Children.Add(criteria);
            }
        }
    }
}