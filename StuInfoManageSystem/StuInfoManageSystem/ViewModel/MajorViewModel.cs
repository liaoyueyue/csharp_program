using System.ComponentModel.DataAnnotations;

namespace StuInfoManageSystem.ViewModel
{
    public class MajorViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "专业名称")]
        public string Name { get; set; } = string.Empty;
    }
}
