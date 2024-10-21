using StuInfoManageSystem.Models;
using StuInfoManageSystem.Repositories;
using StuInfoManageSystem.ViewModels;

namespace StuInfoManageSystem.Services
{
    public class MajorService(MajorRepo majorRepo)
    {
        public void Insert(MajorViewModel model)
        {
            Major major = new Major()
            {
                Name = model.Name,
            };
            majorRepo.Insert(major);
        }

        public List<MajorViewModel> GetList()
        {
            List<Major> majors = majorRepo.GetList();
            List<MajorViewModel> majorViewModels = new List<MajorViewModel>();
            foreach (var major in majors)
            {
                majorViewModels.Add(new MajorViewModel()
                {
                    Id = major.Id,
                    Name = major.Name,
                });
            }
            return majorViewModels;
        }

        public MajorViewModel Get(Guid id)
        {
            Major? major = majorRepo.Get(id);
            if (major == null)
            {
                throw new NullReferenceException();
            }

            MajorViewModel model = new MajorViewModel()
            {
                Id = major.Id,
                Name = major.Name,
            };
            return model;
        }

        public void Update(MajorViewModel model)
        {
            Major major = new Major()
            {
                Id = model.Id,
                Name = model.Name,
            };
            majorRepo.Update(major);
        }

        public void Delete(Guid id)
        {
            Major? major = majorRepo.GetWithClasses(id);
            if (major == null)
            {
                throw new NullReferenceException("未找到该专业，无法删除");
            }
            if (major.Classes.Any())
            {
                throw new InvalidOperationException("专业中存在班级，无法删除");
            }
            majorRepo.Delete(major);
        }
    }
}
