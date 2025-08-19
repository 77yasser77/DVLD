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
    public partial class Button : UserControl
    {
        public Button()
        {
            InitializeComponent();
        }
        public String text
        {
            get { return button1.Text; }
            set { button1.Text = value; }

        }
        public Image Image
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
    

      
      

        
    }
}
