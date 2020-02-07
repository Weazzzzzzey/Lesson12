using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBussinesLayer
{
    public class Emploee
    {
        public int EmployeeID { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        
        private List<int> GetIdRights;

        public Emploee(int employee, string name, string surname, List<int> rights) 
        {
            this.EmployeeID = employee;
            this.Name = name;
            this.Surname = surname;
            this.GetIdRights = rights;
        }

        public List<int> RightsList()
        {
            return GetIdRights;
        }
    }
}
