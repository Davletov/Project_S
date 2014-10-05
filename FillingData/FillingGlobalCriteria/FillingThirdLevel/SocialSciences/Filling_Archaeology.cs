using Web.DataAccess.Repository;
using Web.Models.Criteria;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic; 

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Archaeology(ref SecondLevelCriteria archaeology, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Classical archaeology", Tags = "classical archaeology", SecondLevelCriteria = archaeology },
                new ThirdLevelCriteria { Name = "Egyptology", Tags = "egyptology", SecondLevelCriteria = archaeology },
                new ThirdLevelCriteria { Name = "Architectural analytics", Tags = "architectural analytics", SecondLevelCriteria = archaeology },
                new ThirdLevelCriteria { Name = "Experimental archaeology", Tags = "experimental archaeology", SecondLevelCriteria = archaeology },
                new ThirdLevelCriteria { Name = "Maritime archaeology", Tags = "maritime archaeology", SecondLevelCriteria = archaeology },
                new ThirdLevelCriteria { Name = "Near Eastern archaeology", Tags = "near Eastern archaeology", SecondLevelCriteria = archaeology },
                new ThirdLevelCriteria { Name = "Paleoanthropology", Tags = "paleoanthropology", SecondLevelCriteria = archaeology },
                new ThirdLevelCriteria { Name = "Prehistoric archaeology", Tags = "prehistoric archaeology", SecondLevelCriteria = archaeology }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                archaeology.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}