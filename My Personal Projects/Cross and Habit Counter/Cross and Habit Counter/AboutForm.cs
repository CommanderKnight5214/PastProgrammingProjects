using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cross_and_Habit_Counter
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        //The AboutForm will close when the OKButton is clicked.
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
