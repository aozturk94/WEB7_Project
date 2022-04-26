using System;
using System.Collections.Generic;

namespace EF_2504.DAL.Entities
{
    public class Book
    {
        //Primary Key
        public int BookId { get; set; }
        public string BookName { get; set; }
        public decimal BookPrice { get; set; }
        public string BookImageUrl { get; set; }
        public DateTime BookCreatedDate { get; set; }

        public int? CategoryId { get; set; } //Foreign Key

        public Category Category { get; set; } //Navigation Prop
        public BookDetail BookDetail { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }
}

