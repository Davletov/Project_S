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
                var natSciences = uow.Repository<Criteria>().Get(x => x.Name == "Natural Sciences").FirstOrDefault();
                if (natSciences != null)
                {
                    var secondLevelCriterias = natSciences.Children.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.Children.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.Repository<Criteria>().Delete(thirdLevel);
                        }
                        uow.Repository<Criteria>().Delete(secondLevel);
                    }
                    uow.Repository<Criteria>().Delete(natSciences);
                }
                uow.Commit();
            }

            // Добавляем данные связанные с критерием HumanitiesSciences
            using (var uow = new UnitOfWork())
            {
                var naturalSciences = new Criteria
                {
                    Name = "Natural Sciences",
                    Tags = "natural sciences,natural",
                    Children = new Collection<Criteria>()
                };
                FillingSecondLevelCriteria.Filling_NaturalSciences(ref naturalSciences, uow);
                uow.Repository<Criteria>().Add(naturalSciences);
                uow.Commit();
            }
        }
    }
}