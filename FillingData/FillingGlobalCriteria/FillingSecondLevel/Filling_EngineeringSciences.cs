namespace FiilingData.FillingGlobalCriteria.FillingSecondLevel
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingThirdLevel;

    public partial class FillingSecondLevelCriteria
    {
        public static void Filling_EngineeringSciences(ref FirstLevelCriteria engineeringSciences, UnitOfWork uow)
        {
            var tmpSecondCritList = new List<SecondLevelCriteria>();
            var item_1 = new SecondLevelCriteria { Name = "Mechanical Engineering", Tags = "mechanical engineering", FirstLevelCriteria = engineeringSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>()};
            FillingThirdLevelCriteria.Filling_MechanicalEngineering(ref item_1, uow);
            tmpSecondCritList.Add(item_1);

            var item_2 = new SecondLevelCriteria { Name = "Chemical Engineering", Tags = "chemical engineering", FirstLevelCriteria = engineeringSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_ChemicalEngineering(ref item_2, uow);
            tmpSecondCritList.Add(item_2);

            var item_3 = new SecondLevelCriteria { Name = "Civil Engineering", Tags = "civil engineering", FirstLevelCriteria = engineeringSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_CivilEngineering(ref item_3, uow);
            tmpSecondCritList.Add(item_3);

            var item_4 = new SecondLevelCriteria { Name = "Electrical Engineering", Tags = "electrical engineering", FirstLevelCriteria = engineeringSciences, ThirdLevelCriteria = new Collection<ThirdLevelCriteria>() };
            FillingThirdLevelCriteria.Filling_ElectricalEngineering(ref item_4, uow);
            tmpSecondCritList.Add(item_4);

            foreach (var secondLevelCriteria in tmpSecondCritList)
            {
                uow.SecondLevelCriteriaRepository.Add(secondLevelCriteria);
                engineeringSciences.SecondLevelCriteria.Add(secondLevelCriteria);
            }
        }
    }
}