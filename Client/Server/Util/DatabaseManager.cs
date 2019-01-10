using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Util
{
    class DatabaseManager
    {
        private static SQLiteConnection connection;
        public DatabaseManager()
        {
            EstablishConnection();
        }
        public static void EstablishConnection()
        {
            connection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            connection.Open();
        }
        public static SQLiteDataReader ExecuteQuery(String sqlStatement)
        {
            SQLiteCommand command = new SQLiteCommand(sqlStatement, connection);
            SQLiteDataReader dataReader = command.ExecuteReader();
            return dataReader;
        }
        public static void ExecuteCommand(string sqlStatement)
        {
            SQLiteCommand command = new SQLiteCommand(sqlStatement, connection);
            command.ExecuteNonQuery();
        }
        public static void InsertOrder(int id,string address, int user_id)
        {
            ExecuteCommand("insert into orders values(" + id + ", '" + address + "', " + user_id+");");
        }
        public static void InsertCart(int orderID,string pizza,string ingredients)
        {
            ExecuteCommand("insert into cart values(" + orderID + ", '" + pizza + "', '" + ingredients + "');");
        }
        public static void InsertUser(string usr,string pswrd,string address)
        {
            ExecuteCommand("insert into users(username,password,address) values( '" + usr.ToLower() + "', '" + pswrd + "', '"+address+"');");
        }
        public static bool isLogin(string usr, string pswrd)
        {
            SQLiteDataReader reader = ExecuteQuery("select * from users where username='" + usr.ToLower() + "' and password = '" + pswrd + "';");
            if (reader.Read()) return true;

            return false;
        }
        public static SQLiteDataReader getOrdersForUsr(string usr)
        {
            return ExecuteQuery("select orders.id, orders.userid, orders.address from orders,users where orders.userid=users.id and users.username='" + usr.ToLower() + "';");
        }
        public static SQLiteDataReader getOrders()
        {
            return ExecuteQuery("select orders.id, orders.userid, orders.address from orders,users where orders.userid=users.id ;");
        }
        public static SQLiteDataReader getOrderDetails(int orderID)
        {
            return ExecuteQuery("select * from cart where orderID=" + orderID + ";"); 
        }
    }
}
