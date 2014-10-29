using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class File
    {
        public Guid FileID { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
