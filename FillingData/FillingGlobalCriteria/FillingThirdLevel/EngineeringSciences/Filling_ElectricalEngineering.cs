using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_ElectricalEngineering(ref Criteria electricalEngineering, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Applied physics", Tags = "applied physics", Parent = electricalEngineering },
                new Criteria { Name = "Computer engineering", Tags = "computer engineering", Parent = electricalEngineering },
                new Criteria { Name = "Computer science", Tags = "computer science", Parent = electricalEngineering },
                new Criteria { Name = "Control systems engineering", Tags = "control systems engineering", Parent = electricalEngineering },
                new Criteria { Name = "Control theory", Tags = "control theory", Parent = electricalEngineering },
                new Criteria { Name = "Electronic engineering", Tags = "electronic engineering", Parent = electricalEngineering },
                new Criteria { Name = "Instrumentation engineering", Tags = "instrumentation engineering", Parent = electricalEngineering },
                new Criteria { Name = "Engineering physics", Tags = "engineering physics", Parent = electricalEngineering },
                new Criteria { Name = "Photonics", Tags = "photonics", Parent = electricalEngineering },
                new Criteria { Name = "Information theory", Tags = "information theory", Parent = electricalEngineering },
                new Criteria { Name = "Mechatronics", Tags = "mechatronics", Parent = electricalEngineering },
                new Criteria { Name = "Power engineering", Tags = "power engineering", Parent = electricalEngineering },
                new Criteria { Name = "Robotics", Tags = "robotics", Parent = electricalEngineering },
                new Criteria { Name = "Semiconductors", Tags = "semiconductors", Parent = electricalEngineering },
                new Criteria { Name = "Telecommunications engineering", Tags = "telecommunications engineering", Parent = electricalEngineering },
                new Criteria { Name = "Quantum computing", Tags = "quantum computing", Parent = electricalEngineering }
            };

             foreach (var thirdLevelCriteria in tmpThirdCritList)
             {
                 uow.Repository<Criteria>().Add(thirdLevelCriteria);
                 electricalEngineering.Children.Add(thirdLevelCriteria);
             }
        }
    }
}