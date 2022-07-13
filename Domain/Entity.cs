namespace Avengers.Domain
{
    public abstract class Entity
    {
        public Entity()
        {
            UserId = Guid.NewGuid();
            ShopId = Guid.NewGuid();
        }

        public int Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ShopId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
