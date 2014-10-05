using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_PoliticalScience(ref SecondLevelCriteria politicalScience, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "American politics", Tags = "american politics", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Canadian politics", Tags = "canadian politics", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Civics", Tags = "civics", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Comparative politics", Tags = "comparative politics", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Geopolitics", Tags = "geopolitics,political geography", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "International relations", Tags = "international relations", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "International organizations", Tags = "international organizations", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Nationalism studies", Tags = "nationalism studies", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Peace and conflict studies", Tags = "peace and conflict studies", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Policy studies", Tags = "policy studies", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Political behavior", Tags = "political behavior", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Political culture", Tags = "political culture", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Political economy", Tags = "political economy", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Political history", Tags = "political history", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Political philosophy", Tags = "political philosophy", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Psephology", Tags = "psephology", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Nonprofit administration", Tags = "nonprofit administration,public administration", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Non-governmental organization", Tags = "non-governmental organization,public administration", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Public policy", Tags = "public policy", SecondLevelCriteria = politicalScience },
                new ThirdLevelCriteria { Name = "Social choice theory", Tags = "social choice theory", SecondLevelCriteria = politicalScience }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                politicalScience.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}