using ContactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContactsBusinessLayer
{
    public class clsPeople
    {
      
        public clsPeople(int ID)
        {
            clsPeople People = FindByID(ID);
            if (People != null)
            {
                this.ID = People.ID;
                this.NationalNO = People.NationalNO;
                this.FirstName = People.FirstName;
                this.SecondName = People.SecondName;
                this.ThirdName = People.ThirdName;
                this.LastName = People.LastName;
                this.DateOfBirth = People.DateOfBirth;
                this.Gendor = People.Gendor;
                this.Address = People.Address;
                this.Phone = People.Phone;
                this.Email = People.Email;
                this.NationaltyCountryID = People.NationaltyCountryID;
                this.ImagePath = People.ImagePath;
            }
            else
            {
                this.ID = 0;
                this.NationalNO = "";
                this.FirstName = "";
                this.SecondName = "";
                this.ThirdName = "";
                this.LastName = "";
                this.DateOfBirth = DateTime.MinValue;
                this.Gendor = false;
                this.Address = "";
                this.Phone = "";
                this.Email = "";
                this.NationaltyCountryID = -1;
                this.ImagePath = "";
            }
        }
        public clsPeople()
        {
            this.ID = 0;
            this.NationalNO = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.MinValue;
            this.Gendor = false;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationaltyCountryID = -1;
            this.ImagePath = "";
        }
        public int ID { get; set; }
        public string NationalNO { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationaltyCountryID { get; set; }
        public string ImagePath { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
        }

        static public int Add(string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
             bool Gendor, string Address, string Phone, string Email, int NationaltyCountryID, string ImagePath)
        {
            return clsPeopleDataAccess.AddPerson(NationalNO, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationaltyCountryID,
                  ImagePath);
        }

        static public clsPeople FindByID(int ID)
        {
            clsPeople People = new clsPeople();
            if (ID <= 0)
            {
                return null;
            }
            string NationalNO = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            bool Gendor = false;
            int NationaltyCountryID = -1;
            DateTime DateOfBirth = DateTime.MinValue;




            if (!clsPeopleDataAccess.GetPersonByID(ID, ref NationalNO, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
     ref Gendor, ref Address, ref Phone, ref Email, ref NationaltyCountryID, ref ImagePath))
            {
                return null;
            }
            People.ID = ID;
            People.NationalNO = NationalNO;
            People.FirstName = FirstName;
            People.SecondName = SecondName;
            People.ThirdName = ThirdName;
            People.LastName = LastName;
            People.DateOfBirth = DateOfBirth;
            People.Gendor = Gendor;
            People.Address = Address;
            People.Phone = Phone;
            People.Email = Email;
            People.NationaltyCountryID = NationaltyCountryID;
            People.ImagePath = ImagePath;
            return People;
        }

        public bool Update()
        {
            if (this.ID <= 0)
            {
                return false;
            }
            return clsPeopleDataAccess.EditPeople(this.ID, this.NationalNO, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth,
                this.Gendor, this.Address, this.Phone, this.Email, this.NationaltyCountryID, this.ImagePath);

        }
      
        public static bool Delete(int ID,string ImagePath)
        {
            if (ID <= 0)
            {
                return false;
            }
         
            
                return clsPeopleDataAccess.DeletePerson(ID,ImagePath); 
             
        }
        public static bool IsFindNationalNo(string NationalNo)
        {
            return clsPeopleDataAccess.FindNationalNO(NationalNo);

        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }

        public static DataTable GetPeopleID(int ID)
        {
            return clsPeopleDataAccess.GetPeopleID(ID);    
        }
        public static DataTable GetFirsName(string FirstName)
        {
            return clsPeopleDataAccess.GetPeopleFirstName(FirstName);
        }
        public static DataTable GetSecondName(string SecondName)
        {
            return clsPeopleDataAccess.GetPeopleSecondName(SecondName);
        }
        public static DataTable GetThirdName(string ThirdName)
        {
            return clsPeopleDataAccess.GetPeopleThirdName(ThirdName);
        }
        public static DataTable GetLastName(string LastName)
        {
            return clsPeopleDataAccess.GetPeopleLastName(LastName);
        }
        public static DataTable GetNationalty(string Nationalty)
        {
            return clsPeopleDataAccess.GetPeopleNationalty(Nationalty);
        }

        public static DataTable GetGender(bool Gender)
        {
            return clsPeopleDataAccess.GetPeopleGendor(Gender);
        }
        public static DataTable GetPhone(string Phone)
        {
            return clsPeopleDataAccess.GetPeoplePhone(Phone);
        }
        public static DataTable GetEmail(string Email)
        {
            return clsPeopleDataAccess.GetPeopleEmail(Email);
        }

    }
}

