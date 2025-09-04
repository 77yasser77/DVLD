using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsDataAccessLayer;
namespace ContactsBusinessLayer
{
    public class clsCountry
    {
        public int ID { get; set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            ID = -1;
            CountryName = "";
        }
        private clsCountry(int ID,string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
        }
        public static clsCountry Find(int ID)
        {
            string CountryName = "";
            if (clsCountryDataAccess.GetCountryByID(ID,ref CountryName))
                return new clsCountry(ID, CountryName);
            else
                    return null;

        }
        public static clsCountry Find(string CountryName)
        {
            int ID = -1;
            if (clsCountryDataAccess.GetCountryByName(CountryName,ref ID))
                return new clsCountry(ID, CountryName);
            else
                    return null;

        }

        static public DataTable AllCountry()
        {
            return clsCountryDataAccess.GetAllCountry();
        }


    }
}
