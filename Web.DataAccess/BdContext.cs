﻿namespace Web
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Web.Models.Location;
    using Web.Models.Profile;
    using Web.Models.Criteria;
    using Web.Models.CourseraEntity;

    public class BdContext : IdentityDbContext
    {
        public BdContext() : base("BdContext")
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<University> Universities { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Criteria> Criterias { get; set; }        

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<ProfileCriteria> ProfileCriterias { get; set; }                        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Criteria>().HasMany(t => t.Children).WithRequired();
            

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });

            /* Связка (Профайл пользователя <-> Критерии (1 - 3 уровень) */
            modelBuilder.Entity<Profile>().
                HasMany(c => c.ProfileCriteria);          


            /* Связка многие ко многим (Категория <-> Курсы)
             * Каждая категория (Пр.: математика) может иметь несколько курсов
             * Каждый курс (Пр.: Математические методы в экономике) может относится к нескольких категориям */
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

            modelBuilder.Entity<Criteria>()
                .HasMany(p => p.Children)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("Id");
                    m.MapRightKey("ChildrenId");
                    m.ToTable("CriteriaChildren");
                });
        }
    }
}