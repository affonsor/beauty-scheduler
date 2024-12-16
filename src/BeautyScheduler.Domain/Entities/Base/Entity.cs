namespace BeautyScheduler.Domain.Entities.Base
{
    public abstract class Entity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public DateTime UpdateAt { get; protected set; }
        public bool IsDeleted { get; private set; }
        public void SetAsDeleted() => IsDeleted = true;

    }
}
