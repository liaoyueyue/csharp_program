using Microsoft.EntityFrameworkCore;
using StuInfoManageSystem.Data;

namespace StuInfoManageSystem.Repositories
{
    public class BaseRepository<T>(AppDbContext context) where T : class, new()
    {
        protected DbSet<T> DbSet => context.Set<T>();

        public void Insert(T entity)
        {
            DbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            DbSet.Update(entity);
            context.SaveChanges();
        }

        public T? Get(Guid id)
        {
            return DbSet.Find(id);
        }

        public List<T> GetList()
        {
            return DbSet.ToList();
        }
    }
}
