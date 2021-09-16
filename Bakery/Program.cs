using System;
using Bakery.Models;


namespace CustomerBakery
{
  public class Program
  {
    public static void Main() {
      string starSeparator = "*************************************************************************************";
      Console.WriteLine(starSeparator + "\nWelcome to the Bakery\n" + starSeparator);
      Console.WriteLine(starSeparator + "\nIf you buy 2 loaves of bread you get 1 for free!\n" + starSeparator);
      Console.WriteLine(starSeparator + "\nFor pastries, Buy 1 for $2, or 3 for $5, 4 for $7, 5 for $9, and 6 for $10!\n" + starSeparator);
      string userInput;
      do {
        Console.WriteLine("What would you like to order?\n\n  B for bread\n  P for pastries\n  Q for quit\n");
        userInput = Console.ReadLine().ToUpper();
      } while (userInput != "Q");
      Console.WriteLine("Thank you for stopping by");
    }
  }
}