using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Anthropology(ref Criteria anthropology, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Forensic anthropology", Tags = "forensic anthropology,biological anthropology", Parent = anthropology },
                new Criteria { Name = "Gene-culture coevolution", Tags = "gene-culture coevolution,biological anthropology", Parent = anthropology },
                new Criteria { Name = "Human behavioral ecology", Tags = "human behavioral ecology,biological anthropology", Parent = anthropology },
                new Criteria { Name = "Human evolution", Tags = "Human evolution,biological anthropology", Parent = anthropology },
                new Criteria { Name = "Medical anthropology", Tags = "medical anthropology,biological anthropology", Parent = anthropology },
                new Criteria { Name = "Paleoanthropology", Tags = "paleoanthropology,biological anthropology", Parent = anthropology },
                new Criteria { Name = "Population genetics", Tags = "population genetics,biological anthropology", Parent = anthropology },
                new Criteria { Name = "Primatology", Tags = "primatology,biological anthropology", Parent = anthropology },
                new Criteria { Name = "Synchronic linguistics", Tags = "synchronic linguistics,anthropological linguistics", Parent = anthropology },
                new Criteria { Name = "Diachronic linguistics", Tags = "diachronic linguistics,anthropological linguistics", Parent = anthropology },
                new Criteria { Name = "Ethnolinguistics", Tags = "ethnolinguistics,anthropological linguistics", Parent = anthropology },
                new Criteria { Name = "Sociolinguistics", Tags = "sociolinguistics,anthropological linguistics", Parent = anthropology },
                new Criteria { Name = "Anthropology of religion", Tags = "anthropology of religion,cultural anthropology", Parent = anthropology },
                new Criteria { Name = "Economic anthropology", Tags = "economic anthropology,cultural anthropology", Parent = anthropology },
                new Criteria { Name = "Ethnography", Tags = "ethnography,cultural anthropology", Parent = anthropology },
                new Criteria { Name = "Ethnohistory", Tags = "ethnohistory,cultural anthropology", Parent = anthropology },
                new Criteria { Name = "Ethnology", Tags = "ethnology,cultural anthropology", Parent = anthropology },
                new Criteria { Name = "Ethnomusicology", Tags = "ethnomusicology,cultural anthropology", Parent = anthropology },
                new Criteria { Name = "Folklore", Tags = "folklore,cultural anthropology", Parent = anthropology },
                new Criteria { Name = "Mythology", Tags = "mythology,cultural anthropology", Parent = anthropology },
                new Criteria { Name = "Missiology", Tags = "missiology,cultural anthropology", Parent = anthropology },
                new Criteria { Name = "Political anthropology", Tags = "political anthropology,cultural anthropology", Parent = anthropology },
                new Criteria { Name = "Psychological anthropology", Tags = "psychological anthropology,cultural anthropology", Parent = anthropology }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                anthropology.Children.Add(thirdLevelCriteria);
            }
        }
    }
}