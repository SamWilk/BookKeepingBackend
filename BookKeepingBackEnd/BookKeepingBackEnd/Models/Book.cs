namespace BookKeepingBackEnd.Models
{
    public class Book
    {
        public Guid bookID { get; set; }
        public List<Guid> AuthorID { get; set; } = new List<Guid>();
        public string Title { get; set; } = string.Empty;
        public List<string> Author { get; set; } = new List<string>();
        public double Rating { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public int NumberOfReads { get; set; }
        public List<BookReview> Reviews { get; set; } = new List<BookReview>();

    }
}
