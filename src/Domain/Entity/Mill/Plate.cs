namespace Domain.Entity.Mill
{
    public class Plate : Item
    {
        public virtual string Number { get; set; }
        public virtual int Thicknes { get; set; }
        public virtual Heat Heat { get; set; }
        public virtual ChemicalComposition ChemicalComposition { get; set; }
        public virtual TensileTest TensileTest { get; set; }
        public virtual Pipe Pipe { get; set; }
    }
}