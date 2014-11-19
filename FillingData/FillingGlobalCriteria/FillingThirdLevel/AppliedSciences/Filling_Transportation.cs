using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Transportation(ref Criteria transportation, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Highway safety", Tags = "highway safety", Parent = transportation},
                new Criteria {Name = "Infographics", Tags = "infographics", Parent = transportation},
                new Criteria {Name = "Intermodal transportation studies", Tags = "intermodal transportation studies", Parent = transportation},
                new Criteria {Name = "Marine transportation", Tags = "marine transportation", Parent = transportation},
                new Criteria {Name = "Operations research", Tags = "operations research", Parent = transportation},
                new Criteria {Name = "Mass transit", Tags = "mass transit", Parent = transportation}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                transportation.Children.Add(thirdLevelCriteria);
            }
        }
    }
}



