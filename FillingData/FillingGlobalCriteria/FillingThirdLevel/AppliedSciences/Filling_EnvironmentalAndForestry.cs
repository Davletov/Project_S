using System.Collections.Generic;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

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
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                environmentalAndForestry.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



