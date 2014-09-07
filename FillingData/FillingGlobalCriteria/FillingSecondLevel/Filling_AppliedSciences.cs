using System.Collections.Generic;

namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_AppliedSciences(ref FirstLevelCriteria appliedSciences, UnitOfWork uow)
        {
            var tmpSecondCritList = new List<SecondLevelCriteria>();
            var item_1 = new SecondLevelCriteria { Name = "Agriculture", Tags = "agriculture", FirstLevelCriteria = appliedSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>()};
            FillingThirdLevelCriteria.Filling_Agriculture(ref item_1, uow);
            tmpSecondCritList.Add(item_1);
            
            var item_2 = new SecondLevelCriteria { Name = "Architecture and design", Tags = "architecture,design", FirstLevelCriteria = appliedSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_ArchitectureAndDesign(ref item_2, uow);
            tmpSecondCritList.Add(item_2);

            var item_3 = new SecondLevelCriteria { Name = "Business", Tags = "business", FirstLevelCriteria = appliedSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Business(ref item_3, uow);
            tmpSecondCritList.Add(item_3);

            var item_4 = new SecondLevelCriteria { Name = "Divinity", Tags = "divinity", FirstLevelCriteria = appliedSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Divinity(ref item_4, uow);
            tmpSecondCritList.Add(item_4);

            var item_5 = new SecondLevelCriteria { Name = "Education", Tags = "education", FirstLevelCriteria = appliedSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Education(ref item_5, uow);
            tmpSecondCritList.Add(item_5);

            var item_6 = new SecondLevelCriteria { Name = "Environmental studies and forestry", Tags = "environmental studies and forestry", FirstLevelCriteria = appliedSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_EnvironmentalAndForestry(ref item_6, uow);
            tmpSecondCritList.Add(item_6);

            var item_7 = new SecondLevelCriteria { Name = "Family and consumer science", Tags = "family and consumer science", FirstLevelCriteria = appliedSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_FamilyAndConsumer(ref item_7, uow);
            tmpSecondCritList.Add(item_7);

            var item_8 = new SecondLevelCriteria { Name = "Healthcare science", Tags = "healthcare science", FirstLevelCriteria = appliedSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_HealthcareScience(ref item_8, uow);
            tmpSecondCritList.Add(item_8);

            var item_9 = new SecondLevelCriteria { Name = "Human physical performance and recreation", Tags = "human physical performance,recreation", FirstLevelCriteria = appliedSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_HumanPerformanceRecreation(ref item_9, uow);
            tmpSecondCritList.Add(item_9);

            var item_10 = new SecondLevelCriteria { Name = "Journalism, media studies and communication", Tags = "journalism, media studies and communication", FirstLevelCriteria = appliedSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Journalism(ref item_10, uow);
            tmpSecondCritList.Add(item_10);
            /* продолжить */


            foreach (var secondLevelCriteria in tmpSecondCritList)
            {
                uow.SecondLevelCriteriaRepository.Add(secondLevelCriteria);
                appliedSciences.SecondLevelCriteria.Add(secondLevelCriteria);
            }
        }
    }
}