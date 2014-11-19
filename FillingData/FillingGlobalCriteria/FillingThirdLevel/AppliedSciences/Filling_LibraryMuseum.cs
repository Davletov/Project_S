using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_LibraryMuseum(ref Criteria libraryMuseum, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Archival science", Tags = "archival science", Parent = libraryMuseum},
                new Criteria {Name = "Bibliometrics", Tags = "bibliometrics", Parent = libraryMuseum},
                new Criteria {Name = "Citation analysis", Tags = "citation analysis", Parent = libraryMuseum},
                new Criteria {Name = "Conservation science", Tags = "conservation science", Parent = libraryMuseum},
                new Criteria {Name = "Informatics", Tags = "informatics", Parent = libraryMuseum},
                new Criteria {Name = "Information architecture", Tags = "information architecture", Parent = libraryMuseum},
                new Criteria {Name = "Museology", Tags = "museology", Parent = libraryMuseum}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                libraryMuseum.Children.Add(thirdLevelCriteria);
            }
        }
    }
}



