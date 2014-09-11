namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Sociology(ref SecondLevelCriteria sociology, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Political sociology", Tags = "political sociology,applied sociology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Public sociology", Tags = "public sociology,applied sociology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social engineering", Tags = "social engineering,applied sociology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Leisure studies", Tags = "leisure studies,applied sociology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social movements", Tags = "social movements,collective behavior", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social network analysis", Tags = "social network analysis,community informatics", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Comparative sociology", Tags = "comparative sociology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Conflict theory", Tags = "conflict theory", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Cultural studies", Tags = "cultural studies", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Criminology/Criminal justice", Tags = "criminology,criminal justice", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Critical management studies", Tags = "critical management studies", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Demography", Tags = "demography,population", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Environmental sociology", Tags = "environmental sociology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Feminist sociology", Tags = "feminist sociology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Futures studies", Tags = "futures studies", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Human ecology", Tags = "human ecology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Humanistic sociology", Tags = "humanistic sociology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Phenomenology", Tags = "phenomenology,interactionism", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Ethnomethodology", Tags = "ethnomethodology,interactionism", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Symbolic interactionism", Tags = "symbolic interactionism,interactionism", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social constructionism", Tags = "social constructionism,interactionism", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Medical sociology", Tags = "medical sociology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Military sociology", Tags = "military sociology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Organizational studies", Tags = "organizational studies", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Science and technology studies", Tags = "science studies,technology studies", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sexology", Tags = "sexology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social capital", Tags = "social capital", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social change", Tags = "social change", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social transformation", Tags = "social transformation", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Pure sociology", Tags = "pure sociology,social control", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social economy", Tags = "social economy", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social philosophy", Tags = "social philosophy", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social psychology", Tags = "social psychology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social policy", Tags = "social policy", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Computational sociology", Tags = "computational sociology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Economic sociology,Socioeconomics", Tags = "economic sociology,socioeconomics", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociology of culture", Tags = "sociology of culture", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociology of deviance", Tags = "sociology of deviance", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociology of education", Tags = "sociology of education", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociology of gender", Tags = "sociology of gender", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociology of the family", Tags = "sociology of the family", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociology of knowledge", Tags = "sociology of knowledge", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociology of law", Tags = "sociology of law", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociology of religion", Tags = "sociology of religion", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociology of sport", Tags = "sociology of sport", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociology of work", Tags = "sociology of work", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social theory", Tags = "social theory", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Social stratification", Tags = "social stratification", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociological theory", Tags = "sociological theory", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociobiology", Tags = "sociobiology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociocybernetics", Tags = "sociocybernetics", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Sociolinguistics", Tags = "sociolinguistics", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Urban studies or Urban sociology", Tags = "urban studies,urban sociology,rural sociology", SecondLevelCriteria = sociology },
                new ThirdLevelCriteria { Name = "Visual sociology", Tags = "visual sociology", SecondLevelCriteria = sociology }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                sociology.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}