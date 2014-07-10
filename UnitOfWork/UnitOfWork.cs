namespace Testing.UnitOfWork
{
    using System;
    using Testing.Repository;
    using Testing.CourseraEntity;

    public class UnitOfWork : IDisposable
    {
        private readonly BdContext _context = new BdContext();

        public UnitOfWork()
        {
            _context.Database.CommandTimeout = 180;
        }

        #region Repositories

        private BaseRepository<Category> _categoryRepository;
        private BaseRepository<Course> _courseRepository;
        private BaseRepository<Instructor> _instructorRepository;
        private BaseRepository<Session> _sessionRepository;
        private BaseRepository<University> _universityRepository;

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