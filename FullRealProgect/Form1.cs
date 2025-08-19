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
using MyControlsLibrary;
namespace FullRealProgect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       EnterPeople E = new EnterPeople(1033);
        private void Form1_Load(object sender, EventArgs e)
        {
           butApplications.text="التطبيقات";
            button2.text = "الناس";
         this.Controls.Add(E);

            butApplications.Text = "التطبيقات";
        }

        private void enterPeople1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {
        }

        private void button2_Load(object sender, EventArgs e)
        {

           
        }

     
    }
}
