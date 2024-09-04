using StuInfoManageSystem.Data;
using StuInfoManageSystem.Models;

namespace StuInfoManageSystem.Repositories
{
    public class StudentRepo(AppDbContext context) : BaseRepository<Student>(context)
    {
    }
}
