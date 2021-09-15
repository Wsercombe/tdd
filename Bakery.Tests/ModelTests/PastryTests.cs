using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void OnePastryForTwoDollars() {
      Pastry pastryTest = new Pastry("1");
      int price = pastryTest.Price;
      Assert.AreEqual(2, price);
    }
    [TestMethod]
    public void TwoPastriesForFourDollars() {
      Pastry pastryTest = new Pastry("2");
      int price = pastryTest.Price;
      Assert.AreEqual(4, price);
    }
    [TestMethod]
    public void ThreePastriesForFiveDollars() {
      Pastry pastryTest = new Pastry("3");
      int price = pastryTest.Price;
      Assert.AreEqual(5, price);
    }
    [TestMethod]
    public void FourPastriesForSevenDollars() {
      Pastry pastryTest = new Pastry("4");
      int price = pastryTest.Price;
      Assert.AreEqual(7, price);
    }
    // Test method will go here
  }
}