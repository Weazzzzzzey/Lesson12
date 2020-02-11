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

        public EventController(EmploeeRepository er)
        {
            Eventai = new List<Event>();
            visuDarbuotojuRepo = er;
 
        }
        
        public bool TryPass (int emploeeID, int varetliuID) //0 darbuotojas 1-2 gate "Rytiniai vartai" 2
        {
            bool turiGateTeise = false;
            Emploee vienasDarbuotojas = visuDarbuotojuRepo.Retrieve(emploeeID);
            turiGateTeise = vienasDarbuotojas.HasRight(varetliuID);
            
            Eventai.Add(new Event(Guid.NewGuid(), emploeeID,varetliuID,DateTime.Now,turiGateTeise));
            return turiGateTeise;
            
        }

        public List<Event> Retrieve()
        {
            return Eventai;
        }

    }
}
