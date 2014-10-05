using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;    
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_NaturalSciences(ref FirstLevelCriteria naturalSciences, UnitOfWork uow)
        {
            var tmpSecondCritList = new List<SecondLevelCriteria>();
            var item_1 = new SecondLevelCriteria { Name = "Physics and Space sciences", Tags = "physics sciences,space sciences", FirstLevelCriteria = naturalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>()};
            FillingThirdLevelCriteria.Filling_PhysicsSpaceSciences(ref item_1, uow);
            tmpSecondCritList.Add(item_1);

            var item_2 = new SecondLevelCriteria { Name = "Earth sciences", Tags = "earth sciences", FirstLevelCriteria = naturalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Earth(ref item_2, uow);
            tmpSecondCritList.Add(item_2);

            var item_3 = new SecondLevelCriteria { Name = "Biology", Tags = "biology", FirstLevelCriteria = naturalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Biology(ref item_3, uow);
            tmpSecondCritList.Add(item_3);

            var item_4 = new SecondLevelCriteria { Name = "Chemistry", Tags = "chemistry", FirstLevelCriteria = naturalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_Chemistry(ref item_4, uow);
            tmpSecondCritList.Add(item_4);

            var item_5 = new SecondLevelCriteria { Name = "Materials Science and Engineering", Tags = "materials Science and engineering", FirstLevelCriteria = naturalSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_MaterialsEngineering(ref item_5, uow);
            tmpSecondCritList.Add(item_5);


            foreach (var secondLevelCriteria in tmpSecondCritList)
            {
                uow.Repository<SecondLevelCriteria>().Add(secondLevelCriteria);
                naturalSciences.SecondLevelCriteria.Add(secondLevelCriteria);
            }
        }
    }
}