using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonProject_Spring2021
{
    public partial class ManagerMenu : Form
    {
        String Order;
        String reset = "Total:";
        public ManagerMenu(String Order)
        {
            this.Order = Order;
            InitializeComponent();
        }

        private void button_refund_Click(object sender, EventArgs e)
        {

        }

        private void button_receipt_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MessageBox.Show(now + "\n" + Order, "Recipt");
        }

        private void button_clockIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are now clocked in", "clock in");
        }

        private void button_clockOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are now clocked out", "clock out");
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notice: " + Environment.NewLine + Environment.NewLine + "Print the receipt for the last transaction.");
        }

        private void button_hRefund_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notice: " + Environment.NewLine + Environment.NewLine + "Refund's the last transaction completed");
        }

        private void button_hIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notice: " + Environment.NewLine + Environment.NewLine + "Used for employees to clock in." + Environment.NewLine +
                "Enter in employee id and password.");
        }

        private void button_hOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notice: " + Environment.NewLine + Environment.NewLine + "Used for employees to clock out." + Environment.NewLine +
                "Enter in employee id and password.");
        }

        private void button_hReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notice: " + Environment.NewLine + Environment.NewLine + "Reset the running total and list of orders." + Environment.NewLine +
                "Enter in employee id and password.");
        }

        private void button_reset_Click(object sender, EventArgs e)
        {

        }
    }
}
