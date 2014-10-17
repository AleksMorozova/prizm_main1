using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.DummyData
{
    public class JointsDummy
    {
        public static BindingList<Joint> GetAllJoints()
        {
            return new BindingList<Joint>
            {
                new Joint{Id=234,Status="Control",ControlState="Accepted",WeldingDate = DateTime.Today,ControlDate= DateTime.Today },
                new Joint{Id=231,Status="Repair",ControlState="Accepted", WeldingDate = DateTime.Today,ControlDate= DateTime.Today },
                new Joint{Id=245,Status="Repair",ControlState="Accepted", WeldingDate = DateTime.Today,ControlDate= DateTime.Today }   
            };
        }
    }

    public class Joint
    {
        public int      Id { get; set; }
        public string   Status { get; set; }
        public string   ControlState { get; set; }
        public DateTime WeldingDate { get; set; }
        public string   Repair { get; set; }
        public DateTime ControlDate { get; set; }
    }

}
