using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_PublicAdministration(ref Criteria publicAdministration, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Corrections", Tags = "corrections", Parent = publicAdministration},
                new Criteria {Name = "Conservation biology", Tags = "conservation biology", Parent = publicAdministration},
                new Criteria {Name = "Criminal justice", Tags = "criminal justice", Parent = publicAdministration},
                new Criteria {Name = "Emergency management", Tags = "emergency management", Parent = publicAdministration},
                new Criteria {Name = "Fire safety", Tags = "fire safety,structural fire protection", Parent = publicAdministration},
                new Criteria {Name = "Fire ecology", Tags = "fire ecology,wildland fire management", Parent = publicAdministration},
                new Criteria {Name = "Governmental affairs", Tags = "governmental affairs", Parent = publicAdministration},
                new Criteria {Name = "International affairs", Tags = "international affairs", Parent = publicAdministration},
                new Criteria {Name = "Peace and conflict studies", Tags = "peace and conflict studies", Parent = publicAdministration},
                new Criteria {Name = "Police science", Tags = "police science", Parent = publicAdministration},
                new Criteria {Name = "Nonprofit administration", Tags = "nonprofit administration,public administration", Parent = publicAdministration},
                new Criteria {Name = "Non-governmental organization", Tags = "non-governmental organization,NGO,administration,public administration", Parent = publicAdministration},
                new Criteria {Name = "Agricultural policy", Tags = "agricultural policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Defense policy", Tags = "defense policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Domestic policy", Tags = "domestic policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Education policy", Tags = "education policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Health policy", Tags = "health policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Housing policy", Tags = "housing policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Labor policy", Tags = "labor policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Social policy", Tags = "social policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Drug policy", Tags = "drug policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Energy policy", Tags = "energy policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Environmental policy", Tags = "environmental policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Fiscal policy", Tags = "fiscal policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Foreign policy", Tags = "foreign policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Immigration policy", Tags = "immigration policy,public policy", Parent = publicAdministration},
                new Criteria {Name = "Trade policy", Tags = "trade policy,public policy", Parent = publicAdministration}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                publicAdministration.Children.Add(thirdLevelCriteria);
            }
        }
    }
}



