namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_ElectricalEngineering(ref SecondLevelCriteria electricalEngineering, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Applied physics", Tags = "applied physics", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Computer engineering", Tags = "computer engineering", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Computer science", Tags = "computer science", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Control systems engineering", Tags = "control systems engineering", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Control theory", Tags = "control theory", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Electronic engineering", Tags = "electronic engineering", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Instrumentation engineering", Tags = "instrumentation engineering", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Engineering physics", Tags = "engineering physics", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Photonics", Tags = "photonics", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Information theory", Tags = "information theory", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Mechatronics", Tags = "mechatronics", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Power engineering", Tags = "power engineering", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Robotics", Tags = "robotics", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Semiconductors", Tags = "semiconductors", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Telecommunications engineering", Tags = "telecommunications engineering", SecondLevelCriteria = electricalEngineering },
                new ThirdLevelCriteria { Name = "Quantum computing", Tags = "quantum computing", SecondLevelCriteria = electricalEngineering }
            };

             foreach (var thirdLevelCriteria in tmpThirdCritList)
             {
                 uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                 electricalEngineering.ThirdLevelCriteria.Add(thirdLevelCriteria);
             }
        }
    }
}