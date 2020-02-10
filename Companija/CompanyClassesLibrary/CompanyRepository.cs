using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyClassesLibrary
{
    public class CompanyRepository
    {
        //public List<Company> Kompanijos;
        public List<Company> Kompanijos { get; private set; }
        public CompanyRepository()
        {
            Kompanijos = new List<Company>();
        }

        public void addCompanys(int id, string name, bool KMO)
        {
            Kompanijos.Add(new Company(id,name,KMO));
        }

        public List<Company> Retrieve()
        {
            return Kompanijos;
        }

        public Company Retrieve(int CompanyID)
        {
            foreach (var item in Kompanijos)
            {
                if (CompanyID == item.ID)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
