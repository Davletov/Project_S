namespace FiilingData.FillingGlobalCriteria.FillingFirstLevel
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingSecondLevel;

    public partial class FillingFirstLevelCriteria
    {
        public static void Filling_AppliedSciences()
        {
            // Сначала удаляем из таблиц данные связанные с критерием AppliedSciences
            using (var uow = new UnitOfWork())
            {
                var applSciences = uow.FirstLevelCriteriaRepository.Get(x => x.Name == "Applied Sciences").FirstOrDefault();
                if (applSciences != null)
                {
                    var secondLevelCriterias = applSciences.SecondLevelCriteria.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.ThirdLevelCriteria.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.ThirdLevelCriteriaRepository.Delete(thirdLevel);
                        }
                        uow.SecondLevelCriteriaRepository.Delete(secondLevel);
                    }
                    uow.FirstLevelCriteriaRepository.Delete(applSciences);
                }
                uow.Save();
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
                uow.FirstLevelCriteriaRepository.Add(appliedSciences);
                uow.Save();
            }
        }
    }
}