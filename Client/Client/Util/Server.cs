using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client.Util
{
    public class Server
    {
        // The port number for the remote device.  
        private const int port = 11000;
        private const int portSendin = 11001;

        public static String response = String.Empty;
        private static String command;
        private static Thread thread;
        private static void StartClient()
        {
            try
            {
                using (TcpClient tcpc = new TcpClient())
                {
                    Byte[] read = new Byte[9999];   // read buffer
                                                    // server name

                    // Try to connect to the server
                    tcpc.Connect("localhost", port);                    // Get a NetworkStream object
                    Stream s;
                    s = tcpc.GetStream();

                    // Read the stream and convert it to ASII
                    int bytes = s.Read(read, 0, read.Length);
                    response = Encoding.ASCII.GetString(read);
                    if (response.CompareTo("loginTrue") == 0)
                    {
                        
                        ((LoginForm)LoginForm.ActiveForm).login();
                    }else if (response.CompareTo("loginFail") == 0)
                    {
                        ((LoginForm)LoginForm.ActiveForm).loginFailed();
                    }
                    tcpc.Close();
                }
                Console.WriteLine("Reciever closed");
            }
            catch (PlatformNotSupportedException e)
            {

            }
        }

        public static void StartServer(string str)
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

                        // Convert the string to a Byte Array and send it
                        Byte[] byteData = Encoding.ASCII.GetBytes(str.ToCharArray());
                        s.Send(byteData, byteData.Length, 0);
                        s.Close();
                        StartClient();
                        tcpl.Server.Close();
                        break;
                    }
                }
                catch (Exception e)
                {

                }
            }

        }

        public static void Execute(String args)
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

                        return;
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
        private static void commandExecute()
        {
            StartServer(command);
        }
    }
}

