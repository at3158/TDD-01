using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_01.WEBDATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_01.WEBDATA.Tests
{
    [TestClass()]
    public class CalTests
    {
        Cal cal = new Cal();

        [TestMethod()]
        public void CalAddTest()
        {
            int iER=3;
            int IFR;
            IFR = cal.CalAdd(1, 2);
            Assert.AreEqual(iER, IFR);
            //Assert.Fail();
        }

        [TestMethod()]
        public void CalMinTest()
        {
            int iER = 1;
            int IFR;
            IFR = cal.CalMin(2, 1);
            Assert.AreEqual(iER, IFR);
            //Assert.Fail();
        }
    }
}