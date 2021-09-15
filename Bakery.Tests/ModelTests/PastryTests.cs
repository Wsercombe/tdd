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
    [TestMethod]
    public void FivePastriesForNineDollars() {
      Pastry pastryTest = new Pastry("5");
      int price = pastryTest.Price;
      Assert.AreEqual(9, price);
    }
    [TestMethod]
    public void SixPastriesForTenDollars() {
      Pastry pastryTest = new Pastry("6");
      int price = pastryTest.Price;
      Assert.AreEqual(10, price);
    }
    [TestMethod]
    public void TwelvePastriesForTwentyDollars() {
      Pastry pastryTest = new Pastry("12");
      int price = pastryTest.Price;
      Assert.AreEqual(20, price);
    }
    // Test method will go here
  }
}