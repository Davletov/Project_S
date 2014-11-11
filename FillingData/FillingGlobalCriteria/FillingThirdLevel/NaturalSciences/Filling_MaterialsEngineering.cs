using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_MaterialsEngineering(ref Criteria materialsEngineering, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Biomaterials", Tags = "biomaterials", Parent = materialsEngineering },
                new Criteria { Name = "Ceramic engineering", Tags = "ceramic engineering", Parent = materialsEngineering },
                new Criteria { Name = "Crystallography", Tags = "crystallography", Parent = materialsEngineering },
                new Criteria { Name = "Nanomaterials", Tags = "nanomaterials", Parent = materialsEngineering },
                new Criteria { Name = "Photonics", Tags = "photonics", Parent = materialsEngineering },
                new Criteria { Name = "Physical metallurgy", Tags = "physical metallurgy", Parent = materialsEngineering },
                new Criteria { Name = "Polymer engineering", Tags = "polymer engineering", Parent = materialsEngineering },
                new Criteria { Name = "Polymer science", Tags = "polymer science", Parent = materialsEngineering },
                new Criteria { Name = "Semiconductors", Tags = "semiconductors", Parent = materialsEngineering }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                materialsEngineering.Children.Add(thirdLevelCriteria);
            }
        }
    }
}