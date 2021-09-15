using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int NumberBread { get; set; }

    public Bread(string numberBread)
    {
      NumberBread = numberBread;
    }
    void ClearAll()
    {
      _instances.Clear();
    }
  }
}
