using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Earth(ref Criteria earth, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Edaphology", Tags = "edaphology", Parent = earth },
                new Criteria { Name = "Environmental science", Tags = "environmental science", Parent = earth },
                new Criteria { Name = "Environmental chemistry", Tags = "environmental chemistry", Parent = earth },
                new Criteria { Name = "Gemology", Tags = "gemology", Parent = earth },
                new Criteria { Name = "Geodesy", Tags = "geodesy", Parent = earth },
                new Criteria { Name = "Geography", Tags = "geography", Parent = earth },
                new Criteria { Name = "Geology", Tags = "geology", Parent = earth },
                new Criteria { Name = "Geochemistry", Tags = "geochemistry", Parent = earth },
                new Criteria { Name = "Geomorphology", Tags = "geomorphology", Parent = earth },
                new Criteria { Name = "Geophysics", Tags = "geophysics", Parent = earth },
                new Criteria { Name = "Glaciology", Tags = "glaciology", Parent = earth },
                new Criteria { Name = "Hydrogeology", Tags = "hydrogeology", Parent = earth },
                new Criteria { Name = "Hydrology", Tags = "hydrology", Parent = earth },
                new Criteria { Name = "Meteorology", Tags = "meteorology", Parent = earth },
                new Criteria { Name = "Mineralogy", Tags = "mineralogy", Parent = earth },
                new Criteria { Name = "Oceanography", Tags = "oceanography", Parent = earth },
                new Criteria { Name = "Pedology", Tags = "pedology", Parent = earth },
                new Criteria { Name = "Paleontology", Tags = "paleontology", Parent = earth },
                new Criteria { Name = "Paleobiology", Tags = "paleobiology", Parent = earth },
                new Criteria { Name = "Planetary science", Tags = "planetary science", Parent = earth },
                new Criteria { Name = "Sedimentology", Tags = "sedimentology", Parent = earth },
                new Criteria { Name = "Soil science", Tags = "soil science", Parent = earth },
                new Criteria { Name = "Speleology", Tags = "speleology", Parent = earth },
                new Criteria { Name = "Tectonics", Tags = "tectonics", Parent = earth },
                new Criteria { Name = "Volcanology", Tags = "volcanology", Parent = earth }
            };

            foreach (var criteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(criteria);
                earth.Children.Add(criteria);
            }
        }
    }
}