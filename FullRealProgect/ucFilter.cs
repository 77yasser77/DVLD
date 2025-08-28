using ContactsBusinessLayer;
using MyFirstClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FullRealProgect
{
    public partial class ucFilter : UserControl
    {
        public ucFilter()
        {
            InitializeComponent();
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

//Nationsl No
//First Name
//Second Name
//Third Name
//Last Name
//Nationslty
//Gender
//Phone
//Email
            switch (comboBox1.Items.ToString())
            {
                case "None":
                    {

                        break;
                    }
                case "Perons ID":
                    {
                        TextBox ID = new TextBox();
                        ID.Width = 300;
                        ID.Height = 24;
                        flp.Controls.Add(ID);
                        ID.Dock = DockStyle.Top;
                         DataTable PeopleID = MyToolsLibrary.DataTableAddingData(clsPeople.GetPeopleID(Convert.ToInt16(ID.Text)));
                        break;
                    }
            }
        }
    }
}
