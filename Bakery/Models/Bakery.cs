namespace PierresBakery
{
  public class Bread
  {
    // Properties
    public int Quantity { get; }

    //Constructor
    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    //Methods
    public int CalcBreadOrderPrice()
    {
      int price = 5;
      return price;
    }

  }

  public class Pastry
  {
    // Properties
    public int Quantity { get; }

    //Constructor
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }
    //Methods
    
  }

}