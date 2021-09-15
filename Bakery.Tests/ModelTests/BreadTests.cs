using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void OneLoafForFiveDollars() {
      Bread breadTest = new Bread("1");
      int price = breadTest.Price;
      Assert.AreEqual(5, price);
    }
    // Test method will go here
  }
}