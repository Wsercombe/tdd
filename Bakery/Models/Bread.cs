using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int NumberBread { get; set; }

    public Bread(string numberBread)
    {
      NumberBread = numberBread;
      return CalculateBread();
    }
    public CalculateBread () {
      return NumberBread * 3;
    }
    void ClearAll()
    {
      _instances.Clear();
    }
  }
}
