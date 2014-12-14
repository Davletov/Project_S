using System.Linq;
using Web.DataAccess.Repository;
using Web.Models.Criteria;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic; 

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Archaeology(ref Criteria archaeology, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Classical archaeology", Tags = "classical archaeology", Parent = archaeology },
                new Criteria { Name = "Egyptology", Tags = "egyptology", Parent = archaeology },
                new Criteria { Name = "Architectural analytics", Tags = "architectural analytics", Parent = archaeology },
                new Criteria { Name = "Experimental archaeology", Tags = "experimental archaeology", Parent = archaeology },
                new Criteria { Name = "Maritime archaeology", Tags = "maritime archaeology", Parent = archaeology },
                new Criteria { Name = "Near Eastern archaeology", Tags = "near Eastern archaeology", Parent = archaeology },
                new Criteria { Name = "Paleoanthropology", Tags = "paleoanthropology", Parent = archaeology },
                new Criteria { Name = "Prehistoric archaeology", Tags = "prehistoric archaeology", Parent = archaeology }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                archaeology.Children.Add(thirdLevelCriteria);
            }
        }
    }
}