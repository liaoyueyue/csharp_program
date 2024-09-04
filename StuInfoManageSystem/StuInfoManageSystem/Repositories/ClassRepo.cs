using StuInfoManageSystem.Data;
using StuInfoManageSystem.Models;

namespace StuInfoManageSystem.Repositories
{
    public class ClassRepo(AppDbContext context) : BaseRepository<Class>(context)
    {
    }
}
