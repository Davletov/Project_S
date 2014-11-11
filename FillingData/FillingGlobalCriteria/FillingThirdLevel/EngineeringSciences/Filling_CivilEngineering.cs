using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_CivilEngineering(ref Criteria civilEngineering, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Earthquake engineering", Tags = "earthquake engineering", Parent = civilEngineering },
                new Criteria { Name = "Ecological engineering", Tags = "ecological engineering", Parent = civilEngineering },
                new Criteria { Name = "Environmental engineering", Tags = "environmental engineering", Parent = civilEngineering },
                new Criteria { Name = "Engineering geology", Tags = "engineering geology,geotechnical engineering", Parent = civilEngineering },
                new Criteria { Name = "Geoengineering", Tags = "geoengineering,geotechnical engineering", Parent = civilEngineering },
                new Criteria { Name = "Hydraulic Engineering", Tags = "hydraulic engineering", Parent = civilEngineering },
                new Criteria { Name = "Mining engineering", Tags = "mining engineering", Parent = civilEngineering },
                new Criteria { Name = "Highway engineering", Tags = "highway engineering,transportation engineering", Parent = civilEngineering },
                new Criteria { Name = "Architectural engineering", Tags = "architectural engineering,structural engineering", Parent = civilEngineering },
                new Criteria { Name = "Structural Mechanics", Tags = "structural mechanics", Parent = civilEngineering },
                new Criteria { Name = "Surveying", Tags = "surveying", Parent = civilEngineering }
            };

             foreach (var thirdLevelCriteria in tmpThirdCritList)
             {
                 uow.Repository<Criteria>().Add(thirdLevelCriteria);
                 civilEngineering.Children.Add(thirdLevelCriteria);
             }
        }
    }
}