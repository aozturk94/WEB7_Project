using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public DateTime AuthorDateofBirth { get; set; }
    }
}