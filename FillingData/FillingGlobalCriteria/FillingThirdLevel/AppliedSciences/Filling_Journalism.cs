namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Journalism(ref SecondLevelCriteria journalism, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Broadcast journalism", Tags = "broadcast journalism", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Literary journalism", Tags = "literary journalism", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "New media journalism", Tags = "new media journalism", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Print journalism", Tags = "print journalism", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Sports journalism and sportscasting", Tags = "sports journalism,sportscasting", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Newspaper", Tags = "newspaper,media studies,mass media", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Magazine", Tags = "magazine,media studies,mass media", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Radio", Tags = "radio,media studies,mass media", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Television", Tags = "television,media studies,mass media", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Television studies", Tags = "television studies,media studies,mass media", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Internet", Tags = "internet,media studies,mass media", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Advertising", Tags = "advertising,communication studies", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Animal communication", Tags = "animal communication,communication studies", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Communication design", Tags = "communication design,communication studies", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Environmental communication", Tags = "environmental communication,communication studies", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Information theory", Tags = "information theory,communication studies", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Intercultural communication", Tags = "intercultural communication,communication studies", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Marketing", Tags = "marketing,communication studies", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Mass communication", Tags = "mass communication,communication studies", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Nonverbal communication", Tags = "nonverbal communication,sports biomechanics", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Organizational communication", Tags = "organizational communication,sports biomechanics", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Propaganda", Tags = "propaganda,sports biomechanics", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Public relations", Tags = "public relations,sports biomechanics", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Speech communication", Tags = "speech communication,sports biomechanics", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Technical writing", Tags = "technical writing,sports biomechanics", SecondLevelCriteria = journalism},
                new ThirdLevelCriteria {Name = "Translation", Tags = "translation,sports biomechanics", SecondLevelCriteria = journalism}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                journalism.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



