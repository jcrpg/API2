using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using Film.Services;
using Film.Models;

namespace Film.Test
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Json_Has_Return_Data()
        {

            var service = new StringService(new MockService());

            var output = service.GetAscendingOrder();

            Assert.IsInstanceOf<IEnumerable<Models.Actor>>(output);

        }

        [Test]
        public void simpleTest()
        {
            //A dummy test just to see if the test setup correctly
            Assert.Pass();
        }

    }
}
