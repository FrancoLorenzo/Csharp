using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tobosco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailer Trash");

            // Expect true
            Assert.IsTrue(testInstance.IsSauceAwesome("Trailer Trash"));

            // Expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
