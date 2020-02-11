using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBussinesLayer
{
    public class ReportEvents
    {
        public string Emploee { get; set; }
        public string Gate { get; set; }
        public string Date { get; set; }
        public string Pass { get; set; }

        public ReportEvents(string emploee, string gate, DateTime date, bool pass)
        {
            Emploee = emploee;
            Gate = gate;
            Date = date.ToShortTimeString();
            Pass = praejo(pass);
        }
        public string praejo(bool praejo)
        {
            if (praejo == true)
            {
                return "Praejo";
            }
            else return "Nepraejo";
        }
    }
}
