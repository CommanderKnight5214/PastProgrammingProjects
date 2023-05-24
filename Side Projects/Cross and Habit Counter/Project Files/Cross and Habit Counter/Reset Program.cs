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
    public partial class ResetProgramForm : Form
    {
        public ResetProgramForm()
        {
            InitializeComponent();
        }

        //This button will close the form and open the CandHCounter form, passing in a value for the "ResetIndicator" which is equal to one.
        private void YesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CandHCounter CandH = new CandHCounter(1);
            CandH.ShowDialog();
        }

        //Identical to the YesButton, except the value for the "ResetIndicator" is equal to zero.
        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CandHCounter CandH = new CandHCounter(0);
            CandH.ShowDialog();
        }
    }
}
