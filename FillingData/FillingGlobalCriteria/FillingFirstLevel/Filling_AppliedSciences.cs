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
                var applSciences = uow.Repository<Criteria>().Get(x => x.Name == "Applied Sciences").FirstOrDefault();
                if (applSciences != null)
                {
                    var secondLevelCriterias = applSciences.Children.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.Children.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.Repository<Criteria>().Delete(thirdLevel);
                        }
                        uow.Repository<Criteria>().Delete(secondLevel);
                    }
                    uow.Repository<Criteria>().Delete(applSciences);
                }
                uow.Commit();
            }

            // Добавляем данные связанные с критерием AppliedSciences
            using (var uow = new UnitOfWork())
            {
                var appliedSciences = new Criteria
                {
                    Name = "Applied Sciences",
                    Tags = "applied sciences",
                    Children = new Collection<Criteria>()
                };

                FillingSecondLevelCriteria.Filling_AppliedSciences(ref appliedSciences, uow);
                uow.Repository<Criteria>().Add(appliedSciences);
                uow.Commit();
            }
        }
    }
}