using System;

namespace Dealership.Models 
{
  public class Car
  {
      // Fields
    private string _makeModel;
    private int _price;
    private int _miles;

      // Constructor
    public Car(string makeModel, int price, int miles) // <---- the final field
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

  // Methods
    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
    public bool WorthBuying(int maxPrice) 
    {
      return (_price <= maxPrice);
    }
  }
}