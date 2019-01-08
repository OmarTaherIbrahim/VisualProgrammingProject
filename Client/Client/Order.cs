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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBox1.SelectedIndex)
            {
               
                case 0:
                    listView2.Clear();
                    listView2.Items.Add("Cheese");
                    listView2.Items.Add("Sauce");
                    break;
                case 1:
                    listView2.Clear();
                    listView2.Items.Add("Cheese");
                    listView2.Items.Add("Sauce");
                    listView2.Items.Add("Pepperoni");
                    break;
                case 2:
                    listView2.Clear();
                    listView2.Items.Add("Cheese");
                    listView2.Items.Add("Sauce");
                    listView2.Items.Add("Mashrom");
                    listView2.Items.Add("Artichokes");
                    listView2.Items.Add("Ham");
                    break;
                case 3:
                    listView2.Clear();
                    listView2.Items.Add("Cheese");
                    listView2.Items.Add("Sauce");
                    listView2.Items.Add("Beef");
                    listView2.Items.Add("Pepperoni");
                    listView2.Items.Add("Sausage");
                    break;
                case 4:
                    listView2.Clear();
                    listView2.Items.Add("Cheese");
                    listView2.Items.Add("Sauce");
                    listView2.Items.Add("Beef");
                    listView2.Items.Add("Pepperoni");
                    listView2.Items.Add("Mashroom");
                    listView2.Items.Add("Green Pepper");
                    listView2.Items.Add("Onion");
                    listView2.Items.Add("Olive");
                    break;
                case 5:
                    listView2.Clear();
                    listView2.Items.Add("Cheese");
                    listView2.Items.Add("Sauce");
                    listView2.Items.Add("Mashroom");
                    listView2.Items.Add("Green Pepper");
                    listView2.Items.Add("Onion");
                    listView2.Items.Add("Olive");
                    listView2.Items.Add("Tomato");
                    break;
                case 6:
                    listView2.Clear();
                    listView2.Items.Add("Cheese");
                    listView2.Items.Add("Sauce");
                    listView2.Items.Add("Pinapple");
                    listView2.Items.Add("Beef");
                    break;

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Order_Load(object sender, EventArgs e)
        { 
            listView1.Items.Add("Cheese");
            listView1.Items.Add("Sauce");
            listView1.Items.Add("Mashroom");
            listView1.Items.Add("Pinapple");
            listView1.Items.Add("Tomato");
            listView1.Items.Add("Pepperoni");
            listView1.Items.Add("Sausage");
            listView1.Items.Add("Onion");
            listView1.Items.Add("Olives");
            listView1.Items.Add("Green Pepper");
            listView1.Items.Add("Beef");
            listView1.Items.Add("Chicken");
            listView1.Items.Add("BBQ Ssauce");




        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            string key = listView1.SelectedItems[0].Text;
            if (comboBox1.SelectedItem == null)
            {
                listView2.Clear();
                return;
            }
            else
                foreach (ListViewItem item in listView2.Items)
                {
                    if (key == item.Text)
                    {
                        item.Text = key + " Extra";
                        return;
                    }
                }
                listView2.Items.Add(key);
        }

        private void addBtn_Click(object sender, EventArgs e)
    {
       
            listView3.Groups.Add(new ListViewGroup(comboBox1.SelectedItem.ToString()  + "," + comboBox2.SelectedItem.ToString()));
              foreach(ListViewItem item in listView2.Items)
            {
                listView3.Items.Add(item.Text);
                
            }
        }
        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.SelectedItems)
            {
                listView2.Items.Remove(item);
            }
        }
    }
}
