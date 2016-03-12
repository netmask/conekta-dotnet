using System;
using conekta.io;
using conekta.io.Resource;
using conekta.io.Service;
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

        [TestMethod]
        public void CustomerUpdateCard()
        {

            var request = JObject.Parse("{'name': 'test'}");
            var customer = Customer.Create(request);

            var newCard = JObject.Parse("{'token':'tok_test_visa_1881'}");
            var updatedCard = JObject.Parse("{'token':'tok_test_mastercard_4444', 'active':false}");

            customer.CreateCard(newCard);
            var uc  = customer.Cards[0].Update(updatedCard);

            Assert.IsTrue(customer.Cards[0].Last4 == "4444", uc.ToString());


        }


        [TestMethod] public void CustomerSubscriptionCreate()
        {

            var request = JObject.Parse("{'name': 'test', 'cards':['tok_test_visa_4242']}");
            var customer = Customer.Create(request);

            customer.CreateSubscription(JObject.Parse("{'plan':'gold-plan'}"));

            Assert.IsNotNull(customer.Subscription);
            Assert.IsNotNull(customer.Subscription.Id);
        }


        [TestMethod]
        public void CustomerUpdateSubscription()
        {

            var request = JObject.Parse("{'name': 'test', 'cards':['tok_test_visa_4242']}");
            var customer = Customer.Create(request);

            customer.CreateSubscription(JObject.Parse("{'plan':'gold-plan'}"));

            customer.Subscription.Update(JObject.Parse("{'plan':'gold-plan2'}"));

            Assert.IsTrue(customer.Subscription.PlanId == "gold-plan2", customer.Subscription.PlanId);
        }


        [TestMethod]
        [ExpectedException(typeof(ApiException), "A userId of null was inappropriately allowed.")]
        public void CustomerErrorSubscriptionNotExists()
        {

            var request = JObject.Parse("{'name': 'test', 'cards':['tok_test_visa_4242']}");
            var customer = Customer.Create(request);

          
            customer.CreateSubscription(JObject.Parse("{'plan':'gold12121212plan'}"));

        }


        [TestMethod]
        public void CustomerPauseSubscription()
        {

            var request = JObject.Parse("{'name': 'test', 'cards':['tok_test_visa_4242']}");
            var customer = Customer.Create(request);
            customer.CreateSubscription(JObject.Parse("{'plan':'gold-plan'}"));
                
            customer.Subscription.Pause();

            Assert.IsTrue(customer.Subscription.Status == "paused" );
        }

        [TestMethod]
        public void CustomerPauseResumenSubscription()
        {

            var request = JObject.Parse("{'name': 'test', 'cards':['tok_test_visa_4242']}");
            var customer = Customer.Create(request);
            customer.CreateSubscription(JObject.Parse("{'plan':'gold-plan'}"));

            customer.Subscription.Pause();

            Assert.IsTrue(customer.Subscription.Status == "paused");

            customer.Subscription.Resume();

            Assert.IsTrue(customer.Subscription.Status == "in_trial");
        }


        [TestMethod]
        public void CustomerCancelSubscription()
        {

            var request = JObject.Parse("{'name': 'test', 'cards':['tok_test_visa_4242']}");
            var customer = Customer.Create(request);
            customer.CreateSubscription(JObject.Parse("{'plan':'gold-plan'}"));

            customer.Subscription.Cancel();

            Assert.IsTrue(customer.Subscription.Status == "canceled");
        }
    }
}
