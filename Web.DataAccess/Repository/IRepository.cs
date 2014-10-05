using System;
using System.Linq;
using System.Linq.Expressions;

namespace Web.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entityToDelete);

        IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        TEntity GetById(object id);
        void Update(TEntity entityToUpdate);
    }
}