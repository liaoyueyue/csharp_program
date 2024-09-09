using StuInfoManageSystem.Data;
using StuInfoManageSystem.Models;

namespace StuInfoManageSystem.Repositories
{
    public class MajorRepo(AppDbContext context) : BaseRepository<Major>(context)
    {

    }
}
