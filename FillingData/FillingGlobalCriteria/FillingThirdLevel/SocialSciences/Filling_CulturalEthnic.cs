using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_CulturalEthnic(ref SecondLevelCriteria culturalEthnic, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Asian studies", Tags = "asian studies", SecondLevelCriteria = culturalEthnic },
                new ThirdLevelCriteria { Name = "Asian american studies", Tags = "asian american studies", SecondLevelCriteria = culturalEthnic },
                new ThirdLevelCriteria { Name = "Black studies or African American studies", Tags = "black studies, african american studies", SecondLevelCriteria = culturalEthnic },
                new ThirdLevelCriteria { Name = "Chicano studies", Tags = "chicano studies", SecondLevelCriteria = culturalEthnic },
                new ThirdLevelCriteria { Name = "Childhood studies", Tags = "childhood studies", SecondLevelCriteria = culturalEthnic },
                new ThirdLevelCriteria { Name = "Disability studies", Tags = "disability studies", SecondLevelCriteria = culturalEthnic },
                new ThirdLevelCriteria { Name = "Latino studies", Tags = "latino studies", SecondLevelCriteria = culturalEthnic },
                new ThirdLevelCriteria { Name = "Native American studies", Tags = "native american studies", SecondLevelCriteria = culturalEthnic },
                new ThirdLevelCriteria { Name = "Deaf Studies", Tags = "deaf studies", SecondLevelCriteria = culturalEthnic }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                culturalEthnic.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}