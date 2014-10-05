using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingFirstLevel
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;    
    using FiilingData.FillingGlobalCriteria.FillingSecondLevel;

    public partial class FillingFirstLevelCriteria
    {
        public static void Filling_AppliedSciences()
        {
            // Сначала удаляем из таблиц данные связанные с критерием AppliedSciences
            using (var uow = new UnitOfWork())
            {
                var applSciences = uow.Repository<FirstLevelCriteria>().Get(x => x.Name == "Applied Sciences").FirstOrDefault();
                if (applSciences != null)
                {
                    var secondLevelCriterias = applSciences.SecondLevelCriteria.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.ThirdLevelCriteria.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.Repository<ThirdLevelCriteria>().Delete(thirdLevel);
                        }
                        uow.Repository<SecondLevelCriteria>().Delete(secondLevel);
                    }
                    uow.Repository<FirstLevelCriteria>().Delete(applSciences);
                }
                uow.Commit();
            }

            // Добавляем данные связанные с критерием AppliedSciences
            using (var uow = new UnitOfWork())
            {
                var appliedSciences = new FirstLevelCriteria
                {
                    Name = "Applied Sciences",
                    Tags = "applied sciences",
                    SecondLevelCriteria = new Collection<SecondLevelCriteria>()
                };

                FillingSecondLevelCriteria.Filling_AppliedSciences(ref appliedSciences, uow);
                uow.Repository<FirstLevelCriteria>().Add(appliedSciences);
                uow.Commit();
            }
        }
    }
}