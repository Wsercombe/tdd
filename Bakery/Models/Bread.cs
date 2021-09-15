using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int NumberBread { get; set; }
    public int Price { get; set; }

    public Bread (string numberBread)
    {
      NumberBread = Int32.Parse(numberBread);
      Price = CalculateBread();
    }
    public int CalculateBread () {
      return NumberBread * (5 - NumberBread / 3);
    }
  }
}
