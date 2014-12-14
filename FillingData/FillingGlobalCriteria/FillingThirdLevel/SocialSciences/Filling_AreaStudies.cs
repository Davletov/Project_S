using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_AreaStudies(ref Criteria areaStudies, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "African studies", Tags = "african studies", Parent = areaStudies },
                new Criteria { Name = "Appalachian studies", Tags = "appalachian studies", Parent = areaStudies },
                new Criteria { Name = "Canadian studies", Tags = "canadian studies", Parent = areaStudies },
                new Criteria { Name = "Latin American studies", Tags = "latin american studies", Parent = areaStudies },
                new Criteria { Name = "Indology", Tags = "indology", Parent = areaStudies },
                new Criteria { Name = "Iranian studies", Tags = "iranian studies", Parent = areaStudies },
                new Criteria { Name = "Japanology", Tags = "japanology", Parent = areaStudies },
                new Criteria { Name = "Korean studies", Tags = "korean studies", Parent = areaStudies },
                new Criteria { Name = "Pakistan studies", Tags = "pakistan studies", Parent = areaStudies },
                new Criteria { Name = "Sinology", Tags = "sinology", Parent = areaStudies },
                new Criteria { Name = "Southeast Asian studies", Tags = "southeast asian studies", Parent = areaStudies },
                new Criteria { Name = "Celtic studies", Tags = "celtic studies", Parent = areaStudies },
                new Criteria { Name = "German studies", Tags = "german studies", Parent = areaStudies },
                new Criteria { Name = "Scandinavian studies", Tags = "scandinavian studies", Parent = areaStudies },
                new Criteria { Name = "Slavic studies", Tags = "slavic studies", Parent = areaStudies },
                new Criteria { Name = "Australian studies", Tags = "australian studies", Parent = areaStudies },
                new Criteria { Name = "Middle East studies", Tags = "middle East studies", Parent = areaStudies }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                areaStudies.Children.Add(thirdLevelCriteria);
            }
        }
    }
}