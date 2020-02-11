using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBussinesLayer
{
    class ReportTotalHours
    {
        public int EmploeeID { get; set; }
        public int TotalHours { get; set; }

        public ReportTotalHours(int emploeeid, int totalHours)
        {
            EmploeeID = emploeeid;
            TotalHours = totalHours;
        }
    }
}
