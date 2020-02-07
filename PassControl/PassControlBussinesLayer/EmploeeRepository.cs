using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBussinesLayer
{
    public class EmploeeRepository
    {
        private List<Emploee> Darbuotojai;
        public EmploeeRepository()
        {
            Darbuotojai = new List<Emploee>();

            Darbuotojai.Add(new Emploee(0,"ab","cd",new List<int> {1,2}));
            Darbuotojai.Add(new Emploee(1,"ef","gh",new List<int> {2}));
            Darbuotojai.Add(new Emploee(2,"zz","qfq" ,new List<int> {1}));
            Darbuotojai.Add(new Emploee(3,"fqq","aa",new List<int> {1}));
            Darbuotojai.Add(new Emploee(4,"az","zggd",new List<int> {0,1}));
            Darbuotojai.Add(new Emploee(5,"agb","acd",new List<int> {0,3}));
            Darbuotojai.Add(new Emploee(6,"agdb","aqcd",new List<int> {0}));
            Darbuotojai.Add(new Emploee(7,"agab","adcd",new List<int> {0}));
            Darbuotojai.Add(new Emploee(8,"agb","ascd",new List<int> {1}));
            Darbuotojai.Add(new Emploee(9,"agab","acsd",new List<int> {0,2}));
            Darbuotojai.Add(new Emploee(10, "Vardas", "Pavarde", new List<int> { 0, 1 }));
        }
        
        public List<Emploee> Retrieve()
        {
            return Darbuotojai;
        }

        public Emploee Retrieve(int darbuotojoID)
        {
            foreach (var item in Darbuotojai)
            {
                if (darbuotojoID == item.EmployeeID)
                {
                    return item;
                }
            }
            return null;
        }


        
    }
}
