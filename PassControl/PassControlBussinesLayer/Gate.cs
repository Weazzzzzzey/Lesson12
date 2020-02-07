using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBussinesLayer
{
    public class Gate
    {
        public int GateID { get; private set; }
        public string Description { get; private set; }
        public string HumaninCode { get; private set; }

        public Gate(int gateID, string description, string humaninCode)
        {
            this.GateID = gateID;
            this.Description = description;
            this.HumaninCode = humaninCode;
        }
    }
}
