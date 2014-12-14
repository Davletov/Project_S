using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Journalism(ref Criteria journalism, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Broadcast journalism", Tags = "broadcast journalism", Parent = journalism},
                new Criteria {Name = "Literary journalism", Tags = "literary journalism", Parent = journalism},
                new Criteria {Name = "New media journalism", Tags = "new media journalism", Parent = journalism},
                new Criteria {Name = "Print journalism", Tags = "print journalism", Parent = journalism},
                new Criteria {Name = "Sports journalism and sportscasting", Tags = "sports journalism,sportscasting", Parent = journalism},
                new Criteria {Name = "Newspaper", Tags = "newspaper,media studies,mass media", Parent = journalism},
                new Criteria {Name = "Magazine", Tags = "magazine,media studies,mass media", Parent = journalism},
                new Criteria {Name = "Radio", Tags = "radio,media studies,mass media", Parent = journalism},
                new Criteria {Name = "Television", Tags = "television,media studies,mass media", Parent = journalism},
                new Criteria {Name = "Television studies", Tags = "television studies,media studies,mass media", Parent = journalism},
                new Criteria {Name = "Internet", Tags = "internet,media studies,mass media", Parent = journalism},
                new Criteria {Name = "Advertising", Tags = "advertising,communication studies", Parent = journalism},
                new Criteria {Name = "Animal communication", Tags = "animal communication,communication studies", Parent = journalism},
                new Criteria {Name = "Communication design", Tags = "communication design,communication studies", Parent = journalism},
                new Criteria {Name = "Environmental communication", Tags = "environmental communication,communication studies", Parent = journalism},
                new Criteria {Name = "Information theory", Tags = "information theory,communication studies", Parent = journalism},
                new Criteria {Name = "Intercultural communication", Tags = "intercultural communication,communication studies", Parent = journalism},
                new Criteria {Name = "Marketing", Tags = "marketing,communication studies", Parent = journalism},
                new Criteria {Name = "Mass communication", Tags = "mass communication,communication studies", Parent = journalism},
                new Criteria {Name = "Nonverbal communication", Tags = "nonverbal communication,sports biomechanics", Parent = journalism},
                new Criteria {Name = "Organizational communication", Tags = "organizational communication,sports biomechanics", Parent = journalism},
                new Criteria {Name = "Propaganda", Tags = "propaganda,sports biomechanics", Parent = journalism},
                new Criteria {Name = "Public relations", Tags = "public relations,sports biomechanics", Parent = journalism},
                new Criteria {Name = "Speech communication", Tags = "speech communication,sports biomechanics", Parent = journalism},
                new Criteria {Name = "Technical writing", Tags = "technical writing,sports biomechanics", Parent = journalism},
                new Criteria {Name = "Translation", Tags = "translation,sports biomechanics", Parent = journalism}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                journalism.Children.Add(thirdLevelCriteria);
            }
        }
    }
}



