using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_FamilyAndConsumer(ref Criteria familyAndConsumer, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Consumer education", Tags = "consumer education", Parent = familyAndConsumer},
                new Criteria {Name = "Housing", Tags = "housing", Parent = familyAndConsumer},
                new Criteria {Name = "Interior design", Tags = "interior design", Parent = familyAndConsumer},
                new Criteria {Name = "Nutrition", Tags = "nutrition", Parent = familyAndConsumer},
                new Criteria {Name = "Foodservice management", Tags = "foodservice management", Parent = familyAndConsumer},
                new Criteria {Name = "Textiles", Tags = "textiles", Parent = familyAndConsumer}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                familyAndConsumer.Children.Add(thirdLevelCriteria);
            }
        }
    }
}



