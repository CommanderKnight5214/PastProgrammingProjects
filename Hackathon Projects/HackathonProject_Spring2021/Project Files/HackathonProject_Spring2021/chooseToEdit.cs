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
    public partial class chooseToEdit : Form    //int[] chosenReturned;
    {
        //Object[] theArr;
        string[] theList;

        public chooseToEdit() //Object[] theArr)
        {
            //this.theArr = theArr;
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checkedListBox1 
        }

        private void chooseToEdit_Load(object sender, EventArgs e)
        {
            int len = Variables.count;
            ListViewItem listViewItem;
            //checkedListBox1.View = Details;
            theList = new string[len];
            //this.checkedListBox1
            
            
            for (int i = 0; i < len; i++)
            {
                //listViewItem = new ListViewItem(Variables.theSelected[i]);
                //checkedListBox1.Items.Add(Variables.theSelected[i]);
                string temp = Variables.theSelected[i];
                //checkedListBox1.Items.Add(Variables.theSelected[i]);
                checkedListBox1.Items.Add(Variables.theSelected[i]);
            }


            //istViewItem listViewItem = new ListViewItem(Variables.theSelected);
            //checkedListBox1.Items.AddRange(Variables.theSelected);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("closing", "form shutdown");
            Variables.chooseReturn = 1;
            this.Close();
        }
    }
}
