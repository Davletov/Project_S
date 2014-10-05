using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_CivilEngineering(ref SecondLevelCriteria civilEngineering, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Earthquake engineering", Tags = "earthquake engineering", SecondLevelCriteria = civilEngineering },
                new ThirdLevelCriteria { Name = "Ecological engineering", Tags = "ecological engineering", SecondLevelCriteria = civilEngineering },
                new ThirdLevelCriteria { Name = "Environmental engineering", Tags = "environmental engineering", SecondLevelCriteria = civilEngineering },
                new ThirdLevelCriteria { Name = "Engineering geology", Tags = "engineering geology,geotechnical engineering", SecondLevelCriteria = civilEngineering },
                new ThirdLevelCriteria { Name = "Geoengineering", Tags = "geoengineering,geotechnical engineering", SecondLevelCriteria = civilEngineering },
                new ThirdLevelCriteria { Name = "Hydraulic Engineering", Tags = "hydraulic engineering", SecondLevelCriteria = civilEngineering },
                new ThirdLevelCriteria { Name = "Mining engineering", Tags = "mining engineering", SecondLevelCriteria = civilEngineering },
                new ThirdLevelCriteria { Name = "Highway engineering", Tags = "highway engineering,transportation engineering", SecondLevelCriteria = civilEngineering },
                new ThirdLevelCriteria { Name = "Architectural engineering", Tags = "architectural engineering,structural engineering", SecondLevelCriteria = civilEngineering },
                new ThirdLevelCriteria { Name = "Structural Mechanics", Tags = "structural mechanics", SecondLevelCriteria = civilEngineering },
                new ThirdLevelCriteria { Name = "Surveying", Tags = "surveying", SecondLevelCriteria = civilEngineering }
            };

             foreach (var thirdLevelCriteria in tmpThirdCritList)
             {
                 uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                 civilEngineering.ThirdLevelCriteria.Add(thirdLevelCriteria);
             }
        }
    }
}