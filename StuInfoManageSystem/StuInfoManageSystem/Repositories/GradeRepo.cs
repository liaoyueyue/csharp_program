using StuInfoManageSystem.Data;
using StuInfoManageSystem.Models;

namespace StuInfoManageSystem.Repositories
{
    public class GradeRepo(AppDbContext context) : BaseRepository<Grade>(context)
    {
    }
}
