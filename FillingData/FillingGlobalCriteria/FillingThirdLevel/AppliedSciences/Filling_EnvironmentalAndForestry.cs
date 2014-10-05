using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_EnvironmentalAndForestry(ref SecondLevelCriteria environmentalAndForestry, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Coastal management", Tags = "coastal management,environmental management", SecondLevelCriteria = environmentalAndForestry},
                new ThirdLevelCriteria {Name = "Fisheries management", Tags = "fisheries management,environmental management", SecondLevelCriteria = environmentalAndForestry},
                new ThirdLevelCriteria {Name = "Land management", Tags = "land management,environmental management", SecondLevelCriteria = environmentalAndForestry},
                new ThirdLevelCriteria {Name = "Natural resource management", Tags = "natural resource management,environmental management", SecondLevelCriteria = environmentalAndForestry},
                new ThirdLevelCriteria {Name = "Wildlife management", Tags = "wildlife management,environmental management", SecondLevelCriteria = environmentalAndForestry},
                new ThirdLevelCriteria {Name = "Environmental policy", Tags = "environmental policy", SecondLevelCriteria = environmentalAndForestry},
                new ThirdLevelCriteria {Name = "Recreation ecology", Tags = "recreation ecology", SecondLevelCriteria = environmentalAndForestry},
                new ThirdLevelCriteria {Name = "Silviculture", Tags = "silviculture", SecondLevelCriteria = environmentalAndForestry},
                new ThirdLevelCriteria {Name = "Sustainability studies", Tags = "sustainability studies", SecondLevelCriteria = environmentalAndForestry},
                new ThirdLevelCriteria {Name = "Sustainable development", Tags = "sustainable development", SecondLevelCriteria = environmentalAndForestry},
                new ThirdLevelCriteria {Name = "Toxicology", Tags = "toxicology", SecondLevelCriteria = environmentalAndForestry}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                environmentalAndForestry.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



