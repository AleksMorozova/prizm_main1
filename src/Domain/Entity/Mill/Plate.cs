namespace Prizm.Domain.Entity.Mill
{
    public class Plate : Item
    {
        public Plate()
        {
            this.Heat = new Heat();
            this.Heat.Plates.Add(this);
        }
        public virtual string Number { get; set; }
        public virtual float Thickness { get; set; }

        public virtual Heat Heat { get; set; }
        public virtual Pipe Pipe { get; set; }
    }
}