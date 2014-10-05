using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Geography(ref SecondLevelCriteria geography, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Cartography", Tags = "cartography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Cultural geography", Tags = "cultural geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Economic geography", Tags = "economic geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Development geography", Tags = "development geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Historical geography", Tags = "historical geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Time geography", Tags = "time geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Military geography", Tags = "military geography,political geography,geopolitics", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Strategic geography", Tags = "strategic geography,political geography,geopolitics", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Population geography", Tags = "population geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Behavioral geography", Tags = "behavioral geography,social geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Children's geographies", Tags = "children's geographies,social geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Health geography", Tags = "health geography,social geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Tourism geography", Tags = "tourism geography,social geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Urban geography", Tags = "urban geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Environmental geography", Tags = "environmental geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Biogeography", Tags = "biogeography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Climatology", Tags = "climatology", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Palaeoclimatology", Tags = "palaeoclimatology", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Coastal geography", Tags = "coastal geography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Geomorphology", Tags = "geomorphology", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Geodesy", Tags = "geodesy", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Glaciology", Tags = "glaciology,hydrology,hydrography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Limnology", Tags = "limnology,hydrology,hydrography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Oceanography", Tags = "oceanography,hydrology,hydrography", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Landscape ecology", Tags = "landscape ecology", SecondLevelCriteria = geography },
                new ThirdLevelCriteria { Name = "Palaeogeography", Tags = "palaeogeography", SecondLevelCriteria = geography }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                geography.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}