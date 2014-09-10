namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_ChemicalEngineering(ref SecondLevelCriteria chemicalEngineering, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Biochemical Engineering", Tags = "biochemical engineering,bioengineering", SecondLevelCriteria = chemicalEngineering },
                new ThirdLevelCriteria { Name = "Catalysis", Tags = "catalysis", SecondLevelCriteria = chemicalEngineering },
                new ThirdLevelCriteria { Name = "Molecular engineering", Tags = "molecular engineering", SecondLevelCriteria = chemicalEngineering },
                new ThirdLevelCriteria { Name = "Nanotechnology", Tags = "nanotechnology", SecondLevelCriteria = chemicalEngineering },
                new ThirdLevelCriteria { Name = "Polymer engineering", Tags = "polymer engineering", SecondLevelCriteria = chemicalEngineering },
                new ThirdLevelCriteria { Name = "Petroleum engineering", Tags = "petroleum engineering,process design", SecondLevelCriteria = chemicalEngineering },
                new ThirdLevelCriteria { Name = "Nuclear engineering", Tags = "nuclear engineering,process design", SecondLevelCriteria = chemicalEngineering },
                new ThirdLevelCriteria { Name = "Food engineering", Tags = "food engineering,process design", SecondLevelCriteria = chemicalEngineering },
                new ThirdLevelCriteria { Name = "Reaction engineering", Tags = "reaction engineering", SecondLevelCriteria = chemicalEngineering },
                new ThirdLevelCriteria { Name = "Thermodynamics", Tags = "thermodynamics", SecondLevelCriteria = chemicalEngineering },
                new ThirdLevelCriteria { Name = "Transport phenomena", Tags = "transport phenomena", SecondLevelCriteria = chemicalEngineering }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                chemicalEngineering.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}