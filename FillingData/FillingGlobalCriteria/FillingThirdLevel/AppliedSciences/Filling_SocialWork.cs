using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_SocialWork(ref Criteria socialWork, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Child welfare", Tags = "Child welfare", Parent = socialWork},
                new Criteria {Name = "Community practice", Tags = "community practice", Parent = socialWork},
                new Criteria {Name = "Community organizing", Tags = "community organizing", Parent = socialWork},
                new Criteria {Name = "Social policy", Tags = "social policy", Parent = socialWork},
                new Criteria {Name = "Corrections", Tags = "corrections", Parent = socialWork},
                new Criteria {Name = "Gerontology", Tags = "gerontology", Parent = socialWork},
                new Criteria {Name = "Medical social work", Tags = "medical social work", Parent = socialWork},
                new Criteria {Name = "Mental health", Tags = "mental health", Parent = socialWork},
                new Criteria {Name = "School social work", Tags = "school social work", Parent = socialWork}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                socialWork.Children.Add(thirdLevelCriteria);
            }
        }
    }
}



