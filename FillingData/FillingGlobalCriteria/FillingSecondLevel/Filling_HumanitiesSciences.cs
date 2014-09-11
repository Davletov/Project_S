namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_HumanitiesSciences(ref FirstLevelCriteria humanitiesSciences, UnitOfWork uow)
        {
            var tmpSecondCritList = new List<SecondLevelCriteria>();
            var item_1 = new SecondLevelCriteria { Name = "History", Tags = "history", FirstLevelCriteria = humanitiesSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_History(ref item_1, uow);
            tmpSecondCritList.Add(item_1);

            var item_2 = new SecondLevelCriteria { Name = "Linguistics", Tags = "linguistics", FirstLevelCriteria = humanitiesSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Linguistics(ref item_2, uow);
            tmpSecondCritList.Add(item_2);

            var item_3 = new SecondLevelCriteria { Name = "Literature", Tags = "literature", FirstLevelCriteria = humanitiesSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Literature(ref item_3, uow);
            tmpSecondCritList.Add(item_3);

            var item_4 = new SecondLevelCriteria { Name = "Arts", Tags = "arts", FirstLevelCriteria = humanitiesSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Arts(ref item_4, uow);
            tmpSecondCritList.Add(item_4);

            var item_5 = new SecondLevelCriteria { Name = "Philosophy", Tags = "philosophy", FirstLevelCriteria = humanitiesSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Philosophy(ref item_5, uow);
            tmpSecondCritList.Add(item_5);

            var item_6 = new SecondLevelCriteria { Name = "Religion", Tags = "religion", FirstLevelCriteria = humanitiesSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Religion(ref item_6, uow);
            tmpSecondCritList.Add(item_6);

            foreach (var secondLevelCriteria in tmpSecondCritList)
            {
                uow.SecondLevelCriteriaRepository.Add(secondLevelCriteria);
                humanitiesSciences.SecondLevelCriteria.Add(secondLevelCriteria);
            }
        }
    }
}