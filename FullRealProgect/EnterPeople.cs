using ContactsBusinessLayer;
using FullRealProgect.Properties;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFirstClassLibrary;
namespace FullRealProgect
{
    public partial class EnterPeople : UserControl
    {
        //this is value to know the Mode of the Form 
        enum enMode { Add, Edit };
        public EnterPeople()
        {//this the conseracter use Add EnterPeople
            InitializeComponent();
            _Mode = enMode.Add;
        }

        public EnterPeople(int ID)
        {//this the conseracter use Edit EnterPeople

            InitializeComponent();
            _Mode = enMode.Edit;
            _People = clsPeople.FindByID(ID);

        }

        //those are the variables that I will use in this class
        //{
        enMode _Mode;
        string _ImagePath = "";
        string _newImagePath = "";
        bool _Gendr = true;
        int _ViewData = 0;
        //this code give the folder that you want to save the Image
        string _destinationFolderPath = @"C:\Users\yasee\source\repos\FullRealProgect\ImageCoustomer";
        clsPeople _People = new clsPeople();
        //}

        //this is property to get the ID of the People {
        public string ImagePath { get { return _ImagePath; } }
        public int PeopleId { get { return _People.ID; } } //}


        private void changePic(bool G)
        {  //this code to change picture in the picture box if it comes Gender Value from the database
            switch (G)
            {
                case true:
                    {
                        radbMale.Checked = true; //set the radio button to checked

                        break;
                    }
                case false:
                    {
                        radbFemale.Checked = true; //set the radio button to checked

                        break;
                    }
            }
        }

       private void radbMale_CheckedChanged(object sender, EventArgs e)
        {//if you change the radio Button will change the picture in the picImage to Man
            _Gendr = true;
            if(picImage.Image== Resources.WomnePictuer)
            picImage.Image = Resources.ManPicture1;
        }

        private void radbFemale_CheckedChanged(object sender, EventArgs e)
        {//if you change the radio Button will change the picture in the picImage to Women
            _Gendr = false;
            if(picImage.Image==Resources.ManPicture)
            picImage.Image = Resources.WomnePictuer;
        }




      

