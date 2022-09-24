namespace PierresBakery
{
  public class Bread
  {
    // Properties
    public int Quantity { get; }
    public int TotalPrice;

    //Constructor
    public Bread(int quantity)
    {
      Quantity = quantity;
      TotalPrice = this.CalcBreadOrderPrice();
    }

    //Methods
    public int CalcBreadOrderPrice()
    {
      int price = 5;

      if ( Quantity == 1)
      {
        price = 5;
      }
      else if(Quantity == 2)
      {
        price = price * 2;
      }
      else
      {
       price = (price * Quantity) - (price * (Quantity % 3 - ((Quantity % 3) - (Quantity / 3))));
      } 
      return price;
    }
  }

  public class Pastry
  {
    // Properties
    public int Quantity { get; }
    public int TotalPrice;

    //Constructor
    public Pastry(int quantity)
    {
      Quantity = quantity;
      TotalPrice = this.CalcPastryOrderPrice();
    }

    //Methods
    public int CalcPastryOrderPrice()
    {
      int price = 2;

      if (Quantity == 1)
      {
        price = 2;
      }
      
      else if (Quantity == 2)
      {
       price = Quantity * 2;
      } 

      else 
      {
        price = (price * Quantity) - (price * 1/2);
      }
      return price;
    }
  }
}