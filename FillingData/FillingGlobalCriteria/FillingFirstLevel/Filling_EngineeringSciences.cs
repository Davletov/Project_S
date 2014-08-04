namespace FiilingData.FillingGlobalCriteria.FillingFirstLevel
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingSecondLevel;

    public partial class FillingFirstLevelCriteria
    {
        public static void Filling_EngineeringSciences()
        {
            // Сначала удаляем из таблиц данные связанные с критерием EngineeringSciences
            using (var uow = new UnitOfWork())
            {
                var engSciences = uow.FirstLevelCriteriaRepository.Get(x => x.Name == "Engineering Sciences").FirstOrDefault();
                if (engSciences != null)
                {
                    var secondLevelCriterias = engSciences.SecondLevelCriteria.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.ThirdLevelCriteria.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.ThirdLevelCriteriaRepository.Delete(thirdLevel);
                        }
                        uow.SecondLevelCriteriaRepository.Delete(secondLevel);
                    }
                    uow.FirstLevelCriteriaRepository.Delete(engSciences);
                }
                uow.Save();
            }

            // Добавляем данные связанные с критерием EngineeringSciences
            using (var uow = new UnitOfWork())
            {
                var engineeringSciences = new FirstLevelCriteria
                {
                    Name = "Engineering Sciences",
                    Tags = "engineering sciences,engineering",
                    SecondLevelCriteria = new Collection<SecondLevelCriteria>()
                };
                FillingSecondLevelCriteria.Filling_EngineeringSciences(ref engineeringSciences, uow);
                uow.FirstLevelCriteriaRepository.Add(engineeringSciences);
                uow.Save();
            }
        }
    }
}