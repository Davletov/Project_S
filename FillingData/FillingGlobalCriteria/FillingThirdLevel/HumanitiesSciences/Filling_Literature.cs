namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Literature(ref SecondLevelCriteria literature, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Poetry", Tags = "poetry", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Comparative literature", Tags = "comparative literature", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "English literature", Tags = "english literature", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "American literature", Tags = "american literature,world literature", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "British literature", Tags = "british literature,world literature", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Medieval literature", Tags = "medieval literature,historical", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Post-colonial literature", Tags = "post-colonial literature,historical", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Post-modern literature", Tags = "post-modern literature,historical", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Critical theory", Tags = "critical theory,literary theory", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Literary criticism", Tags = "literary criticism,literary theory", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Poetics", Tags = "poetics,literary theory", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Rhetoric", Tags = "rhetoric,literary theory", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Creative nonfiction", Tags = "creative nonfiction,creative writing", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Fiction writing", Tags = "fiction writing,creative writing", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Non-fiction writing", Tags = "non-fiction writing,creative writing", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Literary journalism", Tags = "literary journalism,creative writing", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Poetry composition", Tags = "poetry composition,creative writing", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Screenwriting", Tags = "screenwriting,creative writing", SecondLevelCriteria = literature },
                new ThirdLevelCriteria { Name = "Playwrighting", Tags = "playwrighting,creative writing", SecondLevelCriteria = literature }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                literature.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}