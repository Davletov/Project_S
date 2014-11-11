using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingFirstLevel
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;    
    using FiilingData.FillingGlobalCriteria.FillingSecondLevel;

    public partial class FillingFirstLevelCriteria
    {
        public static void Filling_EngineeringSciences()
        {
            // Сначала удаляем из таблиц данные связанные с критерием EngineeringSciences
            using (var uow = new UnitOfWork())
            {
                var engSciences = uow.Repository<Criteria>().Get(x => x.Name == "Engineering Sciences").FirstOrDefault();
                if (engSciences != null)
                {
                    var secondLevelCriterias = engSciences.Children.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.Children.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.Repository<Criteria>().Delete(thirdLevel);
                        }
                        uow.Repository<Criteria>().Delete(secondLevel);
                    }
                    uow.Repository<Criteria>().Delete(engSciences);
                }
                uow.Commit();
            }

            // Добавляем данные связанные с критерием EngineeringSciences
            using (var uow = new UnitOfWork())
            {
                var engineeringSciences = new Criteria
                {
                    Name = "Engineering Sciences",
                    Tags = "engineering sciences,engineering",
                    Children = new Collection<Criteria>()
                };
                FillingSecondLevelCriteria.Filling_EngineeringSciences(ref engineeringSciences, uow);
                uow.Repository<Criteria>().Add(engineeringSciences);
                uow.Commit();
            }
        }
    }
}