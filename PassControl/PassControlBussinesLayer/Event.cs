using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBussinesLayer
{
    public class Event
    {
        public Guid EventsID { get; private set; }
        public int HumanID { get; private set; }
        public int GateID { get; private set; }
        public DateTime Date { get; private set; }
        public bool Pass { get; private set; }

        public Event(Guid eventsID, int humanID, int gateID, DateTime date, bool pass)
        {
            EventsID = eventsID;
            HumanID = humanID;
            GateID = gateID;
            Date = date;
            Pass = pass;
        }
    }
}
