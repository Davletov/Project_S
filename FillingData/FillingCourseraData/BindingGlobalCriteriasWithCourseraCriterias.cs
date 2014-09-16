namespace FiilingData.FillingCourseraData
{
    using System.Linq;
    using Web.UnitOfWork;
    using Web.Models.Criteria;

    public static partial class FillingDataFromCoursera
    {
        /// <summary>
        /// Связываем курсы с категориями
        /// </summary>
        public static void BindingGlobalCriteriasWithCourseraCriterias()
        {

            using (var uow = new UnitOfWork())
            {
                var res =
                    uow.CriteriaWithCourseraCategoryRepository.Get().Select(x => x.Category).ToList();

                var tmp = res;
            }

            // Если в таблице GlobalCriteriasWithCourseraCriteria уже есть какие то данные, то удалим их
            using (var uowDel = new UnitOfWork())
            {
                var criteriasList = uowDel.CriteriaWithCourseraCategoryRepository.Get().Select(x => x.GlobalCriteriaId).ToList();
                var countRowsInExistingBase = criteriasList.Count;
                if (countRowsInExistingBase > 0)
                {
                    foreach (var criteriaId in criteriasList)
                    {
                        uowDel.CriteriaWithCourseraCategoryRepository.Delete(criteriaId);
                    }

                    uowDel.Save();
                }
            }

            // Связывание глоб.критериев с категориями курсеры
            using (var uow = new UnitOfWork())
            {
                var philosophyId =
                    uow.SecondLevelCriteriaRepository.Get()
                        .Where(x => x.Name == "Philosophy")
                        .Select(x => x.Id)
                        .FirstOrDefault();

                var humanities = uow.CategoryRepository.Get().Where(x => x.Name == "Humanities").ToList();

                var newCriteriaWithCourseraCategory = new CriteriaWithCourseraCategory
                {
                    GlobalCriteriaId = philosophyId,
                    GlobalCriteriaName = "Philosophy",
                    CourseraCategoryName = "Humanities",
                    Category = humanities
                };

                uow.CriteriaWithCourseraCategoryRepository.Add(newCriteriaWithCourseraCategory); // эта запись запишется

                var thirdCriteriaIds = uow.ThirdLevelCriteriaRepository.Get()
                    .Where(x => x.SecondLevelCriteria.Id == philosophyId)
                    .Select(x => new { x.Id, x.Name }).ToList();

                foreach (var thirdCriteriaId in thirdCriteriaIds)
                {
                    var humanities2 = uow.CategoryRepository.Get().Where(x => x.Name == "Humanities").ToList();

                    var newCriteria = new CriteriaWithCourseraCategory
                    {
                        GlobalCriteriaId = thirdCriteriaId.Id,
                        GlobalCriteriaName = thirdCriteriaId.Name,
                        CourseraCategoryName = "Humanities",
                        Category = humanities2
                    };

                    uow.CriteriaWithCourseraCategoryRepository.Add(newCriteria); // эти записи запишутся, но Category = humanities2 будет пустым
                }
                
                uow.Save();
            }
        }
    }
}
