﻿namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishDate { get; set; }
        public int CategoryId { get; set; }
        public BookCategory Category { get; set; }
    }

}
