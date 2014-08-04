﻿using Web.Models;
using Web.Models.Criteria;

namespace Web.UnitOfWork
{
    using System;
    using Web.Models.CourseraEntity;
    using Web.Repository;

    // Паттерн UnitOfWork, плюсы его использования пока не вкурил ?!!?!??!
    // При любом обращении к репозиторию делаю так:
    // using(var uow = new UnitOfWork()) { // something doing with repository }
    // Постоянно приходится использовать using чтобы закрывать текущий контект обращния к БД.

    public class UnitOfWork : IDisposable
    {
        private readonly BdContext _context;

        public UnitOfWork()
        {
            _context = new BdContext();
            _context.Database.CommandTimeout = 180;
        }

        #region Repositories

        private BaseRepository<Category> _categoryRepository;
        private BaseRepository<Course> _courseRepository;
        private BaseRepository<Instructor> _instructorRepository;
        private BaseRepository<Session> _sessionRepository;
        private BaseRepository<University> _universityRepository;
        private BaseRepository<Profile> _profileRepository;
        private BaseRepository<FirstLevelCriteria> _firstLevelCriteriaRepository;
        private BaseRepository<SecondLevelCriteria> _secondLevelCriteriaRepository;
        private BaseRepository<ThirdLevelCriteria> _thirdLevelCriteriaRepository;
        private BaseRepository<CriteriaForCoursera> _criteriaForCourseraRepository;

        public BaseRepository<FirstLevelCriteria> FirstLevelCriteriaRepository
        {
            get
            {
                return _firstLevelCriteriaRepository ?? (_firstLevelCriteriaRepository = new BaseRepository<FirstLevelCriteria>(_context));
            }
        }

        public BaseRepository<SecondLevelCriteria> SecondLevelCriteriaRepository
        {
            get
            {
                return _secondLevelCriteriaRepository ?? (_secondLevelCriteriaRepository = new BaseRepository<SecondLevelCriteria>(_context));
            }
        }

        public BaseRepository<ThirdLevelCriteria> ThirdLevelCriteriaRepository
        {
            get
            {
                return _thirdLevelCriteriaRepository ?? (_thirdLevelCriteriaRepository = new BaseRepository<ThirdLevelCriteria>(_context));
            }
        }

        public BaseRepository<CriteriaForCoursera> CriteriaForCourseraRepository
        {
            get
            {
                return _criteriaForCourseraRepository ?? (_criteriaForCourseraRepository = new BaseRepository<CriteriaForCoursera>(_context));
            }
        }

        public BaseRepository<Profile> ProfileRepository
        {
            get
            {
                return _profileRepository ?? (_profileRepository = new BaseRepository<Profile>(_context));
            }
        }
        public BaseRepository<Category> CategoryRepository
        {
            get
            {
                return _categoryRepository ?? (_categoryRepository = new BaseRepository<Category>(_context));
            }
        }

        public BaseRepository<Course> CourseRepository
        {
            get
            {
                return _courseRepository ?? (_courseRepository = new BaseRepository<Course>(_context));
            }
        }
        public BaseRepository<Instructor> InstructorRepository
        {
            get
            {
                return _instructorRepository ?? (_instructorRepository = new BaseRepository<Instructor>(_context));
            }
        }
        public BaseRepository<Session> SessionRepository
        {
            get
            {
                return _sessionRepository ?? (_sessionRepository = new BaseRepository<Session>(_context));
            }
        }
        public BaseRepository<University> UniversityRepository
        {
            get
            {
                return _universityRepository ?? (_universityRepository = new BaseRepository<University>(_context));
            }
        }

        #endregion

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed; // false by deafult

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}