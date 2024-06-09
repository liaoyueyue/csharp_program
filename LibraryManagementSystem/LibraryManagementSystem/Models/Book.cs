using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "标题是必填项。")]
        public string Title { get; set; }

        [Required(ErrorMessage = "作者是必填项。")]
        public string Author { get; set; }

        [Required(ErrorMessage = "出版社是必填项。")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "ISBN 是必填项。")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "价格是必填项。")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "出版日期是必填项。")]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "分类编号是必填项。")]
        public int CategoryId { get; set; }
    }

}
