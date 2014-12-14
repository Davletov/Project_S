using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Agriculture(ref Criteria agriculture, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Agroecology", Tags = "agroecology", Parent = agriculture},
                new Criteria { Name = "Agronomy", Tags = "agronomy", Parent = agriculture },
                new Criteria { Name = "Animal husbandry", Tags = "animal husbandry,animal science", Parent = agriculture },
                new Criteria { Name = "Beekeeping", Tags = "beekeeping,apiculture", Parent = agriculture },
                new Criteria { Name = "Agrology", Tags = "agrology", Parent = agriculture },
                new Criteria { Name = "Entomology", Tags = "entomology", Parent = agriculture },
                new Criteria { Name = "Agricultural economics", Tags = "agricultural economics", Parent = agriculture },
                new Criteria { Name = "Biological systems engineering (Agricultural engineering)", Tags = "agricultural engineering,biological systems engineering", Parent = agriculture },
                new Criteria { Name = "Food engineering (Agricultural engineering)", Tags = "agricultural engineering,food engineering", Parent = agriculture },
                new Criteria { Name = "Aquaculture", Tags = "aquaculture", Parent = agriculture },
                new Criteria { Name = "Enology", Tags = "enology", Parent = agriculture },
                new Criteria { Name = "Food science", Tags = "food science", Parent = agriculture },
                new Criteria { Name = "Horticulture", Tags = "horticulture", Parent = agriculture },
                new Criteria { Name = "Hydrology", Tags = "hydrology", Parent = agriculture },
                new Criteria { Name = "Plant science", Tags = "plant science", Parent = agriculture },
                new Criteria { Name = "Pomology", Tags = "pomology", Parent = agriculture },
                new Criteria { Name = "Viticulture", Tags = "viticulture", Parent = agriculture }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                agriculture.Children.Add(thirdLevelCriteria);
            }
        }
    }
}
