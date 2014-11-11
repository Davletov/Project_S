using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingFirstLevel
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;    
    using FiilingData.FillingGlobalCriteria.FillingSecondLevel;
    
    public partial class FillingFirstLevelCriteria
    {
        public static void Filling_SocialSciences()
        {
            // Сначала удаляем из таблиц данные связанные с критерием SocialSciences
            using (var uow = new UnitOfWork())
            {
                var socSciences = uow.Repository<Criteria>().Get(x => x.Name == "Social sciences").FirstOrDefault();
                if (socSciences != null)
                {
                    var secondLevelCriterias = socSciences.Children.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.Children.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.Repository<Criteria>().Delete(thirdLevel);
                        }
                        uow.Repository<Criteria>().Delete(secondLevel);
                    }
                    uow.Repository<Criteria>().Delete(socSciences);
                }
                uow.Commit();
            }

            // Добавляем данные связанные с критерием HumanitiesSciences
            using (var uow = new UnitOfWork())
            {
                var socialSciences = new Criteria
                {
                    Name = "Social sciences",
                    Tags = "social sciences,public sciences,community sciences",
                    Children = new Collection<Criteria>()
                };

                FillingSecondLevelCriteria.Filling_SocialSciences(ref socialSciences, uow);
                uow.Repository<Criteria>().Add(socialSciences);
                uow.Commit();
            }
        }
    }
}