using MyControlsLibrary;
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
    public partial class FormAdd_EditPersonInfo : Form
    {
        public FormAdd_EditPersonInfo()
        {
            InitializeComponent();
            labTitle.Text = "Add Person Info";
            EnterPeople en = new EnterPeople();
            this.Controls.Add(en);
            en.Dock = DockStyle.Bottom;

        }

        public FormAdd_EditPersonInfo(int ID)
        {
             InitializeComponent();
            EnterPeople en = new EnterPeople(ID);
            this.Controls.Add(en);
           
            flowLayoutPanel1.Controls.Add(en);
            en.Dock = DockStyle.Bottom;

            labTitle.Text = "Eidte Person Info";

        }

       
    }
}
