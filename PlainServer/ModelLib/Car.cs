using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string RegNo { get; set; }

        public override string ToString()
        {
            return "Model: Tesla, " + "Color: Red, " + "RegNo: EL23400";
        }
    }
}
