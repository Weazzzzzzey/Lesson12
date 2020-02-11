using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBussinesLayer
{
    public class ReportGenerator
    {
        private EmploeeRepository emploeeRepo { get; set; }
        private GateRepository gateRepo { get; set; }
        private EventController eventControler { get; set; }

        private List<ReportTotalHours> reportTotalHours = new List<ReportTotalHours>();
        private List<ReportEvents> reportEvenets = new List<ReportEvents>();


        public ReportGenerator(EmploeeRepository em, GateRepository gr, EventController ec)
        {
            emploeeRepo = em;
            gateRepo = gr;
            eventControler = ec;
            GenerateTotalEvents();
        }
        
        public string ConvertToName(int ID)
        {
            Emploee vienasdarbuotojas = emploeeRepo.Retrieve(ID);
            return vienasdarbuotojas.Name;
        }

        public string ConvertToGateName(int ID)
        {
            Gate varetliupav = gateRepo.Retrieve(ID);
            return varetliupav.HumaninCode;
        }

        public void GenerateTotalEvents()
        {
            foreach (var item in eventControler.Retrieve())
            {
                reportEvenets.Add(new ReportEvents(
                    ConvertToName(item.HumanID),
                    ConvertToGateName(item.GateID), 
                    item.Date, 
                    item.Pass));
            }
        }
        
        public void EstimateTotalHours()
        {
            List<Event> eventukai = eventControler.Retrieve();
            int ieskomasID = 0;
            foreach (var item in eventukai)
            {
                if (item.Pass == true)
                {
                    ieskomasID = item.HumanID;
                    //reportTotalHours.Add(new ReportTotalHours(ConvertToName(item.GateID),0));
                }



            }
        
        }

        public List<ReportEvents> Retrieve()
        {
            return reportEvenets;
        }
    }
}
