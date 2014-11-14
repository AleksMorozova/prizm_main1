namespace Domain.Entity.Mill
{
    public class Plate : Item
    {
        public Plate(string number, int thickness, Heat heat, Pipe pipe)
        {
            this.Number = number;
            this.Thickness = thickness;
            this.Heat = heat;
            this.Pipe = pipe;
        }

        protected Plate() { }

        public virtual string Number { get; set; }
        public virtual int Thickness { get; set; }

        public virtual Heat Heat { get; set; }
        public virtual Pipe Pipe { get; set; }

        public virtual ChemicalComposition ChemicalComposition { get; set; }
        public virtual TensileTest TensileTest { get; set; }
        
    }
}