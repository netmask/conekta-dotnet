using System;
using conekta.io;
using conekta.io.Resource;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace tests.Resource
{
    [TestClass]
    public class CustomerTest
    {

        [TestInitialize()]
        public void Setup()
        {
            Conekta.setApiKey("key_eYvWV7gSDkNYXsmr");
        }


        [TestMethod]
        public void Create()
        {
            var request = JObject.Parse("{'name': 'test', 'cards':['tok_test_visa_4242']}");
            var customer = Customer.Create(request);

            Assert.IsNotNull(customer);
            Assert.IsNotNull(customer.Id);
        }

        [TestMethod]
        public void Find()
        {
            var request = JObject.Parse("{'name': 'test', 'cards':['tok_test_visa_4242']}");
            var customer = Customer.Create(request);
            var foundCustomer = Customer.Find(customer.Id);

            Assert.IsNotNull(foundCustomer);
            Assert.IsNotNull(foundCustomer.Id);
        }


        [TestMethod]
        public void Update()
        {
            var request = JObject.Parse("{'name': 'test', 'cards':['tok_test_visa_4242']}");
            var customer = Customer.Create(request);
            customer.Update(JObject.Parse("{'name':'Logan', 'email':'logan@x-men.org'}"));
          
            Assert.IsTrue(customer.Name == "Logan", customer.Name);
        }


        [TestMethod]
        public void Delete()
        {
            var request = JObject.Parse("{'name': 'test', 'cards':['tok_test_visa_4242']}");
            var customer = Customer.Create(request);

            customer.Delete();

            Assert.IsTrue(customer.Deleted, customer.ToString());
        }


        [TestMethod]
        public void CustomerCreateCard()
        {

            var request = JObject.Parse("{'name': 'test', 'cards':['tok_test_visa_4242']}");
            var customer = Customer.Create(request);
            var newCard = JObject.Parse("{'token':'tok_test_visa_1881'}");

            customer.CreateCard(newCard);

            Assert.IsTrue(customer.Cards.Count > 0);
        }


        [TestMethod]
        public void CustomerDeleteCard()
        {

            var request = JObject.Parse("{'name': 'test'}");
            var customer = Customer.Create(request);
            var newCard = JObject.Parse("{'token':'tok_test_visa_1881'}");

            customer.CreateCard(newCard);
            Assert.IsTrue(customer.Cards.Count == 1);
            customer.Cards[0].Delete();
            Assert.IsTrue(customer.Cards.Count == 0);
        }

    }
}
