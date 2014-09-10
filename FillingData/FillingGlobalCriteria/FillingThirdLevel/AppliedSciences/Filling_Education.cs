namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Education(ref SecondLevelCriteria education, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Comparative education", Tags = "comparative education", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Consumer education", Tags = "consumer education", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Critical pedagogy", Tags = "critical pedagogy", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Alternative education", Tags = "alternative education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Elementary education", Tags = "elementary education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Secondary education", Tags = "secondary education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Higher education", Tags = "higher education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Mastery learning", Tags = "mastery learning,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Cooperative learning", Tags = "cooperative learning,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Agricultural education", Tags = "agricultural education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Art education", Tags = "art education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Bilingual education", Tags = "bilingual education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Chemistry education", Tags = "chemistry education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Counselor education", Tags = "Counselor education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Language education", Tags = "language education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Legal education", Tags = "legal education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Mathematics education", Tags = "mathematics education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Medical education", Tags = "medical education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Military education and training", Tags = "military education and training,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Music education", Tags = "music education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Nursing education", Tags = "nursing education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Peace education", Tags = "peace education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Physical education/Sports coaching", Tags = "physical education,sports coaching,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Physics education", Tags = "physics education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Reading education", Tags = "reading education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Religious education", Tags = "religious education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Science education", Tags = "science education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Special education", Tags = "special education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Sex education", Tags = "sex education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Sociology of education", Tags = "sociology of education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Technology education", Tags = "technology education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Vocational education", Tags = "vocational education,curriculum", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Educational leadership", Tags = "educational leadership", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Educational philosophy", Tags = "educational philosophy", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Educational psychology", Tags = "educational psychology", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Educational technology", Tags = "educational technology", SecondLevelCriteria = education},
                new ThirdLevelCriteria {Name = "Distance education", Tags = "distance education", SecondLevelCriteria = education}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                education.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



