namespace Domain.Entity
{
    // FIX: remove??
    public class Project : Item
    {
        public virtual string Title { get; set; }
        public virtual PersonName Client { get; set; }
        public virtual PersonName Designer { get; set; }
    }
}