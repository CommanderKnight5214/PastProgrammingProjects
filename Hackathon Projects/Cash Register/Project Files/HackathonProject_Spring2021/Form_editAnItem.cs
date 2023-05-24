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
    public partial class Form_editAnItem : Form
    {
        public Form_editAnItem()
        {
            InitializeComponent();
        }

        private void Form_editAnItem_Load(object sender, EventArgs e)
        {
            /*
            //int len = theArr.Length;
            ListViewItem item1 = new ListViewItem(theArr[0].name, 0);
            ListViewItem item2 = new ListViewItem(theArr[1].name, 0);
            ListViewItem item3 = new ListViewItem(theArr[2].name, 0);
            ListViewItem item4 = new ListViewItem(theArr[3].name, 0);
            ListViewItem item5 = new ListViewItem(theArr[4].name, 0);
            ListViewItem item6 = new ListViewItem(theArr[5].name, 0);
            ListViewItem item7 = new ListViewItem(theArr[6].name, 0);
            ListViewItem item8 = new ListViewItem(theArr[7].name, 0);
            ListViewItem item9 = new ListViewItem(theArr[8].name, 0);
            ListViewItem item10 = new ListViewItem(theArr[9].name, 0);
            ListViewItem item11 = new ListViewItem(theArr[10].name, 0);
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
