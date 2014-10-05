using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Anthropology(ref SecondLevelCriteria anthropology, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Forensic anthropology", Tags = "forensic anthropology,biological anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Gene-culture coevolution", Tags = "gene-culture coevolution,biological anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Human behavioral ecology", Tags = "human behavioral ecology,biological anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Human evolution", Tags = "Human evolution,biological anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Medical anthropology", Tags = "medical anthropology,biological anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Paleoanthropology", Tags = "paleoanthropology,biological anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Population genetics", Tags = "population genetics,biological anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Primatology", Tags = "primatology,biological anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Synchronic linguistics", Tags = "synchronic linguistics,anthropological linguistics", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Diachronic linguistics", Tags = "diachronic linguistics,anthropological linguistics", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Ethnolinguistics", Tags = "ethnolinguistics,anthropological linguistics", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Sociolinguistics", Tags = "sociolinguistics,anthropological linguistics", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Anthropology of religion", Tags = "anthropology of religion,cultural anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Economic anthropology", Tags = "economic anthropology,cultural anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Ethnography", Tags = "ethnography,cultural anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Ethnohistory", Tags = "ethnohistory,cultural anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Ethnology", Tags = "ethnology,cultural anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Ethnomusicology", Tags = "ethnomusicology,cultural anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Folklore", Tags = "folklore,cultural anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Mythology", Tags = "mythology,cultural anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Missiology", Tags = "missiology,cultural anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Political anthropology", Tags = "political anthropology,cultural anthropology", SecondLevelCriteria = anthropology },
                new ThirdLevelCriteria { Name = "Psychological anthropology", Tags = "psychological anthropology,cultural anthropology", SecondLevelCriteria = anthropology }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                anthropology.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}