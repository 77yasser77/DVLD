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
                    NationalNO = Reader["NationalNO"]as string;
                    FirstName = Reader["FirstName"]as string;
                    SecondName = Reader["SecondName"] as string;
                    if (Reader["ThirsdName"] == DBNull.Value)
                    {
                        ThirdName = string.Empty;
                    }
                    else
                    {
                        ThirdName = Reader["ThirdName"] as string;
                    }

                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Gendor = Convert.ToBoolean(Reader["Gendor"]);
                    Address = Reader["Address"] as string;
                    Phone = Reader["Phone"] as string;
                    if (Reader["Email"] == DBNull.Value)
                    {
                        Email = string.Empty;
                    }
                    else
                    {
                        Email = Reader["Email"] as string;
                    }
                 
                    NationaltyCountryID =Convert.ToInt32(Reader["NationalityCountryID"]);
                    if (Reader["ImagePath"] == DBNull.Value)
                    {
                        ImagePath = string.Empty;
                    }
                    else
                    {
                        ImagePath = (string)Reader["ImagePath"] as string;
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
        public static bool GetPersonByNationalNo(string NationalNO, ref int ID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
        ref bool Gendor, ref string Address, ref string Phone, ref string Email, ref int NationaltyCountryID, ref string ImagePath)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE PersonID = @NationalNO ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNO", NationalNO);
            bool Result = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Result = true;
                    ID =Convert.ToInt32(Reader["PersonID"]);
                    FirstName = Reader["FirstName"] as string;
                    SecondName = Reader["SecondName"] as string;
                    if (Reader["ThirsdName"] == DBNull.Value)
                    {
                        ThirdName = string.Empty;
                    }
                    else
                    {
                        ThirdName = Reader["ThirdName"] as string;
                    }

                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Gendor = Convert.ToBoolean(Reader["Gendor"]);
                    Address = Reader["Address"] as string;
                    Phone = Reader["Phone"] as string;
                    if (Reader["Email"] == DBNull.Value)
                    {
                        Email = string.Empty;
                    }
                    else
                    {
                        Email = Reader["Email"] as string;
                    }

                    NationaltyCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                    if (Reader["ImagePath"] == DBNull.Value)
                    {
                        ImagePath = string.Empty;
                    }
                    else
                    {
                        ImagePath = (string)Reader["ImagePath"] as string;
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

        public static int AddNewPerson(string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
         bool Gendor, string Address, string Phone, string Email, int NationaltyCountryID, string ImagePath)
        {
            int ID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Qury = "INSERT INTO People ( NationalNO, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath) " +
                "VALUES ( @NationalNO, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationaltyCountryID, @ImagePath);" +
                " SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Qury, Connection);
            Command.Parameters.AddWithValue("@NationalNO", NationalNO);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != null && ThirdName != "")
            {


                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else { Command.Parameters.AddWithValue("@ThirdName", DBNull.Value); }
                Command.Parameters.AddWithValue("@LastName", LastName);



            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            Command.Parameters.AddWithValue("@Gendor", Gendor);



            if (Address != "" && Address != null) {
                Command.Parameters.AddWithValue("@Address", Address);
            }
            else 
            {
                Command.Parameters.AddWithValue("@Address", DBNull.Value);
            }
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

    
        public static bool UpdatePeople(int ID, string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
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
            if (string.IsNullOrEmpty(ThirdName))
            {
                Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            if (string.IsNullOrEmpty(Address))
            {
                Command.Parameters.AddWithValue("@Address", DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@Address", Address);
            }

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
    
        public static DataTable GetAllPeople()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select People.PersonID,People.NationalNo,People.FirstName,People.SecondName,People.ThirdName,People.LastName,People.DateOfBirth,
 case
when Gendor=1 then 'ذكر'
ELse 'انثى'
end As GenderDescription
,People.Address,People.Phone,People.Email,Countries.CountryName,People.ImagePath
from 
Countries  inner join People on Countries.CountryID=People.NationalityCountryID;
";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable Table = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Table.Load(Reader);

                    Reader.Close();
                }
            }
            finally
            {
                Connection.Close();
            }
            return Table;
        }

        public static bool DeletePerson(int ID)
        {
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

        public static bool IsPeronsExist(int ID)
        {
            bool Result = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select * from People where PersonID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Result = true;
                }
                Reader.Close();

            }
            finally
            {
                Connection.Close();

            }
            return Result;
        }
        public static bool IsPeronsExist(string NationalNo)
        {
            bool Result = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select * from People where PersonID = @NationalNo";
            SqlCommand Command = new SqlCommand(Query, Connection); 
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Result = true;
                }
                Reader.Close();

            }
            finally
            {
                Connection.Close();

            }
            return Result;
        }

        //-----------------------------------------------------------------------------
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

        public static bool DeletePerson(int ID, string ImagePath)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "DELETE FROM People WHERE PersonID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            int Result = -1;
            try
            {
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


        public static DataTable GetPeopleNationalNo(string NationalNo)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE PersonID = @NationalNo ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            DataTable Table = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    Table.Load(Reader);


                    Reader.Close();

                }
            }

            finally
            {

                Connection.Close();

            }
            return Table;
        }


        public static bool FindNationalNO(string NationalNo)
        {
            bool Result = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select * from People where People.NationalNo=@NationalNO;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNO", NationalNo);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Result = true;
                }
                Reader.Close();

            }
            finally
            {
                Connection.Close();

            }
            return Result;
        }

        public static DataTable GetPeopleID(int ID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE PersonID = @ID ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            DataTable Table = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    Table.Load(Reader);
                  

                    Reader.Close();

                }
            }

            finally
            {

                Connection.Close();

            }
            return Table;
        }
       public static DataTable GetPeopleFirstName(string FirstName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE FirstName = @FirstName ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            DataTable Table = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    Table.Load(Reader);


                    Reader.Close();

                }
            }

            finally
            {

                Connection.Close();

            }
            return Table;
        }
        
        public static DataTable GetPeopleSecondName(string SecondNameame)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE SecondName = @SecondName ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@SecondName", SecondNameame);
            DataTable Table = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    Table.Load(Reader);


                    Reader.Close();

                }
            }

            finally
            {

                Connection.Close();

            }
            return Table;
        }

        public static DataTable GetPeopleThirdName(string ThirdName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE ThirdName = @ThirdName ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            DataTable Table = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    Table.Load(Reader);


                    Reader.Close();

                }
            }

            finally
            {

                Connection.Close();

            }
            return Table;
        }

        public static DataTable GetPeopleLastName(string LastName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE LastName = @LastName ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LastName", LastName);
            DataTable Table = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    Table.Load(Reader);


                    Reader.Close();

                }
            }

            finally
            {

                Connection.Close();

            }
            return Table;
        }

        public static DataTable GetPeopleNationalty(int Nationalty)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE NationalityCountryID = @Nationalty ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Nationalty", Nationalty);
            DataTable Table = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    Table.Load(Reader);


                    Reader.Close();

                }
            }

            finally
            {

                Connection.Close();

            }
            return Table;
        }

        public static DataTable GetPeopleGendor(bool Gendor)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE Gendor = @Gendor ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            DataTable Table = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    Table.Load(Reader);


                    Reader.Close();

                }
            }

            finally
            {

                Connection.Close();

            }
            return Table;
        }
        public static DataTable GetPeoplePhone(string Phone)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE Phone = @Phone ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Phone", Phone);
            DataTable Table = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    Table.Load(Reader);


                    Reader.Close();

                }
            }

            finally
            {

                Connection.Close();

            }
            return Table;
        }
        public static DataTable GetPeopleEmail(string Email)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE Email = @Email ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Email", Email);
            DataTable Table = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    Table.Load(Reader);


                    Reader.Close();

                }
            }

            finally
            {

                Connection.Close();

            }
            return Table;
        }

    }


}
