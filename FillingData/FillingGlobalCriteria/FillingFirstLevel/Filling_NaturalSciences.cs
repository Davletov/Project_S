using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingFirstLevel
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;    
    using FiilingData.FillingGlobalCriteria.FillingSecondLevel;

    public partial class FillingFirstLevelCriteria
    {
        public static void Filling_NaturalSciences()
        {
            // Сначала удаляем из таблиц данные связанные с критерием NaturalSciences
            using (var uow = new UnitOfWork())
            {
                var natSciences = uow.Repository<FirstLevelCriteria>().Get(x => x.Name == "Natural Sciences").FirstOrDefault();
                if (natSciences != null)
                {
                    var secondLevelCriterias = natSciences.SecondLevelCriteria.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.ThirdLevelCriteria.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.Repository<ThirdLevelCriteria>().Delete(thirdLevel);
                        }
                        uow.Repository<SecondLevelCriteria>().Delete(secondLevel);
                    }
                    uow.Repository<FirstLevelCriteria>().Delete(natSciences);
                }
                uow.Commit();
            }

            // Добавляем данные связанные с критерием HumanitiesSciences
            using (var uow = new UnitOfWork())
            {
                var naturalSciences = new FirstLevelCriteria
                {
                    Name = "Natural Sciences",
                    Tags = "natural sciences,natural",
                    SecondLevelCriteria = new Collection<SecondLevelCriteria>()
                };
                FillingSecondLevelCriteria.Filling_NaturalSciences(ref naturalSciences, uow);
                uow.Repository<FirstLevelCriteria>().Add(naturalSciences);
                uow.Commit();
            }
        }
    }
}