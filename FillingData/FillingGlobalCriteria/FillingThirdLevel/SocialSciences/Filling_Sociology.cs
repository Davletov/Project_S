using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Sociology(ref Criteria sociology, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Political sociology", Tags = "political sociology,applied sociology", Parent = sociology },
                new Criteria { Name = "Public sociology", Tags = "public sociology,applied sociology", Parent = sociology },
                new Criteria { Name = "Social engineering", Tags = "social engineering,applied sociology", Parent = sociology },
                new Criteria { Name = "Leisure studies", Tags = "leisure studies,applied sociology", Parent = sociology },
                new Criteria { Name = "Social movements", Tags = "social movements,collective behavior", Parent = sociology },
                new Criteria { Name = "Social network analysis", Tags = "social network analysis,community informatics", Parent = sociology },
                new Criteria { Name = "Comparative sociology", Tags = "comparative sociology", Parent = sociology },
                new Criteria { Name = "Conflict theory", Tags = "conflict theory", Parent = sociology },
                new Criteria { Name = "Cultural studies", Tags = "cultural studies", Parent = sociology },
                new Criteria { Name = "Criminology/Criminal justice", Tags = "criminology,criminal justice", Parent = sociology },
                new Criteria { Name = "Critical management studies", Tags = "critical management studies", Parent = sociology },
                new Criteria { Name = "Demography", Tags = "demography,population", Parent = sociology },
                new Criteria { Name = "Environmental sociology", Tags = "environmental sociology", Parent = sociology },
                new Criteria { Name = "Feminist sociology", Tags = "feminist sociology", Parent = sociology },
                new Criteria { Name = "Futures studies", Tags = "futures studies", Parent = sociology },
                new Criteria { Name = "Human ecology", Tags = "human ecology", Parent = sociology },
                new Criteria { Name = "Humanistic sociology", Tags = "humanistic sociology", Parent = sociology },
                new Criteria { Name = "Phenomenology", Tags = "phenomenology,interactionism", Parent = sociology },
                new Criteria { Name = "Ethnomethodology", Tags = "ethnomethodology,interactionism", Parent = sociology },
                new Criteria { Name = "Symbolic interactionism", Tags = "symbolic interactionism,interactionism", Parent = sociology },
                new Criteria { Name = "Social constructionism", Tags = "social constructionism,interactionism", Parent = sociology },
                new Criteria { Name = "Medical sociology", Tags = "medical sociology", Parent = sociology },
                new Criteria { Name = "Military sociology", Tags = "military sociology", Parent = sociology },
                new Criteria { Name = "Organizational studies", Tags = "organizational studies", Parent = sociology },
                new Criteria { Name = "Science and technology studies", Tags = "science studies,technology studies", Parent = sociology },
                new Criteria { Name = "Sexology", Tags = "sexology", Parent = sociology },
                new Criteria { Name = "Social capital", Tags = "social capital", Parent = sociology },
                new Criteria { Name = "Social change", Tags = "social change", Parent = sociology },
                new Criteria { Name = "Social transformation", Tags = "social transformation", Parent = sociology },
                new Criteria { Name = "Pure sociology", Tags = "pure sociology,social control", Parent = sociology },
                new Criteria { Name = "Social economy", Tags = "social economy", Parent = sociology },
                new Criteria { Name = "Social philosophy", Tags = "social philosophy", Parent = sociology },
                new Criteria { Name = "Social psychology", Tags = "social psychology", Parent = sociology },
                new Criteria { Name = "Social policy", Tags = "social policy", Parent = sociology },
                new Criteria { Name = "Computational sociology", Tags = "computational sociology", Parent = sociology },
                new Criteria { Name = "Economic sociology,Socioeconomics", Tags = "economic sociology,socioeconomics", Parent = sociology },
                new Criteria { Name = "Sociology of culture", Tags = "sociology of culture", Parent = sociology },
                new Criteria { Name = "Sociology of deviance", Tags = "sociology of deviance", Parent = sociology },
                new Criteria { Name = "Sociology of education", Tags = "sociology of education", Parent = sociology },
                new Criteria { Name = "Sociology of gender", Tags = "sociology of gender", Parent = sociology },
                new Criteria { Name = "Sociology of the family", Tags = "sociology of the family", Parent = sociology },
                new Criteria { Name = "Sociology of knowledge", Tags = "sociology of knowledge", Parent = sociology },
                new Criteria { Name = "Sociology of law", Tags = "sociology of law", Parent = sociology },
                new Criteria { Name = "Sociology of religion", Tags = "sociology of religion", Parent = sociology },
                new Criteria { Name = "Sociology of sport", Tags = "sociology of sport", Parent = sociology },
                new Criteria { Name = "Sociology of work", Tags = "sociology of work", Parent = sociology },
                new Criteria { Name = "Social theory", Tags = "social theory", Parent = sociology },
                new Criteria { Name = "Social stratification", Tags = "social stratification", Parent = sociology },
                new Criteria { Name = "Sociological theory", Tags = "sociological theory", Parent = sociology },
                new Criteria { Name = "Sociobiology", Tags = "sociobiology", Parent = sociology },
                new Criteria { Name = "Sociocybernetics", Tags = "sociocybernetics", Parent = sociology },
                new Criteria { Name = "Sociolinguistics", Tags = "sociolinguistics", Parent = sociology },
                new Criteria { Name = "Urban studies or Urban sociology", Tags = "urban studies,urban sociology,rural sociology", Parent = sociology },
                new Criteria { Name = "Visual sociology", Tags = "visual sociology", Parent = sociology }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                sociology.Children.Add(thirdLevelCriteria);
            }
        }
    }
}