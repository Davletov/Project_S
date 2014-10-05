using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Psychology(ref SecondLevelCriteria psychology, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Abnormal psychology", Tags = "abnormal psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Applied psychology", Tags = "applied psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Biological psychology", Tags = "biological psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Clinical psychology", Tags = "clinical psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Clinical neuropsychology", Tags = "clinical neuropsychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Cognitive psychology", Tags = "cognitive psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Community psychology", Tags = "community psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Comparative psychology", Tags = "comparative psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Conservation psychology", Tags = "conservation psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Consumer psychology", Tags = "consumer psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Counseling psychology", Tags = "counseling psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Cultural psychology", Tags = "cultural psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Differential psychology", Tags = "differential psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Developmental psychology", Tags = "developmental psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Educational psychology", Tags = "educational psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Environmental psychology", Tags = "environmental psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Evolutionary psychology", Tags = "evolutionary psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Experimental psychology", Tags = "experimental psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Group psychology", Tags = "group psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Family psychology", Tags = "family psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Forensic psychology", Tags = "forensic psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Health psychology", Tags = "health psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Humanistic psychology", Tags = "humanistic psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Legal psychology", Tags = "legal psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Media psychology", Tags = "media psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Medical psychology", Tags = "medical psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Military psychology", Tags = "military psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Moral psychology and Descriptive ethics", Tags = "moral psychology,descriptive ethics", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Neuropsychology", Tags = "neuropsychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Occupational health psychology", Tags = "occupational health psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Organizational psychology", Tags = "organizational psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Parapsychology", Tags = "parapsychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Pediatric psychology", Tags = "pediatric psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Personality psychology", Tags = "personality psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Political psychology", Tags = "political psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Positive psychology", Tags = "positive psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Psychoanalysis", Tags = "psychoanalysis", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Psychometrics", Tags = "psychometrics", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Psychology of religion", Tags = "psychology of religion", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Psychophysics", Tags = "psychophysics", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Quantitative psychology", Tags = "quantitative psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Rehabilitation psychology", Tags = "rehabilitation psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "School psychology", Tags = "school psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Social psychology", Tags = "social psychology", SecondLevelCriteria = psychology },
                new ThirdLevelCriteria { Name = "Sport psychology", Tags = "sport psychology", SecondLevelCriteria = psychology }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                psychology.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}