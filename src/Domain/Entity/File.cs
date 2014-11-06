using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class File : Entity
    {
        public virtual string FileName { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime UploadDate { get; set; }
    }
}
