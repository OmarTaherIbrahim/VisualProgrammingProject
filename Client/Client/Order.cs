using Client.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{

    public partial class Order : Form
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static int orderID = 67830;
        double orderSum = 0;

        public Order()
        {
            InitializeComponent();
        }
        public string getPizzaSize()
        {
            return comboBox2.Items[comboBox2.SelectedIndex].ToString();
        }

        public void OrderPizza()
        {
            try
            {
                string text = "order";
                foreach (ListViewGroup group in listView3.Groups) {
                    text += group.Header.Split(',')[0]+":";
                    foreach (ListViewItem item in group.Items)
                    {
                        
                            text += item.Text + ",";
                    }
                     text=text.Remove(text.Length - 1);
                    text +="^";
                    MessageBox.Show(text);
                 }
                Server.Execute(text);
            }
            catch(Exception)
            {

            }
        }

        public double getPrice(int i)
        {
            switch (i)
            {
                case 0:
                    return 7;
                case 1:
                    return 10;
                case 2:
                    return 15;
                default:
                    return 0;
            }
        }

        public double getPrice()
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    return 7;
                case 1:
                    return 10;
                case 2:
                    return 15;
                default:
                    return 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DialogResult dialog = MessageBox.Show("Confirm Order", "Order Button", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                OrderPizza();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem != null)
                comboBox2.SelectedIndex = 1;

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
          /*  listView3.Clear();
            listView3.Items.Add(comboBox1.Items[comboBox1.SelectedIndex].ToString());
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                listView3.Items[0].SubItems.Add(listView2.Items[i].Text.ToString());
            }

            listView3.Items.Add("Size is : " + getPizzaSize());
            orderSum = getPrice() + getPrice() * .16;
            label2.Text = "$" + (orderSum).ToString();*/
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
                    if (item.Text.Contains("Extra") && item.Text.Contains(key))
                        return;
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

            try
            {
                ListViewGroup group = new ListViewGroup(comboBox1.SelectedItem.ToString() + "," + comboBox2.SelectedItem.ToString());
                listView3.Items.Add(comboBox1.Items[comboBox1.SelectedIndex].ToString() + " - " + getPizzaSize() + " $" + getPrice(comboBox2.SelectedIndex));
                listView3.Groups.Add(group);

                foreach (ListViewItem item in listView2.Items)
                {
                    ListViewItem listViewItem = new ListViewItem(group);
                    listViewItem.Text = item.Text;
                    listView3.Items.Add(listViewItem);
                }
                orderSum += getPrice() + getPrice() * .16;
                label2.Text = "$" + (orderSum).ToString();
                //   listView3.Clear();

                //Beginning of my code
                //listView3.Items.Add(comboBox1.Items[comboBox1.SelectedIndex].ToString());
                //for (int i = 0; i < listView2.Items.Count; i++)
                //{
                //    listView3.Items[0].SubItems.Add(listView2.Items[i].Text.ToString());
                //}

                //listView3.Items.Add("Size is : " + getPizzaSize());
                //orderSum += getPrice() + getPrice() * .16;
                //label2.Text = "$" + (orderSum).ToString();
            }
            catch(NullReferenceException)
            {
                    MessageBox.Show("Error Type: No Pizza Selected");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listView3.Clear();
            orderSum = 0;
            label2.Text = "$" + (orderSum).ToString();
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
                string[] split = new string[2];
                if (item.Text.Contains("Extra"))
                {
                    split = item.Text.Split(' ');
                    item.Text = split[0];
                    return;
                }
                listView2.Items.Remove(item);
            }
        }


    }
}
