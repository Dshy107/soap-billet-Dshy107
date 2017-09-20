using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfBillet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilletSystemCL;

namespace WcfBillet.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void BilRabatTest()
        {
            var bilRabat = new BIl();
            bilRabat.BroBizz = true;
            Assert.AreEqual(228, bilRabat.Pris());//228
        }

        
        [TestMethod()]
        public void GetMCPrisTest()
        {
            var mc = new MC();
            int pris = mc.Pris();
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void MCRabatTest()
        {
            var mcRabat = new MC();
            mcRabat.BroBizz = true;
            Assert.AreEqual(118, mcRabat.Pris());//118
        }

        [TestMethod()]
        public void GetBilPrisTest()
        {
            var bil = new BIl();
            int pris = bil.Pris();
            Assert.AreEqual(240, pris);
        }
    }
}