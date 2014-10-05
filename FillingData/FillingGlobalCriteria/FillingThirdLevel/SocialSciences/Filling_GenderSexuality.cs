using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_GenderSexuality(ref SecondLevelCriteria genderSexuality, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Feminine psychology", Tags = "feminine psychology", SecondLevelCriteria = genderSexuality },
                new ThirdLevelCriteria { Name = "Gender studies", Tags = "gender studies,gender theory", SecondLevelCriteria = genderSexuality },
                new ThirdLevelCriteria { Name = "Heterosexism", Tags = "heterosexism", SecondLevelCriteria = genderSexuality },
                new ThirdLevelCriteria { Name = "Human sexual behavior", Tags = "human sexual behavior", SecondLevelCriteria = genderSexuality },
                new ThirdLevelCriteria { Name = "Human sexuality", Tags = "human sexuality", SecondLevelCriteria = genderSexuality },
                new ThirdLevelCriteria { Name = "Masculine psychology", Tags = "masculine psychology", SecondLevelCriteria = genderSexuality },
                new ThirdLevelCriteria { Name = "Men's studies", Tags = "men's studies", SecondLevelCriteria = genderSexuality },
                new ThirdLevelCriteria { Name = "Queer studies", Tags = "queer studies,queer theory", SecondLevelCriteria = genderSexuality },
                new ThirdLevelCriteria { Name = "Sex education", Tags = "sex education", SecondLevelCriteria = genderSexuality },
                new ThirdLevelCriteria { Name = "Sexology", Tags = "sexology", SecondLevelCriteria = genderSexuality },
                new ThirdLevelCriteria { Name = "women's studies", Tags = "women's studies", SecondLevelCriteria = genderSexuality }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                genderSexuality.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}