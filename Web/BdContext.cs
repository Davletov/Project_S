using Microsoft.AspNet.Identity.EntityFramework;
using Web.Models;
using Web.Models.Criteria;

namespace Web
{
    using System.Data.Entity;
    using Web.Models.CourseraEntity;

    public class BdContext : IdentityDbContext
    {
        public BdContext():base("BdContext"){}

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<University> Universities { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<FirstLevelCriteria> FirstLevelCriterias { get; set; }

        public DbSet<SecondLevelCriteria> SecondLevelCriterias { get; set; }

        public DbSet<ThirdLevelCriteria> ThirdLevelCriterias { get; set; }

        public DbSet<CriteriaForCoursera> CriteriaForCoursera { get; set; }
        
        /// <summary>
        /// Связка многие ко многим (Категория <-> Курсы)
        /// Каждая категория (Пр.: математика) может иметь несколько курсов
        /// Каждый курс (Пр.: Математические методы в экономике) может относится к нескольких категориям 
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FirstLevelCriteria>().HasMany(t => t.SecondLevelCriteria).WithRequired();
            modelBuilder.Entity<SecondLevelCriteria>().HasMany(t => t.ThirdLevelCriteria).WithRequired();

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(x => x.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });

            // связь многие ко многим через Fluent Api

            // Course <-> Category
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

            // Course <-> Instructor
            modelBuilder.Entity<Course>().
              HasMany(c => c.Instructors).
              WithMany(p => p.Courses).
              Map(
               m =>
               {
                   m.MapLeftKey("CourseId");
                   m.MapRightKey("InstructorId");
                   m.ToTable("CourseInstructors");
               });

            // Course <-> Session
            modelBuilder.Entity<Course>().
              HasMany(c => c.Sessions).
              WithMany(p => p.Courses).
              Map(
               m =>
               {
                   m.MapLeftKey("CourseId");
                   m.MapRightKey("SessionId");
                   m.ToTable("CourseSessions");
               });

            // Course <-> University
            modelBuilder.Entity<Course>().
              HasMany(c => c.Universities).
              WithMany(p => p.Courses).
              Map(
               m =>
               {
                   m.MapLeftKey("CourseId");
                   m.MapRightKey("UniversityId");
                   m.ToTable("CourseUniversities");
               });
        }
    }
}