using Microsoft.EntityFrameworkCore;
using StuInfoManageSystem.Data;
using StuInfoManageSystem.Models;

namespace StuInfoManageSystem.Repositories
{
    public class StudentRepo(AppDbContext context) : BaseRepository<Student>(context)
    {
        public List<Student> GetListWithMajorAndGradeAndClass()
        {
            return DbSet
                .Include(s => s.Class).ThenInclude(c => c.Major)
                .Include(s => s.Class).ThenInclude(c => c.Grade)
                .ToList();
        }

        public Student? GetWithClass(Guid id)
        {
            return DbSet.Include(s => s.Class).SingleOrDefault(s => s.Id == id);
        }
    }
}
