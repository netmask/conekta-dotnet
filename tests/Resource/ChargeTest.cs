using System.Collections.Generic;
using System.Runtime.InteropServices;
using conekta.io;
using conekta.io.Resource;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace tests.Resource
{
    [TestClass]
    public class ChargeTest
    {
        JObject baseRequest = JObject.Parse("{"
                                   + "'description':'Stogies',"
                                   + "'amount': 20000,"
                                   + "'currency':'MXN',"
                                   + "'reference_id':'9839-wolf_pack',"
                                   + "'details': {"
                                   + "'name': 'Arnulfo Quimare',"
                                   + "'phone': '403-342-0642',"
                                   + "'email': 'logan@x-men.org',"
                                   + "'customer': {"
                                   + "'logged_in': true,"
                                   + "'successful_purchases': 14,"
                                   + "'created_at': 1379784950,"
                                   + "'updated_at': 1379784950,"
                                   + "'offline_payments': 4,"
                                   + "'score': 9"
                                   + "},"
                                   + "'line_items': [{"
                                   + "'name': 'Box of Cohiba S1s',"
                                   + "'description': 'Imported From Mex.',"
                                   + "'unit_price': 20000,"
                                   + "'quantity': 1,"
                                   + "'sku': 'cohb_s1',"
                                   + "'category': 'food'"
                                   + "}],"
                                   + "'billing_address': {"
                                   + "'street1':'77 Mystery Lane',"
                                   + "'street2': 'Suite 124',"
                                   + "'street3': null,"
                                   + "'city': 'Darlington',"
                                   + "'state':'NJ',"
                                   + "'zip': '10192',"
                                   + "'country': 'Mexico',"
                                   + "'tax_id': 'xmn671212drx',"
                                   + "'company_name':'X-Men Inc.',"
                                   + "'phone': '77-777-7777',"
                                   + "'email': 'purshasing@x-men.org'"
                                   + "}"
                                   + "}"
                                   + "}");


        [TestInitialize()]
        public void Setup()
        {
            Conekta.setApiKey("key_eYvWV7gSDkNYXsmr");
        }

        [TestMethod]
        public void create()
        {
            var request = baseRequest;
            request["card"] = "tok_test_visa_4242";

            var c = Charge.Create(request);
          
            Assert.IsNotNull(c);
            Assert.IsNotNull(c.Id);
            Assert.IsInstanceOfType(c.Details, typeof(Details));           
        }


        [TestMethod]
        public void CreateWithBankPaymentMethod()
        {
            var request = baseRequest;
            request["bank"] = JObject.Parse("{'type':'banorte'}");

            var c = Charge.Create(request);

            Assert.IsNotNull(c);
            Assert.IsNotNull(c.Id);
            Assert.IsInstanceOfType(c.Details, typeof(Details));
            Assert.IsTrue((c.PaymentMethod._Object == "bank_transfer_payment"), c.PaymentMethod.ToString());
        }

        [TestMethod]
        public void CreateWithSpeiPaymentMethod()
        {
            var request = baseRequest;
            request["bank"] = JObject.Parse("{'type':'spei'}");

            var c = Charge.Create(request);

            Assert.IsNotNull(c);
            Assert.IsNotNull(c.Id);
            Assert.IsInstanceOfType(c.Details, typeof(Details));
            Assert.IsTrue((c.PaymentMethod.Type == "spei"), c.PaymentMethod.ToString());            
        }

        [TestMethod]
        public void CreateWithOXXOiPaymentMethod()
        {
            var request = baseRequest;
            request["cash"] = JObject.Parse("{'type':'oxxo'}");

            var c = Charge.Create(request);

            Assert.IsNotNull(c);
            Assert.IsNotNull(c.Id);
            Assert.IsInstanceOfType(c.Details, typeof(Details));
            Assert.IsTrue((c.PaymentMethod.Type == "oxxo"), c.PaymentMethod.ToString());
        }



        [TestMethod]
        public void refund()
        {
            var request = baseRequest;
            request["card"] = "tok_test_visa_4242";

            var c = Charge.Create(request);
            var refouded = c.Refund();

            Assert.IsNotNull(refouded);
        }


        [TestMethod]
        public void refundWithQuantity()
        {
            var request = baseRequest;
            request["card"] = "tok_test_visa_4242";

            var c = Charge.Create(request);
            var refouded = c.Refund(10000);

            Assert.IsNotNull(refouded);
        }


        [TestMethod]
        public void find()
        {
            var request = baseRequest;
            request["card"] = "tok_test_visa_4242";
            var existingCharge = Charge.Create(request);

            Assert.IsNotNull(Charge.Find(existingCharge.Id));
        }



        [TestMethod]
        public void testWhere()
        {
            var existingCharge = Charge.Where("{'description':'Stogies'}");
            Assert.IsTrue(existingCharge.Count > 0);
        }

    }
}
