namespace BookStore.Models
{
    public class Book : Product
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }

        public override string ToString()
        {
            return $"{Title} ({Author})";
        }
    }
}
