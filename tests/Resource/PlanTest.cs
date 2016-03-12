using System;
using System.Text;
using System.Collections.Generic;
using conekta.io;
using conekta.io.Resource;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace tests.Resource
{
    /// <summary>
    /// Summary description for PlanTest
    /// </summary>
    [TestClass]
    public class PlanTest
    {

        [TestInitialize()]
        public void Setup()
        {
            Conekta.setApiKey("key_eYvWV7gSDkNYXsmr");
        }


        [TestMethod]
        public void testCreatePlan()
        {
            var id = new Random().Next();

            var planObject = JObject.Parse("{'id' : 'gold-plan"+ id +"',"
                                            + "'name' : 'Gold Plan',"
                                            + "'amount' : 10000,"
                                            + "'currency' : 'MXN',"
                                            + "'interval' : 'month',"
                                            + "'frequency' : 10,"
                                            + "'trial_period_days' : 15,"
                                            + "'expiry_count' : 12}");


            var plan = Plan.Create(planObject);
            Assert.IsNotNull(plan);
            Assert.IsNotNull(plan.CreatedAt);
        }


        [TestMethod]
        public void testUptadePlan()
        {
            var id = new Random().Next();

            var planObject = JObject.Parse("{'id' : 'gold-plan" + id + "',"
                                            + "'name' : 'Gold Plan',"
                                            + "'amount' : 10000,"
                                            + "'currency' : 'MXN',"
                                            + "'interval' : 'month',"
                                            + "'frequency' : 10,"
                                            + "'trial_period_days' : 15,"
                                            + "'expiry_count' : 12}");


            var plan = Plan.Create(planObject);
          
            plan.Update(JObject.Parse("{'name':'Silver Plan'}"));

            Assert.IsTrue(plan.Name == "Silver Plan");

        }


        [TestMethod]
        public void testDeletePlan()
        {
            var id = new Random().Next();

            var planObject = JObject.Parse("{'id' : 'gold-plan" + id + "',"
                                            + "'name' : 'Gold Plan',"
                                            + "'amount' : 10000,"
                                            + "'currency' : 'MXN',"
                                            + "'interval' : 'month',"
                                            + "'frequency' : 10,"
                                            + "'trial_period_days' : 15,"
                                            + "'expiry_count' : 12}");


            var plan = Plan.Create(planObject);
            plan.Delete();
        }


    }
}
