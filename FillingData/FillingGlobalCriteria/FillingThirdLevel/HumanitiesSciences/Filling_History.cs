using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_History(ref Criteria history, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "African history", Tags = "african history,africa,history", Parent = history},
                new Criteria { Name = "American history", Tags = "american history,america,history", Parent = history },
                new Criteria { Name = "Ancient history", Tags = "ancient history", Parent = history },
                new Criteria { Name = "Australian history", Tags = "australian history", Parent = history },
                new Criteria { Name = "Asian history", Tags = "asian history", Parent = history },
                new Criteria { Name = "European history", Tags = "european history", Parent = history },
                new Criteria { Name = "Chinese history", Tags = "chinese history", Parent = history },
                new Criteria { Name = "Economic history", Tags = "economic history", Parent = history },
                new Criteria { Name = "Greek history", Tags = "greek history", Parent = history },
                new Criteria { Name = "Iranian history", Tags = "iranian history", Parent = history },
                new Criteria { Name = "Indian history", Tags = "indian history", Parent = history },
                new Criteria { Name = "Indonesian history", Tags = "indonesian history", Parent = history },
                new Criteria { Name = "Intellectual history", Tags = "intellectual history", Parent = history },
                new Criteria { Name = "Latin American history", Tags = "latin american history", Parent = history },
                new Criteria { Name = "Modern history", Tags = "modern history", Parent = history },
                new Criteria { Name = "Political history", Tags = "political history", Parent = history },
                new Criteria { Name = "Roman history", Tags = "roman history", Parent = history },
                new Criteria { Name = "Russian history", Tags = "russian history", Parent = history },
                new Criteria { Name = "Scientific history", Tags = "scientific history", Parent = history },
                new Criteria { Name = "Technological history", Tags = "technological history", Parent = history },
                new Criteria { Name = "World history", Tags = "world history", Parent = history }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                history.Children.Add(thirdLevelCriteria);
            }
        }
    }
}