namespace FiilingData.FillingGlobalCriteria.FillingFirstLevel
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using Web.Models.Criteria;
    using Web.UnitOfWork;
    using FiilingData.FillingGlobalCriteria.FillingSecondLevel;
    
    public partial class FillingFirstLevelCriteria
    {
        public static void Filling_SocialSciences()
        {
            // Сначала удаляем из таблиц данные связанные с критерием SocialSciences
            using (var uow = new UnitOfWork())
            {
                var socSciences = uow.FirstLevelCriteriaRepository.Get(x => x.Name == "Social sciences").FirstOrDefault();
                if (socSciences != null)
                {
                    var secondLevelCriterias = socSciences.SecondLevelCriteria.ToList();

                    foreach (var secondLevel in secondLevelCriterias)
                    {
                        var thirdLevelCriteriaList = secondLevel.ThirdLevelCriteria.ToList();
                        foreach (var thirdLevel in thirdLevelCriteriaList)
                        {
                            uow.ThirdLevelCriteriaRepository.Delete(thirdLevel);
                        }
                        uow.SecondLevelCriteriaRepository.Delete(secondLevel);
                    }
                    uow.FirstLevelCriteriaRepository.Delete(socSciences);
                }
                uow.Save();
            }

            // Добавляем данные связанные с критерием HumanitiesSciences
            using (var uow = new UnitOfWork())
            {
                var socialSciences = new FirstLevelCriteria
                {
                    Name = "Social sciences",
                    Tags = "social sciences,public sciences,community sciences",
                    SecondLevelCriteria = new Collection<SecondLevelCriteria>()
                };

                FillingSecondLevelCriteria.Filling_SocialSciences(ref socialSciences, uow);
                uow.FirstLevelCriteriaRepository.Add(socialSciences);
                uow.Save();
            }
        }
    }
}