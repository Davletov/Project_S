using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_SocialWork(ref SecondLevelCriteria socialWork, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Child welfare", Tags = "Child welfare", SecondLevelCriteria = socialWork},
                new ThirdLevelCriteria {Name = "Community practice", Tags = "community practice", SecondLevelCriteria = socialWork},
                new ThirdLevelCriteria {Name = "Community organizing", Tags = "community organizing", SecondLevelCriteria = socialWork},
                new ThirdLevelCriteria {Name = "Social policy", Tags = "social policy", SecondLevelCriteria = socialWork},
                new ThirdLevelCriteria {Name = "Corrections", Tags = "corrections", SecondLevelCriteria = socialWork},
                new ThirdLevelCriteria {Name = "Gerontology", Tags = "gerontology", SecondLevelCriteria = socialWork},
                new ThirdLevelCriteria {Name = "Medical social work", Tags = "medical social work", SecondLevelCriteria = socialWork},
                new ThirdLevelCriteria {Name = "Mental health", Tags = "mental health", SecondLevelCriteria = socialWork},
                new ThirdLevelCriteria {Name = "School social work", Tags = "school social work", SecondLevelCriteria = socialWork}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                socialWork.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



