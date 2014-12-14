using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Linguistics(ref Criteria linguistics, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Business English", Tags = "business english", Parent = linguistics },
                new Criteria { Name = "Classical language", Tags = "classical language", Parent = linguistics },
                new Criteria { Name = "Modern language", Tags = "modern language", Parent = linguistics },
                new Criteria { Name = "Standard English", Tags = "standard english", Parent = linguistics },
                new Criteria { Name = "World Englishes", Tags = "world englishes", Parent = linguistics },
                new Criteria { Name = "Applied Linguistics", Tags = "applied linguistics", Parent = linguistics },
                new Criteria { Name = "Computational linguistics", Tags = "computational linguistics,natural language processing", Parent = linguistics },
                new Criteria { Name = "Discourse analysis", Tags = "discourse analysis", Parent = linguistics },
                new Criteria { Name = "Etymology", Tags = "etymology", Parent = linguistics },
                new Criteria { Name = "Historical linguistics", Tags = "historical linguistics", Parent = linguistics },
                new Criteria { Name = "History of linguistics", Tags = "history of linguistics", Parent = linguistics },
                new Criteria { Name = "Interlinguistics", Tags = "interlinguistics", Parent = linguistics },
                new Criteria { Name = "Morphology", Tags = "morphology", Parent = linguistics },
                new Criteria { Name = "Philology", Tags = "philology", Parent = linguistics },
                new Criteria { Name = "Phonetics", Tags = "phonetics", Parent = linguistics },
                new Criteria { Name = "Phonology", Tags = "phonology", Parent = linguistics },
                new Criteria { Name = "Pragmatics", Tags = "pragmatics", Parent = linguistics },
                new Criteria { Name = "Semantics", Tags = "semantics", Parent = linguistics },
                new Criteria { Name = "Semiotics", Tags = "semiotics", Parent = linguistics },
                new Criteria { Name = "Sociolinguistics", Tags = "sociolinguistics", Parent = linguistics },
                new Criteria { Name = "Syntax", Tags = "syntax", Parent = linguistics },
                new Criteria { Name = "Composition studies", Tags = "composition studies", Parent = linguistics },
                new Criteria { Name = "Rhetoric", Tags = "rhetoric", Parent = linguistics }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                linguistics.Children.Add(thirdLevelCriteria);
            }
        }
    }
}