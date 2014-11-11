using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Business(ref Criteria business, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Accounting scholarship", Tags = "accounting scholarship", Parent = business},
                new Criteria {Name = "Business administration", Tags = "business administration", Parent = business},
                new Criteria {Name = "Business analysis", Tags = "business analysis", Parent = business},
                new Criteria {Name = "Business ethics", Tags = "business ethics", Parent = business},
                new Criteria {Name = "Business law", Tags = "business law", Parent = business},
                new Criteria {Name = "E-Business", Tags = "e-business", Parent = business},
                new Criteria {Name = "Entrepreneurship", Tags = "entrepreneurship", Parent = business},
                new Criteria {Name = "Finance", Tags = "finance", Parent = business},
                new Criteria {Name = "Collective bargaining", Tags = "collective bargaining,industrial,labor relations", Parent = business},
                new Criteria {Name = "Human resources", Tags = "human resources,industrial,labor relations", Parent = business},
                new Criteria {Name = "Organizational studies", Tags = "organizational studies,industrial,labor relations", Parent = business},
                new Criteria {Name = "Labor economics", Tags = "labor economics,industrial,labor relations", Parent = business},
                new Criteria {Name = "Labor history", Tags = "labor history,industrial,labor relations", Parent = business},
                new Criteria {Name = "Management information systems", Tags = "management information systems,information systems,business informatics", Parent = business},
                new Criteria {Name = "Health informatics", Tags = "health informatics,information systems,business informatics", Parent = business},
                new Criteria {Name = "Information technology", Tags = "information technology", Parent = business},
                new Criteria {Name = "International trade", Tags = "international trade", Parent = business},
                new Criteria {Name = "Marketing", Tags = "marketing", Parent = business},
                new Criteria {Name = "Purchasing", Tags = "purchasing", Parent = business},
                new Criteria {Name = "Risk management and insurance", Tags = "risk management and insurance", Parent = business},
                new Criteria {Name = "Systems science", Tags = "systems science", Parent = business}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                business.Children.Add(thirdLevelCriteria);
            }
        }
    }
}

