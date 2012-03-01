using System.Data.Entity;

namespace website.DataAccess
{
    public class EntityFrameworkRepository<T> : IRepository<T> where T : class
    {
        protected DbContext DatabaseContext;

        public EntityFrameworkRepository(DbContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        protected DbSet<T> DbSet
        {
            get { return DatabaseContext.Set<T>(); }
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }
    }
}