using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBussinesLayer
{
    public class EventController
    {
        private List<Event> Eventai;
        private EmploeeRepository visuDarbuotojuRepo;
        private GateRepository VieniIsVartu;
        public int EventID = 0;

        public EventController(EmploeeRepository er, GateRepository gr)
        {
            Eventai = new List<Event>();
            visuDarbuotojuRepo = er;
            VieniIsVartu = gr;
        }
        
        public bool TryPass (int emploeeID, string humanisticID) //0 darbuotojas 1-2 gate "Rytiniai vartai" 2
        {
            bool turiGateTeise = false;
            Emploee vienasDarbuotojas = visuDarbuotojuRepo.Retrieve(emploeeID);
            Gate iejimas = VieniIsVartu.Retrieve(humanisticID);
            turiGateTeise = vienasDarbuotojas.RightsList().Contains(iejimas.GateID);
            Console.WriteLine("{0}", turiGateTeise);

            Eventai.Add(new Event(EventID, emploeeID,iejimas.GateID,DateTime.Now,turiGateTeise));
            EventID++;
            return turiGateTeise;
        }



    }
}
