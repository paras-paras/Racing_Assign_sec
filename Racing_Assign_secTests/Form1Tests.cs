using Microsoft.VisualStudio.TestTools.UnitTesting;
using Racing_Assign_sec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing_Assign_sec.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            player ply = new player();
            int y = ply.checkBudget(100, 50);
            if (y == 1)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }
    }
}