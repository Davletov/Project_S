using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Geography(ref Criteria geography, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Cartography", Tags = "cartography", Parent = geography },
                new Criteria { Name = "Cultural geography", Tags = "cultural geography", Parent = geography },
                new Criteria { Name = "Economic geography", Tags = "economic geography", Parent = geography },
                new Criteria { Name = "Development geography", Tags = "development geography", Parent = geography },
                new Criteria { Name = "Historical geography", Tags = "historical geography", Parent = geography },
                new Criteria { Name = "Time geography", Tags = "time geography", Parent = geography },
                new Criteria { Name = "Military geography", Tags = "military geography,political geography,geopolitics", Parent = geography },
                new Criteria { Name = "Strategic geography", Tags = "strategic geography,political geography,geopolitics", Parent = geography },
                new Criteria { Name = "Population geography", Tags = "population geography", Parent = geography },
                new Criteria { Name = "Behavioral geography", Tags = "behavioral geography,social geography", Parent = geography },
                new Criteria { Name = "Children's geographies", Tags = "children's geographies,social geography", Parent = geography },
                new Criteria { Name = "Health geography", Tags = "health geography,social geography", Parent = geography },
                new Criteria { Name = "Tourism geography", Tags = "tourism geography,social geography", Parent = geography },
                new Criteria { Name = "Urban geography", Tags = "urban geography", Parent = geography },
                new Criteria { Name = "Environmental geography", Tags = "environmental geography", Parent = geography },
                new Criteria { Name = "Biogeography", Tags = "biogeography", Parent = geography },
                new Criteria { Name = "Climatology", Tags = "climatology", Parent = geography },
                new Criteria { Name = "Palaeoclimatology", Tags = "palaeoclimatology", Parent = geography },
                new Criteria { Name = "Coastal geography", Tags = "coastal geography", Parent = geography },
                new Criteria { Name = "Geomorphology", Tags = "geomorphology", Parent = geography },
                new Criteria { Name = "Geodesy", Tags = "geodesy", Parent = geography },
                new Criteria { Name = "Glaciology", Tags = "glaciology,hydrology,hydrography", Parent = geography },
                new Criteria { Name = "Limnology", Tags = "limnology,hydrology,hydrography", Parent = geography },
                new Criteria { Name = "Oceanography", Tags = "oceanography,hydrology,hydrography", Parent = geography },
                new Criteria { Name = "Landscape ecology", Tags = "landscape ecology", Parent = geography },
                new Criteria { Name = "Palaeogeography", Tags = "palaeogeography", Parent = geography }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                geography.Children.Add(thirdLevelCriteria);
            }
        }
    }
}