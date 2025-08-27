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


        static public DataTable AllCountry()
        {
            return clsCountryDataAccess.GetAllCountry();
        }

        static public string GetCountryNameByID(int countryID)
        {
                       if (countryID <= 0)
            {
                return "";
            }
            return clsCountryDataAccess.GetCountryNameByID(countryID);
        }



    }
}
