using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBussinesLayer
{
    public class Employee
    {
        public int EmployeeID { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public List<int> GetIdRights { get; private set; }

    }
}
