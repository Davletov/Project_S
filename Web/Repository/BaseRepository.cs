namespace Web.Repository
{
    using System;
    using System.Linq;
    using System.Data.Entity;
    using System.Linq.Expressions;
    using System.Data.Entity.Infrastructure;

    // Базовый репозиторий
    public class BaseRepository<TEntity> where TEntity : class
    {
        internal BdContext Context;
        internal DbSet<TEntity> DbSet;

        public BaseRepository(BdContext context)
        {
            this.Context = context;
            this.DbSet = context.Set<TEntity>();
        }

        // Универсальный метод Get
        // 1 параметр - условие для выборки
        // 2 параметр - сортировка по опр.полю
        // без параметров - вытащит все записи
        public virtual IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return orderBy != null ? orderBy(query) : query;
        }

        public virtual TEntity GetById(object id)
        {
            return DbSet.Find(id);
        }

        public virtual void Add(TEntity entity)
        {
            DbEntityEntry dbEntityEntry = Context.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(entity);
            }
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            DbEntityEntry dbEntityEntry = Context.Entry(entityToDelete);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                DbSet.Attach(entityToDelete);
                DbSet.Remove(entityToDelete);
            }
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            DbEntityEntry dbEntityEntry = Context.Entry(entityToUpdate);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbSet.Attach(entityToUpdate);
            }
            dbEntityEntry.State = EntityState.Modified;
        }
    }
}