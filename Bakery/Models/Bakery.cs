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

        /* 
        Q = 1 -> p = p * Q                Q = 4 -> p = p * (Q - 1)          Q = 7 -> p = p * (Q - 2)   
        Q = 2 -> p = p * Q                Q = 5 -> p = p * (Q - 1)          Q = 8 -> p = p * (Q - 2)
        Q = 3 -> p =(p * Q) - p * 1       Q = 6 -> p = (p * Q) - p * 2      Q = 9 -> p = (p * Q) - p * 3
        */  
      
        price = (price * Quantity) - (price * (Quantity % 3 - ((Quantity % 3) - (Quantity / 3))));

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
        // price = (price * Quantity) - (Quantity / 2);
        price = (price * Quantity) - (price * 1/2);

      }

      return price;
    }
  }
}