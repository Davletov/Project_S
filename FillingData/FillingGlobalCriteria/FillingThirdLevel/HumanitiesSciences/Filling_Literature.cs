using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Literature(ref Criteria literature, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Poetry", Tags = "poetry", Parent = literature },
                new Criteria { Name = "Comparative literature", Tags = "comparative literature", Parent = literature },
                new Criteria { Name = "English literature", Tags = "english literature", Parent = literature },
                new Criteria { Name = "American literature", Tags = "american literature,world literature", Parent = literature },
                new Criteria { Name = "British literature", Tags = "british literature,world literature", Parent = literature },
                new Criteria { Name = "Medieval literature", Tags = "medieval literature,historical", Parent = literature },
                new Criteria { Name = "Post-colonial literature", Tags = "post-colonial literature,historical", Parent = literature },
                new Criteria { Name = "Post-modern literature", Tags = "post-modern literature,historical", Parent = literature },
                new Criteria { Name = "Critical theory", Tags = "critical theory,literary theory", Parent = literature },
                new Criteria { Name = "Literary criticism", Tags = "literary criticism,literary theory", Parent = literature },
                new Criteria { Name = "Poetics", Tags = "poetics,literary theory", Parent = literature },
                new Criteria { Name = "Rhetoric", Tags = "rhetoric,literary theory", Parent = literature },
                new Criteria { Name = "Creative nonfiction", Tags = "creative nonfiction,creative writing", Parent = literature },
                new Criteria { Name = "Fiction writing", Tags = "fiction writing,creative writing", Parent = literature },
                new Criteria { Name = "Non-fiction writing", Tags = "non-fiction writing,creative writing", Parent = literature },
                new Criteria { Name = "Literary journalism", Tags = "literary journalism,creative writing", Parent = literature },
                new Criteria { Name = "Poetry composition", Tags = "poetry composition,creative writing", Parent = literature },
                new Criteria { Name = "Screenwriting", Tags = "screenwriting,creative writing", Parent = literature },
                new Criteria { Name = "Playwrighting", Tags = "playwrighting,creative writing", Parent = literature }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                literature.Children.Add(thirdLevelCriteria);
            }
        }
    }
}