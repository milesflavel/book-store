namespace BookStore.Models
{
    /// <summary>
    /// Represents the base entity class.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
