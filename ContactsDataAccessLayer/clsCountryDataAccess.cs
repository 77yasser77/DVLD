using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsDataAccessLayer
{
    public class clsCountryDataAccess
    {
        static public DataTable GetAllCountry()
        {
            //this is code to get all countries from the database
            DataTable AllCountry = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select * from countries order by CountryName;";
      
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                 AllCountry.Load(Reader); }
                else
                {
                    AllCountry = null;
                }

                Reader.Close();
            }
            finally
            {
                
                Connection.Close();
            }
            return AllCountry;

        }

        static public bool GetCountryByName(string CountryName,ref int CountryID  )
        {
            //this is code to get the country ID from the database
            int ID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select * from countries where CountryName=@CountryName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue(@"CountryName", CountryName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    CountryID = Convert.ToInt32(Reader["CountryID"]);
                    ID = CountryID;
                }
                Reader.Close();
            }
            finally
            {
                Connection.Close();
            }
            return (ID != -1) ;
        }

        static public bool GetCountryByID(int CountryID,ref string CountryName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Qery = @"select * from Countries where CountryID=@CountryID;";
            SqlCommand Command = new SqlCommand(Qery, Connection);
        
            Command.Parameters.AddWithValue(@"CountryID", CountryID);
            string Country = "";
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read()) {
                    Country = Reader["CountryName"] as string;
                    CountryName = Country;
                }
                Reader.Close();

            }
            catch
            {

                return false;
            }
            finally
            {
                Connection.Close();
            }
           
            return (Country!="");
        }

    }
}
