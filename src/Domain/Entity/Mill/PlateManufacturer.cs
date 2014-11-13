using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class PlateManufacturer : Item
    {
        public PlateManufacturer()
        {
            this.Heats = new List<Heat>();
        }

        public virtual string Number { get; set; }
        public virtual ICollection<Heat> Heats { get; set; }
    }
}