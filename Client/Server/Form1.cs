using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Server.Util;
namespace Server
{
    public partial class Form1 : Form
    {
        String username = "omar";
        static int orderidCounter = 100;
        
        public Form1()
        {
            InitializeComponent();
            DatabaseManager.EstablishConnection();
            SQLiteDataReader reader = DatabaseManager.ExecuteQuery("select max(id) from orders;");
            if (reader.Read()) orderidCounter = int.Parse(reader[0].ToString());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderDetailListView.Clear();
            try
            {
               
                string orderid = (orderListView.SelectedItems[0].Text);
                Text = orderid.ToString();
                SQLiteDataReader reader = DatabaseManager.getOrderDetails(int.Parse(orderid));
                while (reader.Read())
                {
                    
                    ListViewGroup group = new ListViewGroup(reader[1].ToString());
                    orderDetailListView.Groups.Add(group);
                    String[] ings = reader[2].ToString().Split(',');
                    foreach (String ing in ings)
                    {
                        string text = ing.Trim();
                        ListViewItem item = orderDetailListView.Items.Add("  "+text.ToUpperInvariant());
                        item.Group = group;
                    }
                }
            }
            catch(Exception exeption)
            {

            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteDataReader reader = DatabaseManager.getOrders();
            while (reader.Read())
            {
                ListViewItem item =orderListView.Items.Add(reader[0].ToString());
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
            }

        }
        public void setUsername(string usr)
        {
            username = usr;
        }
    }
}
