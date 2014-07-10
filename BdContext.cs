namespace Testing
{
    using System.Data.Entity;
    using Testing.CourseraEntity;

    public class BdContext : DbContext 
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<University> Universities { get; set; }

        /// <summary>
        /// Связка многие ко многим (Категория <-> Курсы)
        /// Каждая категория (Пр.: математика) может иметь несколько курсов
        /// Каждый курс (Пр.: Математические методы в экономике) может относится к нескольких категориям 
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().
              HasMany(c => c.Categories).
              WithMany(p => p.Courses).
              Map(
               m =>
               {
                   m.MapLeftKey("CourseId");
                   m.MapRightKey("CategoryId");
                   m.ToTable("CourseCategories");
               });
        }
    }
}