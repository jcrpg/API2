using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using Film.Services;

namespace Film.Test
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void StringIsAlphaticalOrder()
        {
            string[] characters = new string[] { "A", "B", "C" };

            string[] output = StringService.GetAscendingOrder(characters);

        }

        [Test]
        public void simpleTest()
        {
            Assert.Pass();
        }
    }
}
