using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingFirstLevel
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;    
    using FiilingData.FillingGlobalCriteria.FillingSecondLevel;

    public partial class FillingFirstLevelCriteria
    {
        public static void Filling_HumanitiesSciences()
        {
            // Сначала удаляем из таблиц данные связанные с критерием HumanitiesSciences
            using (var uow = new UnitOfWork())
            {
                var humSciences = uow.Repository<FirstLevelCriteria>().Get(x => x.Name == "Humanities sciences").FirstOrDefault();
                if (humSciences != null)
                {
                    var secondLevelCriterias = humSciences.SecondLevelCriteria.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.ThirdLevelCriteria.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.Repository<ThirdLevelCriteria>().Delete(thirdLevel);
                        }
                        uow.Repository<SecondLevelCriteria>().Delete(secondLevel);
                    }
                    uow.Repository<FirstLevelCriteria>().Delete(humSciences);
                }
                uow.Commit();
            }

            // Добавляем данные связанные с критерием HumanitiesSciences
            using (var uow = new UnitOfWork())
            {
                var humanitiesSciences = new FirstLevelCriteria
                {
                    Name = "Humanities sciences",
                    Tags = "humanities sciences,liberal arts",
                    SecondLevelCriteria = new Collection<SecondLevelCriteria>()
                };
                FillingSecondLevelCriteria.Filling_HumanitiesSciences(ref humanitiesSciences, uow);
                uow.Repository<FirstLevelCriteria>().Add(humanitiesSciences);
                uow.Commit();
            }
        }
    }
}