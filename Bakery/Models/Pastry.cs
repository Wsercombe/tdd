using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int NumberPastries { get; set; }
    public int Price { get; set; }

    public Pastry (string numberPastries)
    {
      NumberPastries = Int32.Parse(numberPastries);
      Price = CalculatePastry();
    }
    public int CalculatePastry () {
      return NumberPastries * 7;
    }
  }
}
