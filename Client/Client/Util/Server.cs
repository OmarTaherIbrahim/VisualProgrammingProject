using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Client.Util
{
    public class Server
    {
        // The port number for the remote device.  
        private const int port = 12345;
        private const int portSendin = 11001;

        public  String response = String.Empty;
        private  String command;
        private  Thread thread;
        private  void StartClient()
        {
            while (true)
            {
                try
            {
                
               
                    using (TcpClient tcpc = new TcpClient())
                    {

                        Byte[] read = new Byte[9999];   // read buffer

                        // Try to connect to the server
                        tcpc.Connect("localhost", 12345);
                        Stream s;
                        s = tcpc.GetStream();
                        // Read the stream and convert it to ASII
                        int bytes = s.Read(read, 0, read.Length);
                        StringBuilder builder = new StringBuilder();
                        foreach (byte b in read)
                        {
                            if (b.Equals(59))
                                break;
                            else builder.Append(Convert.ToChar(b).ToString());
                        }
                        response = builder.ToString();
                        if (response.CompareTo("loginTrue") == 0)
                        {
                            MessageBox.Show("login:true");
                            tcpc.Close();
                            return;
                        }
                        else if (response.CompareTo("loginFail") == 0)
                        {
                            MessageBox.Show("login:false;");
                            tcpc.Close();
                            return;

                        }
                        else if (response.Contains("history"))
                        {
                            tcpc.Close();
                            return;
                        }
                        else if (response.CompareTo("done!") == 0)
                        {
                            tcpc.Close();
                            return;
                        }
                        tcpc.Close();
                        return;
                    }
               
                }
                catch (Exception e)
                {
                }
            }
        }

        public  void StartServer(string str)
        {

            while (true)
            {
                try
                {

                    TcpListener tcpl = new TcpListener(portSendin); // listen on port 2048

                    tcpl.Start();


                    // Accept will block until someone connects
                    using (Socket s = tcpl.AcceptSocket())
                    {
                        str += ";";
                        MessageBox.Show(str);
                        // Convert the string to a Byte Array and send it
                        Byte[] byteData = Encoding.ASCII.GetBytes(str.ToCharArray());
                        s.Send(byteData, byteData.Length, 0);
                        s.Close();
                        tcpl.Server.Close();
                        StartClient();
                        return;
                    }
                }
                catch (Exception e)
                {

                }
            }

        }

        public  String Execute(String args)
        {
            response = "null";
            command = args;
            thread = new Thread(commandExecute);
            thread.Start();
            while (true)
            {
                try
                {
                    if (!thread.IsAlive)
                    {

                        return response;
                    }
                    else
                    {
                        Console.WriteLine("thread is alive");
                        Thread.Sleep(1000);
                    }
                }
                catch(Exception e)
                {

                }
            }
            
        }
        public void Close()
        {
            if (thread.IsAlive)
            {
                thread.Abort();
            }
        }
       
        private  void commandExecute()
        {
            StartServer(command);
        }
    }
}

