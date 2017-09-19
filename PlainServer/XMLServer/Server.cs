using ModelLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLServer
{
    class Server
    {
        public Server()
        {

        }
        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 10002);
            server.Start();
            TcpClient client = server.AcceptTcpClient();
            using (NetworkStream ns = client.GetStream())
            using (StreamWriter sw = new StreamWriter(ns))
            using (StreamReader sr = new StreamReader(ns))
            {
                string inLine = sr.ReadLine();
                XmlSerializer serializer = new XmlSerializer(typeof(Car));
                Console.WriteLine(sr.ReadToEnd());
                //Car c = (Car)serializer.Deserialize(sr);

                //Console.WriteLine(c);
            }
        }
    }
}
