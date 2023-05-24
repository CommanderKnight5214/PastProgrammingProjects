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
    public partial class AmountTender : Form
    {
        double theTotal;
        public AmountTender(double theTotal)
        {
            this.theTotal = theTotal;
            InitializeComponent();
            //MessageBox.Show(theTotal.ToString());

        }
        double tax = 0.05;
        double remainder; 
        double input;
        double rt;
        double finTotal;
        double finTotal2;



        private void AmountTender_Load_1(object sender, EventArgs e)
        {
            finTotal = (theTotal * tax);
            textBox_custom.Select();
            textBox_custom.Focus();
            theTotal = Convert.ToDouble(theTotal);
            textBox_sub.Text = theTotal.ToString();
            textBox_tax.Text = finTotal.ToString();
            finTotal2 = finTotal + theTotal;
            textBox_total.Text = finTotal2.ToString();

            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_QC5_Click(object sender, EventArgs e)
        {
            // substracts 5 dollars from the total underneath Pay Full Amount (running total or label_rt) 
            rt += 5.00;
            textBox_rt.Text = rt.ToString();
        }

        private void button_QC10_Click(object sender, EventArgs e)
        {
            // substracts 10 dollars from the total underneath Pay Full Amount (running total or label_rt) 

            rt += 10.00;
            textBox_rt.Text = rt.ToString();

        }

        private void button_QC15_Click(object sender, EventArgs e)
        {
            // substracts 15 dollars from the total underneath Pay Full Amount (running total or label_rt) 
            rt += 15.00;
            textBox_rt.Text = rt.ToString();
        }

        private void button_giftcard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction Completed");
            textBox_custom.Text = string.Empty;
            textBox_rt.Text = string.Empty;
            textBox_total.Text = string.Empty;
            textBox_tax.Text = string.Empty;
            textBox_sub.Text = string.Empty;
            this.Close();
        }

        private void button_card_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction Completed");
            textBox_custom.Text = string.Empty;
            textBox_rt.Text = string.Empty;
            textBox_total.Text = string.Empty;
            textBox_tax.Text = string.Empty;
            textBox_sub.Text = string.Empty;
            this.Close();
        }

        private void button_manual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction Completed");
            textBox_custom.Text = string.Empty;
            textBox_rt.Text = string.Empty;
            textBox_total.Text = string.Empty;
            textBox_tax.Text = string.Empty;
            textBox_sub.Text = string.Empty;
            this.Close();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction Completed");
            textBox_custom.Text = string.Empty;
            textBox_rt.Text = string.Empty;
            textBox_total.Text = string.Empty;
            textBox_tax.Text = string.Empty;
            textBox_sub.Text = string.Empty;
            this.Close();
        }

        private void button_payCash_Click(object sender, EventArgs e)
        {
            // subtracts entered amount from textBox_custom (button next to it) to label_rt or running total
            // Not total in the above box
            // subtracts 
            try
            {
                input = Convert.ToDouble(textBox_custom.Text);
                if (input > 0)
                {
                    rt += Convert.ToDouble(textBox_custom.Text);
                    textBox_rt.Text = rt.ToString();
                    textBox_custom.Text = "";
                    textBox_custom.Text = string.Empty;
                    textBox_custom.Focus();

                }
                else
                {
                    textBox_custom.Text = "Error on Input, Only Numeric Values Greater than 0";
                    textBox_custom.Text = " "; // gets rid of incorrect input
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Input, only positive numbers expected.");

            }
        }

        private void textBox_custom_TextChanged(object sender, EventArgs e)
        {
            //enter custom amount of cash being paid, will substract from the total underneath Pay Full Amount(running total or label_rt)

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            textBox_custom.Text = string.Empty;
            textBox_rt.Text = string.Empty;
            textBox_rt.Text = textBox_total.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //made to keep original balance of the bill
        }

        private void textBox_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Pay_Click(object sender, EventArgs e)
        {
            
            if (rt >= theTotal)
            {
                if (rt > theTotal)
                {
                    remainder = rt - finTotal2;
                    MessageBox.Show("Your Change Back: $" + remainder);
                }
                MessageBox.Show("Transaction Complete");
                textBox_custom.Text = string.Empty;
                textBox_rt.Text = string.Empty;
                textBox_total.Text = string.Empty;
                textBox_tax.Text = string.Empty;
                textBox_sub.Text = string.Empty;
                this.Close();
               

                
            }
            else
            {
                MessageBox.Show("Please Match Amount Running Total with Total");

            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_custom.Text = string.Empty;
            textBox_rt.Text = string.Empty;
            textBox_rt.Text = textBox_total.Text;
        }
    }
}

