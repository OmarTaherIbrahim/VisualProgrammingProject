using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    class Connect
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //   int Flag = 0;//Use this when done with multi threading

        public Connect()
        {
            LoopConnect();
        }

        public void LoopConnect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (SocketException)
                {

                }
                /*    if (Flag == 1)
                        break;*///this should be a W.I.P for multi threading
            }

            if (_clientSocket.Connected)
            {
                MessageBox.Show("Successfully connected to server.");
            }
            else
            {
                MessageBox.Show("Stopped attempting to connect");
            }
        }
        public bool SendLoop(string command1)
        {
            /*
            //Move these to server Socket.
            try
            {
                string[] command = command1.Split(' ');
                switch (command[0])
                {
                    case "login":
                        return(isLogin(command[1], command[2]));
                    case "order":
                        InsertOrder(int.Parse(command[1]), command[2], command[3]);
                        break;
                    case "signup":
                        InsertUser(command[1], command[2], command[3]);
                        break;
                    case "cart":
                        InsertCart(command[1], command[2], command[3]);
                        break;
                    case "history":
                        getOrdersForUsr([command1]);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }*/
            
            //
            string req = command1;
            byte[] buffer = Encoding.ASCII.GetBytes(req);
            _clientSocket.Send(buffer);
            byte[] response = new byte[1024];
            int rec = _clientSocket.Receive(response);
            byte[] data = new byte[rec];
            Array.Copy(response, data, rec);
            return true;
        }
        
    }
}
