namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Arts(ref SecondLevelCriteria arts, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Performing arts", Tags = "performing arts", SecondLevelCriteria = arts },
                new ThirdLevelCriteria { Name = "Visual arts", Tags = "visual arts", SecondLevelCriteria = arts },
                new ThirdLevelCriteria { Name = "Applied arts", Tags = "applied arts", SecondLevelCriteria = arts },
                new ThirdLevelCriteria { Name = "Other arts", Tags = "other arts", SecondLevelCriteria = arts }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                arts.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}