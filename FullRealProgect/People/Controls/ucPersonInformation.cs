using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullRealProgect
{
    public partial class ucPersonInformation : UserControl
    {
     
        public ucPersonInformation(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            _People = new clsPeople(ID);
        //تم تعبعت بيانات الشخص
        }
        public int ID { get; set; }
        clsPeople _People;





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAdd_EditPersonInfo For = new FormAdd_EditPersonInfo(ID);
            For.ShowDialog();
        }
        private void ucPersonInformation_Load()
        {
            clsPeople _People = new clsPeople(ID);
            lblID.Text = _People.ID.ToString();
            lblName.Text = _People.FullName;
            lblNattionalNo.Text = _People.NationalNO;
            lblGendor.Text= _People.Gendor ? "ذكر" : "انثى";
            lblEmail.Text = _People.Email;
            lblAddress.Text = _People.Address;
            lblDateBirth.Text = _People.DateOfBirth.ToShortDateString();
            lblPhone.Text = _People.Phone;
            lblCountry.Text= clsCountry.GetCountryNameByID(_People.NationaltyCountryID);
            pictureBox1.ImageLocation = _People.ImagePath;
        }
        private void gbPersonInformation_Enter(object sender, EventArgs e)
        {
            ucPersonInformation_Load();
        }
    }
}
