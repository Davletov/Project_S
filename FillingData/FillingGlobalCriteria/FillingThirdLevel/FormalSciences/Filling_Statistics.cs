using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Statistics(ref Criteria statistics, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Data mining", Tags = "data mining,computational statistics", Parent = statistics },
                new Criteria { Name = "Regression", Tags = "regression,computational statistics", Parent = statistics },
                new Criteria { Name = "Simulation", Tags = "simulation,computational statistics", Parent = statistics },
                new Criteria { Name = "Bootstrap", Tags = "bootstrap,statistics,computational statistics", Parent = statistics },
                new Criteria { Name = "Block design and Analysis of variance", Tags = "block design,analysis of variance,design of experiments", Parent = statistics },
                new Criteria { Name = "Response surface methodology", Tags = "response surface methodology,design of experiments", Parent = statistics },
                new Criteria { Name = "Sample Survey", Tags = "sample survey", Parent = statistics },
                new Criteria { Name = "Sampling theory", Tags = "sampling theory", Parent = statistics },
                new Criteria { Name = "Biostatistics", Tags = "biostatistics,statistical modelling", Parent = statistics },
                new Criteria { Name = "Epidemiology", Tags = "epidemiology,statistical modelling", Parent = statistics },
                new Criteria { Name = "Multivariate analysis", Tags = "multivariate analysis,statistical modelling", Parent = statistics },
                new Criteria { Name = "Structural equation model", Tags = "structural equation model,statistical modelling", Parent = statistics },
                new Criteria { Name = "Time series", Tags = "time series,statistical modelling", Parent = statistics },
                new Criteria { Name = "Reliability theory", Tags = "reliability theory,statistical modelling", Parent = statistics },
                new Criteria { Name = "Quality control", Tags = "quality control,statistical modelling", Parent = statistics },
                new Criteria { Name = "Decision theory", Tags = "decision theory,statistical theory", Parent = statistics },
                new Criteria { Name = "Mathematical statistics", Tags = "mathematical statistics,statistical theory", Parent = statistics },
                new Criteria { Name = "Probability", Tags = "probability,statistical theory", Parent = statistics },
                new Criteria { Name = "Survey methodology", Tags = "survey methodology,statistical theory", Parent = statistics }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                statistics.Children.Add(thirdLevelCriteria);
            }
        }
    }
}