using ModelLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PlainClient
{
    class Client
    {
        public void Start()
        {
            //string SendCar = "Tesla, Red, EL23400";

            Car car = new Car();
            car.Model = "Tesla";
            car.Color = "Red";
            car.RegNo = "El23400";

            using (TcpClient socket = new TcpClient("localhost", 10001))
            using (NetworkStream ns = socket.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.WriteLine(car);
                sw.Flush();

                string incomingCar = sr.ReadLine();
                Console.WriteLine("Bil modtaget: " + incomingCar);
            }
        }
    }
}
