using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletSystemCL;

namespace WcfBillet
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int BilRabat()
        {
            var bilRabat = new BIl();
            bilRabat.BroBizz = true;
            return bilRabat.Pris();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

       
        public int GetMCPris()
        {
            var mc = new MC();
            return mc.Pris();
            
        }

        public int MCRabat()
        {
            var mcRabat = new MC();
            mcRabat.BroBizz = true;
            return mcRabat.Pris();
        }

        public int GetBilPris()
        {
            var bil = new BIl();
            return bil.Pris();
           
        }
    }
}
