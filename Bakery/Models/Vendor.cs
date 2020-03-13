using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor> {};
    private static int _counter = 1;
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Id = _counter;
      Orders = new List<Order> {};
      _vendors.Add(this);
      IncreaseCounter();
    }

    public static void IncreaseCounter()
    {
      _counter++;
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendors;
    }

    public static Vendor Find(int searchId)
    {
      for (int i=0; i< _vendors.Count; i++)
      {
        if(_vendors[i] is Vendor)
        {
          if(_vendors[i].Id == searchId)
          {
            return _vendors[i];
          }
        }
      }
      return null;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}