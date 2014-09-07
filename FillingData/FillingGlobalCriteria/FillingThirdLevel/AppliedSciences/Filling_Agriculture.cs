using System.Collections.Generic;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Agriculture(ref SecondLevelCriteria agriculture, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Agroecology", Tags = "agroecology", SecondLevelCriteria = agriculture},
                new ThirdLevelCriteria { Name = "Agronomy", Tags = "agronomy", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Animal husbandry", Tags = "animal husbandry,animal science", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Beekeeping", Tags = "beekeeping,apiculture", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Agrology", Tags = "agrology", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Entomology", Tags = "entomology", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Agricultural economics", Tags = "agricultural economics", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Biological systems engineering (Agricultural engineering)", Tags = "agricultural engineering,biological systems engineering", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Food engineering (Agricultural engineering)", Tags = "agricultural engineering,food engineering", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Aquaculture", Tags = "aquaculture", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Enology", Tags = "enology", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Food science", Tags = "food science", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Horticulture", Tags = "horticulture", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Hydrology", Tags = "hydrology", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Plant science", Tags = "plant science", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Pomology", Tags = "pomology", SecondLevelCriteria = agriculture },
                new ThirdLevelCriteria { Name = "Viticulture", Tags = "viticulture", SecondLevelCriteria = agriculture }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                agriculture.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}
