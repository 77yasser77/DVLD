using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;

using System.IO;
namespace ContactsDataAccessLayer
{
    public class clsPeopleDataAccess
    {
        public static int AddPerson(string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
            bool Gendor, string Address, string Phone, string Email, int NationaltyCountryID, string ImagePath)
        { int ID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Qury = "INSERT INTO People ( NationalNO, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath) " +
                "VALUES ( @NationalNO, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationaltyCountryID, @ImagePath);" +
                " SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Qury, Connection);
            Command.Parameters.AddWithValue("@NationalNO", NationalNO);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);



            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            Command.Parameters.AddWithValue("@Gendor", Gendor);



            Command.Parameters.AddWithValue("@Address", Address);

            Command.Parameters.AddWithValue("@Phone", Phone);

            if (string.IsNullOrEmpty(Email))
            { Command.Parameters.AddWithValue("@Email", DBNull.Value); }
            else
            { Command.Parameters.AddWithValue("@Email", Email); }

            Command.Parameters.AddWithValue("@NationaltyCountryID", NationaltyCountryID);

            if (string.IsNullOrEmpty(ImagePath))
            { Command.Parameters.AddWithValue("@ImagePath", DBNull.Value); }
            else
            { Command.Parameters.AddWithValue("@ImagePath", ImagePath); }

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int IDPeople))
                {
                    ID = IDPeople;
                }

            }
            finally
            {

                Connection.Close();

            }
            return ID;

        }


        public static bool GetPersonByID(int ID, ref string NationalNO, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
          ref bool Gendor, ref string Address, ref string Phone, ref string Email, ref int NationaltyCountryID, ref string ImagePath)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE PersonID = @ID ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            bool Result = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Result = true;
                    NationalNO = Reader["NationalNO"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    ThirdName = Reader["ThirdName"].ToString();
                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Gendor = Convert.ToBoolean(Reader["Gendor"]);
                    Address = Reader["Address"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Email = Reader["Email"].ToString();
                    NationaltyCountryID = (int)Reader["NationalityCountryID"];
                    if (Reader["ImagePath"] == DBNull.Value)
                    {
                        ImagePath = string.Empty;
                    }
                    else
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }
                    Reader.Close();

                }
            }

            finally
            {

                Connection.Close();

            }
            return Result;
        }



        public static bool EditPeople(int ID, string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
            bool Gendor, string Address, string Phone, string Email, int NationaltyCountryID, string ImagePath)
        { int Result = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"UPDATE People SET NationalNo = @NationalNO,FirstName =@FirstName,SecondName = @SecondName,ThirdName = @ThirdName 
,LastName = @LastName,DateOfBirth =@DateOfBirth,Gendor =@Gendor,Address = @Address,Phone = @Phone,Email = @Email,NationalityCountryID = @NationaltyCountryID
      ,ImagePath =@ImagePath WHERE PersonID=@ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@NationalNO", NationalNO);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            if (string.IsNullOrEmpty(Email))
            {
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@Email", Email);
            }
            Command.Parameters.AddWithValue("@NationaltyCountryID", NationaltyCountryID);
            if (string.IsNullOrEmpty(ImagePath))
            {
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            try
            {
                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    Result = RowsAffected;
                }
            }
            finally
            {
                Connection.Close();
            }
            return (Result > 0);

        }


        public static bool DeleteImage(string ImagePath)
        {
            if (string.IsNullOrEmpty(ImagePath) || !File.Exists(ImagePath))
            {
                return false;
            }
            try
            {
                File.Delete(ImagePath);
                return true;
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                return false;
            }
        }

        public static bool DeletePerson(int ID,string ImagePath)
        {
            DeleteImage(ImagePath);
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "DELETE FROM People WHERE PersonID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            int Result = -1;
            try {               
                Connection.Open();
                Result = Command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                return false;
             
               
            }
            finally
            {
                Connection.Close();
                
            }
            return (Result > 0);

        }
    } 


}
