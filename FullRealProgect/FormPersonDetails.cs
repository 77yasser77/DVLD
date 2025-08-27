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
    public partial class FormPersonDetails : Form
    {
        public FormPersonDetails(int PeronID)
        {
            InitializeComponent();
            _PeronID = PeronID;
        }
        private int _PeronID=0;
        private void FormPersonDetails_Load(object sender, EventArgs e)
        {
            ucPersonInformation PersonInfromation = new ucPersonInformation(_PeronID);
            PersonInfromation.Dock = DockStyle.Bottom;
            this.Controls.Add(PersonInfromation);
        }
    }
}
