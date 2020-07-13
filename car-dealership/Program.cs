using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);
      Car geo = new Car("1997 Geo Metro", 700, 579454);

      List<Car> CarsList = new List<Car>() {volkswagen, yugo, ford, amc, geo};

      yugo.SetPrice(17000);

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
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Car Model: " + automobile.GetMakeModel());
        Console.WriteLine("Price: $" + automobile.GetPrice());
        Console.WriteLine("Miles: " + automobile.GetMiles() + " mi.");
      }
    }
  }
}
