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
      string amount;
      do {
        Console.WriteLine("What would you like to order?\n\n  B for bread\n  P for pastries\n  Q for quit\n");
        userInput = Console.ReadLine().ToUpper();
        if (userInput == "B"){
          Console.WriteLine("How many loaves of bread would you like?");
          amount = Console.ReadLine();
          Bread breadOrder = new Bread(amount);
          Console.WriteLine("\nThat will be " + breadOrder.Price + " dollars\nWould you like to order more?\n");
        }
        else if (userInput == "P"){
          Console.WriteLine("How many pastries would you like?");
          amount = Console.ReadLine();
          Pastry pastryOrder = new Pastry(amount);
          Console.WriteLine("\nThat will be " + pastryOrder.Price + " dollars\n\nWould you like to order more?\n");
        }
        else if (userInput != "Q") {
          Console.WriteLine("That is not an available option, please try again\n\n");
        }
      } while (userInput != "Q");
      Console.WriteLine(starSeparator + "\nThank you for stopping by\n" + starSeparator);
    }
  }
}