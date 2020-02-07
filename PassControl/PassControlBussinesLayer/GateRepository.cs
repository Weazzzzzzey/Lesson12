using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBussinesLayer
{
    public class GateRepository
    {
        private List<Gate> Vartai;

        public GateRepository()
        {
            Vartai = new List<Gate>();

            Vartai.Add(new Gate(0, "Vartai is siaures puses", "Siauriniai vartai"));
            Vartai.Add(new Gate(1, "Vartai is pietu puses", "Pietiniai vartai"));
            Vartai.Add(new Gate(2, "Vartai is rytu puses", "Rytiniai vartai"));
            Vartai.Add(new Gate(3, "Vartai is vakaru puses", "Vakariniai vartai"));
        }

        public List<Gate> Retrieve()
        {
            return Vartai;
        }

        public Gate Retrieve(int GateID)
        {
            foreach (var item in Vartai)
            {
                if (GateID == item.GateID)
                {
                    return item;
                }
            }
            return null;
        }

        public Gate Retrieve(string humanisticID)
        {
            foreach (var item in Vartai)
            {
                if (humanisticID == item.HumaninCode)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
