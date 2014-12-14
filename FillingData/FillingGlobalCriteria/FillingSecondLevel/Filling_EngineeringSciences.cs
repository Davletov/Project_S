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
        public static void Filling_EngineeringSciences(ref Criteria engineeringSciences, UnitOfWork uow)
        {
            var tmpSecondCritList = new List<Criteria>();
            var item_1 = new Criteria { Name = "Mechanical Engineering", Tags = "mechanical engineering", Parent = engineeringSciences, Children = new Collection<Criteria>()};
            FillingThirdLevelCriteria.Filling_MechanicalEngineering(ref item_1, uow);
            tmpSecondCritList.Add(item_1);

            var item_2 = new Criteria { Name = "Chemical Engineering", Tags = "chemical engineering", Parent = engineeringSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_ChemicalEngineering(ref item_2, uow);
            tmpSecondCritList.Add(item_2);

            var item_3 = new Criteria { Name = "Civil Engineering", Tags = "civil engineering", Parent = engineeringSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_CivilEngineering(ref item_3, uow);
            tmpSecondCritList.Add(item_3);

            var item_4 = new Criteria { Name = "Electrical Engineering", Tags = "electrical engineering", Parent = engineeringSciences, Children = new Collection<Criteria>() };
            FillingThirdLevelCriteria.Filling_ElectricalEngineering(ref item_4, uow);
            tmpSecondCritList.Add(item_4);

            foreach (var secondLevelCriteria in tmpSecondCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(secondLevelCriteria);
                engineeringSciences.Children.Add(secondLevelCriteria);
            }
        }
    }
}