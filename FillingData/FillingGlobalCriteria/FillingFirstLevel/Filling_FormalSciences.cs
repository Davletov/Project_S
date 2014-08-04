namespace FiilingData.FillingGlobalCriteria.FillingFirstLevel
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingSecondLevel;

    public partial class FillingFirstLevelCriteria
    {
        public static void Filling_FormalSciences()
        {
            // Сначала удаляем из таблиц данные связанные с критерием FormalSciences
            using (var uow = new UnitOfWork())
            {
                var formSciences = uow.FirstLevelCriteriaRepository.Get(x => x.Name == "Formal Sciences").FirstOrDefault();
                if (formSciences != null)
                {
                    var secondLevelCriterias = formSciences.SecondLevelCriteria.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.ThirdLevelCriteria.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.ThirdLevelCriteriaRepository.Delete(thirdLevel);
                        }
                        uow.SecondLevelCriteriaRepository.Delete(secondLevel);
                    }
                    uow.FirstLevelCriteriaRepository.Delete(formSciences);
                }
                uow.Save();
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
                uow.FirstLevelCriteriaRepository.Add(formalSciences);
                uow.Save();
            }
        }
    }
}