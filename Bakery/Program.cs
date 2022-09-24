using System;
using System.Collections.Generic;
using PierresBakery;

namespace Bakery
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine("-----------------------------------------------------------------------------");
      Console.WriteLine("Welcome to Pierre's Bakery!");

      bool continueProgram = true;
      while(continueProgram)
      {
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("Press V to View offer, or E to Exit:");
        string userInput = Console.ReadLine().ToUpper();

        if (userInput == "V")
        {
          Console.WriteLine("-----------------------------------------------------------------------------");
          Console.WriteLine("Here's the offer of the day:");
          Console.WriteLine("Loaf of bread: Buy 2, get 1 free (every 3rd loaf is free.)");
          Console.WriteLine("Pastry: Get $1 discount every 3rd pastry. Buy 1 for $2, 2 for $4, 3 for $5, etc.");

          bool continueProgram2 = true;
          while(continueProgram2)
          {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Press B to Buy, or R to Return:");
            string userInput2 = Console.ReadLine().ToUpper();

            if(userInput2 == "B")
            {
              Console.WriteLine("-----------------------------------------------------------------------------");
              Console.WriteLine("How many loaves of bread do you want:");
              string loavesString = Console.ReadLine();
              int loaves = int.Parse(loavesString);

              Console.WriteLine("How many pastries do you want:");
              string pastriesString = Console.ReadLine();
              int pastries = int.Parse(pastriesString);

              Console.WriteLine("-----------------------------------------------------------------------------");
              Console.WriteLine("Here is your order:");
              Console.WriteLine("You want " + loaves + " loaf/loaves and " + pastries + " Pastries");
              
              Bread bread = new Bread(loaves);
              Console.WriteLine("Price for your bread/s: $" + bread.TotalPrice);

              Pastry pastry = new Pastry(pastries);
              Console.WriteLine("Price for your pastry/ies: $" + pastry.TotalPrice);
              int total = bread.TotalPrice + pastry.TotalPrice;

              Console.WriteLine("Your order's total is: $" + total);

            }
            else if(userInput2 == "R")
            {
              continueProgram2 = false;
            }
            else
            {
              Console.WriteLine("This is not a valid command. Try again");
            }
          }
        }
        else if (userInput == "E" )
        {
          continueProgram = false;
        }
        else
        {
          Console.WriteLine("This is not a valid command. Try again");
        }
      }
    }
  }
}