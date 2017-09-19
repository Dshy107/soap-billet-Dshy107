using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PlainServer
{
    class Server
    {
        public Server()
        {

        }

        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 10001);
            server.Start();
            TcpClient client = server.AcceptTcpClient();
            using (NetworkStream ns = client.GetStream())
            using (StreamWriter sw = new StreamWriter(ns))
                using(StreamReader sr = new StreamReader(ns))
            {
                string inLine = sr.ReadLine();
                string outLine = HandelClient(inLine);
                sw.WriteLine(outLine);
                sw.Flush();
            }
        }
        public static string HandelClient(string line)
        {
            Console.WriteLine("Bil modtaget " + line);
            return line;
        }
    }
}
