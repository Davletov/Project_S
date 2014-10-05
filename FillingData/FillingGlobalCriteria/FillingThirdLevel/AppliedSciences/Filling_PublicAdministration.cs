using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_PublicAdministration(ref SecondLevelCriteria publicAdministration, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Corrections", Tags = "corrections", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Conservation biology", Tags = "conservation biology", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Criminal justice", Tags = "criminal justice", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Emergency management", Tags = "emergency management", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Fire safety", Tags = "fire safety,structural fire protection", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Fire ecology", Tags = "fire ecology,wildland fire management", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Governmental affairs", Tags = "governmental affairs", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "International affairs", Tags = "international affairs", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Peace and conflict studies", Tags = "peace and conflict studies", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Police science", Tags = "police science", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Nonprofit administration", Tags = "nonprofit administration,public administration", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Non-governmental organization", Tags = "non-governmental organization,NGO,administration,public administration", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Agricultural policy", Tags = "agricultural policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Defense policy", Tags = "defense policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Domestic policy", Tags = "domestic policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Education policy", Tags = "education policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Health policy", Tags = "health policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Housing policy", Tags = "housing policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Labor policy", Tags = "labor policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Social policy", Tags = "social policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Drug policy", Tags = "drug policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Energy policy", Tags = "energy policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Environmental policy", Tags = "environmental policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Fiscal policy", Tags = "fiscal policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Foreign policy", Tags = "foreign policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Immigration policy", Tags = "immigration policy,public policy", SecondLevelCriteria = publicAdministration},
                new ThirdLevelCriteria {Name = "Trade policy", Tags = "trade policy,public policy", SecondLevelCriteria = publicAdministration}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                publicAdministration.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



