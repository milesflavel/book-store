namespace BookStore.Models
{
    public class Genre : Entity
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
