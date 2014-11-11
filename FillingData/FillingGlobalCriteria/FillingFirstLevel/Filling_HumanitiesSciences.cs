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
                var humSciences = uow.Repository<Criteria>().Get(x => x.Name == "Humanities sciences").FirstOrDefault();
                if (humSciences != null)
                {
                    var secondLevelCriterias = humSciences.Children.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.Children.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.Repository<Criteria>().Delete(thirdLevel);
                        }
                        uow.Repository<Criteria>().Delete(secondLevel);
                    }
                    uow.Repository<Criteria>().Delete(humSciences);
                }
                uow.Commit();
            }

            // Добавляем данные связанные с критерием HumanitiesSciences
            using (var uow = new UnitOfWork())
            {
                var humanitiesSciences = new Criteria
                {
                    Name = "Humanities sciences",
                    Tags = "humanities sciences,liberal arts",
                    Children = new Collection<Criteria>()
                };
                FillingSecondLevelCriteria.Filling_HumanitiesSciences(ref humanitiesSciences, uow);
                uow.Repository<Criteria>().Add(humanitiesSciences);
                uow.Commit();
            }
        }
    }
}