using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_HumanPerformanceRecreation(ref Criteria humanPerformanceRecreation, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Biomechanics", Tags = "biomechanics,sports biomechanics", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Sports coaching", Tags = "sports coaching", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Dance", Tags = "dance", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Ergonomics", Tags = "ergonomics", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Group Fitness and aerobics", Tags = "group fitness,aerobics,physical fitness", Parent = humanPerformanceRecreation},
                new Criteria {Name = "personal trainer", Tags = "personal trainer,personal fitness training,physical fitness", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Game design", Tags = "game design", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Exercise physiology", Tags = "exercise physiology", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Kinesiology", Tags = "kinesiology,exercise science,human performance", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Leisure studies", Tags = "leisure studies", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Physical education", Tags = "physical education,pedagogy", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Sociology of sport", Tags = "sociology of sport", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Sexology", Tags = "sexology", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Sports journalism", Tags = "sports journalism,sportscasting", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Sport management", Tags = "sport management", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Athletic director", Tags = "athletic director", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Sport psychology", Tags = "sport psychology", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Sports medicine", Tags = "sports medicine", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Athletic training", Tags = "athletic training", Parent = humanPerformanceRecreation},
                new Criteria {Name = "Toy and amusement design", Tags = "toy design,amusement design", Parent = humanPerformanceRecreation}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                humanPerformanceRecreation.Children.Add(thirdLevelCriteria);
            }
        }
    }
}



