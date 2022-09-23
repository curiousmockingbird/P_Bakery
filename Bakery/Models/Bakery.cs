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

      if(Quantity == 2)
      {
        price = price * 2;
      }
      else
      {
      // breadCost = (((Bread - (Bread % 3)) * 5) * 2/3) + ((Bread % 3) * 5);
      price = (((Quantity - (Quantity % 3)) * 5) * 2/3) + ((Quantity %3) * 5);
      } 
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