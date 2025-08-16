using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;
using MyFirstClassLibrary;
namespace FullRealProgect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EnterPeople E = new EnterPeople(1045);
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(E);

         
        }

        private void enterPeople1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(clsPeople.Delete(1045,E.ImagePath))
            {
                MessageBox.Show("تم حذف الكنترل");
            }
            else
            {
                MessageBox.Show("هناك مشكله");

            }
        }
    }
}
