namespace FiilingData.FillingGlobalCriteria.FillingFirstLevel
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingSecondLevel;

    public partial class FillingFirstLevelCriteria
    {
        public static void Filling_NaturalSciences()
        {
            // Сначала удаляем из таблиц данные связанные с критерием NaturalSciences
            using (var uow = new UnitOfWork())
            {
                var natSciences = uow.FirstLevelCriteriaRepository.Get(x => x.Name == "Natural Sciences").FirstOrDefault();
                if (natSciences != null)
                {
                    var secondLevelCriterias = natSciences.SecondLevelCriteria.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.ThirdLevelCriteria.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.ThirdLevelCriteriaRepository.Delete(thirdLevel);
                        }
                        uow.SecondLevelCriteriaRepository.Delete(secondLevel);
                    }
                    uow.FirstLevelCriteriaRepository.Delete(natSciences);
                }
                uow.Save();
            }

            // Добавляем данные связанные с критерием HumanitiesSciences
            using (var uow = new UnitOfWork())
            {
                var naturalSciences = new FirstLevelCriteria
                {
                    Name = "Natural Sciences",
                    Tags = "natural sciences,natural",
                    SecondLevelCriteria = new Collection<SecondLevelCriteria>()
                };
                FillingSecondLevelCriteria.Filling_NaturalSciences(ref naturalSciences, uow);
                uow.FirstLevelCriteriaRepository.Add(naturalSciences);
                uow.Save();
            }
        }
    }
}