using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_AreaStudies(ref SecondLevelCriteria areaStudies, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "African studies", Tags = "african studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Appalachian studies", Tags = "appalachian studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Canadian studies", Tags = "canadian studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Latin American studies", Tags = "latin american studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Indology", Tags = "indology", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Iranian studies", Tags = "iranian studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Japanology", Tags = "japanology", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Korean studies", Tags = "korean studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Pakistan studies", Tags = "pakistan studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Sinology", Tags = "sinology", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Southeast Asian studies", Tags = "southeast asian studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Celtic studies", Tags = "celtic studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "German studies", Tags = "german studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Scandinavian studies", Tags = "scandinavian studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Slavic studies", Tags = "slavic studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Australian studies", Tags = "australian studies", SecondLevelCriteria = areaStudies },
                new ThirdLevelCriteria { Name = "Middle East studies", Tags = "middle East studies", SecondLevelCriteria = areaStudies }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                areaStudies.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}