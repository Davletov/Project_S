using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Law(ref Criteria law, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Canon law", Tags = "canon law", Parent = law},
                new Criteria {Name = "Comparative law", Tags = "comparative law", Parent = law},
                new Criteria {Name = "Constitutional law", Tags = "constitutional law", Parent = law},
                new Criteria {Name = "Competition law", Tags = "competition law", Parent = law},
                new Criteria {Name = "Criminal procedure", Tags = "criminal procedure,criminal law", Parent = law},
                new Criteria {Name = "Criminal justice", Tags = "criminal justice,criminal law", Parent = law},
                new Criteria {Name = "Police science", Tags = "police science,criminal law", Parent = law},
                new Criteria {Name = "Forensic science", Tags = "forensic science,criminal law", Parent = law},
                new Criteria {Name = "Islamic law", Tags = "islamic law", Parent = law},
                new Criteria {Name = "Jewish law", Tags = "jewish law", Parent = law},
                new Criteria {Name = "Jurisprudence", Tags = "jurisprudence,philosophy of law", Parent = law},
                new Criteria {Name = "Admiralty law", Tags = "admiralty law,civil law", Parent = law},
                new Criteria {Name = "Animal law,rights", Tags = "animal law,animal rights,civil law", Parent = law},
                new Criteria {Name = "Corporations", Tags = "corporations,civil law", Parent = law},
                new Criteria {Name = "Civil procedure", Tags = "civil procedure,civil law", Parent = law},
                new Criteria {Name = "Contract law", Tags = "contract law,civil law", Parent = law},
                new Criteria {Name = "Environmental law", Tags = "environmental law,civil law", Parent = law},
                new Criteria {Name = "International law", Tags = "international law,civil law", Parent = law},
                new Criteria {Name = "Labor law", Tags = "labor law,civil law", Parent = law},
                new Criteria {Name = "Paralegal studies", Tags = "paralegal studies,civil law", Parent = law},
                new Criteria {Name = "Property law", Tags = "property law,civil law", Parent = law},
                new Criteria {Name = "Tax law", Tags = "tax law,civil law", Parent = law},
                new Criteria {Name = "Tort law", Tags = "tort law,civil law", Parent = law}
            };

            foreach (var criteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(criteria);
                law.Children.Add(criteria);
            }
        }
    }
}



