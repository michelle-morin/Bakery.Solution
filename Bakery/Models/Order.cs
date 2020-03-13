using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public string Paid { get; set; }
    public int Id { get; }
    private static int _counter = 1;
    private static List<Order> _orders = new List<Order> {};

    public Order(string title, string description, int price, string date, string paid)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Paid = paid;
      _orders.Add(this);
      Id = _counter;
      IncreaseCounter();
    }

    public static void IncreaseCounter()
    {
      _counter++;
    }

    public static List<Order> GetAll()
    {
      return _orders;
    }

    public static void ClearAll()
    {
      _orders.Clear();
    }

    public static Order Find(int searchId)
    {
      for (int i=0; i< _orders.Count; i++)
      {
        if(_orders[i] is Order)
        {
          if(_orders[i].Id == searchId)
          {
            return _orders[i];
          }
        }
      }
      return null;
    }

    public static void DeleteOrder(int searchId)
    {
      for (int i=0; i< _orders.Count; i++)
      {
        if(_orders[i] is Order)
        {
          if(_orders[i].Id == searchId)
          {
            _orders.RemoveAt(i);
          }
        }
      }
    }
  }
}