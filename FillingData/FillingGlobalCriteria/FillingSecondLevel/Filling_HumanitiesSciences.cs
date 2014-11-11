using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;    
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_HumanitiesSciences(ref Criteria humanitiesSciences, UnitOfWork uow)
        {
            var tmpSecondCritList = new List<Criteria>();
            var item_1 = new Criteria { Name = "History", Tags = "history", Parent = humanitiesSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_History(ref item_1, uow);
            tmpSecondCritList.Add(item_1);

            var item_2 = new Criteria { Name = "Linguistics", Tags = "linguistics", Parent = humanitiesSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Linguistics(ref item_2, uow);
            tmpSecondCritList.Add(item_2);

            var item_3 = new Criteria { Name = "Literature", Tags = "literature", Parent = humanitiesSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Literature(ref item_3, uow);
            tmpSecondCritList.Add(item_3);

            var item_4 = new Criteria { Name = "Arts", Tags = "arts", Parent = humanitiesSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Arts(ref item_4, uow);
            tmpSecondCritList.Add(item_4);

            var item_5 = new Criteria { Name = "Philosophy", Tags = "philosophy", Parent = humanitiesSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Philosophy(ref item_5, uow);
            tmpSecondCritList.Add(item_5);

            var item_6 = new Criteria { Name = "Religion", Tags = "religion", Parent = humanitiesSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Religion(ref item_6, uow);
            tmpSecondCritList.Add(item_6);

            foreach (var secondLevelCriteria in tmpSecondCritList)
            {
                uow.Repository<Criteria>().Add(secondLevelCriteria);
                humanitiesSciences.Children.Add(secondLevelCriteria);
            }
        }
    }
}