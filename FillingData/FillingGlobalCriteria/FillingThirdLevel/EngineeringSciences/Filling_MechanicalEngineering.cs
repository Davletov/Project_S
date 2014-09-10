namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_MechanicalEngineering(ref SecondLevelCriteria mechanicalEngineering, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Aeronautics engineering", Tags = "aeronautics engineering,aerospace engineering", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Astronautics engineering", Tags = "astronautics engineering,aerospace engineering", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Acoustical engineering", Tags = "acoustical engineering", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Automotive engineering", Tags = "automotive engineering", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Biomedical engineering", Tags = "biomedical engineering", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Biomechanical engineering", Tags = "biomechanical engineering", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Continuum mechanics", Tags = "continuum mechanics", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Fluid mechanics", Tags = "fluid mechanics", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Heat transfer", Tags = "heat transfer", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Industrial engineering", Tags = "industrial engineering", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Manufacturing engineering", Tags = "manufacturing engineering", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Marine engineering", Tags = "marine engineering", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Mass transfer", Tags = "mass transfer", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Mechatronics", Tags = "mechatronics", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Nanoengineering", Tags = "nanoengineering", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Ocean engineering", Tags = "ocean engineering", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Optical engineering", Tags = "optical engineering", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Robotics", Tags = "robotics", SecondLevelCriteria = mechanicalEngineering },
                new ThirdLevelCriteria { Name = "Thermodynamics", Tags = "thermodynamics", SecondLevelCriteria = mechanicalEngineering }
            };

             foreach (var thirdLevelCriteria in tmpThirdCritList)
             {
                 uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                 mechanicalEngineering.ThirdLevelCriteria.Add(thirdLevelCriteria);
             }
        }
    }
}