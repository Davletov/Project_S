using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Education(ref Criteria education, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Comparative education", Tags = "comparative education", Parent = education},
                new Criteria {Name = "Consumer education", Tags = "consumer education", Parent = education},
                new Criteria {Name = "Critical pedagogy", Tags = "critical pedagogy", Parent = education},
                new Criteria {Name = "Alternative education", Tags = "alternative education,curriculum", Parent = education},
                new Criteria {Name = "Elementary education", Tags = "elementary education,curriculum", Parent = education},
                new Criteria {Name = "Secondary education", Tags = "secondary education,curriculum", Parent = education},
                new Criteria {Name = "Higher education", Tags = "higher education,curriculum", Parent = education},
                new Criteria {Name = "Mastery learning", Tags = "mastery learning,curriculum", Parent = education},
                new Criteria {Name = "Cooperative learning", Tags = "cooperative learning,curriculum", Parent = education},
                new Criteria {Name = "Agricultural education", Tags = "agricultural education,curriculum", Parent = education},
                new Criteria {Name = "Art education", Tags = "art education,curriculum", Parent = education},
                new Criteria {Name = "Bilingual education", Tags = "bilingual education,curriculum", Parent = education},
                new Criteria {Name = "Chemistry education", Tags = "chemistry education,curriculum", Parent = education},
                new Criteria {Name = "Counselor education", Tags = "Counselor education,curriculum", Parent = education},
                new Criteria {Name = "Language education", Tags = "language education,curriculum", Parent = education},
                new Criteria {Name = "Legal education", Tags = "legal education,curriculum", Parent = education},
                new Criteria {Name = "Mathematics education", Tags = "mathematics education,curriculum", Parent = education},
                new Criteria {Name = "Medical education", Tags = "medical education,curriculum", Parent = education},
                new Criteria {Name = "Military education and training", Tags = "military education and training,curriculum", Parent = education},
                new Criteria {Name = "Music education", Tags = "music education,curriculum", Parent = education},
                new Criteria {Name = "Nursing education", Tags = "nursing education,curriculum", Parent = education},
                new Criteria {Name = "Peace education", Tags = "peace education,curriculum", Parent = education},
                new Criteria {Name = "Physical education/Sports coaching", Tags = "physical education,sports coaching,curriculum", Parent = education},
                new Criteria {Name = "Physics education", Tags = "physics education,curriculum", Parent = education},
                new Criteria {Name = "Reading education", Tags = "reading education,curriculum", Parent = education},
                new Criteria {Name = "Religious education", Tags = "religious education,curriculum", Parent = education},
                new Criteria {Name = "Science education", Tags = "science education,curriculum", Parent = education},
                new Criteria {Name = "Special education", Tags = "special education,curriculum", Parent = education},
                new Criteria {Name = "Sex education", Tags = "sex education,curriculum", Parent = education},
                new Criteria {Name = "Sociology of education", Tags = "sociology of education,curriculum", Parent = education},
                new Criteria {Name = "Technology education", Tags = "technology education,curriculum", Parent = education},
                new Criteria {Name = "Vocational education", Tags = "vocational education,curriculum", Parent = education},
                new Criteria {Name = "Educational leadership", Tags = "educational leadership", Parent = education},
                new Criteria {Name = "Educational philosophy", Tags = "educational philosophy", Parent = education},
                new Criteria {Name = "Educational psychology", Tags = "educational psychology", Parent = education},
                new Criteria {Name = "Educational technology", Tags = "educational technology", Parent = education},
                new Criteria {Name = "Distance education", Tags = "distance education", Parent = education}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                education.Children.Add(thirdLevelCriteria);
            }
        }
    }
}



