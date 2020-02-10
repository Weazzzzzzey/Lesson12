using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyClassesLibrary
{
    public class Company
    {
        private static Random rnd;
        public int ID { get; private set; }
        public string Name { get; private set; }
        public bool KomercineOrganizacija { get; private set; }
        private List<string> PhoneNumbers;

        public Company(int iD, string name, bool KMO)
        {
            ID = iD;
            Name = name;
            KomercineOrganizacija = KMO;
            PhoneNumbers = new List<string>();
            randomAddNumbers();
        }

        public void addNumber(string numeris)
        {
            PhoneNumbers.Add(numeris);
        }

        public int Randomizeris()
        {
            rnd = new Random();
            return rnd.Next(1,10) * rnd.Next(2,10) * rnd.Next(3,10) * rnd.Next(4,10);
        }

        public int dvigubasR()
        {
            return Randomizeris() * Randomizeris();
        }

        public void randomAddNumbers()
        {
            for (int i = 0; i < dvigubasR(); i++)
            {
                addNumber("Numeriukas");
            }
        }
        public int returnCountPhoneNumbers()
        {
            return PhoneNumbers.Count();
        }

        public List<string> RetrievePhones()
        {
            return PhoneNumbers;
        }

    }
}
