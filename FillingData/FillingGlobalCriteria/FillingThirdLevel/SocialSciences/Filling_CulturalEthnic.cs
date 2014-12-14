using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_CulturalEthnic(ref Criteria culturalEthnic, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Asian studies", Tags = "asian studies", Parent = culturalEthnic },
                new Criteria { Name = "Asian american studies", Tags = "asian american studies", Parent = culturalEthnic },
                new Criteria { Name = "Black studies or African American studies", Tags = "black studies, african american studies", Parent = culturalEthnic },
                new Criteria { Name = "Chicano studies", Tags = "chicano studies", Parent = culturalEthnic },
                new Criteria { Name = "Childhood studies", Tags = "childhood studies", Parent = culturalEthnic },
                new Criteria { Name = "Disability studies", Tags = "disability studies", Parent = culturalEthnic },
                new Criteria { Name = "Latino studies", Tags = "latino studies", Parent = culturalEthnic },
                new Criteria { Name = "Native American studies", Tags = "native american studies", Parent = culturalEthnic },
                new Criteria { Name = "Deaf Studies", Tags = "deaf studies", Parent = culturalEthnic }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                culturalEthnic.Children.Add(thirdLevelCriteria);
            }
        }
    }
}