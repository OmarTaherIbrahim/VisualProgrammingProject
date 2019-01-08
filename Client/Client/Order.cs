using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            listView3.Groups.Add(new ListViewGroup(comboBox1.SelectedItem.ToString()  + "," + comboBox2.SelectedItem.ToString()));
              foreach(ListViewItem item in listView2.Items)
            {
                listView3.Items.Add(item.Text);
                
            }
        }
    }
}
