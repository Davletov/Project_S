using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;    
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_NaturalSciences(ref Criteria naturalSciences, UnitOfWork uow)
        {
            var tmpSecondCritList = new List<Criteria>();
            var item_1 = new Criteria { Name = "Physics and Space sciences", Tags = "physics sciences,space sciences", Parent = naturalSciences, Children = new Collection<Criteria>()};
            FillingThirdLevelCriteria.Filling_PhysicsSpaceSciences(ref item_1, uow);
            tmpSecondCritList.Add(item_1);

            var item_2 = new Criteria { Name = "Earth sciences", Tags = "earth sciences", Parent = naturalSciences, Children = new Collection<Criteria>() };
            //FillingThirdLevelCriteria.Filling_Earth(ref item_2, uow);
            tmpSecondCritList.Add(item_2);

            var item_3 = new Criteria { Name = "Biology", Tags = "biology", Parent = naturalSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Biology(ref item_3, uow);
            tmpSecondCritList.Add(item_3);

            var item_4 = new Criteria { Name = "Chemistry", Tags = "chemistry", Parent = naturalSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_Chemistry(ref item_4, uow);
            tmpSecondCritList.Add(item_4);

            var item_5 = new Criteria { Name = "Materials Science and Engineering", Tags = "materials Science and engineering", Parent = naturalSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_MaterialsEngineering(ref item_5, uow);
            tmpSecondCritList.Add(item_5);


            foreach (var secondLevelCriteria in tmpSecondCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(secondLevelCriteria);
                naturalSciences.Children.Add(secondLevelCriteria);
            }
        }
    }
}