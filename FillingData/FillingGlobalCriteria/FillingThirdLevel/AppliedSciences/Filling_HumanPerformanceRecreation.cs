namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_HumanPerformanceRecreation(ref SecondLevelCriteria humanPerformanceRecreation, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Biomechanics", Tags = "biomechanics,sports biomechanics", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Sports coaching", Tags = "sports coaching", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Dance", Tags = "dance", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Ergonomics", Tags = "ergonomics", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Group Fitness and aerobics", Tags = "group fitness,aerobics,physical fitness", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "personal trainer", Tags = "personal trainer,personal fitness training,physical fitness", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Game design", Tags = "game design", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Exercise physiology", Tags = "exercise physiology", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Kinesiology", Tags = "kinesiology,exercise science,human performance", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Leisure studies", Tags = "leisure studies", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Physical education", Tags = "physical education,pedagogy", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Sociology of sport", Tags = "sociology of sport", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Sexology", Tags = "sexology", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Sports journalism", Tags = "sports journalism,sportscasting", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Sport management", Tags = "sport management", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Athletic director", Tags = "athletic director", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Sport psychology", Tags = "sport psychology", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Sports medicine", Tags = "sports medicine", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Athletic training", Tags = "athletic training", SecondLevelCriteria = humanPerformanceRecreation},
                new ThirdLevelCriteria {Name = "Toy and amusement design", Tags = "toy design,amusement design", SecondLevelCriteria = humanPerformanceRecreation}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                humanPerformanceRecreation.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



