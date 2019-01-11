using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using Server.Util;
using System.Net;

namespace Server
{
    class Server
    {
        private const int port = 11001;
        private static Thread thread;
        public  void StartServer()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("start server enter");
                    String value = StartClient();
                    String sendValue = new string("string".ToCharArray());

                    do
                    {
                        if (value.Equals("null"))
                            value = StartClient();
                    } while (value.Equals("null"));
                    
                    if (value.StartsWith("order"))
                    {
                        sendValue = "done!";
                        string[] orders = value.Split('^');
                        orders[0] = orders[0].Substring(5);
                        String[] pizzas;
                        ListView listView = new ListView();
                        Form1.addOrderId();
                        foreach (string order in orders)
                        {
                            if (order.CompareTo("") == 0) continue;
                            String[] pizza = order.Split(':');
                            
                            DatabaseManager.InsertCart(Form1.orderidCounter, pizza[0], pizza[1]);
                        }
                       ((Form1)Form1.ActiveForm).RefreshOrderView();
                            //String[] indgredent = pizza[1].Split(',');
                            //MessageBox.Show("ok message:" + pizza[1]);
                            //ListViewGroup group = new ListViewGroup(pizza[0]);
                            //foreach(string ing in indgredent)
                            //{
                            //    group.Items.Add(ing);
                            //    MessageBox.Show("ing one:" + ing);
                            //}
                            //listView.Groups.Add(group);
                        //}
                        //Form1.addOrder(listView);
                        //DatabaseManager.getOrders(((Form1)Form1.ActiveForm).getOrderListView());
                        MessageBox.Show("orders added!");
                    }
                    else if (value.StartsWith("login"))
                    {
                        value = value.Substring(5);
                        string[] info = value.Split(',');
                        sendValue = "loginFail";
                        String usr = info[0].ToLower().Trim();
                        string pswrd = info[1].ToLower().Trim();
;                        MessageBox.Show("userName:" + usr + ",password" + pswrd);
                        if (DatabaseManager.isLogin(usr,pswrd)) sendValue="loginTrue";
                        MessageBox.Show("login:" + sendValue + ",userName:" + usr + ",password" + pswrd);
                    }
                    else if (value.StartsWith("createuser"))
                    {
                        sendValue = "true";
                        Console.WriteLine("send value is equal login!!!!");
                    }

                    else if (value.StartsWith("history"))
                    {
                        sendValue = "true";
                        Console.WriteLine("send value is equal login!!!!");
                    }

                    Console.WriteLine("value :" + value);
                    IPAddress iPAddress = Dns.GetHostAddresses(Dns.GetHostName())[0];
                    TcpListener tcpl = new TcpListener(iPAddress,11000);

                    tcpl.Start();

                    // Accept will block until someone connects
                    using (Socket s = tcpl.AcceptSocket())
                    {

                        // Convert the string to a Byte Array and send it
                        Byte[] byteDateLine = Encoding.ASCII.GetBytes(sendValue.ToCharArray());
                        s.Send(byteDateLine, byteDateLine.Length, 0);
                        s.Close();
                        Console.WriteLine("Sent {0}", sendValue);
                        tcpl.Server.Close();

                        break;
                    }
                }
                catch (Exception e)
                {

                }
            }

            Console.WriteLine("while loop close");
            if (thread.IsAlive)
            {
                Console.WriteLine("thread close");
                thread.Abort();
            }
        }
        private  string StartClient()
        {

            string value = "null";
            try
            {
                using (TcpClient tcpc = new TcpClient())
                {
                    Byte[] read = new Byte[1024];   // read buffer
                                                    // server name

                    // Try to connect to the server
                    tcpc.Connect("localhost", port);
                    Stream send = tcpc.GetStream();
                    // Get a NetworkStream object
                    Stream s;
                    s = tcpc.GetStream();


                    // Read the stream and convert it to ASII
                    int bytes = s.Read(read, 0, read.Length);
                    value = Encoding.ASCII.GetString(read);

                    // Display the data
                    Console.WriteLine("Received {0} bytes", bytes);
                    Console.WriteLine("Received value: {0}", value);

                    tcpc.Close();
                    Console.WriteLine("Reciever closed");
                    return value.Trim().ToLower();
                }
            }
            catch (Exception)
            {
                return value;
            }


        }
        public  void Start()
        {
            thread = new Thread(StartServer);

            while (true)
            {
                try
                {
                    if (!thread.IsAlive)
                    {

                        //Console.WriteLine("thread isnot alive");
                        thread = new Thread(StartServer);
                        thread.Start();
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        //Console.WriteLine("thread is alive");
                        Thread.Sleep(1000);
                    }
                }
                catch
                {

                }
            }
        }
    }
}
