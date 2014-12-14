using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Arts(ref Criteria arts, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Performing arts", Tags = "performing arts", Parent = arts },
                new Criteria { Name = "Visual arts", Tags = "visual arts", Parent = arts },
                new Criteria { Name = "Applied arts", Tags = "applied arts", Parent = arts },
                new Criteria { Name = "Other arts", Tags = "other arts", Parent = arts }
            };

            foreach (var criteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(criteria);
                arts.Children.Add(criteria);
            }
        }
    }
}