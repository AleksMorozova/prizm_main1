using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;

namespace Prizm.Domain.Entity
{
    // TODO: Part 
    public class Part : Item
    {
        public virtual string Number { get; set; }
        public virtual int Length { get; set; }
        public virtual bool IsAvailableToJoint { get; set; }

        public virtual PartConstructionStatus ConstructionStatus { get; set; }
        public virtual PartInspectionStatus InspectionStatus { get; set; }

        public virtual IList<InspectionTestResult> InspectionTestResults { get; set; }
    }
}