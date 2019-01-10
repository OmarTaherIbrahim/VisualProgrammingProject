using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Util
{
    class DatabaseManager
    {
        
        public static string ConnectionString = "Data Source=database.sqlite;Version=3;";

        
        public static int getOrderIdMax()
        {
            try
            {
                string sqlStatement = "select max(id) from orders;";
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlStatement, c))
                    {
                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                                return int.Parse(rdr[0].ToString());

                        }
                    }
                }
            }
            catch (Exception)
            {

                
            }
            return -1;
        }
        public static String getAddress(string user)
        {
            try
            {
                string sql = "select address from users where username='" + user + "';";
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                string re = rdr[0].ToString();
                                rdr.Close();
                                return re;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                
            }
            return "null";
        }
        public static int getUserID(string user)
        {
            try
            {
                string sql = "select id from users where username='" + user + "';";
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                int re = int.Parse(rdr[0].ToString());
                                rdr.Close();
                                return re;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                
            }
            return -1;
        }
        public static void ExecuteCommand(string sqlStatement)
        {

            try
            {
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlStatement, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }
        // is used to enter id address and user id for the order the address is from users table 
        public static void InsertOrder(int id,string address, int user_id)
        {
            try
            {
                ExecuteCommand("insert into orders values(" + id + ", '" + address + "', " + user_id + ");");
            }
            catch (Exception)
            {

                
            } 
        }
        //insert the pizzas that were ordered , orderid is used to connect the pizzas with the order
        public static void InsertCart(int orderID,string pizza,string ingredients)
        {
            try
            {
                ExecuteCommand("insert into cart values(" + orderID + ", '" + pizza + "', '" + ingredients + "');");

            }
            catch (Exception)
            {

                
            }
            
        }
        //inserts users by there usrname , password, and address and userid is autoincrement
        public static void InsertUser(string usr,string pswrd,string address)
        {
            try
            {
                ExecuteCommand("insert into users(username,password,address) values( '" + usr.ToLower() + "', '" + pswrd + "', '" + address + "');");
            }
            catch (Exception)
            {

                
            }
        }
        //should be used by the socket to check if the user can login which returns true if the query returns something meaning this user exits
        public static bool isLogin(string usr, string pswrd)
        {
            try
            {
                string sql = "select * from users where username='" + usr.ToLower() + "' and password = '" + pswrd + "';";
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read()) return true;

                        }
                    }
                }
            }
            catch (Exception)
            {

                
            }
            return false;
        }
        /// <summary>
        /// should be used by the socket to send the history form a SQLiteDataReader so you can fill the listview with the order history same as in form1 in server but this one is 
        /// specific to the user, rather than to every one
        /// </summary>
        /// <param name="usr"></param>
        /// <returns></returns>
        public static void getOrdersForUsr(string usr,ListView orderListView)
        {
            try
            {

                string sqlStatement = ("select orders.id, orders.userid, orders.address from orders,users where orders.userid=users.id and users.username='" + usr.ToLower() + "';");
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlStatement, c))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = orderListView.Items.Add(reader[0].ToString());
                                item.SubItems.Add(reader[1].ToString());
                                item.SubItems.Add(reader[2].ToString());
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {

                
            }
        }

        /// <summary>
        /// gets the orders that is used by server side
        /// </summary>
        /// <returns></returns>
        public static void getOrders(ListView orderListView)
        {
            try
            {
                string sqlStatement = ("select orders.id, orders.userid, orders.address from orders,users where orders.userid=users.id ;");
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlStatement, c))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = orderListView.Items.Add(reader[0].ToString());
                                item.SubItems.Add(reader[1].ToString());
                                item.SubItems.Add(reader[2].ToString());
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {

                
            }
        }
        /// <summary>
        /// gets  the order details  
        /// i.e: order 1 has : pepperoni pizza with extra cheese and extra pepperoni
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public static void getOrderDetails(int orderID,ListView listView)
        {

            try
            {
                string sqlStatement = ("select * from cart where orderID=" + orderID + ";");
                using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlStatement, c))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                ListViewGroup group = new ListViewGroup(reader[1].ToString());
                                listView.Groups.Add(group);
                                String[] ings = reader[2].ToString().Split(',');
                                foreach (String ing in ings)
                                {
                                    string text = ing.Trim();
                                    ListViewItem item = listView.Items.Add("  " + text.ToUpperInvariant());
                                    item.Group = group;
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
