using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void OnePastryForSevenDollars() {
      Pastry pastryTest = new Pastry("1");
      int price = pastryTest.Price;
      Assert.AreEqual(7, price);
    }
    // Test method will go here
  }
}