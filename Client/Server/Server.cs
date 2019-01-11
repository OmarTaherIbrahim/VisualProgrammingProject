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
        public  Thread thread;
        public  void StartServer()
        {

            while (true)
            {
                try
                {
                    String value = StartClient();
                    String sendValue = new string("string".ToCharArray());
                    //MessageBox.Show("sending is awaiting");
                    do
                    {
                        if (value.Equals("null"))
                            value = StartClient();
                    } while (value.Equals("null"));
                    //MessageBox.Show("recieved"+value);
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
                        ((Form1)Form1.ActiveForm).getOrderListView().Items.Clear();
                        DatabaseManager.getOrders(((Form1)Form1.ActiveForm).getOrderListView());
                        //MessageBox.Show("ok message");
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
                        //MessageBox.Show("orders added!");
                    }
                    else if (value.StartsWith("login"))
                    {
                        value = value.Substring(5);
                        string[] info = value.Split(',');
                        sendValue = "loginFail";
                        String usr = info[0].ToLower().Trim();
                        string pswrd = info[1].ToLower().Trim();
//;                        MessageBox.Show("userName:" + usr + ",password" + pswrd);
                        if (DatabaseManager.isLogin(usr,pswrd)) sendValue="loginTrue";
                        //MessageBox.Show("sendValue:" + sendValue);
                    }
                    else if (value.StartsWith("createuser"))
                    {
                        value = value.Substring(10);
                        string[] info = value.Split(',');
                        DatabaseManager.InsertUser(info[0], info[1], info[2]);
                        sendValue = "loginTrue";
                        Console.WriteLine("send value is equal login!!!!");
                    }

                    else if (value.StartsWith("history"))
                    {
                        //MessageBox.Show("listview:" + sendValue);
                        sendValue = "history:";
                        value = value.Substring(7).ToLower().Trim();
                        //MessageBox.Show("usr:" + value);
                        sendValue += DatabaseManager.getOrdersForUsr(value);
                        //MessageBox.Show("listview:" + sendValue);
                    }
                    sendValue += ";";
                    while (true)
                    {
                        try
                        {
                            IPAddress iPAddress = Dns.GetHostAddresses(Dns.GetHostName())[0];
                            //MessageBox.Show("waiting for connection");
                            TcpListener tcpl = new TcpListener(12345);

                            tcpl.Start();

                            // Accept will block until someone connects
                            using (Socket s = tcpl.AcceptSocket())
                            {

                                //MessageBox.Show(" value send is being sent");
                                // Convert the string to a Byte Array and send it
                                Byte[] byteDateLine = Encoding.ASCII.GetBytes(sendValue.ToCharArray());
                                s.Send(byteDateLine, byteDateLine.Length, 0);
                                s.Close();
                                //MessageBox.Show(" value send has been sent");
                                tcpl.Server.Close();

                                break;
                            }
                        }catch(Exception e)
                        {
                            //MessageBox.Show("Error Ocurred");
                        }
                    }
                    //MessageBox.Show("Thread killed");
                    thread.Abort();
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
                    StringBuilder builder = new StringBuilder();
                    foreach(byte b in read)
                    {
                        if (b.Equals(59))//the byte representation of a semicolon ";"
                            break;
                        else
                            builder.Append(Convert.ToChar(b).ToString());
                    }
                    value = builder.ToString();
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
                    }
                }
                catch
                {

                }
            }
        }
    }
}
