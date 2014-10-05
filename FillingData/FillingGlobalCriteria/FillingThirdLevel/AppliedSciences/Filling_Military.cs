using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Military(ref SecondLevelCriteria military, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Amphibious warfare", Tags = "amphibious warfare", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Artillery", Tags = "artillery", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Campaigning", Tags = "campaigning", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Military engineering", Tags = "military engineering", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Doctrine", Tags = "doctrine", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Game theory", Tags = "game theory", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Leadership", Tags = "leadership", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Logistics", Tags = "logistics", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Military intelligence", Tags = "military intelligence", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Military law", Tags = "military law", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Military medicine", Tags = "military medicine", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Naval engineering", Tags = "naval engineering,naval science", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Naval tactics", Tags = "naval tactics,naval science", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Naval architecture", Tags = "naval architecture,naval science", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Weapons systems", Tags = "weapons systems,naval science", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Strategy", Tags = "strategy", SecondLevelCriteria = military},
                new ThirdLevelCriteria {Name = "Naval tactics", Tags = "naval tactics,tactics", SecondLevelCriteria = military}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                military.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



