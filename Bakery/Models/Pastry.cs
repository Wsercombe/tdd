using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int NumberPastries { get; set; }

    public Pastry(int numberPastries)
    {
      NumberPastries = numberPastries;
    }
    void ClearAll()
    {
      _instances.Clear();
    }
  }
}
