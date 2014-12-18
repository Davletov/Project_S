namespace FiilingData.FillingCourseraData
{
    using System;
    using System.Linq;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;    
    using Web.Models.CourseraEntity;
    using Web.DataAccess.Repository;
    using Web.Models.Criteria;

    public static partial class FillingDataFromCoursera
    {
        /// <summary>
        /// Связываем курсы с категориями
        /// </summary>
        public static void BindingGlobalCriteriasWithCourseraCriterias()
        {
            var stopWatch = new Stopwatch();
            Console.WriteLine("\nСвязывание глоб.критериев с курсами Coursera ...");

            stopWatch.Start();
            using (var uow = new UnitOfWork())
            {
                var secLevCourses = uow.Repository<Criteria>().Get().Where(x => x.Name == "Philosophy").Select(x => x.Courses).ToList();
                var secondLevId = uow.Repository<Criteria>().Get().Where(x => x.Name == "Electrical Engineering").Select(x => x.Id).FirstOrDefault();
                var list = uow.Repository<Criteria>().Get().Where(x => x.Parent.Id == secondLevId).Select(x => x.Courses).ToList();
                var tmp = list;
            }

            // Связываем 2-й и 3-й уровень глоб.критериев с курсами Coursera (по соот.категориям Coursera)
            BindSecondLevelCriterias("Arts", new[] { "Arts"});
            BindSecondLevelCriterias("Agriculture", new[] { "Energy & Earth Sciences"}); // ?
            BindSecondLevelCriterias("Anthropology", new[] { "Biology & Life Sciences"}); // ?
            BindSecondLevelCriterias("Applied Mathematics", new[] { "Mathematics"});
            BindSecondLevelCriterias("Archaeology", new[] { "Energy & Earth Sciences"}); // ?
            BindSecondLevelCriterias("Architecture and design", new[] { "Engineering"}); // ?
            BindSecondLevelCriterias("Biology", new[] { "Biology & Life Sciences"});
            BindSecondLevelCriterias("Business", new[] { "Business & Management"});
            BindSecondLevelCriterias("Chemical Engineering", new[] { "Chemistry"});
            BindSecondLevelCriterias("Chemistry", new[] { "Chemistry"});
            BindSecondLevelCriterias("Civil Engineering", new[] { "Engineering"});
            BindSecondLevelCriterias("Computer sciences", new[] { "Computer Science: Artificial Intelligence",
                "Computer Science: Software Engineering", "Computer Science: Systems & Security", "Computer Science: Theory"}); 
            BindSecondLevelCriterias("Cultural and ethnic studies",new[] { "Humanities" }); // ?
            BindSecondLevelCriterias("Earth sciences", new[] { "Energy & Earth Sciences", "Physical & Earth Sciences"});
            BindSecondLevelCriterias("Economics", new[] {"Economics & Finance"});
            BindSecondLevelCriterias("Education", new[] {"Education"});
            BindSecondLevelCriterias("Family and consumer science", new[] { "Food and Nutrition", "Health & Society"});
            BindSecondLevelCriterias("Healthcare science", new[] { "Health & Society" });
            BindSecondLevelCriterias("Human physical performance and recreation", new[] { "Health & Society" }); // ?
            BindSecondLevelCriterias("Law", new[] { "Law" });
            BindSecondLevelCriterias("Linguistics", new[] { "-" });
            BindSecondLevelCriterias("Literature", new[] { "Humanities" });
            BindSecondLevelCriterias("Materials Science and Engineering", new[] { "Physical & Earth Sciences" }); // ?
            BindSecondLevelCriterias("Mechanical Engineering", new[] {"Engineering"});
            BindSecondLevelCriterias("Philosophy", new[] {"Humanities"});
            BindSecondLevelCriterias("Physics and Space sciences", new[] {"Physics"});
            BindSecondLevelCriterias("Statistics", new[] {"Statistics and Data Analysis"});
            BindSecondLevelCriterias("Pure Mathematics", new[] {"Mathematics"});


            BindByCourseName("Area studies", new[] { "Area studies" });
            BindByCourseName("Divinity", new[] { "Divinity", "religio" });
            BindByCourseName("Electrical Engineering", new[] { "Electric"});
            BindByCourseName("Environmental studies and forestry", new[] { "Environmental", "forestry" });
            BindByCourseName("Gender and sexuality studies", new[] { "Gender", "sex" });
            BindByCourseName("Geography", new[] { "Geography" });
            BindByCourseName("History", new[] { "History" }); // детализировать до критериев 3-го уровня (Пр., история россии, история мировая и т.д.)
            BindByCourseName("Journalism, media studies and communication", new[] { "Journalism", "media" }, true);
            BindByCourseName("Library and museum studies", new[] { "Library", "museum" });
            BindByCourseName("Linguistics", new[] { "Linguistics" });
            BindByCourseName("Logic", new[] { "Logic" }, true);
            BindByCourseName("Military sciences", new[] { "Military"/*, "war"*/ });
            BindByCourseName("Political science", new[] { "Political", "policy" });
            BindByCourseName("Psychology", new[] { "Psychology" });
            BindByCourseName("Public administration", new[] { "Public administration", "administration" });
            BindByCourseName("Religion", new[] { "Religio" });
            BindByCourseName("Social work", new[] { "Social" });
            BindByCourseName("Sociology", new[] { "Sociology" });
            BindByCourseName("Systems science", new[] { "Systems" });
            BindByCourseName("Transportation", new[] { "Transportation", "logistics" });

            stopWatch.Stop();
            Console.WriteLine("Связывание глоб.критериев с курсами Coursera прошло успешно !");

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        // Связываем глобальные критерии 2-го с курсами курсеры (по категориям курсеры)
        // однозначное соот-е : Пр.: Law - Law
        // критерии 3-го уровня в этом случае будут иметь пустые списки курсов
        private static void BindSecondLevelCriterias(string globalSecondLevCriteria, string[] courseraCriterias)
        {
            if (courseraCriterias.Any())
            {
                for (var i = 0; i < courseraCriterias.Length; ++i)
                {
                    courseraCriterias[i] = courseraCriterias[i].ToLower();
                }
            }
            else
            {
                return;
            }

            // Связывание глоб.критериев с категориями курсеры
            using (var uow = new UnitOfWork())
            {
                var secGlobalCriteria = uow.Repository<Criteria>().Get().FirstOrDefault(x => x.Name == globalSecondLevCriteria); // 2-й уровень Global Criteria

                // Курсы Coursera соотв.категорий
                var courseraCoursesList = new List<Course>();
                foreach (var courseraCriteria in courseraCriterias)
                {
                    courseraCoursesList.AddRange(uow.Repository<Category>().Get()
                        .Where(x => x.Name.ToLower().Contains(courseraCriteria)
                            || x.ShortName.ToLower().Contains(courseraCriteria)).SelectMany(x => x.Courses).ToList());
                }

                if (secGlobalCriteria == null || courseraCoursesList.Count <= 0) return;

                secGlobalCriteria.Courses = new Collection<Course>();
                secGlobalCriteria.Courses = courseraCoursesList;
                uow.Repository<Criteria>().Update(secGlobalCriteria);
                uow.Commit();
            }
        }

        // Связываем глобальные критерии 2-го и 3-го уровня непосредственно с курсами 
        // (связывание идет по вхождению тэгов критериев в название курса)
        // or_and - используем связку Name or ShortName (false), либо Name and ShortName (true)
        private static void BindByCourseName(string globalCriteriaName, string[] globalCriteriaTags, bool or_and = false)
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
                var secGlobalCriteria = uow.Repository<Criteria>().Get().FirstOrDefault(x => x.Name.ToLower() == globalCriteriaName.ToLower()); // 2-й уровень Global Criteria

                var courses = new List<Course>();
                foreach (var globalCriteriaTag in globalCriteriaTags)
                {
                    var query = or_and
                        ? uow.Repository<Course>().Get()
                            .Where(x => x.Name.ToLower().Contains(globalCriteriaTag)
                                        && x.ShortName.ToLower().Contains(globalCriteriaTag)).ToList()
                        : uow.Repository<Course>().Get()
                            .Where(x => x.Name.ToLower().Contains(globalCriteriaTag)
                                        && x.ShortName.ToLower().Contains(globalCriteriaTag)).ToList();
                    courses.AddRange(query);
                }
                
                if (secGlobalCriteria == null || !courses.Any()) return;

                secGlobalCriteria.Courses = new Collection<Course>();
                secGlobalCriteria.Courses = courses;
                uow.Repository<Criteria>().Update(secGlobalCriteria);

                var thirdCriterias = uow.Repository<Criteria>().Get()
                    .Where(x => x.Parent.Id == secGlobalCriteria.Id).ToList();

                // Все критерии 3-го уровня из globalCriteria(2-й уровень) связываем с courses
                foreach (var thirdCriteria in thirdCriterias)
                {
                    thirdCriteria.Courses = new Collection<Course>();
                    thirdCriteria.Courses = courses;

                    uow.Repository<Criteria>().Update(thirdCriteria);
                }

                uow.Commit();

            }
        }
    }
}
