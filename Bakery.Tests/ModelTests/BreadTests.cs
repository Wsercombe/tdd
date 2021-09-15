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
    [TestMethod]
    public void TwoLoavesForTenDollars() {
      Bread breadTest = new Bread("2");
      int price = breadTest.Price;
      Assert.AreEqual(10, price);
    }
    [TestMethod]
    public void ThreeLoavesForTenDollars() {
      Bread breadTest = new Bread("3");
      int price = breadTest.Price;
      Assert.AreEqual(10, price);
    }
    [TestMethod]
    public void SixLoavesForTwentyDollars() {
      Bread breadTest = new Bread("6");
      int price = breadTest.Price;
      Assert.AreEqual(20, price);
    }
  }
}