        //this code to get all the countries from the database and fill the combobox with them 
        //{
        private void GetAllCountryIncomdbCountry()
        {
            //get all the countries from the clsCountry class
            DataTable AllCountry = clsCountry.AllCountry();

            if (!MyToolsLibrary.ComboBoxDisplayAndValueMember(comdbCountry, AllCountry, "Yemen", "CountryName", "CountryID"))
            {
                MessageBox.Show("No countries available to select.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }//}
        private void cobyDataClsPeopleToTools()
        {
            labID.Text = _People.ID.ToString();
            txtbFirstName.Text = _People.FirstName.ToString();
            txtbSecondName.Text = _People.SecondName.ToString();
            txtbThirdName.Text = _People.ThirdName.ToString();
            txtbLastName.Text = _People.LastName.ToString();
            txtbNationalNo.Text = _People.NationalNO.ToString();
            dateTimePicker2.Value = _People.DateOfBirth;
            _Gendr = _People.Gendor;
            txtbAddress.Text = _People.Address.ToString();
            txtbPhone.Text = _People.Phone.ToString();
            txtEmail.Text = _People.Email.ToString();
            comdbCountry.SelectedValue = _People.NationaltyCountryID;
          
            if (!string.IsNullOrEmpty(_People.ImagePath))
            {
                if (File.Exists(_People.ImagePath)) { 
                    picImage.ImageLocation = _People.ImagePath; //Image.FromFile(_People.ImagePath) The code loads the image directly into memory.
                }
                else
                {
                    MessageBox.Show("Image file not found. Please check the path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cobyDataToolsToClsPeople()
        {

            _People.FirstName = txtbFirstName.Text.ToString();
            _People.SecondName = txtbSecondName.Text.ToString();
            _People.ThirdName = txtbThirdName.Text.ToString();
            _People.LastName = txtbLastName.Text.ToString();
            _People.NationalNO = txtbNationalNo.Text.ToString();
            _People.DateOfBirth = dateTimePicker2.Value;
            _People.Gendor = _Gendr;
            _People.Address = txtbAddress.Text.ToString();
            _People.Phone = txtbPhone.Text.ToString();
            _People.Email = txtEmail.Text.ToString();
            _People.NationaltyCountryID = (int)comdbCountry.SelectedValue;
         
                if (_newImagePath != "")
                {
                
                    _People.ImagePath = _newImagePath; // Set the new image path after saving the image
                SeveImageInToFolder();
            }
            
        }
        //this code loads the form and sets default values for controls When the control is started{
       
        private void EnterPeople_Load(object sender, EventArgs e)
        {
           


            MyToolsLibrary.CheckFolderIsFindAndAdding(_destinationFolderPath);//Ensure the folder exists or create it if it doesn't
            
            // this code to set the DateTimePicker to the date and time before 18 years
            MyToolsLibrary.DateTimePickerMaxDateTodayDateMinusNumberYears(dateTimePicker2, 18);
            MyToolsLibrary.DateTimePickerDefaultValueYearsMinusFromCurrentYear(dateTimePicker2, 18);

            GetAllCountryIncomdbCountry();

            if (_Mode == enMode.Add)
            {
                labID.Text = "???";

            }
            else if (_Mode == enMode.Edit)
            {

                if (_People != null)
                {
                    cobyDataClsPeopleToTools();
                    changePic(_Gendr); // Change the picture based

                }
                else
                {
                    MessageBox.Show("No data found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }//}
       
    

     
        private void ValidatingTextBoxs(object sender, CancelEventArgs e)
        {
            TextBox text = sender as TextBox;
            //this code to check if the text box is empty or not
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                errorProvider1.SetError(text, "This textBox cannot be empty");
                e.Cancel = true; // Cancel the event if the text box is empty
                butSeve.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(text, ""); // Clear the error if the text box is filled
                butSeve.Enabled = true; // Enable the save button if all fields are filled
            }
        }

      

        private void linkImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //
            _ImagePath = MyToolsLibrary.GetPahtFromDialog(openFileDialog1);
            
            picImage.ImageLocation=ImagePath;

            _newImagePath = Path.Combine(_destinationFolderPath, Path.GetFileName(ImagePath)); //This code gives you Image Path in the new folder




        }

        private bool SeveCobyImageToFolder(string ImagePath, string CobyImagePath)
        {


            try
            {
                //copy the image to the new path
                File.Copy(ImagePath, CobyImagePath, true);
             
            }
            catch (Exception ex)
            {
        
                MessageBox.Show("فشل في النسخ" );
                return false; // Return false if there is an error while copying the image
            }


            return true; // Return true if the image is copied successfully
        }
        
        private void SeveImageInToFolder()
        {

            if (_ImagePath == "")
            { return ; }
          
       
               SeveCobyImageToFolder(ImagePath, _newImagePath);
       
            

        }

        private bool SeveDataPepleInDataBases()
        {
            SeveImageInToFolder();
            

            _People.ID = clsPeople.Add(txtbNationalNo.Text.ToString(), txtbFirstName.Text.ToString(), txtbSecondName.Text.ToString(),
            txtbThirdName.Text.ToString(), txtbLastName.Text.ToString(), (DateTime)dateTimePicker2.Value, _Gendr, txtbAddress.Text.ToString(),
            txtbPhone.Text.ToString(), txtEmail.Text.ToString(), (int)comdbCountry.SelectedValue, _newImagePath);

            // this code to copy the data from the text boxes to the clsPeople class
            if (_People.ID != -1)
            {
                _Mode = enMode.Edit; // Change mode to Edit after saving
                return true; // Return true if the data is saved successfully

            }
            MessageBox.Show("Error saving data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false; // Exit the method if there is an error
        }

    

    
        private bool SeveUpdateDataInDataBases()
        {
            //this code to update the data in the database
            cobyDataToolsToClsPeople();
            if (_People.Update())
            {
                return true; // Return true if the data is updated successfully
            }
            else
            {
                return false; // Return false if there is an error
            }
        }
        private void butSeve_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Add)
            {
                if (SeveDataPepleInDataBases())
                {
                    MessageBox.Show("تم حفظ البيانات");
                }


            }
            else if (_Mode == enMode.Edit)
            {
                if (SeveUpdateDataInDataBases())

                { MessageBox.Show("تم تعديل البيانات"); }


                labID.Text = _People.ID.ToString();
            }
        }
    

        private void butClose_Click(object sender, EventArgs e)
        {
            Form FormEnterPerople = new Form();
            FormEnterPerople = this.FindForm();
            FormEnterPerople.Close();

        }

       
    }
}
