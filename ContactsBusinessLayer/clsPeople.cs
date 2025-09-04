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
        public enum enMode { Add = 0, Update = 1 }
        public enMode Mode=enMode.Add;
     
        
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
        private string _ImagePath;
        public string ImagePath { get { return _ImagePath; } set { _ImagePath = value; } }
        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
        }

        clsCountry CountryInfo;
        
        public clsPeople()
        {
            this.ID = -1;
            this.NationalNO = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
          
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationaltyCountryID = -1;
            this.ImagePath = "";
            Mode = enMode.Add;
        }
        private clsPeople(int ID, string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
         bool Gendor, string Address, string Phone, string Email, int NationaltyCountryID, string ImagePath)
        {

            this.ID = ID;
            this.NationalNO = NationalNO;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationaltyCountryID = NationaltyCountryID;
            this.ImagePath = ImagePath;
            CountryInfo = clsCountry.Find(NationaltyCountryID);
            Mode = enMode.Update;
        }

         private bool _AddNew()
        {
         
         this.ID=clsPeopleDataAccess.AddNewPerson(this.NationalNO, this.FirstName, this.SecondName,this.ThirdName, this.LastName, 
             this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationaltyCountryID,
                  ImagePath);
            return (this.ID != -1);
        }

        

        private bool _Update()
        {
           
            return clsPeopleDataAccess.UpdatePeople(this.ID, this.NationalNO, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth,
                this.Gendor, this.Address, this.Phone, this.Email, this.NationaltyCountryID, this.ImagePath);

        }
        public static clsPeople Find(int ID)
        {
            if (ID <= 0)
            {
                return null;
            }
            
            string NationalNO = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            bool Gendor = false;
            int NationaltyCountryID = -1;
            DateTime DateOfBirth = DateTime.MinValue;


            bool isFound = clsPeopleDataAccess.GetPersonByID(ID, ref NationalNO, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
     ref Gendor, ref Address, ref Phone, ref Email, ref NationaltyCountryID, ref ImagePath);

            if (isFound)
            {
                return new clsPeople(ID, NationalNO, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationaltyCountryID
                    , ImagePath);
            }
            else
            {
                return null;
            }
              
    
        }
        public static clsPeople Find(string NationalNo)
        {
            if (NationalNo != "")
            {
                return null;
            }

            
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            bool Gendor = false;
            int NationaltyCountryID = -1, ID = -1;
            DateTime DateOfBirth = DateTime.MinValue;


            bool isFound = clsPeopleDataAccess.GetPersonByNationalNo(NationalNo, ref ID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
     ref Gendor, ref Address, ref Phone, ref Email, ref NationaltyCountryID, ref ImagePath);

            if (isFound)
            {
                return new clsPeople(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationaltyCountryID
                    , ImagePath);
            }
            else
            {
                return null;
            }
         
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        return _AddNew();      
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
            
            }
            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }
        public static bool Delete(int ID,string ImagePath)
        {
            if (ID <= 0)
            {
                return false;
            }
         
            
                return clsPeopleDataAccess.DeletePerson(ID); 
             
        }

        public static bool IsPersonExist(int ID)
        {
            if (ID <= 0) { return false; }
            return clsPeopleDataAccess.IsPeronsExist(ID);
        }
        public static bool IsPersonExist(string NationalNo)
        {
            return clsPeopleDataAccess.IsPeronsExist(NationalNo);

        }

      







        //--------------------------------------------------------------
        public static DataTable GetPeopleID(int ID)
        {
            return clsPeopleDataAccess.GetPeopleID(ID);    
        }
        public static DataTable GetFirsName(string FirstName)
        {
            return clsPeopleDataAccess.GetPeopleFirstName(FirstName);
        }
        public static DataTable GetPeopleNationalNo(string NationalNo)
        {
            return clsPeopleDataAccess.GetPeopleNationalNo(NationalNo);
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
        public static DataTable GetNationalty(int Nationalty)
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

