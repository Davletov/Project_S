using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingFirstLevel
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;    
    using FiilingData.FillingGlobalCriteria.FillingSecondLevel;

    public partial class FillingFirstLevelCriteria
    {
        public static void Filling_FormalSciences()
        {
            // Сначала удаляем из таблиц данные связанные с критерием FormalSciences
            using (var uow = new UnitOfWork())
            {
                var formSciences = uow.Repository<Criteria>().Get(x => x.Name == "Formal Sciences").FirstOrDefault();
                if (formSciences != null)
                {
                    var secondLevelCriterias = formSciences.Children.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.Children.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.Repository<Criteria>().Delete(thirdLevel);
                        }
                        uow.Repository<Criteria>().Delete(secondLevel);
                    }
                    uow.Repository<Criteria>().Delete(formSciences);
                }
                uow.Commit();
            }

            // Добавляем данные связанные с критерием FormalSciences
            using (var uow = new UnitOfWork())
            {
                var formalSciences = new Criteria
                {
                    Name = "Formal Sciences",
                    Tags = "formal sciences,formal",
                    Children = new Collection<Criteria>()
                };

                FillingSecondLevelCriteria.Filling_FormalSciences(ref formalSciences, uow);
                uow.Repository<Criteria>().Add(formalSciences);
                uow.Commit();
            }
        }
    }
}