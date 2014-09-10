namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Business(ref SecondLevelCriteria business, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Accounting scholarship", Tags = "accounting scholarship", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Business administration", Tags = "business administration", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Business analysis", Tags = "business analysis", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Business ethics", Tags = "business ethics", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Business law", Tags = "business law", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "E-Business", Tags = "e-business", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Entrepreneurship", Tags = "entrepreneurship", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Finance", Tags = "finance", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Collective bargaining", Tags = "collective bargaining,industrial,labor relations", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Human resources", Tags = "human resources,industrial,labor relations", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Organizational studies", Tags = "organizational studies,industrial,labor relations", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Labor economics", Tags = "labor economics,industrial,labor relations", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Labor history", Tags = "labor history,industrial,labor relations", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Management information systems", Tags = "management information systems,information systems,business informatics", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Health informatics", Tags = "health informatics,information systems,business informatics", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Information technology", Tags = "information technology", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "International trade", Tags = "international trade", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Marketing", Tags = "marketing", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Purchasing", Tags = "purchasing", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Risk management and insurance", Tags = "risk management and insurance", SecondLevelCriteria = business},
                new ThirdLevelCriteria {Name = "Systems science", Tags = "systems science", SecondLevelCriteria = business}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                business.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}

