using ContactsBusinessLayer;
using MyFirstClassLibrary;
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
    public partial class FormPeople : Form
    {
        public FormPeople()
        {
            InitializeComponent();
        }

        private void FormPeople_Load(object sender, EventArgs e)
        {
           if(!MyToolsLibrary.GetAllDataToDataGridView(dgvPeole, clsPeople.GetAllPeople()))
            {
                MessageBox.Show("No Data Found");
            }


            lblRecords.Text = dgvPeole.RowCount.ToString();


        }

        private void اظهارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonDetails For=new FormPersonDetails(Convert.ToInt32(dgvPeole.CurrentRow.Cells[0].Value));
            For.ShowDialog();
        }

        private void اضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd_EditPersonInfo For = new FormAdd_EditPersonInfo();
            For.ShowDialog();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd_EditPersonInfo For=new FormAdd_EditPersonInfo(Convert.ToInt32( dgvPeole.CurrentRow.Cells[0].Value));
            For.ShowDialog();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            FormAdd_EditPersonInfo For = new FormAdd_EditPersonInfo();
            For.ShowDialog();

        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPeople.Delete(Convert.ToInt32(dgvPeole.CurrentRow.Cells["PersonID"].Value), dgvPeole.CurrentRow.Cells["ImagePath"].Value.ToString());
        }
    }
}
