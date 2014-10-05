using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Law(ref SecondLevelCriteria law, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Canon law", Tags = "canon law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Comparative law", Tags = "comparative law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Constitutional law", Tags = "constitutional law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Competition law", Tags = "competition law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Criminal procedure", Tags = "criminal procedure,criminal law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Criminal justice", Tags = "criminal justice,criminal law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Police science", Tags = "police science,criminal law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Forensic science", Tags = "forensic science,criminal law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Islamic law", Tags = "islamic law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Jewish law", Tags = "jewish law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Jurisprudence", Tags = "jurisprudence,philosophy of law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Admiralty law", Tags = "admiralty law,civil law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Animal law,rights", Tags = "animal law,animal rights,civil law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Corporations", Tags = "corporations,civil law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Civil procedure", Tags = "civil procedure,civil law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Contract law", Tags = "contract law,civil law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Environmental law", Tags = "environmental law,civil law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "International law", Tags = "international law,civil law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Labor law", Tags = "labor law,civil law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Paralegal studies", Tags = "paralegal studies,civil law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Property law", Tags = "property law,civil law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Tax law", Tags = "tax law,civil law", SecondLevelCriteria = law},
                new ThirdLevelCriteria {Name = "Tort law", Tags = "tort law,civil law", SecondLevelCriteria = law}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                law.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



