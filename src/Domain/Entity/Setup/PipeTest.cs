using Prizm.Domain.Entity.Mill;
using System.Collections.Generic;

namespace Prizm.Domain.Entity.Setup
{
    public class PipeTest : Item
    {
        public PipeTest(string code, string subject, bool isRequired, string expected)
            : this(code, subject, isRequired)
        {
            this.StringExpected = expected;
        }

        //diapasone test
        public PipeTest(string code, string subject, bool isRequired, int min, int max)
            : this(code, subject, isRequired)
        {
            this.MinExpected = min;
            this.MaxExpected = max;
        }

        //bool test
        public PipeTest(string code, string subject, bool isRequired, bool expected)
            : this(code, subject, isRequired)
        {
            this.BoolExpected = expected;
        }

        public PipeTest(string code, string subject, bool isRequired)
        {
            this.Code = code;
            this.IsRequired = isRequired;
            this.PipeTestResults = new List<PipeTestResult>();
        }

        public PipeTest()
        {
            this.PipeTestResults = new List<PipeTestResult>();
        }

        //category of test
        public virtual Category Category { get; set; }

        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual int MinExpected { get; set; }
        public virtual int MaxExpected { get; set; }
        public virtual string StringExpected { get; set; }
        public virtual bool BoolExpected { get; set; }
        public virtual bool IsRequired { get; set; }

        public virtual PipeMillSizeType pipeType { get; set; }
        //enums
        public virtual PipeTestControlType ControlType { get; set; }
        public virtual PipeTestResultType ResultType { get; set; }

        public virtual ICollection<PipeTestResult> PipeTestResults { get; set; }

        //string test
    }
}
