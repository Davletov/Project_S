using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_EnvironmentalAndForestry(ref Criteria environmentalAndForestry, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Coastal management", Tags = "coastal management,environmental management", Parent = environmentalAndForestry},
                new Criteria {Name = "Fisheries management", Tags = "fisheries management,environmental management", Parent = environmentalAndForestry},
                new Criteria {Name = "Land management", Tags = "land management,environmental management", Parent = environmentalAndForestry},
                new Criteria {Name = "Natural resource management", Tags = "natural resource management,environmental management", Parent = environmentalAndForestry},
                new Criteria {Name = "Wildlife management", Tags = "wildlife management,environmental management", Parent = environmentalAndForestry},
                new Criteria {Name = "Environmental policy", Tags = "environmental policy", Parent = environmentalAndForestry},
                new Criteria {Name = "Recreation ecology", Tags = "recreation ecology", Parent = environmentalAndForestry},
                new Criteria {Name = "Silviculture", Tags = "silviculture", Parent = environmentalAndForestry},
                new Criteria {Name = "Sustainability studies", Tags = "sustainability studies", Parent = environmentalAndForestry},
                new Criteria {Name = "Sustainable development", Tags = "sustainable development", Parent = environmentalAndForestry},
                new Criteria {Name = "Toxicology", Tags = "toxicology", Parent = environmentalAndForestry}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                environmentalAndForestry.Children.Add(thirdLevelCriteria);
            }
        }
    }
}



