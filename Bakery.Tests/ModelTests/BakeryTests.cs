using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread(3);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void SetQuantity_SetsQuantityOfBreadNeeded_Int()
    {
      //Arrange
      int quantity = 3;
      Bread bread = new Bread(quantity);
      //Act
      int result = bread.Quantity;
      //Assert
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void CalcBreadOrderPrice_CalcsSingleLoafPrice_Int()
    {
      //Arrange
      int quantity = 1;
      Bread bread = new Bread(quantity);
      //Act
      int result = bread.CalcBreadOrderPrice();
      //Assert
      Assert.AreEqual(5, result);
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void SetQuantity_SetsQuantityOfPastryNeeded_Int()
    {
      //Arrange
      int quantity = 3;
      Pastry pastry = new Pastry(quantity);
      //Act
      int result = pastry.Quantity;
      //Assert
      Assert.AreEqual(quantity, result);
    }
  }
}