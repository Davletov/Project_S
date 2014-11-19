using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Psychology(ref Criteria psychology, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Abnormal psychology", Tags = "abnormal psychology", Parent = psychology },
                new Criteria { Name = "Applied psychology", Tags = "applied psychology", Parent = psychology },
                new Criteria { Name = "Biological psychology", Tags = "biological psychology", Parent = psychology },
                new Criteria { Name = "Clinical psychology", Tags = "clinical psychology", Parent = psychology },
                new Criteria { Name = "Clinical neuropsychology", Tags = "clinical neuropsychology", Parent = psychology },
                new Criteria { Name = "Cognitive psychology", Tags = "cognitive psychology", Parent = psychology },
                new Criteria { Name = "Community psychology", Tags = "community psychology", Parent = psychology },
                new Criteria { Name = "Comparative psychology", Tags = "comparative psychology", Parent = psychology },
                new Criteria { Name = "Conservation psychology", Tags = "conservation psychology", Parent = psychology },
                new Criteria { Name = "Consumer psychology", Tags = "consumer psychology", Parent = psychology },
                new Criteria { Name = "Counseling psychology", Tags = "counseling psychology", Parent = psychology },
                new Criteria { Name = "Cultural psychology", Tags = "cultural psychology", Parent = psychology },
                new Criteria { Name = "Differential psychology", Tags = "differential psychology", Parent = psychology },
                new Criteria { Name = "Developmental psychology", Tags = "developmental psychology", Parent = psychology },
                new Criteria { Name = "Educational psychology", Tags = "educational psychology", Parent = psychology },
                new Criteria { Name = "Environmental psychology", Tags = "environmental psychology", Parent = psychology },
                new Criteria { Name = "Evolutionary psychology", Tags = "evolutionary psychology", Parent = psychology },
                new Criteria { Name = "Experimental psychology", Tags = "experimental psychology", Parent = psychology },
                new Criteria { Name = "Group psychology", Tags = "group psychology", Parent = psychology },
                new Criteria { Name = "Family psychology", Tags = "family psychology", Parent = psychology },
                new Criteria { Name = "Forensic psychology", Tags = "forensic psychology", Parent = psychology },
                new Criteria { Name = "Health psychology", Tags = "health psychology", Parent = psychology },
                new Criteria { Name = "Humanistic psychology", Tags = "humanistic psychology", Parent = psychology },
                new Criteria { Name = "Legal psychology", Tags = "legal psychology", Parent = psychology },
                new Criteria { Name = "Media psychology", Tags = "media psychology", Parent = psychology },
                new Criteria { Name = "Medical psychology", Tags = "medical psychology", Parent = psychology },
                new Criteria { Name = "Military psychology", Tags = "military psychology", Parent = psychology },
                new Criteria { Name = "Moral psychology and Descriptive ethics", Tags = "moral psychology,descriptive ethics", Parent = psychology },
                new Criteria { Name = "Neuropsychology", Tags = "neuropsychology", Parent = psychology },
                new Criteria { Name = "Occupational health psychology", Tags = "occupational health psychology", Parent = psychology },
                new Criteria { Name = "Organizational psychology", Tags = "organizational psychology", Parent = psychology },
                new Criteria { Name = "Parapsychology", Tags = "parapsychology", Parent = psychology },
                new Criteria { Name = "Pediatric psychology", Tags = "pediatric psychology", Parent = psychology },
                new Criteria { Name = "Personality psychology", Tags = "personality psychology", Parent = psychology },
                new Criteria { Name = "Political psychology", Tags = "political psychology", Parent = psychology },
                new Criteria { Name = "Positive psychology", Tags = "positive psychology", Parent = psychology },
                new Criteria { Name = "Psychoanalysis", Tags = "psychoanalysis", Parent = psychology },
                new Criteria { Name = "Psychometrics", Tags = "psychometrics", Parent = psychology },
                new Criteria { Name = "Psychology of religion", Tags = "psychology of religion", Parent = psychology },
                new Criteria { Name = "Psychophysics", Tags = "psychophysics", Parent = psychology },
                new Criteria { Name = "Quantitative psychology", Tags = "quantitative psychology", Parent = psychology },
                new Criteria { Name = "Rehabilitation psychology", Tags = "rehabilitation psychology", Parent = psychology },
                new Criteria { Name = "School psychology", Tags = "school psychology", Parent = psychology },
                new Criteria { Name = "Social psychology", Tags = "social psychology", Parent = psychology },
                new Criteria { Name = "Sport psychology", Tags = "sport psychology", Parent = psychology }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                psychology.Children.Add(thirdLevelCriteria);
            }
        }
    }
}