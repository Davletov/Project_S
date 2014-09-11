namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_MaterialsEngineering(ref SecondLevelCriteria materialsEngineering, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Biomaterials", Tags = "biomaterials", SecondLevelCriteria = materialsEngineering },
                new ThirdLevelCriteria { Name = "Ceramic engineering", Tags = "ceramic engineering", SecondLevelCriteria = materialsEngineering },
                new ThirdLevelCriteria { Name = "Crystallography", Tags = "crystallography", SecondLevelCriteria = materialsEngineering },
                new ThirdLevelCriteria { Name = "Nanomaterials", Tags = "nanomaterials", SecondLevelCriteria = materialsEngineering },
                new ThirdLevelCriteria { Name = "Photonics", Tags = "photonics", SecondLevelCriteria = materialsEngineering },
                new ThirdLevelCriteria { Name = "Physical metallurgy", Tags = "physical metallurgy", SecondLevelCriteria = materialsEngineering },
                new ThirdLevelCriteria { Name = "Polymer engineering", Tags = "polymer engineering", SecondLevelCriteria = materialsEngineering },
                new ThirdLevelCriteria { Name = "Polymer science", Tags = "polymer science", SecondLevelCriteria = materialsEngineering },
                new ThirdLevelCriteria { Name = "Semiconductors", Tags = "semiconductors", SecondLevelCriteria = materialsEngineering }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                materialsEngineering.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}