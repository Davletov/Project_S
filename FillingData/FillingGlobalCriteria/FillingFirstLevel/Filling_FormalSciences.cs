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
                var formSciences = uow.Repository<FirstLevelCriteria>().Get(x => x.Name == "Formal Sciences").FirstOrDefault();
                if (formSciences != null)
                {
                    var secondLevelCriterias = formSciences.SecondLevelCriteria.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.ThirdLevelCriteria.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.Repository<ThirdLevelCriteria>().Delete(thirdLevel);
                        }
                        uow.Repository<SecondLevelCriteria>().Delete(secondLevel);
                    }
                    uow.Repository<FirstLevelCriteria>().Delete(formSciences);
                }
                uow.Commit();
            }

            // Добавляем данные связанные с критерием FormalSciences
            using (var uow = new UnitOfWork())
            {
                var formalSciences = new FirstLevelCriteria
                {
                    Name = "Formal Sciences",
                    Tags = "formal sciences,formal",
                    SecondLevelCriteria = new Collection<SecondLevelCriteria>()
                };

                FillingSecondLevelCriteria.Filling_FormalSciences(ref formalSciences, uow);
                uow.Repository<FirstLevelCriteria>().Add(formalSciences);
                uow.Commit();
            }
        }
    }
}