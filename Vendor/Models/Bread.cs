using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string BreadType{get;set;}

    private static List<Bread> _instances = new List<Bread>{};

    public Bread(string breadType)
    {
      BreadType = breadType;
      _instances.Add(this);
    }

    public static int GetBreadPrice()
    {
      int breadCount = _instances.Count;
      int breadPrice = 0;
      List<int>breadList = new List<int>{};
      for(int i = 0; i <= breadCount; i++)
      {
        breadList.Add(i);
      }
      foreach(int bread in breadList)
      {
        if(bread % 3 == 0)
        {
          breadPrice += 0;
        }
        else
        {
          breadPrice += 5;
        }
      }
      return breadPrice;
    }
    public static List<Bread> GetAllBread()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}