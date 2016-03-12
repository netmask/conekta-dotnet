using System;
using conekta.io;
using conekta.io.Resource;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests.Resource
{
    [TestClass]
    public class EventTest
    {
        [TestInitialize()]
        public void Setup()
        {
            Conekta.setApiKey("key_eYvWV7gSDkNYXsmr");
        }


        [TestMethod]
        public void testFindAllEvents()
        {
           var events = ModelEvent.FindAll();
            Assert.IsTrue(events.Count > 1);
        }

    }
}
