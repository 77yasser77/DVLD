using ContactsBusinessLayer;
using MyFirstClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FullRealProgect
{
    public partial class ucFilter : UserControl
    {
        public ucFilter()
        {
            InitializeComponent();
        }

        public DataGridView DGV
        {
            get;
            set;
        }
        public void updeteData(DataTable Table)
        {
            if (!MyToolsLibrary.GetAllDataToDataGridView(DGV, Table))
            {
                if (Table.Rows.Count == 0)
                {
                    MessageBox.Show("No Data Found");
                }
            }
        }




        private void ShowBox(Control co)
        {
            co.Visible = true;

        }
        private void clearBox()
        {
            cmbBox.Visible = false;
            txtBox.Visible = false;
            rdF.Visible = false;
            rdM.Visible = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "None")
            {
                clearBox();
                updeteData(clsPeople.GetAllPeople());
                return;
            }
            else if (comboBox1.SelectedItem.ToString() == "Nationslty")
            {
                clearBox();
                ShowBox(cmbBox);
                clsComboBox.DisplayMemberAndValueMember( cmbBox, clsCountry.AllCountry(), 191, "CountryName", "CountryID");
                return;
            }
            else if (comboBox1.SelectedItem.ToString() == "Gendor")
            {
                clearBox();
                ShowBox(rdF);
                ShowBox(rdM);
                return;
            }
            else
            {
                clearBox();
                ShowBox(txtBox);
                return;
            }
        }

        private void cmbBox_Validating(object sender, CancelEventArgs e)
        {
            Control con = sender as Control;
            if (con.Text == string.Empty)
            {
                errorProvider1.SetError(con, "Please select a value");
            }
            else
            {
                errorProvider1.SetError(con, "");
            }
        }

        private void ucFilter_Load(object sender, EventArgs e)
        {

            cmbBox.Visible = false;
            txtBox.Visible = false;
            rdF.Visible = false;
            rdM.Visible = false;
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updeteData(clsPeople.GetNationalty(Convert.ToInt16(cmbBox.SelectedIndex)));
 
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem.ToString())
            {

                case "Perons ID":
                    {
                     updeteData(clsPeople.GetPeopleID(Convert.ToInt16(txtBox.Text)));

                        break;
                    }
                case "Nationsl No":
                    {



                        // workingAfterCleckEnter(txtBox, ke);
                        updeteData(clsPeople.GetPeopleNationalNo(txtBox.Text.ToString()));

                        break;
                    }
                case "First Name":
                    {

                      updeteData(clsPeople.GetFirsName(txtBox.Text.ToString()));

                        break;

                    }
                case "Second Name":
                    {
                        updeteData(clsPeople.GetSecondName(txtBox.Text.ToString()));
                        break;
                    }
                case "Third Name":
                    {
                        updeteData(clsPeople.GetThirdName(txtBox.Text.ToString()));
                        break;
                    }


                case "Phone":
                    {
                        updeteData(clsPeople.GetPhone(txtBox.Text.ToString()));

                        break;


                    }
                case "Email":
                    {
                        updeteData(clsPeople.GetEmail(txtBox.Text.ToString()));
                        break;

                    }
            }
        }

        private void rdF_CheckedChanged(object sender, EventArgs e)
        {
            updeteData(clsPeople.GetGender(false));
        }

        private void rdM_CheckedChanged(object sender, EventArgs e)
        {
            updeteData(clsPeople.GetGender(true));
        }
    }
}
