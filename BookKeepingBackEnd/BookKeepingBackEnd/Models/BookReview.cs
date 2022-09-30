namespace BookKeepingBackEnd.Models
{
    public class BookReview
    {
        public Guid ReviewID { get; set; }
        public Guid BookID { get; set; }
        public Guid UserID { get; set; }
        public string ReviewTitle { get; set; } = string.Empty;
        public string ReviewDescription { get; set; } = string.Empty;
        public int Likes{ get; set; }
        public int Dislikes { get; set; }

    }
}
