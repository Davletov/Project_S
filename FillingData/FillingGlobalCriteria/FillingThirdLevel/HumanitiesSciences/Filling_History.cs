namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_History(ref SecondLevelCriteria history, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "African history", Tags = "african history,africa,history", SecondLevelCriteria = history},
                new ThirdLevelCriteria { Name = "American history", Tags = "american history,america,history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Ancient history", Tags = "ancient history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Australian history", Tags = "australian history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Asian history", Tags = "asian history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "European history", Tags = "european history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Chinese history", Tags = "chinese history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Economic history", Tags = "economic history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Greek history", Tags = "greek history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Iranian history", Tags = "iranian history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Indian history", Tags = "indian history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Indonesian history", Tags = "indonesian history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Intellectual history", Tags = "intellectual history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Latin American history", Tags = "latin american history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Modern history", Tags = "modern history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Political history", Tags = "political history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Roman history", Tags = "roman history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Russian history", Tags = "russian history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Scientific history", Tags = "scientific history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "Technological history", Tags = "technological history", SecondLevelCriteria = history },
                new ThirdLevelCriteria { Name = "World history", Tags = "world history", SecondLevelCriteria = history }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                history.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}