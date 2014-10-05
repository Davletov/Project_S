using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Linguistics(ref SecondLevelCriteria linguistics, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Business English", Tags = "business english", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Classical language", Tags = "classical language", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Modern language", Tags = "modern language", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Standard English", Tags = "standard english", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "World Englishes", Tags = "world englishes", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Applied Linguistics", Tags = "applied linguistics", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Computational linguistics", Tags = "computational linguistics,natural language processing", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Discourse analysis", Tags = "discourse analysis", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Etymology", Tags = "etymology", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Historical linguistics", Tags = "historical linguistics", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "History of linguistics", Tags = "history of linguistics", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Interlinguistics", Tags = "interlinguistics", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Morphology", Tags = "morphology", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Philology", Tags = "philology", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Phonetics", Tags = "phonetics", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Phonology", Tags = "phonology", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Pragmatics", Tags = "pragmatics", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Semantics", Tags = "semantics", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Semiotics", Tags = "semiotics", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Sociolinguistics", Tags = "sociolinguistics", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Syntax", Tags = "syntax", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Composition studies", Tags = "composition studies", SecondLevelCriteria = linguistics },
                new ThirdLevelCriteria { Name = "Rhetoric", Tags = "rhetoric", SecondLevelCriteria = linguistics }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                linguistics.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}