using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Repository;

namespace Web.DataAccess.Repository
{
    public class UnitOfWork : ISession
    {
        private readonly BdContext _context;

        private Dictionary<object, object> Cache;
        public UnitOfWork()
        {
            _context = new BdContext();
            _context.Database.CommandTimeout = 180;
            Cache = new Dictionary<object, object>();
        }
        public IRepository<T> Repository<T>() where T : class
        {
            object cachedRepository = null;
            Cache.TryGetValue(typeof (T), out cachedRepository);
            
            if (cachedRepository != null)
            {
                return cachedRepository as IRepository<T>;
            }

            IRepository<T> newRepository = new BaseRepository<T>(_context);
            Cache.Add(typeof(T), newRepository);
            return newRepository;
        }
       
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            
        }
    }
}
