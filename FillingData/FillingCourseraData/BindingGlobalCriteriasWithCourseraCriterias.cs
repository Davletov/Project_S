using System.Collections.ObjectModel;
using Web.Models.CourseraEntity;

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
                var secondLevCriteriaId = uow.SecondLevelCriteriaRepository.Get().Where(x => x.Name == "Philosophy").Select(x => x.Id).FirstOrDefault();
                var res2 = uow.ThirdLevelCriteriaRepository.Get().Where(x => x.SecondLevelCriteria.Id == secondLevCriteriaId).Select(x => x.Categories).ToList();
                var tmp = res2;
            }

            // Связываем 2-й и 3-й уровень глоб.критериев с категориями Coursera
            BindCriterias("Arts", "Arts");
            BindCriterias("Agriculture", "Energy & Earth Sciences"); // ?
            BindCriterias("Anthropology", "Biology & Life Sciences"); // ?
            BindCriterias("Applied Mathematics", "Mathematics");
            BindCriterias("Archaeology", "Energy & Earth Sciences"); // ?
            BindCriterias("Architecture and design", "Engineering"); // ?
            BindCriterias("Area studies", "-");
            BindCriterias("Biology", "Biology & Life Sciences");
            BindCriterias("Business", "Business & Management");
            BindCriterias("Chemical Engineering", "Chemistry");
            BindCriterias("Chemistry", "Chemistry");
            BindCriterias("Civil Engineering", "Engineering");

            BindCriterias("Computer sciences", "Computer Science: Artificial Intelligence"); // Computer sciences - переработать
            BindCriterias("Computer sciences", "Computer Science: Software Engineering");
            BindCriterias("Computer sciences", "Computer Science: Systems & Security");
            BindCriterias("Computer sciences", "Computer Science: Theory");

            BindCriterias("Cultural and ethnic studies", "Humanities"); // ?
            BindCriterias("Divinity", "-");
            BindCriterias("Earth sciences", "Energy & Earth Sciences");
            BindCriterias("Earth sciences", "Physical & Earth Sciences");
            BindCriterias("Economics", "Economics & Finance");
            BindCriterias("Education", "Education");
            BindCriterias("Electrical Engineering", "-");

            BindCriterias("Environmental studies and forestry", "-");
            BindCriterias("Family and consumer science", "Food and Nutrition");
            BindCriterias("Family and consumer science", "Health & Society");

            BindCriterias("Gender and sexuality studies", "-");
            BindCriterias("Geography", "-");
            BindCriterias("Healthcare science", "Health & Society");
            BindCriterias("History", "-");
            BindCriterias("Human physical performance and recreation", "Health & Society"); // ?

            BindCriterias("Journalism, media studies and communication", "-");
            BindCriterias("Law", "Law");

            BindCriterias("Library and museum studies", "-");
            BindCriterias("Linguistics", "-");
            BindCriterias("Literature", "Humanities");
            BindCriterias("Logic", "-");
            BindCriterias("Materials Science and Engineering", "Physical & Earth Sciences"); // ?
            BindCriterias("Mechanical Engineering", "Engineering");
            BindCriterias("Military sciences", "-");
            BindCriterias("Military sciences", "-");
            BindCriterias("Philosophy", "Humanities");
            BindCriterias("Physics and Space sciences", "Physics");
            BindCriterias("Political science", "-");
            BindCriterias("Psychology", "-");
            BindCriterias("Public administration", "-");

            BindCriterias("Pure Mathematics", "Mathematics");
            BindCriterias("Religion", "-");
            BindCriterias("Social work", "-");
            BindCriterias("Sociology", "-");
            BindCriterias("Statistics", "Statistics and Data Analysis");
            BindCriterias("Systems science", "-");
            BindCriterias("Transportation", "-");
        }


        private static void BindCriterias(string globalCriteria, string courseraCriteria)
        {
            // Связывание глоб.критериев с категориями курсеры
            using (var uow = new UnitOfWork())
            {
                var secGlobalCriteria = uow.SecondLevelCriteriaRepository.Get().FirstOrDefault(x => x.Name == globalCriteria); // 2-й уровень Global Criteria

                var courseraCategory = uow.CategoryRepository.Get().FirstOrDefault(x => x.Name == courseraCriteria); // Категория Coursera

                if (secGlobalCriteria == null || courseraCategory == null) return;

                secGlobalCriteria.Categories = new Collection<Category> {courseraCategory};
                uow.SecondLevelCriteriaRepository.Update(secGlobalCriteria);


                var thirdCriterias = uow.ThirdLevelCriteriaRepository.Get()
                    .Where(x => x.SecondLevelCriteria.Id == secGlobalCriteria.Id).ToList();

                // Все критерии 3-го уровня из globalCriteria(2-й уровень) связываем с courseraCriteria
                foreach (var thirdCriteria in thirdCriterias)
                {
                    thirdCriteria.Categories = new Collection<Category>();
                    thirdCriteria.Categories = new Collection<Category> {courseraCategory};

                    uow.ThirdLevelCriteriaRepository.Update(thirdCriteria);
                }

                uow.Save();
            }
        }
    }
}
