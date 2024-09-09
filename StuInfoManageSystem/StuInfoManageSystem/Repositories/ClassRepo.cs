using StuInfoManageSystem.Data;
using StuInfoManageSystem.Models;

namespace StuInfoManageSystem.Repositories
{
    public class ClassRepo(AppDbContext context) : BaseRepository<Class>(context)
    {
        public List<Class> GetList(Guid? majorId, Guid? gradeId)
        {
            IQueryable<Class> query = DbSet.AsQueryable();
            if (majorId != null)
            {
                query = query.Where(c => c.MajorId.Equals(majorId));
            }
            if (gradeId != null)
            {
                query = query.Where(c => c.GradeId.Equals(gradeId));
            }
            return query.ToList();
        }
    }
}
