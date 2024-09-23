using Microsoft.EntityFrameworkCore;
using StuInfoManageSystem.Data;
using StuInfoManageSystem.Models;

namespace StuInfoManageSystem.Repositories
{
    public class MajorRepo(AppDbContext context) : BaseRepository<Major>(context)
    {
        public Major? GetWithClasses(Guid id)
        {
            return DbSet.Include(m => m.Classes).SingleOrDefault(m => m.Id == id);
        }
    }
}
