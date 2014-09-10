namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Transportation(ref SecondLevelCriteria transportation, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Highway safety", Tags = "highway safety", SecondLevelCriteria = transportation},
                new ThirdLevelCriteria {Name = "Infographics", Tags = "infographics", SecondLevelCriteria = transportation},
                new ThirdLevelCriteria {Name = "Intermodal transportation studies", Tags = "intermodal transportation studies", SecondLevelCriteria = transportation},
                new ThirdLevelCriteria {Name = "Marine transportation", Tags = "marine transportation", SecondLevelCriteria = transportation},
                new ThirdLevelCriteria {Name = "Operations research", Tags = "operations research", SecondLevelCriteria = transportation},
                new ThirdLevelCriteria {Name = "Mass transit", Tags = "mass transit", SecondLevelCriteria = transportation}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                transportation.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



