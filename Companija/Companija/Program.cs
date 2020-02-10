using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyClassesLibrary;

namespace Companija
{
    class Program
    {
        static void Main(string[] args)
        {
            Company Kompanija = new Company(4321,"Telefonu Kompanija", true);
            Kompanija.addNumber("1");
            Kompanija.addNumber("2");
            Kompanija.addNumber("3");
            Kompanija.addNumber("4");

            //Console.WriteLine(Kompanija.returnCountPhoneNumbers());

            CompanyRepository Companys = new CompanyRepository();
            Companys.addCompanys(1,"Bambukai",true);
            Companys.addCompanys(2,"McCaffe",true);
            Companys.addCompanys(3,"PcMan",true);
            Companys.addCompanys(4,"VWindustries",false);
            Companys.addCompanys(5,"RedCross",false);
            

            List<Company> kampanijos = Companys.Retrieve();
            foreach (var item in kampanijos)
            {
                //Console.WriteLine("{0} {1} {2}",item.ID, item.Name, item.KomercineOrganizacija);
            }


            Company vienaKompanija = Companys.Retrieve(3);
            //Console.WriteLine("{0} {1} {2}",vienaKompanija.ID, vienaKompanija.Name, vienaKompanija.KomercineOrganizacija);

            ReportGenerator RP = new ReportGenerator(Companys);
            Console.WriteLine(RP.GenerateCompanyR());
            
            Console.ReadLine();

        }

    }
}
