using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_PoliticalScience(ref Criteria politicalScience, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "American politics", Tags = "american politics", Parent = politicalScience },
                new Criteria { Name = "Canadian politics", Tags = "canadian politics", Parent = politicalScience },
                new Criteria { Name = "Civics", Tags = "civics", Parent = politicalScience },
                new Criteria { Name = "Comparative politics", Tags = "comparative politics", Parent = politicalScience },
                new Criteria { Name = "Geopolitics", Tags = "geopolitics,political geography", Parent = politicalScience },
                new Criteria { Name = "International relations", Tags = "international relations", Parent = politicalScience },
                new Criteria { Name = "International organizations", Tags = "international organizations", Parent = politicalScience },
                new Criteria { Name = "Nationalism studies", Tags = "nationalism studies", Parent = politicalScience },
                new Criteria { Name = "Peace and conflict studies", Tags = "peace and conflict studies", Parent = politicalScience },
                new Criteria { Name = "Policy studies", Tags = "policy studies", Parent = politicalScience },
                new Criteria { Name = "Political behavior", Tags = "political behavior", Parent = politicalScience },
                new Criteria { Name = "Political culture", Tags = "political culture", Parent = politicalScience },
                new Criteria { Name = "Political economy", Tags = "political economy", Parent = politicalScience },
                new Criteria { Name = "Political history", Tags = "political history", Parent = politicalScience },
                new Criteria { Name = "Political philosophy", Tags = "political philosophy", Parent = politicalScience },
                new Criteria { Name = "Psephology", Tags = "psephology", Parent = politicalScience },
                new Criteria { Name = "Nonprofit administration", Tags = "nonprofit administration,public administration", Parent = politicalScience },
                new Criteria { Name = "Non-governmental organization", Tags = "non-governmental organization,public administration", Parent = politicalScience },
                new Criteria { Name = "Public policy", Tags = "public policy", Parent = politicalScience },
                new Criteria { Name = "Social choice theory", Tags = "social choice theory", Parent = politicalScience }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                politicalScience.Children.Add(thirdLevelCriteria);
            }
        }
    }
}