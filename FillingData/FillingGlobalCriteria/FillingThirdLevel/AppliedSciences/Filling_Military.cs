using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Military(ref Criteria military, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Amphibious warfare", Tags = "amphibious warfare", Parent = military},
                new Criteria {Name = "Artillery", Tags = "artillery", Parent = military},
                new Criteria {Name = "Campaigning", Tags = "campaigning", Parent = military},
                new Criteria {Name = "Military engineering", Tags = "military engineering", Parent = military},
                new Criteria {Name = "Doctrine", Tags = "doctrine", Parent = military},
                new Criteria {Name = "Game theory", Tags = "game theory", Parent = military},
                new Criteria {Name = "Leadership", Tags = "leadership", Parent = military},
                new Criteria {Name = "Logistics", Tags = "logistics", Parent = military},
                new Criteria {Name = "Military intelligence", Tags = "military intelligence", Parent = military},
                new Criteria {Name = "Military law", Tags = "military law", Parent = military},
                new Criteria {Name = "Military medicine", Tags = "military medicine", Parent = military},
                new Criteria {Name = "Naval engineering", Tags = "naval engineering,naval science", Parent = military},
                new Criteria {Name = "Naval tactics", Tags = "naval tactics,naval science", Parent = military},
                new Criteria {Name = "Naval architecture", Tags = "naval architecture,naval science", Parent = military},
                new Criteria {Name = "Weapons systems", Tags = "weapons systems,naval science", Parent = military},
                new Criteria {Name = "Strategy", Tags = "strategy", Parent = military},
                new Criteria {Name = "Naval tactics", Tags = "naval tactics,tactics", Parent = military}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                military.Children.Add(thirdLevelCriteria);
            }
        }
    }
}



