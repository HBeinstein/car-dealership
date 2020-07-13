using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public Car(string makeModel, int price, int miles)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }

  public bool WorthBuying(int maxPrice) 
  {
    return (Price <= maxPrice);
  }
}

public class Program
{
    public static void Main()
    {
      Car volkswagen = new Car();
      volkswagen.MakeModel = "1974 Volkswagen Thing";
      volkswagen.Price = 1100;
      volkswagen.Miles = 368792;

      Car yugo = new Car();
      yugo.MakeModel = "1980 Yugo Koral";
      yugo.Price = 700;
      yugo.Miles = 56000;

      Car ford = new Car();
      ford.MakeModel = "1988 Ford Country Squire";
      ford.Price = 1400;
      ford.Miles = 239001;

      Car amc = new Car();
      amc.MakeModel = "1976 AMC Pacer";
      amc.Price = 400;
      amc.Miles = 198000;

      Car geo = new Car();
      geo.MakeModel = "1997 Geo Metro";
      geo.Price = 700;
      geo.Miles = 579454;

      List<Car> CarsList = new List<Car>() {volkswagen, yugo, ford, amc, geo};

      Console.WriteLine("Enter Maximum Price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchSearch = new List<Car>(0);

      foreach(Car automobile in CarsList)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchSearch.Add(automobile);
        }
      }

      foreach(Car automobile in CarsMatchSearch)
      {
        Console.WriteLine("Car Model: " + automobile.MakeModel);
        Console.WriteLine("Price: " + automobile.Price);
        Console.WriteLine("Miles: " + automobile.Miles);
      }
    }
}