using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyClassesLibrary
{
    public class ReportGenerator
    {
        private CompanyRepository _companyR;

        public ReportGenerator(CompanyRepository companyR)
        {
            _companyR = companyR;
        }
        
        public string GenerateCompanyR()
        {
            string Report = "";
            //string NumerisReport = "";

            List < Company > kompanijos = _companyR.Retrieve();
            foreach (var item in kompanijos)
            {
                /*
                List<string> Numeriai = item.RetrievePhones();
                foreach (var Numeris in Numeriai)
                {
                    NumerisReport = NumerisReport + " " + Numeris;
                } */

                Report = Report + item.ID + " " + item.Name + " Komercine " + item.KomercineOrganizacija + " Turimas telefonu kiekis " + item.returnCountPhoneNumbers() + "\n";
                //NumerisReport = "";
            }
            return Report;
        }
    }
}
