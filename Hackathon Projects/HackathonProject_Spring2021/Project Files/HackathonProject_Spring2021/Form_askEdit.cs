using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonProject_Spring2021
{
    public partial class Form_askEdit : Form
    {
        public Form_askEdit()
        {
            InitializeComponent();
        }

        private void button_yes_Click(object sender, EventArgs e)
        {

        }

        private void button_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
