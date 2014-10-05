using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Earth(ref SecondLevelCriteria earth, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Edaphology", Tags = "edaphology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Environmental science", Tags = "environmental science", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Environmental chemistry", Tags = "environmental chemistry", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Gemology", Tags = "gemology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Geodesy", Tags = "geodesy", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Geography", Tags = "geography", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Geology", Tags = "geology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Geochemistry", Tags = "geochemistry", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Geomorphology", Tags = "geomorphology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Geophysics", Tags = "geophysics", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Glaciology", Tags = "glaciology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Hydrogeology", Tags = "hydrogeology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Hydrology", Tags = "hydrology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Meteorology", Tags = "meteorology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Mineralogy", Tags = "mineralogy", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Oceanography", Tags = "oceanography", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Pedology", Tags = "pedology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Paleontology", Tags = "paleontology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Paleobiology", Tags = "paleobiology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Planetary science", Tags = "planetary science", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Sedimentology", Tags = "sedimentology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Soil science", Tags = "soil science", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Speleology", Tags = "speleology", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Tectonics", Tags = "tectonics", SecondLevelCriteria = earth },
                new ThirdLevelCriteria { Name = "Volcanology", Tags = "volcanology", SecondLevelCriteria = earth }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                earth.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}