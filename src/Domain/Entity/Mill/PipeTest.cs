using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class PipeTest : Entity
    {
        public virtual string Code { get; set; }
        public virtual string TestSubject { get; set; }
        public virtual int MinExpected { get; set; }
        public virtual int MaxExpected { get; set; }
        public virtual bool BoolExpected { get; set; }
        public virtual bool IsRequired { get; set; }

        //enums
        public virtual PipeTestControlType ControlType { get; set; }
        public virtual PipeTestResultType Resulttype { get; set; }

        public virtual ICollection<PipeTestResult> PipeTestResults { get; set; }

        protected PipeTest()
        {
            this.PipeTestResults = new List<PipeTestResult>();
        }
    }
}
