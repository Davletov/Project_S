namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_LibraryMuseum(ref SecondLevelCriteria libraryMuseum, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Archival science", Tags = "archival science", SecondLevelCriteria = libraryMuseum},
                new ThirdLevelCriteria {Name = "Bibliometrics", Tags = "bibliometrics", SecondLevelCriteria = libraryMuseum},
                new ThirdLevelCriteria {Name = "Citation analysis", Tags = "citation analysis", SecondLevelCriteria = libraryMuseum},
                new ThirdLevelCriteria {Name = "Conservation science", Tags = "conservation science", SecondLevelCriteria = libraryMuseum},
                new ThirdLevelCriteria {Name = "Informatics", Tags = "informatics", SecondLevelCriteria = libraryMuseum},
                new ThirdLevelCriteria {Name = "Information architecture", Tags = "information architecture", SecondLevelCriteria = libraryMuseum},
                new ThirdLevelCriteria {Name = "Museology", Tags = "museology", SecondLevelCriteria = libraryMuseum}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                libraryMuseum.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



