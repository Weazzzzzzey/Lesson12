using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassControlBussinesLayer;


namespace PassControl
{
    class Program
    {
        static void Main(string[] args)
        {
            EmploeeRepository VisiDarbuotojai = new EmploeeRepository();
            GateRepository VisiVartai = new GateRepository();
            EventController EC = new EventController(VisiDarbuotojai);
            EC.TryPass(0,1);
            EC.TryPass(2,2);
            EC.TryPass(4,2);
            EC.TryPass(1,3);
            EC.TryPass(10,3);

            /*List<Event> ivykditiE =  EC.Retrieve();
            foreach (var item in ivykditiE)
            {
                Console.WriteLine(item.EventsID);
                Console.WriteLine(item.Pass);
            }
            Console.ReadLine(); */

            

            ReportGenerator rp = new ReportGenerator(VisiDarbuotojai,VisiVartai,EC);
            List<ReportEvents> report = rp.Retrieve();
            foreach (var item in report)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Emploee, item.Gate, item.Date, item.Pass);
            }

            Console.ReadLine();
        }
    }
}
