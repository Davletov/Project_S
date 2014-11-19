using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_GenderSexuality(ref Criteria genderSexuality, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Feminine psychology", Tags = "feminine psychology", Parent = genderSexuality },
                new Criteria { Name = "Gender studies", Tags = "gender studies,gender theory", Parent = genderSexuality },
                new Criteria { Name = "Heterosexism", Tags = "heterosexism", Parent = genderSexuality },
                new Criteria { Name = "Human sexual behavior", Tags = "human sexual behavior", Parent = genderSexuality },
                new Criteria { Name = "Human sexuality", Tags = "human sexuality", Parent = genderSexuality },
                new Criteria { Name = "Masculine psychology", Tags = "masculine psychology", Parent = genderSexuality },
                new Criteria { Name = "Men's studies", Tags = "men's studies", Parent = genderSexuality },
                new Criteria { Name = "Queer studies", Tags = "queer studies,queer theory", Parent = genderSexuality },
                new Criteria { Name = "Sex education", Tags = "sex education", Parent = genderSexuality },
                new Criteria { Name = "Sexology", Tags = "sexology", Parent = genderSexuality },
                new Criteria { Name = "women's studies", Tags = "women's studies", Parent = genderSexuality }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                genderSexuality.Children.Add(thirdLevelCriteria);
            }
        }
    }
}