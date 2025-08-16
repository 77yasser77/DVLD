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
            string Query = @"select * from countries;";
      
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

        static public int GetCountryID(string CountryName)
        {
            //this is code to get the country ID from the database
            int CountryID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select CountryID from countries where CountryName=@CountryName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue(@"CountryName", CountryName);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    CountryID = (int)Result;
                }

            }
            finally
            {
                Connection.Close();
            }
            return CountryID;
        }
    }
}
