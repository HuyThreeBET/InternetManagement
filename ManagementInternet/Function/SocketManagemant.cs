using System;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ManagementInternet.Function
{
    internal class SocketManagemant
    {
        private string ip = "127.0.0.1";
        private const int PORT = 9999;
        private const int BUFFER = 1024;
        private bool isServer = true;

        public string Ip { get => ip; set => ip = value; }

        #region Client

        private Socket client;

        public bool ConnectServer()
        {
            IPEndPoint iEP = new IPEndPoint(IPAddress.Parse(this.Ip), PORT);

            this.client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(iEP);

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region server

        private Socket server;

        public void CreateServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(this.Ip), PORT);

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(iep);
            server.Listen(10);

            Thread acceptClient = new Thread(() =>
            {
                client = server.Accept();
            });

            acceptClient.IsBackground = true;
            acceptClient.Start();
        }
        #endregion

        #region Both
        public bool Send(object data)
        {
            byte[] sendData = SerializeData(data);

            return SendData(client, sendData);
        }

        public object Receive()
        {
            byte[] receiveData = new byte[BUFFER];

            bool isOk = ReceiveData(client, receiveData);

            return DeserializeData(receiveData);
        }

        private bool SendData(Socket target, byte[] data)
        {
            return target.Send(data) == 1 ? true : false;
        }

        private bool ReceiveData(Socket target, byte[] data)
        {
            return target.Receive(data) == 1 ? true : false;
        }

        // Tranfer object to byte[]
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        // Unzip byte[] to object
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }

        // Get IPV4 of network card is using
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }

            return output;
        }

        public void listen()
        {
            object data = Receive();

            if (data == null)
            {
                return;
            }
            else
            {
                MessageBox.Show("Có order");
            }
        }
        #endregion
    }
}
