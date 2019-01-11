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
using System.Threading;
namespace Server
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        static String username = "omar";
        public static int orderidCounter = 100;
        private Server server;
        public Form1()
        {
            InitializeComponent();
            // takes the  id of the largest id to know where to insert
            orderidCounter = DatabaseManager.getOrderIdMax();
            server = new Server();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshOrderView();
            orderDetailListView.Clear();
            try
            {
               
                string orderid = (orderListView.SelectedItems[0].Text);
                Text = orderid.ToString();
                DatabaseManager.getOrderDetails(int.Parse(orderid), orderDetailListView);

            }
            catch(Exception)
            {

            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseManager.getOrders(orderListView);

            Thread thread = new Thread(check);
            thread.Start();
        }
        private void check()
        {
            server.Start();
        }
        public void setUsername(string usr)
        {
            username = usr;
        }
        public static void addOrder(ListView listView)
        {

            try
            {
                DatabaseManager.InsertOrder(++orderidCounter, DatabaseManager.getAddress(username), DatabaseManager.getUserID(username));
                MessageBox.Show(orderidCounter+"");
                foreach (ListViewGroup group in listView.Groups)
                {
                    String ing = "";
                    foreach (ListViewItem item in group.Items)
                    {
                        ing += item.Text;
                        if (ing.Equals("")) continue;
                        ing += ",";
                    }
                    MessageBox.Show(ing);
                    DatabaseManager.InsertCart(orderidCounter, group.Header, ing);
                }
            }
            catch (Exception)
            {
            }
            
        }
        public  void RefreshOrderView()
        {
            orderListView.Clear();
            DatabaseManager.getOrders(orderListView);
        }
        public static void addOrderId()
        {
            try
            {
                DatabaseManager.InsertOrder(++orderidCounter, DatabaseManager.getAddress(username), DatabaseManager.getUserID(username));
               
            }
            catch (Exception)
            {
            }

        }
        public ListView getHistoryListView(string username)
        {
            ListView listView = new ListView();
            DatabaseManager.getOrdersForUsr(username, listView);
            return listView;
        }

        public ListView getOrderListView()
        {
            return orderListView;
        }
    }
}
