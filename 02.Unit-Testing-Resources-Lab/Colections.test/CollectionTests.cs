using System;
using Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Colections.test
{
    [TestFixture]
    public class CollectionTests
    {
        [Test]
        public void CampasityShoudBe16ForEmptyColection()
        {
            var collection = new Collections<int>();

            Assert.That(collection.Capacity, Is.EaualTo(18));
        }

        [Test]
        public void 
    }
}
