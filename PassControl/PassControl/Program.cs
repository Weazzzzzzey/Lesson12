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
            EventController EC = new EventController(VisiDarbuotojai, VisiVartai);
            EC.TryPass(0,"Rytiniai vartai");
            Console.ReadLine();
        }
    }
}
