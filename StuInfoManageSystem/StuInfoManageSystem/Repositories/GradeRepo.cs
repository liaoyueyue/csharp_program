using Microsoft.EntityFrameworkCore;
using StuInfoManageSystem.Data;
using StuInfoManageSystem.Models;

namespace StuInfoManageSystem.Repositories
{
    public class GradeRepo(AppDbContext context) : BaseRepository<Grade>(context)
    {
        public Grade? GetWithClasses(Guid id)
        {
            return DbSet.Include(g => g.Classes).SingleOrDefault(g => g.Id == id);
        }
    }
}
