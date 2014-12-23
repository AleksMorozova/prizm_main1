using Prizm.Domain.Entity.Setup;
namespace Prizm.Domain.Entity
{
    // FIX: remove??
    public class Project : Item
    {
        public virtual string Title { get; set; }
        public virtual string Client { get; set; }
        public virtual string MillName { get; set; }
        public virtual int DocumentSizeLimit { get; set; }
        public virtual WorkstationType WorkstationType { get; set; }
        public virtual string MillPipeNumberMask { get; set; }
        public virtual string MillPipeNumberMaskRegexp { get; set; }
        public virtual string ExternalFilesPath { get; set; }
    }
}