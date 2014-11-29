using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class PlateManufacturer : Item
    {
        public PlateManufacturer()
        {
            this.Heats = new List<Heat>();
        }

        public virtual string Name { get; set; }
        public virtual IList<Heat> Heats { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}