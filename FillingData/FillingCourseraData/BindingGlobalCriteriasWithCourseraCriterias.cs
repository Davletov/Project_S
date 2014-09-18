namespace FiilingData.FillingCourseraData
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using Web.UnitOfWork;
    using Web.Models.CourseraEntity;

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
            BindSecondLevelCriterias("Arts", "Arts");
            BindSecondLevelCriterias("Agriculture", "Energy & Earth Sciences"); // ?
            BindSecondLevelCriterias("Anthropology", "Biology & Life Sciences"); // ?
            BindSecondLevelCriterias("Applied Mathematics", "Mathematics");
            BindSecondLevelCriterias("Archaeology", "Energy & Earth Sciences"); // ?
            BindSecondLevelCriterias("Architecture and design", "Engineering"); // ?
            BindSecondLevelCriterias("Biology", "Biology & Life Sciences");
            BindSecondLevelCriterias("Business", "Business & Management");
            BindSecondLevelCriterias("Chemical Engineering", "Chemistry");
            BindSecondLevelCriterias("Chemistry", "Chemistry");
            BindSecondLevelCriterias("Civil Engineering", "Engineering");
            BindSecondLevelCriterias("Computer sciences", "Computer Science: Artificial Intelligence"); // Computer sciences - переработать
            BindSecondLevelCriterias("Computer sciences", "Computer Science: Software Engineering");
            BindSecondLevelCriterias("Computer sciences", "Computer Science: Systems & Security");
            BindSecondLevelCriterias("Computer sciences", "Computer Science: Theory");
            BindSecondLevelCriterias("Cultural and ethnic studies", "Humanities"); // ?
            BindSecondLevelCriterias("Earth sciences", "Energy & Earth Sciences");
            BindSecondLevelCriterias("Earth sciences", "Physical & Earth Sciences");
            BindSecondLevelCriterias("Economics", "Economics & Finance");
            BindSecondLevelCriterias("Education", "Education");
            BindSecondLevelCriterias("Family and consumer science", "Food and Nutrition");
            BindSecondLevelCriterias("Family and consumer science", "Health & Society");
            BindSecondLevelCriterias("Healthcare science", "Health & Society");
            BindSecondLevelCriterias("Human physical performance and recreation", "Health & Society"); // ?
            BindSecondLevelCriterias("Law", "Law");
            BindSecondLevelCriterias("Linguistics", "-");
            BindSecondLevelCriterias("Literature", "Humanities");
            BindSecondLevelCriterias("Materials Science and Engineering", "Physical & Earth Sciences"); // ?
            BindSecondLevelCriterias("Mechanical Engineering", "Engineering");
            BindSecondLevelCriterias("Philosophy", "Humanities");
            BindSecondLevelCriterias("Physics and Space sciences", "Physics");
            BindSecondLevelCriterias("Statistics", "Statistics and Data Analysis");
            BindSecondLevelCriterias("Pure Mathematics", "Mathematics");


            BindByCourseName("Area studies", new[] { "Area studies" });
            BindByCourseName("Divinity", new[] { "Divinity", "religion" });
            BindByCourseName("Electrical Engineering", new[] { "Electrical", "Engineering" });
            BindByCourseName("Environmental studies and forestry", new[] { "Environmental", "forestry" });
            BindByCourseName("Gender and sexuality studies", new[] { "Gender", "sexuality" });
            BindByCourseName("Geography", new[] { "Geography" });
            BindByCourseName("History", new[] { "History" });
            BindByCourseName("Journalism, media studies and communication", new[] { "Journalism", "media studies" });
            BindByCourseName("Library and museum studies", new[] { "Library", "museum" });
            BindByCourseName("Linguistics", new[] { "Linguistics" });
            BindByCourseName("Logic", new[] { "Logic" });
            BindByCourseName("Military sciences", new[] { "Military" });
            BindByCourseName("Political science", new[] { "Political", "policy" });
            BindByCourseName("Psychology", new[] { "Psychology" });
            BindByCourseName("Public administration", new[] { "Public administration", "administration" });
            BindByCourseName("Religion", new[] { "Religion" });
            BindByCourseName("Social work", new[] { "Social" });
            BindByCourseName("Sociology", new[] { "Sociology" });
            BindByCourseName("Systems science", new[] { "Systems" });
            BindByCourseName("Transportation", new[] { "Transportation", "logistics" });
        }

        // Связываем глобальные критерии 2-го и 3-го уровня с категориями курсеры
        private static void BindSecondLevelCriterias(string globalSecondLevCriteria, string courseraCriteria)
        {
            // Связывание глоб.критериев с категориями курсеры
            using (var uow = new UnitOfWork())
            {
                var secGlobalCriteria = uow.SecondLevelCriteriaRepository.Get().FirstOrDefault(x => x.Name == globalSecondLevCriteria); // 2-й уровень Global Criteria

                var courseraCategory = uow.CategoryRepository.Get().FirstOrDefault(x => x.Name.ToLower() == courseraCriteria.ToLower()); // Категория Coursera

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

        // Связываем глобальные критерии 2-го и 3-го уровня непосредственно с курсами (связывание идет по вхождению тэгов критериев в название курса)
        private static void BindByCourseName(string globalCriteriaName, string[] globalCriteriaTags)
        {
            if (globalCriteriaTags.Any())
            {
                for (var i = 0; i < globalCriteriaTags.Length; ++i)
                {
                    globalCriteriaTags[i] = globalCriteriaTags[i].ToLower();
                }
            }
            else
            {
                return;
            }

            using (var uow = new UnitOfWork())
            {
                var secGlobalCriteria = uow.SecondLevelCriteriaRepository.Get().FirstOrDefault(x => x.Name.ToLower() == globalCriteriaName.ToLower()); // 2-й уровень Global Criteria

                var courses = uow.CourseRepository.Get().Where(x => globalCriteriaTags.Contains(x.Name.ToLower()) || globalCriteriaTags.Contains(x.ShortName.ToLower())).ToList();

                if (secGlobalCriteria == null || !courses.Any()) return;

                secGlobalCriteria.Courses = new Collection<Course>();
                secGlobalCriteria.Courses = courses;
                uow.SecondLevelCriteriaRepository.Update(secGlobalCriteria);
                
                var thirdCriterias = uow.ThirdLevelCriteriaRepository.Get()
                    .Where(x => x.SecondLevelCriteria.Id == secGlobalCriteria.Id).ToList();

                // Все критерии 3-го уровня из globalCriteria(2-й уровень) связываем с courses
                foreach (var thirdCriteria in thirdCriterias)
                {
                    thirdCriteria.Courses = new Collection<Course>();
                    thirdCriteria.Courses = courses;

                    uow.ThirdLevelCriteriaRepository.Update(thirdCriteria);
                }

                uow.Save();

            }
        }
    }
}
