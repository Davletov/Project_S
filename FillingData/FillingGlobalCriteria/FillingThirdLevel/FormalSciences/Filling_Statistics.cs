namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Statistics(ref SecondLevelCriteria statistics, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Data mining", Tags = "data mining,computational statistics", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Regression", Tags = "regression,computational statistics", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Simulation", Tags = "simulation,computational statistics", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Bootstrap", Tags = "bootstrap,statistics,computational statistics", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Block design and Analysis of variance", Tags = "block design,analysis of variance,design of experiments", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Response surface methodology", Tags = "response surface methodology,design of experiments", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Sample Survey", Tags = "sample survey", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Sampling theory", Tags = "sampling theory", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Biostatistics", Tags = "biostatistics,statistical modelling", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Epidemiology", Tags = "epidemiology,statistical modelling", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Multivariate analysis", Tags = "multivariate analysis,statistical modelling", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Structural equation model", Tags = "structural equation model,statistical modelling", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Time series", Tags = "time series,statistical modelling", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Reliability theory", Tags = "reliability theory,statistical modelling", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Quality control", Tags = "quality control,statistical modelling", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Decision theory", Tags = "decision theory,statistical theory", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Mathematical statistics", Tags = "mathematical statistics,statistical theory", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Probability", Tags = "probability,statistical theory", SecondLevelCriteria = statistics },
                new ThirdLevelCriteria { Name = "Survey methodology", Tags = "survey methodology,statistical theory", SecondLevelCriteria = statistics }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                statistics.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}