using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Tracker
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        //This button will close this form and go back to the main program.
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
