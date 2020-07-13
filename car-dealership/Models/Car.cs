namespace Dealership.Models
{
  public class Car
  {
      // Fields
    private string MakeModel;
    private int Price;
    private int Miles;

      // Constructor
    public Car(string makeModel, int price, int miles) // <---- the final field
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

  // Methods
    public bool WorthBuying(int maxPrice) 
    {
      return (Price <= maxPrice);
    }
  }
}