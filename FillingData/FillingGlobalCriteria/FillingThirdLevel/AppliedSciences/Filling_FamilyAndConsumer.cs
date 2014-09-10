namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_FamilyAndConsumer(ref SecondLevelCriteria familyAndConsumer, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Consumer education", Tags = "consumer education", SecondLevelCriteria = familyAndConsumer},
                new ThirdLevelCriteria {Name = "Housing", Tags = "housing", SecondLevelCriteria = familyAndConsumer},
                new ThirdLevelCriteria {Name = "Interior design", Tags = "interior design", SecondLevelCriteria = familyAndConsumer},
                new ThirdLevelCriteria {Name = "Nutrition", Tags = "nutrition", SecondLevelCriteria = familyAndConsumer},
                new ThirdLevelCriteria {Name = "Foodservice management", Tags = "foodservice management", SecondLevelCriteria = familyAndConsumer},
                new ThirdLevelCriteria {Name = "Textiles", Tags = "textiles", SecondLevelCriteria = familyAndConsumer}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                familyAndConsumer.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



