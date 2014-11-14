namespace Domain.Entity.Mill
{
    public class ChemicalComposition : Item
    {
        public ChemicalComposition()
        {
        }

        public virtual string Value { get; set; }
        public virtual string Quantity { get; set; }
    }
}