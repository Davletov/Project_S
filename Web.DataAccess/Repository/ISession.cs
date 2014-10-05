using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Repository;

namespace Web.DataAccess.Repository
{
    public interface ISession : IDisposable
    {
        IRepository<T> Repository<T>() where T : class;
        void Commit();
    }
}
