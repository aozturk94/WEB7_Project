namespace EF_2504.DAL.Entities
{
    public class BookAuthor
    {
        //ÇOK'A ÇOK İlişkiyi iki tane BİR'E ÇOK ilişki ile sağladık.
        public int BookAuthorId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}

